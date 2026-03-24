<div id="top">

<!-- HEADER STYLE: CLASSIC -->
<div align="center">

# <code>XmlToJsonConverter</code>

<em></em>

<!-- BADGES -->
<!-- local repository, no metadata badges. -->

</div>
<br>

---

## Overview
<b>XmlToJsonConverter</b> is a C# Windows Forms desktop application that converts XML files to JSON format. Here's a quick overview:

<b>What it does:</b>
- Lets you select individual XML files (.xml, .xsl, .xslt) or entire folders of them via a GUI
- Converts each XML file to a structured JSON file and saves them to an output folder you choose
- Shows a progress bar and live log as files are processed
- Handles batch conversion asynchronously so the UI stays responsive

<b>How it converts XML → JSON:</b>
- XML attributes become @attributeName keys
- Text content becomes a #text key
- Repeated sibling elements of the same tag are grouped into JSON arrays
- Nested elements are recursively converted into nested JSON objects

It's a straightforward, practical utility — a nice little desktop tool for anyone who needs to batch-transform XML data into JSON without writing custom scripts each time.


---

## Features

<code>XmlToJsonConverter</code>

---

## Project Structure

```sh
└── /
    ├── .github
    │   └── workflows
    ├── XmlToJsonConverter
    │   ├── MainWindow.Designer.cs
    │   ├── MainWindow.cs
    │   ├── MainWindow.resx
    │   ├── Program.cs
    │   └── XmlToJsonConverter.csproj
    └── XmlToJsonConverter.sln
```

<div align="right">

[![][back-to-top]](#top)

</div>


[back-to-top]: https://img.shields.io/badge/-BACK_TO_TOP-151515?style=flat-square


---
