using DoxXCode.Utility;
using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;

namespace DoxXCode
{
    public partial class DocXCodeForm : Form
    {

        private DoxXCodeScheme edittedScheme;

        private DoxXCodeScheme usedScheme;
        private DoxXCodeDocument usedDocument;

        public DocXCodeForm()
        {
            InitializeComponent();

            loadTemplateMenuItem.Click += OnLoadTemplateMenuItemClicked;

            CloseTab(editSchemeTabPage);
            CloseTab(schemeTabPage);

            LoadRecentFilesList();
        }

        #region MainTab

        private void OnCreateSchemeButtonClick(object sender, EventArgs e)
        {
            CloseTab(homeTab);
            OpenTab(editSchemeTabPage);
            edittedScheme = new DoxXCodeScheme();
        }

        private void OnLoadSchemeButtonClick(object sender, EventArgs e)
        {
            var result = openSchemeDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var scheme = DoxXCodeScheme.LoadFromFile(openSchemeDialog.FileName);
                if (scheme != null)
                {
                    OpenTab(schemeTabPage);
                    OnSchemeTabOpen(scheme);
                    CloseTab(editSchemeTabPage);
                }
            }
        }

        private void OnLoadPresetButtonClick(object sender, EventArgs e)
        {

        }

        private void OnLoadRecentFileButtonClick(object sender, EventArgs e)
        {

        }

        private void LoadRecentFilesList()
        {
            //TODO: Load some file storing recent files data
            //TODO: Fill recent files list view with recent files
        }

