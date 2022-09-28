
namespace DoxXCode
{
    partial class DocXCodeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocXCodeForm));
            this.openDocXFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fileDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.loadTemplateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDocxMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.loadRecentFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.recentFilesListBox = new System.Windows.Forms.ListBox();
            this.loadPresetButton = new System.Windows.Forms.Button();
            this.loadSchemeButton = new System.Windows.Forms.Button();
            this.createSchemeButton = new System.Windows.Forms.Button();
            this.editSchemeTabPage = new System.Windows.Forms.TabPage();
            this.schemeEditVariablesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.schemeEditIncludeTemplateDataCheckBox = new System.Windows.Forms.CheckBox();
            this.schemeEditSaveButton = new System.Windows.Forms.Button();
            this.schemeEditCancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.schemeEditTemplatePathTextBox = new System.Windows.Forms.TextBox();
            this.schemeEditSchemeNameTextBox = new System.Windows.Forms.TextBox();
            this.schemeNameLabel = new System.Windows.Forms.Label();
            this.schemeEditBrowseTemplateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.schemeTabPage = new System.Windows.Forms.TabPage();
            this.schemeUseVariableFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.generateButton = new System.Windows.Forms.Button();
            this.cancelSchemeButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.schemeBrowseTemplateTextBox = new System.Windows.Forms.TextBox();
            this.schemeBrowseTemplateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.saveSchemeDialog = new System.Windows.Forms.SaveFileDialog();
            this.openSchemeDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveDocXDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.editSchemeTabPage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.schemeTabPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openDocXFileDialog
            // 
            this.openDocXFileDialog.FileName = "openDocXFileDialog";
            this.openDocXFileDialog.Filter = "Dokument word|*.docx";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileDropDownButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(835, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // fileDropDownButton
            // 
            this.fileDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fileDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTemplateMenuItem,
            this.saveDocxMenuItem});
            this.fileDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("fileDropDownButton.Image")));
            this.fileDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fileDropDownButton.Name = "fileDropDownButton";
            this.fileDropDownButton.Size = new System.Drawing.Size(56, 29);
            this.fileDropDownButton.Text = "File";
            // 
            // loadTemplateMenuItem
            // 
            this.loadTemplateMenuItem.Name = "loadTemplateMenuItem";
            this.loadTemplateMenuItem.Size = new System.Drawing.Size(229, 34);
            this.loadTemplateMenuItem.Text = "Load Template";
            // 
            // saveDocxMenuItem
            // 
            this.saveDocxMenuItem.Name = "saveDocxMenuItem";
            this.saveDocxMenuItem.Size = new System.Drawing.Size(229, 34);
            this.saveDocxMenuItem.Text = "Save DocX";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.homeTab);
            this.tabControl.Controls.Add(this.editSchemeTabPage);
            this.tabControl.Controls.Add(this.schemeTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 34);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(835, 572);
            this.tabControl.TabIndex = 1;
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.loadRecentFileButton);
            this.homeTab.Controls.Add(this.label1);
            this.homeTab.Controls.Add(this.recentFilesListBox);
            this.homeTab.Controls.Add(this.loadPresetButton);
            this.homeTab.Controls.Add(this.loadSchemeButton);
            this.homeTab.Controls.Add(this.createSchemeButton);
            this.homeTab.Location = new System.Drawing.Point(4, 34);
            this.homeTab.Name = "homeTab";
            this.homeTab.Size = new System.Drawing.Size(827, 534);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            this.homeTab.UseVisualStyleBackColor = true;
            // 
            // loadRecentFileButton
            // 
            this.loadRecentFileButton.Location = new System.Drawing.Point(604, 257);
            this.loadRecentFileButton.Name = "loadRecentFileButton";
            this.loadRecentFileButton.Size = new System.Drawing.Size(151, 35);
            this.loadRecentFileButton.TabIndex = 5;
            this.loadRecentFileButton.Text = "Load";
            this.loadRecentFileButton.UseVisualStyleBackColor = true;
            this.loadRecentFileButton.Click += new System.EventHandler(this.OnLoadRecentFileButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recent files";
            // 
            // recentFilesListBox
            // 
            this.recentFilesListBox.FormattingEnabled = true;
            this.recentFilesListBox.ItemHeight = 25;
            this.recentFilesListBox.Location = new System.Drawing.Point(54, 185);
            this.recentFilesListBox.Name = "recentFilesListBox";
            this.recentFilesListBox.Size = new System.Drawing.Size(500, 179);
            this.recentFilesListBox.TabIndex = 3;
            // 
            // loadPresetButton
            // 
            this.loadPresetButton.Location = new System.Drawing.Point(570, 40);
            this.loadPresetButton.Name = "loadPresetButton";
            this.loadPresetButton.Size = new System.Drawing.Size(151, 35);
            this.loadPresetButton.TabIndex = 2;
            this.loadPresetButton.Text = "Load preset";
            this.loadPresetButton.UseVisualStyleBackColor = true;
            this.loadPresetButton.Click += new System.EventHandler(this.OnLoadPresetButtonClick);
            // 
            // loadSchemeButton
            // 
            this.loadSchemeButton.Location = new System.Drawing.Point(306, 40);
            this.loadSchemeButton.Name = "loadSchemeButton";
            this.loadSchemeButton.Size = new System.Drawing.Size(151, 35);
            this.loadSchemeButton.TabIndex = 1;
            this.loadSchemeButton.Text = "Load scheme";
            this.loadSchemeButton.UseVisualStyleBackColor = true;
            this.loadSchemeButton.Click += new System.EventHandler(this.OnLoadSchemeButtonClick);
            // 
            // createSchemeButton
            // 
            this.createSchemeButton.Location = new System.Drawing.Point(54, 40);
            this.createSchemeButton.Name = "createSchemeButton";
            this.createSchemeButton.Size = new System.Drawing.Size(151, 35);
            this.createSchemeButton.TabIndex = 0;
            this.createSchemeButton.Text = "Create scheme";
            this.createSchemeButton.UseVisualStyleBackColor = true;
            this.createSchemeButton.Click += new System.EventHandler(this.OnCreateSchemeButtonClick);
            // 
            // editSchemeTabPage
            // 
            this.editSchemeTabPage.Controls.Add(this.schemeEditVariablesFlowLayoutPanel);
            this.editSchemeTabPage.Controls.Add(this.panel2);
            this.editSchemeTabPage.Controls.Add(this.panel1);
            this.editSchemeTabPage.Location = new System.Drawing.Point(4, 34);
            this.editSchemeTabPage.Name = "editSchemeTabPage";
            this.editSchemeTabPage.Size = new System.Drawing.Size(827, 534);
            this.editSchemeTabPage.TabIndex = 1;
            this.editSchemeTabPage.Text = "Edit scheme";
            this.editSchemeTabPage.UseVisualStyleBackColor = true;
            // 
            // schemeEditVariablesFlowLayoutPanel
            // 
            this.schemeEditVariablesFlowLayoutPanel.AutoScroll = true;
            this.schemeEditVariablesFlowLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.schemeEditVariablesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schemeEditVariablesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.schemeEditVariablesFlowLayoutPanel.Location = new System.Drawing.Point(0, 106);
            this.schemeEditVariablesFlowLayoutPanel.Name = "schemeEditVariablesFlowLayoutPanel";
            this.schemeEditVariablesFlowLayoutPanel.Size = new System.Drawing.Size(827, 328);
            this.schemeEditVariablesFlowLayoutPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.schemeEditIncludeTemplateDataCheckBox);
            this.panel2.Controls.Add(this.schemeEditSaveButton);
            this.panel2.Controls.Add(this.schemeEditCancelButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 100);
            this.panel2.TabIndex = 8;
            // 
            // schemeEditIncludeTemplateDataCheckBox
            // 
            this.schemeEditIncludeTemplateDataCheckBox.AutoSize = true;
            this.schemeEditIncludeTemplateDataCheckBox.Location = new System.Drawing.Point(442, 39);
            this.schemeEditIncludeTemplateDataCheckBox.Name = "schemeEditIncludeTemplateDataCheckBox";
            this.schemeEditIncludeTemplateDataCheckBox.Size = new System.Drawing.Size(209, 29);
            this.schemeEditIncludeTemplateDataCheckBox.TabIndex = 2;
            this.schemeEditIncludeTemplateDataCheckBox.Text = "include template data";
            this.schemeEditIncludeTemplateDataCheckBox.UseVisualStyleBackColor = true;
            // 
            // schemeEditSaveButton
            // 
            this.schemeEditSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.schemeEditSaveButton.Location = new System.Drawing.Point(682, 35);
            this.schemeEditSaveButton.Name = "schemeEditSaveButton";
            this.schemeEditSaveButton.Size = new System.Drawing.Size(112, 34);
            this.schemeEditSaveButton.TabIndex = 1;
            this.schemeEditSaveButton.Text = "Save";
            this.schemeEditSaveButton.UseVisualStyleBackColor = true;
            this.schemeEditSaveButton.Click += new System.EventHandler(this.OnSchemeEditSaveButtonClick);
            // 
            // schemeEditCancelButton
            // 
            this.schemeEditCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.schemeEditCancelButton.Location = new System.Drawing.Point(38, 35);
            this.schemeEditCancelButton.Name = "schemeEditCancelButton";
            this.schemeEditCancelButton.Size = new System.Drawing.Size(112, 34);
            this.schemeEditCancelButton.TabIndex = 0;
            this.schemeEditCancelButton.Text = "Cancel";
            this.schemeEditCancelButton.UseVisualStyleBackColor = true;
            this.schemeEditCancelButton.Click += new System.EventHandler(this.OnSchemeEditCancelButtonClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.schemeEditTemplatePathTextBox);
            this.panel1.Controls.Add(this.schemeEditSchemeNameTextBox);
            this.panel1.Controls.Add(this.schemeNameLabel);
            this.panel1.Controls.Add(this.schemeEditBrowseTemplateButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 106);
            this.panel1.TabIndex = 7;
            // 
            // schemeEditTemplatePathTextBox
            // 
            this.schemeEditTemplatePathTextBox.Enabled = false;
            this.schemeEditTemplatePathTextBox.Location = new System.Drawing.Point(103, 51);
            this.schemeEditTemplatePathTextBox.Name = "schemeEditTemplatePathTextBox";
            this.schemeEditTemplatePathTextBox.Size = new System.Drawing.Size(381, 31);
            this.schemeEditTemplatePathTextBox.TabIndex = 2;
            // 
            // schemeEditSchemeNameTextBox
            // 
            this.schemeEditSchemeNameTextBox.Location = new System.Drawing.Point(103, 14);
            this.schemeEditSchemeNameTextBox.Name = "schemeEditSchemeNameTextBox";
            this.schemeEditSchemeNameTextBox.Size = new System.Drawing.Size(381, 31);
            this.schemeEditSchemeNameTextBox.TabIndex = 0;
            // 
            // schemeNameLabel
            // 
            this.schemeNameLabel.AutoSize = true;
            this.schemeNameLabel.Location = new System.Drawing.Point(38, 17);
            this.schemeNameLabel.Name = "schemeNameLabel";
            this.schemeNameLabel.Size = new System.Drawing.Size(59, 25);
            this.schemeNameLabel.TabIndex = 1;
            this.schemeNameLabel.Text = "Name";
            this.schemeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // schemeEditBrowseTemplateButton
            // 
            this.schemeEditBrowseTemplateButton.Location = new System.Drawing.Point(490, 49);
            this.schemeEditBrowseTemplateButton.Name = "schemeEditBrowseTemplateButton";
            this.schemeEditBrowseTemplateButton.Size = new System.Drawing.Size(112, 34);
            this.schemeEditBrowseTemplateButton.TabIndex = 4;
            this.schemeEditBrowseTemplateButton.Text = "Browse";
            this.schemeEditBrowseTemplateButton.UseVisualStyleBackColor = true;
            this.schemeEditBrowseTemplateButton.Click += new System.EventHandler(this.OnSchemeEditBrowseTemplateButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Template";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // schemeTabPage
            // 
            this.schemeTabPage.Controls.Add(this.schemeUseVariableFlowLayoutPanel);
            this.schemeTabPage.Controls.Add(this.panel3);
            this.schemeTabPage.Controls.Add(this.panel4);
            this.schemeTabPage.Location = new System.Drawing.Point(4, 34);
            this.schemeTabPage.Name = "schemeTabPage";
            this.schemeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.schemeTabPage.Size = new System.Drawing.Size(827, 534);
            this.schemeTabPage.TabIndex = 2;
            this.schemeTabPage.Text = "Scheme";
            this.schemeTabPage.UseVisualStyleBackColor = true;
            // 
            // schemeUseVariableFlowLayoutPanel
            // 
            this.schemeUseVariableFlowLayoutPanel.AutoScroll = true;
            this.schemeUseVariableFlowLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.schemeUseVariableFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schemeUseVariableFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.schemeUseVariableFlowLayoutPanel.Location = new System.Drawing.Point(3, 64);
            this.schemeUseVariableFlowLayoutPanel.Name = "schemeUseVariableFlowLayoutPanel";
            this.schemeUseVariableFlowLayoutPanel.Size = new System.Drawing.Size(821, 367);
            this.schemeUseVariableFlowLayoutPanel.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.generateButton);
            this.panel3.Controls.Add(this.cancelSchemeButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 431);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(821, 100);
            this.panel3.TabIndex = 11;
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generateButton.Location = new System.Drawing.Point(676, 35);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(112, 34);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.OnSchemeGenerateButtonClick);
            // 
            // cancelSchemeButton
            // 
            this.cancelSchemeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelSchemeButton.Location = new System.Drawing.Point(38, 35);
            this.cancelSchemeButton.Name = "cancelSchemeButton";
            this.cancelSchemeButton.Size = new System.Drawing.Size(112, 34);
            this.cancelSchemeButton.TabIndex = 0;
            this.cancelSchemeButton.Text = "Cancel";
            this.cancelSchemeButton.UseVisualStyleBackColor = true;
            this.cancelSchemeButton.Click += new System.EventHandler(this.OnSchemeCancelButtonClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.schemeBrowseTemplateTextBox);
            this.panel4.Controls.Add(this.schemeBrowseTemplateButton);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(821, 61);
            this.panel4.TabIndex = 10;
            // 
            // schemeBrowseTemplateTextBox
            // 
            this.schemeBrowseTemplateTextBox.Enabled = false;
            this.schemeBrowseTemplateTextBox.Location = new System.Drawing.Point(104, 13);
            this.schemeBrowseTemplateTextBox.Name = "schemeBrowseTemplateTextBox";
            this.schemeBrowseTemplateTextBox.Size = new System.Drawing.Size(381, 31);
            this.schemeBrowseTemplateTextBox.TabIndex = 2;
            // 
            // schemeBrowseTemplateButton
            // 
            this.schemeBrowseTemplateButton.Location = new System.Drawing.Point(491, 11);
            this.schemeBrowseTemplateButton.Name = "schemeBrowseTemplateButton";
            this.schemeBrowseTemplateButton.Size = new System.Drawing.Size(112, 34);
            this.schemeBrowseTemplateButton.TabIndex = 4;
            this.schemeBrowseTemplateButton.Text = "Browse";
            this.schemeBrowseTemplateButton.UseVisualStyleBackColor = true;
            this.schemeBrowseTemplateButton.Click += new System.EventHandler(this.OnSchemeBrowseTemplateButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Template";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // saveSchemeDialog
            // 
            this.saveSchemeDialog.Filter = "scheme files|*.scheme";
            this.saveSchemeDialog.Title = "Save scheme";
            // 
            // openSchemeDialog
            // 
            this.openSchemeDialog.FileName = "openSchemeDialog";
            this.openSchemeDialog.Filter = "scheme files|*.scheme";
            this.openSchemeDialog.Title = "Open scheme";
            // 
            // saveDocXDialog
            // 
            this.saveDocXDialog.Filter = "Dokument word|*.docx";
            this.saveDocXDialog.Title = "Save DocX";
            // 
            // DocXCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(835, 606);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DocXCodeForm";
            this.Text = "DocX Code";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homeTab.PerformLayout();
            this.editSchemeTabPage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.schemeTabPage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openDocXFileDialog;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton fileDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem loadTemplateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDocxMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.Button loadRecentFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox recentFilesListBox;
        private System.Windows.Forms.Button loadPresetButton;
        private System.Windows.Forms.Button loadSchemeButton;
        private System.Windows.Forms.Button createSchemeButton;
        private System.Windows.Forms.TabPage editSchemeTabPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button schemeEditSaveButton;
        private System.Windows.Forms.Button schemeEditCancelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox schemeEditTemplatePathTextBox;
        private System.Windows.Forms.TextBox schemeEditSchemeNameTextBox;
        private System.Windows.Forms.Label schemeNameLabel;
        private System.Windows.Forms.Button schemeEditBrowseTemplateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel schemeEditVariablesFlowLayoutPanel;
        private System.Windows.Forms.SaveFileDialog saveSchemeDialog;
        private System.Windows.Forms.CheckBox schemeEditIncludeTemplateDataCheckBox;
        private System.Windows.Forms.TabPage schemeTabPage;
        private System.Windows.Forms.FlowLayoutPanel schemeUseVariableFlowLayoutPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button cancelSchemeButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox schemeBrowseTemplateTextBox;
        private System.Windows.Forms.Button schemeBrowseTemplateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openSchemeDialog;
        private System.Windows.Forms.SaveFileDialog saveDocXDialog;
    }
}

