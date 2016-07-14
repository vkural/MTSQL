using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MTSQL.Generators;
using MTSQL.Core.Enums;

namespace MTSQL.UI
{
    public partial class frmMain : Form
    {
        private readonly List<string> _metadaList = new List<string>();

        private string _sql = string.Empty;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                var result = fbd.ShowDialog();

                if (result.Equals(DialogResult.OK))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath, "*.xml", SearchOption.AllDirectories);

                    if (files.Length > 0)
                    {
                        _metadaList.Clear();

                        for (var i = 0; i < files.Length; i++)
                        {
                            _metadaList.Add(files[i]);


                           ListViewItem listViewItem1 = new ListViewItem(new string[] {
                            "",
                            Path.GetFileName(files[i]) }, 0);

                            this.listView1.Items.Add(listViewItem1);
                         
                        }

                        this.listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }
            }
        }

        private void btnScriptOlustur_Click(object sender, EventArgs e)
        {
            if (_metadaList.Count > 0)
            {
                try
                {
                    if (chckMssql.Checked)
                    {
                        IDBScriptGenerator generator = ScriptGeneratorFactory.CreateGenerator(DBTypes.MSSQL);

                        txtSql.Text = _sql = generator.GenerateScript(_metadaList);
                    }

                    if (chckOracle.Checked)
                    {
                        IDBScriptGenerator generator = ScriptGeneratorFactory.CreateGenerator(DBTypes.ORACLE);

                        txtSql.Text = _sql = generator.GenerateScript(_metadaList);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_sql))
            {
                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "SQL Files (*.sql)|*.sql";

                    if (sfd.ShowDialog().Equals(DialogResult.OK))
                    {
                        using (var sw = new StreamWriter(sfd.FileName))
                        {
                            sw.WriteLine(_sql);
                        }
                    }
                }
            }
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_sql))
            {
                txtSql.SelectAll();
                txtSql.Focus();

                Clipboard.SetText(_sql);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listView1.SelectedItems.Clear();
        }
    }
}
