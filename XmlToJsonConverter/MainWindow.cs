using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XmlToJsonConverter
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // ──────────────────────────────────────────────────────────
        //  Button Events
        // ──────────────────────────────────────────────────────────

        private void BtnAddFiles_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog
            {
                Title       = "Select XML File(s)",
                Filter      = "XML Files (*.xml;*.xsl;*.xslt)|*.xml;*.xsl;*.xslt|All Files (*.*)|*.*",
                Multiselect = true
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in dlg.FileNames)
                    if (!lstInputFiles.Items.Contains(file))
                        lstInputFiles.Items.Add(file);

                Log($"Added {dlg.FileNames.Length} file(s).");
            }
        }

        private void BtnAddFolder_Click(object sender, EventArgs e)
        {
            using var dlg = new FolderBrowserDialog
            {
                Description = "Select a folder — all XML/XSL/XSLT files inside will be added"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                int added = 0;
                foreach (var file in Directory.GetFiles(dlg.SelectedPath, "*.*", SearchOption.AllDirectories))
                {
                    var ext = Path.GetExtension(file).ToLowerInvariant();
                    if ((ext == ".xml" || ext == ".xsl" || ext == ".xslt") &&
                        !lstInputFiles.Items.Contains(file))
                    {
                        lstInputFiles.Items.Add(file);
                        added++;
                    }
                }
                Log($"Added {added} file(s) from folder.");
            }
        }

        private void BtnRemoveSelected_Click(object sender, EventArgs e)
        {
            var toRemove = new List<object>();
            foreach (var item in lstInputFiles.SelectedItems)
                toRemove.Add(item);
            foreach (var item in toRemove)
                lstInputFiles.Items.Remove(item);
        }

        private void BtnClearList_Click(object sender, EventArgs e)
        {
            lstInputFiles.Items.Clear();
        }

        private void BtnBrowseOutput_Click(object sender, EventArgs e)
        {
            using var dlg = new FolderBrowserDialog
            {
                Description = "Select Output Folder for JSON Files"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
                txtOutputFolder.Text = dlg.SelectedPath;
        }

        private async void BtnConvert_Click(object sender, EventArgs e)
        {
            if (lstInputFiles.Items.Count == 0)
            {
                MessageBox.Show("Please add at least one XML file.", "No Input Files",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtOutputFolder.Text))
            {
                MessageBox.Show("Please select an output folder.", "No Output Folder",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnConvert.Enabled = false;
            prgProgressBar.Value  = 0;
            lstLog.Items.Clear();

            var files = new List<string>();
            foreach (var item in lstInputFiles.Items)
                files.Add(item.ToString()!);

            try   { await Task.Run(() => RunConversion(files, txtOutputFolder.Text)); }
            finally { btnConvert.Enabled = true; }
        }

        private void BtnClearLog_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
            prgProgressBar.Value = 0;
        }

        // ──────────────────────────────────────────────────────────
        //  Core Conversion
        // ──────────────────────────────────────────────────────────

        private void RunConversion(List<string> files, string outputFolder)
        {
            Directory.CreateDirectory(outputFolder);
            SetProgressMax(files.Count);

            int success = 0, failed = 0;
            var options = new JsonSerializerOptions { WriteIndented = true };

            for (int i = 0; i < files.Count; i++)
            {
                var inputPath = files[i];
                var baseName  = Path.GetFileNameWithoutExtension(inputPath);
                var jsonPath  = Path.Combine(outputFolder, baseName + ".json");

                Log($"Converting: {Path.GetFileName(inputPath)}");

                try
                {
                    var xmlContent = File.ReadAllText(inputPath, Encoding.UTF8);
                    var doc        = new XmlDocument();
                    doc.LoadXml(xmlContent);

                    var obj = new Dictionary<string, object?>
                    {
                        ["sourceFile"] = Path.GetFileName(inputPath),
                        ["content"]    = XmlNodeToObject(doc.DocumentElement!)
                    };

                    File.WriteAllText(jsonPath, JsonSerializer.Serialize(obj, options), Encoding.UTF8);
                    Log($"  → {baseName}.json");
                    success++;
                }
                catch (Exception ex)
                {
                    Log($"  FAIL: {ex.Message}");
                    failed++;
                }

                SetProgress(i + 1);
            }

            Log($"\nDone!  {success} converted,  {failed} failed.");
            Log($"Output → {outputFolder}");
        }

        // ──────────────────────────────────────────────────────────
        //  XML → JSON Tree Converter
        //  Attributes  →  @attrName
        //  Text content → #text
        //  Repeated elements → array
        // ──────────────────────────────────────────────────────────

        private static Dictionary<string, object?> XmlNodeToObject(XmlElement node)
        {
            var dict = new Dictionary<string, object?>();

            // Attributes prefixed with @
            foreach (XmlAttribute attr in node.Attributes)
                dict[$"@{attr.Name}"] = attr.Value;

            // Collect child elements and group by tag name
            var childEls = new List<XmlElement>();
            foreach (XmlNode n in node.ChildNodes)
                if (n is XmlElement el) childEls.Add(el);

            var groups = new Dictionary<string, List<XmlElement>>();
            foreach (var child in childEls)
            {
                if (!groups.ContainsKey(child.LocalName))
                    groups[child.LocalName] = [];
                groups[child.LocalName].Add(child);
            }

            foreach (var kvp in groups)
            {
                if (kvp.Value.Count == 1)
                {
                    var child   = kvp.Value[0];
                    bool hasKids = false;
                    foreach (XmlNode n in child.ChildNodes)
                        if (n is XmlElement) { hasKids = true; break; }

                    if (!hasKids)
                    {
                        // Leaf node
                        var leaf = new Dictionary<string, object?>();
                        foreach (XmlAttribute a in child.Attributes)
                            leaf[$"@{a.Name}"] = a.Value;
                        if (!string.IsNullOrWhiteSpace(child.InnerText))
                            leaf["#text"] = child.InnerText;

                        dict[child.LocalName] = leaf.Count == 1 && leaf.ContainsKey("#text")
                            ? (object?)child.InnerText
                            : leaf.Count == 0 ? null : leaf;
                    }
                    else
                    {
                        dict[child.LocalName] = XmlNodeToObject(child);
                    }
                }
                else
                {
                    // Repeated tag → JSON array
                    var arr = new List<object?>();
                    foreach (var child in kvp.Value)
                    {
                        bool hasKids = false;
                        foreach (XmlNode n in child.ChildNodes)
                            if (n is XmlElement) { hasKids = true; break; }
                        arr.Add(hasKids ? XmlNodeToObject(child) : (object?)child.InnerText);
                    }
                    dict[kvp.Key] = arr;
                }
            }

            // Pure text node with no child elements
            if (childEls.Count == 0 && !string.IsNullOrWhiteSpace(node.InnerText))
                dict["#text"] = node.InnerText;

            return dict;
        }

        // ──────────────────────────────────────────────────────────
        //  Thread-safe UI Helpers
        // ──────────────────────────────────────────────────────────

        private void Log(string msg)
        {
            if (lstLog.InvokeRequired)
                lstLog.Invoke(() => Log(msg));
            else
            {
                lstLog.Items.Add(msg);
                lstLog.TopIndex = lstLog.Items.Count - 1;
            }
        }

        private void SetProgressMax(int max)
        {
            if (prgProgressBar.InvokeRequired)
                prgProgressBar.Invoke(() => prgProgressBar.Maximum = max);
            else
                prgProgressBar.Maximum = max;
        }

        private void SetProgress(int value)
        {
            if (prgProgressBar.InvokeRequired)
                prgProgressBar.Invoke(() => prgProgressBar.Value = value);
            else
                prgProgressBar.Value = value;
        }
    }
}