        private void OnLoadTemplateMenuItemClicked(object sender, EventArgs e)
        {
            var result = openDocXFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filepath = openDocXFileDialog.FileName;
                DoxXCodeDocument document = DoxXCodeDocument.LoadFromTemplate(filepath);

            }
        }

        #endregion MainTab

        #region SchemeEditTab

        private void OnSchemeEditBrowseTemplateButtonClick(object sender, EventArgs e)
        {
            var result = openDocXFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string templatePath = openDocXFileDialog.FileName;

                schemeEditTemplatePathTextBox.Text = templatePath;
                if (string.IsNullOrEmpty(schemeEditSchemeNameTextBox.Text))
                {
                    schemeEditSchemeNameTextBox.Text = System.IO.Path.GetFileNameWithoutExtension(templatePath);
                }

                var editSchemeDocument = DoxXCodeDocument.LoadFromTemplate(templatePath);
                edittedScheme.SetTemplate(editSchemeDocument.Template);
                schemeEditVariablesFlowLayoutPanel.Controls.Clear(); //TODO: do not erase all data from list
                var variables = editSchemeDocument.GetVariables();
                foreach (var variable in variables)
                {
                    Panel newPanel = new FlowLayoutPanel()
                    {
                        Name = "VariableGroup",
                        AutoSize = true,
                        AutoSizeMode = AutoSizeMode.GrowOnly,
                        Anchor = AnchorStyles.Left | AnchorStyles.Right,
                        FlowDirection = FlowDirection.LeftToRight,
                        Dock = DockStyle.Top
                    };
                    Label label = new Label()
                    {
                        Name = "VariableName",
                        AutoSize = true,
                        Anchor = AnchorStyles.Left,
                        Text = variable
                    };
                    ComboBox typeComboBox = new ComboBox
                    {
                        Name = "VariableType",
                        AutoSize = true,
                        Anchor = AnchorStyles.Left,
                    };
                    for (int i = 0; i < (int)VariableType.Count; ++i)
                    {
                        typeComboBox.Items.Add((VariableType)i);
                    }
                    typeComboBox.SelectedIndex = 0;
                    newPanel.Controls.Add(label);
                    newPanel.Controls.Add(typeComboBox);

                    schemeEditVariablesFlowLayoutPanel.Controls.Add(newPanel);
                }
            }
            else
            {
                schemeEditTemplatePathTextBox.Text = string.Empty;
            }
        }

        private void OnSchemeEditSaveButtonClick(object sender, EventArgs e)
        {
            saveSchemeDialog.FileName = schemeEditSchemeNameTextBox.Text;
            var result = saveSchemeDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                UpdateEdittedScheme();
                using (StreamWriter sw = new StreamWriter(saveSchemeDialog.FileName))
                {
                    sw.Write(DoxXCodeScheme.ToJson(edittedScheme, schemeEditIncludeTemplateDataCheckBox.Checked));
                }
                OpenTab(schemeTabPage);
                OnSchemeTabOpen(edittedScheme);
                edittedScheme = null;
                CloseTab(editSchemeTabPage);
            }
        }

        private void OnSchemeEditCancelButtonClick(object sender, EventArgs e)
        {
            edittedScheme = null;
            CloseTab(editSchemeTabPage);
            OpenTab(homeTab);
        }

        private void UpdateEdittedScheme()
        {
            edittedScheme.SetName(schemeEditSchemeNameTextBox.Text);
            foreach (var control in schemeEditVariablesFlowLayoutPanel.Controls)
            {
                if (control is Panel panel)
                {
                    string variableName = null;
                    VariableType variableType = VariableType.Boolean;
                    foreach (var c in panel.Controls)
                    {
                        if (c is Label label && label.Name.Equals("VariableName"))
                        {
                            variableName = label.Text;
                        }
                        else if (c is ComboBox comboBox && comboBox.Name.Equals("VariableType"))
                        {
                            variableType = (VariableType)comboBox.SelectedIndex;
                        }
                    }
                    if (!string.IsNullOrEmpty(variableName))
                    {
                        edittedScheme.SetVariableType(variableName, variableType);
                    }
                }
            }
        }

        #endregion SchemeEditTab

        #region SchemeTab

        private void OnSchemeTabOpen(DoxXCodeScheme scheme)
        {
            usedScheme = scheme;
            schemeTabPage.Text = scheme.SchemeName;

            schemeBrowseTemplateTextBox.Text = usedScheme.HasTemplate ? $"From scheme: {usedScheme.SchemeName}" : "No template provided";

            UpdateVariableControls();
        }
        private void OnSchemeBrowseTemplateButtonClick(object sender, EventArgs e)
        {
            var result = openDocXFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string templatePath = openDocXFileDialog.FileName;

                schemeBrowseTemplateTextBox.Text = templatePath;
                if (string.IsNullOrEmpty(schemeBrowseTemplateTextBox.Text))
                {
                    schemeBrowseTemplateTextBox.Text = System.IO.Path.GetFileNameWithoutExtension(templatePath);
                }

                usedDocument = DoxXCodeDocument.LoadFromTemplate(templatePath);
            }
            else
            {
                usedDocument = null;
                schemeBrowseTemplateTextBox.Text = usedScheme.HasTemplate ? $"From scheme: {usedScheme.SchemeName}" : "No template provided";
            }
        }
        private void OnSchemeGenerateButtonClick(object sender, EventArgs e)
        {
            if (usedDocument == null)
            {
                if (usedScheme.HasTemplate)
                {
                    usedDocument = usedScheme.GenerateDocument();
                }
                else
                {
                    var result = openDocXFileDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        usedDocument = DoxXCodeDocument.LoadFromTemplate(openDocXFileDialog.FileName);
                    }
                }
            }
            if (usedDocument != null)
            {
                var result = saveDocXDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    GenerateOutputDocument(usedDocument, saveDocXDialog.FileName);
                }
            }
        }
        private void OnSchemeCancelButtonClick(object sender, EventArgs e)
        {
            usedScheme = null;
            CloseTab(schemeTabPage);
            OpenTab(homeTab);
        }
        private void UpdateVariableControls()
        {
            schemeUseVariableFlowLayoutPanel.Controls.Clear(); //TODO: do not erase all data from list
            var variables = usedScheme.GetVariablesData();
            foreach (var variable in variables)
            {
                Panel newPanel = new FlowLayoutPanel()
                {
                    Name = "VariableGroup",
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowOnly,
                    Anchor = AnchorStyles.Left | AnchorStyles.Right,
                    FlowDirection = FlowDirection.LeftToRight,
                    Dock = DockStyle.Top
                };
                Label label = new Label()
                {
                    Name = "VariableName",
                    AutoSize = true,
                    Anchor = AnchorStyles.Left,
                    Text = variable.name
                };
                Control variableField = null;
                switch (variable.type)
                {
                    case VariableType.Boolean:
                        {
                            variableField = new CheckBox
                            {
                                Name = "VariableField",
                                AutoSize = true,
                                Anchor = AnchorStyles.Left
                            };
                        }
                        break;
                    case VariableType.Date:
                        {
                            variableField = new DateTimePicker
                            {
                                Name = "VariableField",
                                AutoSize = true,
                                Anchor = AnchorStyles.Left
                            };
                        }
                        break;
                    case VariableType.String:
                        {
                            variableField = new TextBox
                            {
                                Name = "VariableField",
                                AutoSize = true,
                                Anchor = AnchorStyles.Left
                            };
                        }
                        break;
                    case VariableType.Integer:
                        {
                            variableField = new TextBox
                            {
                                Name = "VariableField",
                                AutoSize = true,
                                Anchor = AnchorStyles.Left
                            };
                            variableField.Text = "0";
                            variableField.KeyPress += (sender, eventArgs) =>
                            {
                                eventArgs.Handled = !char.IsDigit(eventArgs.KeyChar);
                            };
                        }
                        break;
                    case VariableType.Float:
                        {
                            variableField = new TextBox
                            {
                                Name = "VariableField",
                                AutoSize = true,
                                Anchor = AnchorStyles.Left
                            };
                            variableField.Text = "0.0";
                            variableField.KeyPress += (sender, eventArgs) =>
                            {
                                eventArgs.Handled = !(char.IsDigit(eventArgs.KeyChar) || (eventArgs.KeyChar.Equals('.') && variableField.Text.Count('.') <= 0));
                            };
                        }
                        break;

                }

                newPanel.Controls.Add(label);
                newPanel.Controls.Add(variableField);

                schemeUseVariableFlowLayoutPanel.Controls.Add(newPanel);
            }
        }
        private void GenerateOutputDocument(DoxXCodeDocument document, string filePath)
        {
            //TODO: read values from controls, place values in docx, save docx
            Dictionary<string, object> variableValues = new Dictionary<string, object>();
            foreach (var control in schemeUseVariableFlowLayoutPanel.Controls)
            {
                if (control is Panel panel)
                {
                    string variableName = null;
                    object variableValue = null;
                    foreach (var c in panel.Controls)
                    {
                        if (c is Label label && label.Name.Equals("VariableName"))
                        {
                            variableName = label.Text;
                        }
                        else if (c is Control cont && cont.Name.Equals("VariableField"))
                        {
                            var type = usedScheme.GetVariableType(variableName);
                            switch (type)
                            {
                                case VariableType.Boolean when cont is CheckBox checkbox:
                                    {
                                        variableValue = checkbox.Checked;
                                    }
                                    break;
                                case VariableType.Date when cont is DateTimePicker datePicker:
                                    {
                                        variableValue = datePicker.Value.Date;
                                    }
                                    break;
                                case VariableType.String when cont is TextBox textBox:
                                    {
                                        variableValue = textBox.Text;
                                    }
                                    break;
                                case VariableType.Integer when cont is TextBox textBox:
                                    {
                                        variableValue = int.Parse(textBox.Text);
                                    }
                                    break;
                                case VariableType.Float when cont is TextBox textBox:
                                    {
                                        variableValue = float.Parse(textBox.Text.Replace('.', ','));
                                    }
                                    break;
                            }
                        }
                    }
                    if (!string.IsNullOrEmpty(variableName))
                    {
                        if (!variableValues.ContainsKey(variableName))
                        {
                            variableValues.Add(variableName, variableValue);
                        }
                        else
                        {
                            Debug.WriteLine("Error");
                        }
                    }
                }
            }
            document.GenerateOutput(variableValues);
            document.OutputDocx.SaveAs(filePath);
        }

        #endregion SchemeTab

        private void OpenTab(TabPage tabPage)
        {
            if (!this.tabControl.TabPages.Contains(tabPage))
            {
                this.tabControl.TabPages.Add(tabPage);
            }
            this.tabControl.SelectedTab = tabPage;
        }
        private void CloseTab(TabPage tabPage)
        {
            if (this.tabControl.TabPages.Contains(tabPage))
            {
                this.tabControl.TabPages.Remove(tabPage);
            }
        }
    }
}
