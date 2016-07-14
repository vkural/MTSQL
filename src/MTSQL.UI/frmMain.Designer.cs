namespace MTSQL.UI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSql = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chckOracle = new System.Windows.Forms.RadioButton();
            this.chckMssql = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnKopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.btnScriptOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.btnYukle = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(436, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(9, 3, 9, 10);
            this.groupBox1.Size = new System.Drawing.Size(777, 592);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtSql);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(9, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(759, 565);
            this.panel4.TabIndex = 2;
            // 
            // txtSql
            // 
            this.txtSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSql.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSql.Location = new System.Drawing.Point(0, 0);
            this.txtSql.Multiline = true;
            this.txtSql.Name = "txtSql";
            this.txtSql.ReadOnly = true;
            this.txtSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSql.Size = new System.Drawing.Size(759, 565);
            this.txtSql.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.LargeImageList = this.ımageList1;
            this.listView1.Location = new System.Drawing.Point(9, 17);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(401, 566);
            this.listView1.SmallImageList = this.ımageList1;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 111;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dosya Adı";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icon_xml_16_16-16x16.gif");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(11, 52);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(9, 3, 9, 9);
            this.groupBox2.Size = new System.Drawing.Size(419, 592);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Files";
            // 
            // chckOracle
            // 
            this.chckOracle.BackColor = System.Drawing.Color.Transparent;
            this.chckOracle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chckOracle.BackgroundImage")));
            this.chckOracle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckOracle.Location = new System.Drawing.Point(762, 0);
            this.chckOracle.Name = "chckOracle";
            this.chckOracle.Size = new System.Drawing.Size(63, 44);
            this.chckOracle.TabIndex = 5;
            this.chckOracle.Text = "Oracle";
            this.chckOracle.UseVisualStyleBackColor = false;
            // 
            // chckMssql
            // 
            this.chckMssql.BackColor = System.Drawing.Color.Transparent;
            this.chckMssql.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chckMssql.BackgroundImage")));
            this.chckMssql.Checked = true;
            this.chckMssql.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chckMssql.Location = new System.Drawing.Point(831, 0);
            this.chckMssql.Name = "chckMssql";
            this.chckMssql.Size = new System.Drawing.Size(148, 44);
            this.chckMssql.TabIndex = 4;
            this.chckMssql.TabStop = true;
            this.chckMssql.Text = "Microsoft Sql Server";
            this.chckMssql.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.BackgroundImage = global::MTSQL.UI.Properties.Resources.menu;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKopyala,
            this.btnKaydet,
            this.btnScriptOlustur,
            this.btnYukle});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.menuStrip1.Size = new System.Drawing.Size(1226, 44);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnKopyala
            // 
            this.btnKopyala.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnKopyala.Image = global::MTSQL.UI.Properties.Resources._1468434261_copy;
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(63, 34);
            this.btnKopyala.Text = "Copy";
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnKaydet.Image = global::MTSQL.UI.Properties.Resources._1468434285_down3;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(68, 34);
            this.btnKaydet.Text = "Export";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnScriptOlustur
            // 
            this.btnScriptOlustur.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnScriptOlustur.Image = global::MTSQL.UI.Properties.Resources._1468434345_finish_flag;
            this.btnScriptOlustur.Name = "btnScriptOlustur";
            this.btnScriptOlustur.Size = new System.Drawing.Size(102, 34);
            this.btnScriptOlustur.Text = "Create Script";
            this.btnScriptOlustur.Click += new System.EventHandler(this.btnScriptOlustur_Click);
            // 
            // btnYukle
            // 
            this.btnYukle.Image = global::MTSQL.UI.Properties.Resources._1468434413_opened_folder;
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(87, 34);
            this.btnYukle.Text = "Load Files";
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 656);
            this.Controls.Add(this.chckOracle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chckMssql);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Metadata to SQL Scripts";
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton chckMssql;
        private System.Windows.Forms.RadioButton chckOracle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSql;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnKopyala;
        private System.Windows.Forms.ToolStripMenuItem btnKaydet;
        private System.Windows.Forms.ToolStripMenuItem btnScriptOlustur;
        private System.Windows.Forms.ToolStripMenuItem btnYukle;
    }
}

