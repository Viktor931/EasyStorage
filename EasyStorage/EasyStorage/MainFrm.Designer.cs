namespace EasyStorage
{
    partial class MainFrm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SkladisteTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KolicinaTxtbx = new System.Windows.Forms.TextBox();
            this.NazivArtiklaTxtbx = new System.Windows.Forms.TextBox();
            this.ObrisiBtn = new System.Windows.Forms.Button();
            this.AzurirajBtn = new System.Windows.Forms.Button();
            this.DodajBtn = new System.Windows.Forms.Button();
            this.dataGridViewArtikli = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.OIBTxtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DugovanjeTxtbx = new System.Windows.Forms.TextBox();
            this.NazivKupcaTxtbx = new System.Windows.Forms.TextBox();
            this.KupciAzurirajBtn = new System.Windows.Forms.Button();
            this.KupciDodajBtn = new System.Windows.Forms.Button();
            this.DataGridViewKupci = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.SkladisteTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikli)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewKupci)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SkladisteTab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 393);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // SkladisteTab
            // 
            this.SkladisteTab.Controls.Add(this.label2);
            this.SkladisteTab.Controls.Add(this.label1);
            this.SkladisteTab.Controls.Add(this.KolicinaTxtbx);
            this.SkladisteTab.Controls.Add(this.NazivArtiklaTxtbx);
            this.SkladisteTab.Controls.Add(this.ObrisiBtn);
            this.SkladisteTab.Controls.Add(this.AzurirajBtn);
            this.SkladisteTab.Controls.Add(this.DodajBtn);
            this.SkladisteTab.Controls.Add(this.dataGridViewArtikli);
            this.SkladisteTab.Location = new System.Drawing.Point(4, 22);
            this.SkladisteTab.Name = "SkladisteTab";
            this.SkladisteTab.Padding = new System.Windows.Forms.Padding(3);
            this.SkladisteTab.Size = new System.Drawing.Size(545, 367);
            this.SkladisteTab.TabIndex = 0;
            this.SkladisteTab.Text = "Skladište";
            this.SkladisteTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Količina (kg)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naziv artikla";
            // 
            // KolicinaTxtbx
            // 
            this.KolicinaTxtbx.Location = new System.Drawing.Point(323, 51);
            this.KolicinaTxtbx.Name = "KolicinaTxtbx";
            this.KolicinaTxtbx.Size = new System.Drawing.Size(100, 20);
            this.KolicinaTxtbx.TabIndex = 5;
            // 
            // NazivArtiklaTxtbx
            // 
            this.NazivArtiklaTxtbx.Location = new System.Drawing.Point(80, 51);
            this.NazivArtiklaTxtbx.Name = "NazivArtiklaTxtbx";
            this.NazivArtiklaTxtbx.Size = new System.Drawing.Size(200, 20);
            this.NazivArtiklaTxtbx.TabIndex = 4;
            // 
            // ObrisiBtn
            // 
            this.ObrisiBtn.Location = new System.Drawing.Point(323, 92);
            this.ObrisiBtn.Name = "ObrisiBtn";
            this.ObrisiBtn.Size = new System.Drawing.Size(100, 25);
            this.ObrisiBtn.TabIndex = 3;
            this.ObrisiBtn.Text = "Obriši";
            this.ObrisiBtn.UseVisualStyleBackColor = true;
            this.ObrisiBtn.Click += new System.EventHandler(this.ObrisiBtn_Click);
            // 
            // AzurirajBtn
            // 
            this.AzurirajBtn.Location = new System.Drawing.Point(203, 92);
            this.AzurirajBtn.Name = "AzurirajBtn";
            this.AzurirajBtn.Size = new System.Drawing.Size(100, 25);
            this.AzurirajBtn.TabIndex = 2;
            this.AzurirajBtn.Text = "Ažuriraj";
            this.AzurirajBtn.UseVisualStyleBackColor = true;
            this.AzurirajBtn.Click += new System.EventHandler(this.AzurirajBtn_Click);
            // 
            // DodajBtn
            // 
            this.DodajBtn.Location = new System.Drawing.Point(80, 92);
            this.DodajBtn.Name = "DodajBtn";
            this.DodajBtn.Size = new System.Drawing.Size(100, 25);
            this.DodajBtn.TabIndex = 1;
            this.DodajBtn.Text = "Dodaj";
            this.DodajBtn.UseVisualStyleBackColor = true;
            this.DodajBtn.Click += new System.EventHandler(this.DodajBtn_Click);
            // 
            // dataGridViewArtikli
            // 
            this.dataGridViewArtikli.AllowUserToAddRows = false;
            this.dataGridViewArtikli.AllowUserToDeleteRows = false;
            this.dataGridViewArtikli.AllowUserToResizeRows = false;
            this.dataGridViewArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtikli.Location = new System.Drawing.Point(80, 138);
            this.dataGridViewArtikli.MinimumSize = new System.Drawing.Size(343, 0);
            this.dataGridViewArtikli.MultiSelect = false;
            this.dataGridViewArtikli.Name = "dataGridViewArtikli";
            this.dataGridViewArtikli.ReadOnly = true;
            this.dataGridViewArtikli.RowHeadersVisible = false;
            this.dataGridViewArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArtikli.Size = new System.Drawing.Size(343, 207);
            this.dataGridViewArtikli.TabIndex = 0;
            this.dataGridViewArtikli.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewArtikli_CellMouseClick);
            this.dataGridViewArtikli.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewArtikli_DataBindingComplete);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.OIBTxtbx);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.DugovanjeTxtbx);
            this.tabPage2.Controls.Add(this.NazivKupcaTxtbx);
            this.tabPage2.Controls.Add(this.KupciAzurirajBtn);
            this.tabPage2.Controls.Add(this.KupciDodajBtn);
            this.tabPage2.Controls.Add(this.DataGridViewKupci);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(545, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kupci";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "OIB kupca";
            // 
            // OIBTxtbx
            // 
            this.OIBTxtbx.Location = new System.Drawing.Point(221, 53);
            this.OIBTxtbx.Name = "OIBTxtbx";
            this.OIBTxtbx.Size = new System.Drawing.Size(100, 20);
            this.OIBTxtbx.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Dugovanje (kn)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Naziv kupca";
            // 
            // DugovanjeTxtbx
            // 
            this.DugovanjeTxtbx.Location = new System.Drawing.Point(344, 53);
            this.DugovanjeTxtbx.Name = "DugovanjeTxtbx";
            this.DugovanjeTxtbx.Size = new System.Drawing.Size(100, 20);
            this.DugovanjeTxtbx.TabIndex = 14;
            // 
            // NazivKupcaTxtbx
            // 
            this.NazivKupcaTxtbx.Location = new System.Drawing.Point(101, 53);
            this.NazivKupcaTxtbx.Name = "NazivKupcaTxtbx";
            this.NazivKupcaTxtbx.Size = new System.Drawing.Size(100, 20);
            this.NazivKupcaTxtbx.TabIndex = 12;
            // 
            // KupciAzurirajBtn
            // 
            this.KupciAzurirajBtn.Location = new System.Drawing.Point(284, 94);
            this.KupciAzurirajBtn.Name = "KupciAzurirajBtn";
            this.KupciAzurirajBtn.Size = new System.Drawing.Size(160, 25);
            this.KupciAzurirajBtn.TabIndex = 16;
            this.KupciAzurirajBtn.Text = "Ažuriraj";
            this.KupciAzurirajBtn.UseVisualStyleBackColor = true;
            this.KupciAzurirajBtn.Click += new System.EventHandler(this.KupciAzurirajBtn_Click);
            // 
            // KupciDodajBtn
            // 
            this.KupciDodajBtn.Location = new System.Drawing.Point(101, 94);
            this.KupciDodajBtn.Name = "KupciDodajBtn";
            this.KupciDodajBtn.Size = new System.Drawing.Size(160, 25);
            this.KupciDodajBtn.TabIndex = 15;
            this.KupciDodajBtn.Text = "Dodaj";
            this.KupciDodajBtn.UseVisualStyleBackColor = true;
            this.KupciDodajBtn.Click += new System.EventHandler(this.KupciDodajBtn_Click);
            // 
            // DataGridViewKupci
            // 
            this.DataGridViewKupci.AllowUserToAddRows = false;
            this.DataGridViewKupci.AllowUserToDeleteRows = false;
            this.DataGridViewKupci.AllowUserToResizeRows = false;
            this.DataGridViewKupci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewKupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewKupci.Location = new System.Drawing.Point(101, 140);
            this.DataGridViewKupci.MinimumSize = new System.Drawing.Size(343, 0);
            this.DataGridViewKupci.MultiSelect = false;
            this.DataGridViewKupci.Name = "DataGridViewKupci";
            this.DataGridViewKupci.ReadOnly = true;
            this.DataGridViewKupci.RowHeadersVisible = false;
            this.DataGridViewKupci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewKupci.Size = new System.Drawing.Size(343, 207);
            this.DataGridViewKupci.TabIndex = 28;
            this.DataGridViewKupci.TabStop = false;
            this.DataGridViewKupci.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewKupci_CellContentDoubleClick);
            this.DataGridViewKupci.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewKupci_CellMouseClick);
            this.DataGridViewKupci.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewKupci_DataBindingComplete);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 393);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainFrm";
            this.Text = "EasyStorage";
            this.tabControl1.ResumeLayout(false);
            this.SkladisteTab.ResumeLayout(false);
            this.SkladisteTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikli)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewKupci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SkladisteTab;
        private System.Windows.Forms.DataGridView dataGridViewArtikli;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KolicinaTxtbx;
        private System.Windows.Forms.TextBox NazivArtiklaTxtbx;
        private System.Windows.Forms.Button ObrisiBtn;
        private System.Windows.Forms.Button AzurirajBtn;
        private System.Windows.Forms.Button DodajBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DugovanjeTxtbx;
        private System.Windows.Forms.TextBox NazivKupcaTxtbx;
        private System.Windows.Forms.Button KupciAzurirajBtn;
        private System.Windows.Forms.Button KupciDodajBtn;
        private System.Windows.Forms.DataGridView DataGridViewKupci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OIBTxtbx;
    }
}

