namespace XmlToJsonConverter
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // ── Declare all controls ───────────────────────────────
            this.lblTitle           = new System.Windows.Forms.Label();
            this.grpInput           = new System.Windows.Forms.GroupBox();
            this.lstInputFiles      = new System.Windows.Forms.ListBox();
            this.pnlInputButtons    = new System.Windows.Forms.Panel();
            this.btnAddFiles        = new System.Windows.Forms.Button();
            this.btnAddFolder       = new System.Windows.Forms.Button();
            this.btnRemoveSelected  = new System.Windows.Forms.Button();
            this.btnClearList       = new System.Windows.Forms.Button();
            this.grpOutput          = new System.Windows.Forms.GroupBox();
            this.txtOutputFolder    = new System.Windows.Forms.TextBox();
            this.btnBrowseOutput    = new System.Windows.Forms.Button();
            this.pnlActions         = new System.Windows.Forms.Panel();
            this.btnConvert         = new System.Windows.Forms.Button();
            this.btnClearLog        = new System.Windows.Forms.Button();
            this.prgProgressBar     = new System.Windows.Forms.ProgressBar();
            this.grpLog             = new System.Windows.Forms.GroupBox();
            this.lstLog             = new System.Windows.Forms.ListBox();

            // Suspend layout while we set everything up
            this.grpInput.SuspendLayout();
            this.pnlInputButtons.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.grpLog.SuspendLayout();
            this.SuspendLayout();

            // ── lblTitle ───────────────────────────────────────────
            this.lblTitle.AutoSize  = true;
            this.lblTitle.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 80, 160);
            this.lblTitle.Location  = new System.Drawing.Point(12, 14);
            this.lblTitle.Name      = "lblTitle";
            this.lblTitle.Size      = new System.Drawing.Size(220, 25);
            this.lblTitle.TabIndex  = 0;
            this.lblTitle.Text      = "XML → JSON Converter";

            // ── grpInput ───────────────────────────────────────────
            this.grpInput.Anchor    = System.Windows.Forms.AnchorStyles.Top
                                    | System.Windows.Forms.AnchorStyles.Left
                                    | System.Windows.Forms.AnchorStyles.Right;
            this.grpInput.Controls.Add(this.lstInputFiles);
            this.grpInput.Controls.Add(this.pnlInputButtons);
            this.grpInput.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpInput.Location  = new System.Drawing.Point(12, 50);
            this.grpInput.Name      = "grpInput";
            this.grpInput.Padding   = new System.Windows.Forms.Padding(10);
            this.grpInput.Size      = new System.Drawing.Size(776, 210);
            this.grpInput.TabIndex  = 1;
            this.grpInput.TabStop   = false;
            this.grpInput.Text      = "Input XML / XSL / XSLT Files";

            // ── lstInputFiles ──────────────────────────────────────
            this.lstInputFiles.Anchor        = System.Windows.Forms.AnchorStyles.Top
                                             | System.Windows.Forms.AnchorStyles.Bottom
                                             | System.Windows.Forms.AnchorStyles.Left
                                             | System.Windows.Forms.AnchorStyles.Right;
            this.lstInputFiles.Font          = new System.Drawing.Font("Consolas", 8.5F);
            this.lstInputFiles.FormattingEnabled = true;
            this.lstInputFiles.HorizontalScrollbar = true;
            this.lstInputFiles.ItemHeight    = 14;
            this.lstInputFiles.Location      = new System.Drawing.Point(12, 22);
            this.lstInputFiles.Name          = "lstInputFiles";
            this.lstInputFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstInputFiles.Size          = new System.Drawing.Size(652, 180);
            this.lstInputFiles.TabIndex      = 0;

            // ── pnlInputButtons ────────────────────────────────────
            this.pnlInputButtons.Anchor      = System.Windows.Forms.AnchorStyles.Top
                                             | System.Windows.Forms.AnchorStyles.Bottom
                                             | System.Windows.Forms.AnchorStyles.Right;
            this.pnlInputButtons.Controls.Add(this.btnAddFiles);
            this.pnlInputButtons.Controls.Add(this.btnAddFolder);
            this.pnlInputButtons.Controls.Add(this.btnRemoveSelected);
            this.pnlInputButtons.Controls.Add(this.btnClearList);
            this.pnlInputButtons.Location    = new System.Drawing.Point(672, 22);
            this.pnlInputButtons.Name        = "pnlInputButtons";
            this.pnlInputButtons.Size        = new System.Drawing.Size(92, 180);
            this.pnlInputButtons.TabIndex    = 1;

            // ── btnAddFiles ────────────────────────────────────────
            this.btnAddFiles.Anchor          = System.Windows.Forms.AnchorStyles.Top
                                             | System.Windows.Forms.AnchorStyles.Left
                                             | System.Windows.Forms.AnchorStyles.Right;
            this.btnAddFiles.BackColor       = System.Drawing.Color.FromArgb(30, 80, 160);
            this.btnAddFiles.FlatStyle       = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFiles.ForeColor       = System.Drawing.Color.White;
            this.btnAddFiles.Location        = new System.Drawing.Point(0, 0);
            this.btnAddFiles.Name            = "btnAddFiles";
            this.btnAddFiles.Size            = new System.Drawing.Size(92, 32);
            this.btnAddFiles.TabIndex        = 0;
            this.btnAddFiles.Text            = "Add File(s)";
            this.btnAddFiles.UseVisualStyleBackColor = false;
            this.btnAddFiles.Click          += new System.EventHandler(this.BtnAddFiles_Click);

            // ── btnAddFolder ───────────────────────────────────────
            this.btnAddFolder.Anchor         = System.Windows.Forms.AnchorStyles.Top
                                             | System.Windows.Forms.AnchorStyles.Left
                                             | System.Windows.Forms.AnchorStyles.Right;
            this.btnAddFolder.BackColor      = System.Drawing.Color.FromArgb(30, 80, 160);
            this.btnAddFolder.FlatStyle      = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFolder.ForeColor      = System.Drawing.Color.White;
            this.btnAddFolder.Location       = new System.Drawing.Point(0, 40);
            this.btnAddFolder.Name           = "btnAddFolder";
            this.btnAddFolder.Size           = new System.Drawing.Size(92, 32);
            this.btnAddFolder.TabIndex       = 1;
            this.btnAddFolder.Text           = "Add Folder";
            this.btnAddFolder.UseVisualStyleBackColor = false;
            this.btnAddFolder.Click         += new System.EventHandler(this.BtnAddFolder_Click);

            // ── btnRemoveSelected ──────────────────────────────────
            this.btnRemoveSelected.Anchor    = System.Windows.Forms.AnchorStyles.Top
                                             | System.Windows.Forms.AnchorStyles.Left
                                             | System.Windows.Forms.AnchorStyles.Right;
            this.btnRemoveSelected.BackColor = System.Drawing.Color.FromArgb(30, 80, 160);
            this.btnRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelected.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSelected.Location  = new System.Drawing.Point(0, 80);
            this.btnRemoveSelected.Name      = "btnRemoveSelected";
            this.btnRemoveSelected.Size      = new System.Drawing.Size(92, 32);
            this.btnRemoveSelected.TabIndex  = 2;
            this.btnRemoveSelected.Text      = "Remove";
            this.btnRemoveSelected.UseVisualStyleBackColor = false;
            this.btnRemoveSelected.Click    += new System.EventHandler(this.BtnRemoveSelected_Click);

            // ── btnClearList ───────────────────────────────────────
            this.btnClearList.Anchor         = System.Windows.Forms.AnchorStyles.Top
                                             | System.Windows.Forms.AnchorStyles.Left
                                             | System.Windows.Forms.AnchorStyles.Right;
            this.btnClearList.BackColor      = System.Drawing.Color.FromArgb(160, 160, 165);
            this.btnClearList.FlatStyle      = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearList.ForeColor      = System.Drawing.Color.White;
            this.btnClearList.Location       = new System.Drawing.Point(0, 120);
            this.btnClearList.Name           = "btnClearList";
            this.btnClearList.Size           = new System.Drawing.Size(92, 32);
            this.btnClearList.TabIndex       = 3;
            this.btnClearList.Text           = "Clear All";
            this.btnClearList.UseVisualStyleBackColor = false;
            this.btnClearList.Click         += new System.EventHandler(this.BtnClearList_Click);

            // ── grpOutput ──────────────────────────────────────────
            this.grpOutput.Anchor   = System.Windows.Forms.AnchorStyles.Top
                                    | System.Windows.Forms.AnchorStyles.Left
                                    | System.Windows.Forms.AnchorStyles.Right;
            this.grpOutput.Controls.Add(this.txtOutputFolder);
            this.grpOutput.Controls.Add(this.btnBrowseOutput);
            this.grpOutput.Font     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpOutput.Location = new System.Drawing.Point(12, 272);
            this.grpOutput.Name     = "grpOutput";
            this.grpOutput.Padding  = new System.Windows.Forms.Padding(10);
            this.grpOutput.Size     = new System.Drawing.Size(776, 58);
            this.grpOutput.TabIndex = 2;
            this.grpOutput.TabStop  = false;
            this.grpOutput.Text     = "Output Folder";

            // ── txtOutputFolder ────────────────────────────────────
            this.txtOutputFolder.Anchor     = System.Windows.Forms.AnchorStyles.Top
                                            | System.Windows.Forms.AnchorStyles.Left
                                            | System.Windows.Forms.AnchorStyles.Right;
            this.txtOutputFolder.BackColor  = System.Drawing.Color.White;
            this.txtOutputFolder.Font       = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOutputFolder.Location   = new System.Drawing.Point(12, 22);
            this.txtOutputFolder.Name       = "txtOutputFolder";
            this.txtOutputFolder.ReadOnly   = true;
            this.txtOutputFolder.Size       = new System.Drawing.Size(654, 23);
            this.txtOutputFolder.TabIndex   = 0;

            // ── btnBrowseOutput ────────────────────────────────────
            this.btnBrowseOutput.Anchor     = System.Windows.Forms.AnchorStyles.Top
                                            | System.Windows.Forms.AnchorStyles.Right;
            this.btnBrowseOutput.BackColor  = System.Drawing.Color.FromArgb(30, 80, 160);
            this.btnBrowseOutput.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseOutput.ForeColor  = System.Drawing.Color.White;
            this.btnBrowseOutput.Location   = new System.Drawing.Point(674, 20);
            this.btnBrowseOutput.Name       = "btnBrowseOutput";
            this.btnBrowseOutput.Size       = new System.Drawing.Size(90, 26);
            this.btnBrowseOutput.TabIndex   = 1;
            this.btnBrowseOutput.Text       = "Browse…";
            this.btnBrowseOutput.UseVisualStyleBackColor = false;
            this.btnBrowseOutput.Click     += new System.EventHandler(this.BtnBrowseOutput_Click);

            // ── pnlActions ─────────────────────────────────────────
            this.pnlActions.Anchor          = System.Windows.Forms.AnchorStyles.Top
                                            | System.Windows.Forms.AnchorStyles.Left;
            this.pnlActions.Controls.Add(this.btnConvert);
            this.pnlActions.Controls.Add(this.btnClearLog);
            this.pnlActions.Location        = new System.Drawing.Point(12, 340);
            this.pnlActions.Name            = "pnlActions";
            this.pnlActions.Size            = new System.Drawing.Size(290, 44);
            this.pnlActions.TabIndex        = 3;

            // ── btnConvert ─────────────────────────────────────────
            this.btnConvert.BackColor       = System.Drawing.Color.FromArgb(0, 140, 70);
            this.btnConvert.FlatStyle       = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font            = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConvert.ForeColor       = System.Drawing.Color.White;
            this.btnConvert.Location        = new System.Drawing.Point(0, 0);
            this.btnConvert.Name            = "btnConvert";
            this.btnConvert.Size            = new System.Drawing.Size(140, 38);
            this.btnConvert.TabIndex        = 0;
            this.btnConvert.Text            = "▶  Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click          += new System.EventHandler(this.BtnConvert_Click);

            // ── btnClearLog ────────────────────────────────────────
            this.btnClearLog.BackColor      = System.Drawing.Color.FromArgb(160, 160, 165);
            this.btnClearLog.FlatStyle      = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLog.Font           = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearLog.ForeColor      = System.Drawing.Color.White;
            this.btnClearLog.Location       = new System.Drawing.Point(148, 0);
            this.btnClearLog.Name           = "btnClearLog";
            this.btnClearLog.Size           = new System.Drawing.Size(100, 38);
            this.btnClearLog.TabIndex       = 1;
            this.btnClearLog.Text           = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = false;
            this.btnClearLog.Click         += new System.EventHandler(this.BtnClearLog_Click);

            // ── prgProgressBar ─────────────────────────────────────
            this.prgProgressBar.Anchor      = System.Windows.Forms.AnchorStyles.Top
                                            | System.Windows.Forms.AnchorStyles.Left
                                            | System.Windows.Forms.AnchorStyles.Right;
            this.prgProgressBar.Location    = new System.Drawing.Point(12, 392);
            this.prgProgressBar.Name        = "prgProgressBar";
            this.prgProgressBar.Size        = new System.Drawing.Size(776, 18);
            this.prgProgressBar.Style       = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgProgressBar.TabIndex    = 4;

            // ── grpLog ─────────────────────────────────────────────
            this.grpLog.Anchor              = System.Windows.Forms.AnchorStyles.Top
                                            | System.Windows.Forms.AnchorStyles.Bottom
                                            | System.Windows.Forms.AnchorStyles.Left
                                            | System.Windows.Forms.AnchorStyles.Right;
            this.grpLog.Controls.Add(this.lstLog);
            this.grpLog.Font                = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpLog.Location            = new System.Drawing.Point(12, 418);
            this.grpLog.Name                = "grpLog";
            this.grpLog.Padding             = new System.Windows.Forms.Padding(10);
            this.grpLog.Size                = new System.Drawing.Size(776, 192);
            this.grpLog.TabIndex            = 5;
            this.grpLog.TabStop             = false;
            this.grpLog.Text                = "Log";

            // ── lstLog ─────────────────────────────────────────────
            this.lstLog.Anchor              = System.Windows.Forms.AnchorStyles.Top
                                           | System.Windows.Forms.AnchorStyles.Bottom
                                           | System.Windows.Forms.AnchorStyles.Left
                                           | System.Windows.Forms.AnchorStyles.Right;
            this.lstLog.BackColor           = System.Drawing.Color.FromArgb(30, 30, 30);
            this.lstLog.BorderStyle         = System.Windows.Forms.BorderStyle.None;
            this.lstLog.Font                = new System.Drawing.Font("Consolas", 8.5F);
            this.lstLog.ForeColor           = System.Drawing.Color.FromArgb(200, 230, 200);
            this.lstLog.FormattingEnabled   = true;
            this.lstLog.HorizontalScrollbar = true;
            this.lstLog.ItemHeight          = 14;
            this.lstLog.Location            = new System.Drawing.Point(10, 22);
            this.lstLog.Name                = "lstLog";
            this.lstLog.Size                = new System.Drawing.Size(754, 158);
            this.lstLog.TabIndex            = 0;

            // ── Form1 ──────────────────────────────────────────────
            this.AutoScaleDimensions        = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode              = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor                  = System.Drawing.Color.FromArgb(245, 245, 248);
            this.ClientSize                 = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.prgProgressBar);
            this.Controls.Add(this.grpLog);
            this.Font                       = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize                = new System.Drawing.Size(700, 560);
            this.Name                       = "Form1";
            this.StartPosition              = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                       = "XML to JSON Converter";

            // Resume layout
            this.pnlInputButtons.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.grpLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // ── Control declarations ───────────────────────────────────
        private System.Windows.Forms.Label          lblTitle;
        private System.Windows.Forms.GroupBox       grpInput;
        private System.Windows.Forms.ListBox        lstInputFiles;
        private System.Windows.Forms.Panel          pnlInputButtons;
        private System.Windows.Forms.Button         btnAddFiles;
        private System.Windows.Forms.Button         btnAddFolder;
        private System.Windows.Forms.Button         btnRemoveSelected;
        private System.Windows.Forms.Button         btnClearList;
        private System.Windows.Forms.GroupBox       grpOutput;
        private System.Windows.Forms.TextBox        txtOutputFolder;
        private System.Windows.Forms.Button         btnBrowseOutput;
        private System.Windows.Forms.Panel          pnlActions;
        private System.Windows.Forms.Button         btnConvert;
        private System.Windows.Forms.Button         btnClearLog;
        private System.Windows.Forms.ProgressBar    prgProgressBar;
        private System.Windows.Forms.GroupBox       grpLog;
        private System.Windows.Forms.ListBox        lstLog;
    }
}
