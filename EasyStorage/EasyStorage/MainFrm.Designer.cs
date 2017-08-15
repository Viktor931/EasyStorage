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
            this.KupciTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.OIBTxtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DugovanjeTxtbx = new System.Windows.Forms.TextBox();
            this.NazivKupcaTxtbx = new System.Windows.Forms.TextBox();
            this.KupciAzurirajBtn = new System.Windows.Forms.Button();
            this.KupciDodajBtn = new System.Windows.Forms.Button();
            this.DataGridViewKupci = new System.Windows.Forms.DataGridView();
            this.KreiranjeRacunaTab = new System.Windows.Forms.TabPage();
            this.OsvjeziBtn1 = new System.Windows.Forms.Button();
            this.KreirajRacunBtn = new System.Windows.Forms.Button();
            this.PonistiRacunBtn = new System.Windows.Forms.Button();
            this.KupacComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ArtiklComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.KolicinaStavkaTxtbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CijenaTxtbx = new System.Windows.Forms.TextBox();
            this.PonistiStavkuRacunaBtn = new System.Windows.Forms.Button();
            this.DodajStavkuRacunaBtn = new System.Windows.Forms.Button();
            this.DataGridViewStavkaRacuna = new System.Windows.Forms.DataGridView();
            this.NaplataRacunaTab = new System.Windows.Forms.TabPage();
            this.OsvjeziBtn = new System.Windows.Forms.Button();
            this.OdgodaPlacanjaBtn = new System.Windows.Forms.Button();
            this.RacunPlacenBtn = new System.Windows.Forms.Button();
            this.PonistiRacunBtn1 = new System.Windows.Forms.Button();
            this.DataGridViewStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.DataGridViewNeobradeniRacuni = new System.Windows.Forms.DataGridView();
            this.IzvjestajiOArtiklima = new System.Windows.Forms.TabPage();
            this.DataGridViewArtikliIzvjesca = new System.Windows.Forms.DataGridView();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tabControl1.SuspendLayout();
            this.SkladisteTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikli)).BeginInit();
            this.KupciTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewKupci)).BeginInit();
            this.KreiranjeRacunaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStavkaRacuna)).BeginInit();
            this.NaplataRacunaTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStavkeRacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewNeobradeniRacuni)).BeginInit();
            this.IzvjestajiOArtiklima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewArtikliIzvjesca)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SkladisteTab);
            this.tabControl1.Controls.Add(this.KupciTab);
            this.tabControl1.Controls.Add(this.KreiranjeRacunaTab);
            this.tabControl1.Controls.Add(this.NaplataRacunaTab);
            this.tabControl1.Controls.Add(this.IzvjestajiOArtiklima);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 540);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            this.tabControl1.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.tabControl1_HelpRequested);
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
            this.SkladisteTab.Size = new System.Drawing.Size(545, 514);
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
            this.KolicinaTxtbx.TabIndex = 2;
            // 
            // NazivArtiklaTxtbx
            // 
            this.NazivArtiklaTxtbx.Location = new System.Drawing.Point(80, 51);
            this.NazivArtiklaTxtbx.Name = "NazivArtiklaTxtbx";
            this.NazivArtiklaTxtbx.Size = new System.Drawing.Size(200, 20);
            this.NazivArtiklaTxtbx.TabIndex = 1;
            // 
            // ObrisiBtn
            // 
            this.ObrisiBtn.Location = new System.Drawing.Point(323, 92);
            this.ObrisiBtn.Name = "ObrisiBtn";
            this.ObrisiBtn.Size = new System.Drawing.Size(100, 28);
            this.ObrisiBtn.TabIndex = 5;
            this.ObrisiBtn.Text = "Obriši";
            this.ObrisiBtn.UseVisualStyleBackColor = true;
            this.ObrisiBtn.Click += new System.EventHandler(this.ObrisiBtn_Click);
            // 
            // AzurirajBtn
            // 
            this.AzurirajBtn.Location = new System.Drawing.Point(203, 92);
            this.AzurirajBtn.Name = "AzurirajBtn";
            this.AzurirajBtn.Size = new System.Drawing.Size(100, 28);
            this.AzurirajBtn.TabIndex = 4;
            this.AzurirajBtn.Text = "Ažuriraj";
            this.AzurirajBtn.UseVisualStyleBackColor = true;
            this.AzurirajBtn.Click += new System.EventHandler(this.AzurirajBtn_Click);
            // 
            // DodajBtn
            // 
            this.DodajBtn.Location = new System.Drawing.Point(80, 92);
            this.DodajBtn.Name = "DodajBtn";
            this.DodajBtn.Size = new System.Drawing.Size(100, 28);
            this.DodajBtn.TabIndex = 3;
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
            this.dataGridViewArtikli.Size = new System.Drawing.Size(343, 368);
            this.dataGridViewArtikli.TabIndex = 0;
            this.dataGridViewArtikli.TabStop = false;
            this.dataGridViewArtikli.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewArtikli_CellMouseClick);
            this.dataGridViewArtikli.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewArtikli_DataBindingComplete);
            // 
            // KupciTab
            // 
            this.KupciTab.Controls.Add(this.label5);
            this.KupciTab.Controls.Add(this.OIBTxtbx);
            this.KupciTab.Controls.Add(this.label3);
            this.KupciTab.Controls.Add(this.label4);
            this.KupciTab.Controls.Add(this.DugovanjeTxtbx);
            this.KupciTab.Controls.Add(this.NazivKupcaTxtbx);
            this.KupciTab.Controls.Add(this.KupciAzurirajBtn);
            this.KupciTab.Controls.Add(this.KupciDodajBtn);
            this.KupciTab.Controls.Add(this.DataGridViewKupci);
            this.KupciTab.Location = new System.Drawing.Point(4, 22);
            this.KupciTab.Name = "KupciTab";
            this.KupciTab.Padding = new System.Windows.Forms.Padding(3);
            this.KupciTab.Size = new System.Drawing.Size(545, 514);
            this.KupciTab.TabIndex = 1;
            this.KupciTab.Text = "Kupci";
            this.KupciTab.UseVisualStyleBackColor = true;
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
            this.OIBTxtbx.TabIndex = 2;
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
            this.DugovanjeTxtbx.TabIndex = 3;
            // 
            // NazivKupcaTxtbx
            // 
            this.NazivKupcaTxtbx.Location = new System.Drawing.Point(101, 53);
            this.NazivKupcaTxtbx.Name = "NazivKupcaTxtbx";
            this.NazivKupcaTxtbx.Size = new System.Drawing.Size(100, 20);
            this.NazivKupcaTxtbx.TabIndex = 1;
            // 
            // KupciAzurirajBtn
            // 
            this.KupciAzurirajBtn.Location = new System.Drawing.Point(284, 94);
            this.KupciAzurirajBtn.Name = "KupciAzurirajBtn";
            this.KupciAzurirajBtn.Size = new System.Drawing.Size(160, 25);
            this.KupciAzurirajBtn.TabIndex = 5;
            this.KupciAzurirajBtn.Text = "Ažuriraj";
            this.KupciAzurirajBtn.UseVisualStyleBackColor = true;
            this.KupciAzurirajBtn.Click += new System.EventHandler(this.KupciAzurirajBtn_Click);
            // 
            // KupciDodajBtn
            // 
            this.KupciDodajBtn.Location = new System.Drawing.Point(101, 94);
            this.KupciDodajBtn.Name = "KupciDodajBtn";
            this.KupciDodajBtn.Size = new System.Drawing.Size(160, 25);
            this.KupciDodajBtn.TabIndex = 4;
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
            this.DataGridViewKupci.Size = new System.Drawing.Size(343, 366);
            this.DataGridViewKupci.TabIndex = 28;
            this.DataGridViewKupci.TabStop = false;
            this.DataGridViewKupci.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewKupci_CellMouseClick);
            this.DataGridViewKupci.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewKupci_CellMouseDoubleClick);
            this.DataGridViewKupci.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewKupci_DataBindingComplete);
            // 
            // KreiranjeRacunaTab
            // 
            this.KreiranjeRacunaTab.Controls.Add(this.OsvjeziBtn1);
            this.KreiranjeRacunaTab.Controls.Add(this.KreirajRacunBtn);
            this.KreiranjeRacunaTab.Controls.Add(this.PonistiRacunBtn);
            this.KreiranjeRacunaTab.Controls.Add(this.KupacComboBox);
            this.KreiranjeRacunaTab.Controls.Add(this.label9);
            this.KreiranjeRacunaTab.Controls.Add(this.ArtiklComboBox);
            this.KreiranjeRacunaTab.Controls.Add(this.label6);
            this.KreiranjeRacunaTab.Controls.Add(this.KolicinaStavkaTxtbx);
            this.KreiranjeRacunaTab.Controls.Add(this.label7);
            this.KreiranjeRacunaTab.Controls.Add(this.label8);
            this.KreiranjeRacunaTab.Controls.Add(this.CijenaTxtbx);
            this.KreiranjeRacunaTab.Controls.Add(this.PonistiStavkuRacunaBtn);
            this.KreiranjeRacunaTab.Controls.Add(this.DodajStavkuRacunaBtn);
            this.KreiranjeRacunaTab.Controls.Add(this.DataGridViewStavkaRacuna);
            this.KreiranjeRacunaTab.Location = new System.Drawing.Point(4, 22);
            this.KreiranjeRacunaTab.Name = "KreiranjeRacunaTab";
            this.KreiranjeRacunaTab.Size = new System.Drawing.Size(545, 514);
            this.KreiranjeRacunaTab.TabIndex = 2;
            this.KreiranjeRacunaTab.Text = "Kreiranje Računa";
            this.KreiranjeRacunaTab.UseVisualStyleBackColor = true;
            // 
            // OsvjeziBtn1
            // 
            this.OsvjeziBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.OsvjeziBtn1.Location = new System.Drawing.Point(382, 310);
            this.OsvjeziBtn1.Name = "OsvjeziBtn1";
            this.OsvjeziBtn1.Size = new System.Drawing.Size(135, 40);
            this.OsvjeziBtn1.TabIndex = 9;
            this.OsvjeziBtn1.Text = "Osvježi";
            this.OsvjeziBtn1.UseVisualStyleBackColor = true;
            this.OsvjeziBtn1.Click += new System.EventHandler(this.OsvjeziBtn1_Click);
            // 
            // KreirajRacunBtn
            // 
            this.KreirajRacunBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KreirajRacunBtn.Location = new System.Drawing.Point(382, 220);
            this.KreirajRacunBtn.Name = "KreirajRacunBtn";
            this.KreirajRacunBtn.Size = new System.Drawing.Size(136, 59);
            this.KreirajRacunBtn.TabIndex = 8;
            this.KreirajRacunBtn.Text = "Kreiraj račun";
            this.KreirajRacunBtn.UseVisualStyleBackColor = true;
            this.KreirajRacunBtn.Click += new System.EventHandler(this.KreirajRacunBtn_Click);
            // 
            // PonistiRacunBtn
            // 
            this.PonistiRacunBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PonistiRacunBtn.Location = new System.Drawing.Point(382, 143);
            this.PonistiRacunBtn.Name = "PonistiRacunBtn";
            this.PonistiRacunBtn.Size = new System.Drawing.Size(136, 43);
            this.PonistiRacunBtn.TabIndex = 7;
            this.PonistiRacunBtn.Text = "Poništi Račun";
            this.PonistiRacunBtn.UseVisualStyleBackColor = true;
            this.PonistiRacunBtn.Click += new System.EventHandler(this.PonistiRacunBtn_Click);
            // 
            // KupacComboBox
            // 
            this.KupacComboBox.FormattingEnabled = true;
            this.KupacComboBox.Location = new System.Drawing.Point(382, 55);
            this.KupacComboBox.Name = "KupacComboBox";
            this.KupacComboBox.Size = new System.Drawing.Size(136, 21);
            this.KupacComboBox.TabIndex = 6;
            this.KupacComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KupacComboBox_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Kupac";
            // 
            // ArtiklComboBox
            // 
            this.ArtiklComboBox.FormattingEnabled = true;
            this.ArtiklComboBox.Location = new System.Drawing.Point(17, 55);
            this.ArtiklComboBox.Name = "ArtiklComboBox";
            this.ArtiklComboBox.Size = new System.Drawing.Size(100, 21);
            this.ArtiklComboBox.TabIndex = 1;
            this.ArtiklComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ArtiklComboBox_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Količina";
            // 
            // KolicinaStavkaTxtbx
            // 
            this.KolicinaStavkaTxtbx.Location = new System.Drawing.Point(137, 56);
            this.KolicinaStavkaTxtbx.Name = "KolicinaStavkaTxtbx";
            this.KolicinaStavkaTxtbx.Size = new System.Drawing.Size(100, 20);
            this.KolicinaStavkaTxtbx.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Cijena";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Artikl";
            // 
            // CijenaTxtbx
            // 
            this.CijenaTxtbx.Location = new System.Drawing.Point(260, 56);
            this.CijenaTxtbx.Name = "CijenaTxtbx";
            this.CijenaTxtbx.Size = new System.Drawing.Size(100, 20);
            this.CijenaTxtbx.TabIndex = 3;
            // 
            // PonistiStavkuRacunaBtn
            // 
            this.PonistiStavkuRacunaBtn.Location = new System.Drawing.Point(200, 97);
            this.PonistiStavkuRacunaBtn.Name = "PonistiStavkuRacunaBtn";
            this.PonistiStavkuRacunaBtn.Size = new System.Drawing.Size(160, 25);
            this.PonistiStavkuRacunaBtn.TabIndex = 5;
            this.PonistiStavkuRacunaBtn.Text = "Poništi stavku";
            this.PonistiStavkuRacunaBtn.UseVisualStyleBackColor = true;
            this.PonistiStavkuRacunaBtn.Click += new System.EventHandler(this.PonistiStavkuRacunaBtn_Click);
            // 
            // DodajStavkuRacunaBtn
            // 
            this.DodajStavkuRacunaBtn.Location = new System.Drawing.Point(17, 97);
            this.DodajStavkuRacunaBtn.Name = "DodajStavkuRacunaBtn";
            this.DodajStavkuRacunaBtn.Size = new System.Drawing.Size(160, 25);
            this.DodajStavkuRacunaBtn.TabIndex = 4;
            this.DodajStavkuRacunaBtn.Text = "Dodaj stavku";
            this.DodajStavkuRacunaBtn.UseVisualStyleBackColor = true;
            this.DodajStavkuRacunaBtn.Click += new System.EventHandler(this.DodajStavkuRacunaBtn_Click);
            // 
            // DataGridViewStavkaRacuna
            // 
            this.DataGridViewStavkaRacuna.AllowUserToAddRows = false;
            this.DataGridViewStavkaRacuna.AllowUserToDeleteRows = false;
            this.DataGridViewStavkaRacuna.AllowUserToResizeRows = false;
            this.DataGridViewStavkaRacuna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewStavkaRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStavkaRacuna.Location = new System.Drawing.Point(17, 143);
            this.DataGridViewStavkaRacuna.MinimumSize = new System.Drawing.Size(343, 0);
            this.DataGridViewStavkaRacuna.MultiSelect = false;
            this.DataGridViewStavkaRacuna.Name = "DataGridViewStavkaRacuna";
            this.DataGridViewStavkaRacuna.ReadOnly = true;
            this.DataGridViewStavkaRacuna.RowHeadersVisible = false;
            this.DataGridViewStavkaRacuna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewStavkaRacuna.Size = new System.Drawing.Size(343, 363);
            this.DataGridViewStavkaRacuna.TabIndex = 37;
            this.DataGridViewStavkaRacuna.TabStop = false;
            this.DataGridViewStavkaRacuna.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewStavkaRacuna_CellMouseClick);
            this.DataGridViewStavkaRacuna.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewStavkaRacuna_DataBindingComplete);
            // 
            // NaplataRacunaTab
            // 
            this.NaplataRacunaTab.Controls.Add(this.OsvjeziBtn);
            this.NaplataRacunaTab.Controls.Add(this.OdgodaPlacanjaBtn);
            this.NaplataRacunaTab.Controls.Add(this.RacunPlacenBtn);
            this.NaplataRacunaTab.Controls.Add(this.PonistiRacunBtn1);
            this.NaplataRacunaTab.Controls.Add(this.DataGridViewStavkeRacuna);
            this.NaplataRacunaTab.Controls.Add(this.DataGridViewNeobradeniRacuni);
            this.NaplataRacunaTab.Location = new System.Drawing.Point(4, 22);
            this.NaplataRacunaTab.Name = "NaplataRacunaTab";
            this.NaplataRacunaTab.Size = new System.Drawing.Size(545, 514);
            this.NaplataRacunaTab.TabIndex = 3;
            this.NaplataRacunaTab.Text = "Naplata računa";
            this.NaplataRacunaTab.UseVisualStyleBackColor = true;
            // 
            // OsvjeziBtn
            // 
            this.OsvjeziBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.OsvjeziBtn.Location = new System.Drawing.Point(402, 229);
            this.OsvjeziBtn.Name = "OsvjeziBtn";
            this.OsvjeziBtn.Size = new System.Drawing.Size(135, 40);
            this.OsvjeziBtn.TabIndex = 4;
            this.OsvjeziBtn.Text = "Osvježi";
            this.OsvjeziBtn.UseVisualStyleBackColor = true;
            this.OsvjeziBtn.Click += new System.EventHandler(this.OsvjeziBtn_Click);
            // 
            // OdgodaPlacanjaBtn
            // 
            this.OdgodaPlacanjaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.OdgodaPlacanjaBtn.Location = new System.Drawing.Point(402, 160);
            this.OdgodaPlacanjaBtn.Name = "OdgodaPlacanjaBtn";
            this.OdgodaPlacanjaBtn.Size = new System.Drawing.Size(135, 40);
            this.OdgodaPlacanjaBtn.TabIndex = 3;
            this.OdgodaPlacanjaBtn.Text = "Odgoda plaćanja";
            this.OdgodaPlacanjaBtn.UseVisualStyleBackColor = true;
            this.OdgodaPlacanjaBtn.Click += new System.EventHandler(this.OdgodaPlacanjaBtn_Click);
            // 
            // RacunPlacenBtn
            // 
            this.RacunPlacenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.RacunPlacenBtn.Location = new System.Drawing.Point(402, 87);
            this.RacunPlacenBtn.Name = "RacunPlacenBtn";
            this.RacunPlacenBtn.Size = new System.Drawing.Size(135, 40);
            this.RacunPlacenBtn.TabIndex = 2;
            this.RacunPlacenBtn.Text = "Račun plaćen";
            this.RacunPlacenBtn.UseVisualStyleBackColor = true;
            this.RacunPlacenBtn.Click += new System.EventHandler(this.RacunPlacenBtn_Click);
            // 
            // PonistiRacunBtn1
            // 
            this.PonistiRacunBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.PonistiRacunBtn1.Location = new System.Drawing.Point(402, 14);
            this.PonistiRacunBtn1.Name = "PonistiRacunBtn1";
            this.PonistiRacunBtn1.Size = new System.Drawing.Size(135, 40);
            this.PonistiRacunBtn1.TabIndex = 1;
            this.PonistiRacunBtn1.Text = "Poništi račun";
            this.PonistiRacunBtn1.UseVisualStyleBackColor = true;
            this.PonistiRacunBtn1.Click += new System.EventHandler(this.PonistiRacunBtn1_Click);
            // 
            // DataGridViewStavkeRacuna
            // 
            this.DataGridViewStavkeRacuna.AllowUserToAddRows = false;
            this.DataGridViewStavkeRacuna.AllowUserToDeleteRows = false;
            this.DataGridViewStavkeRacuna.AllowUserToResizeRows = false;
            this.DataGridViewStavkeRacuna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewStavkeRacuna.Enabled = false;
            this.DataGridViewStavkeRacuna.Location = new System.Drawing.Point(8, 173);
            this.DataGridViewStavkeRacuna.MinimumSize = new System.Drawing.Size(343, 0);
            this.DataGridViewStavkeRacuna.MultiSelect = false;
            this.DataGridViewStavkeRacuna.Name = "DataGridViewStavkeRacuna";
            this.DataGridViewStavkeRacuna.ReadOnly = true;
            this.DataGridViewStavkeRacuna.RowHeadersVisible = false;
            this.DataGridViewStavkeRacuna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewStavkeRacuna.Size = new System.Drawing.Size(388, 333);
            this.DataGridViewStavkeRacuna.TabIndex = 39;
            this.DataGridViewStavkeRacuna.TabStop = false;
            this.DataGridViewStavkeRacuna.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewStavkeRacuna_DataBindingComplete);
            // 
            // DataGridViewNeobradeniRacuni
            // 
            this.DataGridViewNeobradeniRacuni.AllowUserToAddRows = false;
            this.DataGridViewNeobradeniRacuni.AllowUserToDeleteRows = false;
            this.DataGridViewNeobradeniRacuni.AllowUserToResizeRows = false;
            this.DataGridViewNeobradeniRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewNeobradeniRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewNeobradeniRacuni.Location = new System.Drawing.Point(8, 14);
            this.DataGridViewNeobradeniRacuni.MinimumSize = new System.Drawing.Size(343, 0);
            this.DataGridViewNeobradeniRacuni.MultiSelect = false;
            this.DataGridViewNeobradeniRacuni.Name = "DataGridViewNeobradeniRacuni";
            this.DataGridViewNeobradeniRacuni.ReadOnly = true;
            this.DataGridViewNeobradeniRacuni.RowHeadersVisible = false;
            this.DataGridViewNeobradeniRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewNeobradeniRacuni.Size = new System.Drawing.Size(388, 135);
            this.DataGridViewNeobradeniRacuni.TabIndex = 38;
            this.DataGridViewNeobradeniRacuni.TabStop = false;
            this.DataGridViewNeobradeniRacuni.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewNeobradeniRacuni_CellClick);
            this.DataGridViewNeobradeniRacuni.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewNeobradeniRacuni_DataBindingComplete);
            // 
            // IzvjestajiOArtiklima
            // 
            this.IzvjestajiOArtiklima.Controls.Add(this.DataGridViewArtikliIzvjesca);
            this.IzvjestajiOArtiklima.Location = new System.Drawing.Point(4, 22);
            this.IzvjestajiOArtiklima.Name = "IzvjestajiOArtiklima";
            this.IzvjestajiOArtiklima.Size = new System.Drawing.Size(545, 514);
            this.IzvjestajiOArtiklima.TabIndex = 4;
            this.IzvjestajiOArtiklima.Text = "Izvještaji o artiklima";
            this.IzvjestajiOArtiklima.UseVisualStyleBackColor = true;
            // 
            // DataGridViewArtikliIzvjesca
            // 
            this.DataGridViewArtikliIzvjesca.AllowUserToAddRows = false;
            this.DataGridViewArtikliIzvjesca.AllowUserToDeleteRows = false;
            this.DataGridViewArtikliIzvjesca.AllowUserToResizeRows = false;
            this.DataGridViewArtikliIzvjesca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewArtikliIzvjesca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewArtikliIzvjesca.Location = new System.Drawing.Point(101, 20);
            this.DataGridViewArtikliIzvjesca.MinimumSize = new System.Drawing.Size(343, 0);
            this.DataGridViewArtikliIzvjesca.MultiSelect = false;
            this.DataGridViewArtikliIzvjesca.Name = "DataGridViewArtikliIzvjesca";
            this.DataGridViewArtikliIzvjesca.ReadOnly = true;
            this.DataGridViewArtikliIzvjesca.RowHeadersVisible = false;
            this.DataGridViewArtikliIzvjesca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewArtikliIzvjesca.Size = new System.Drawing.Size(343, 486);
            this.DataGridViewArtikliIzvjesca.TabIndex = 1;
            this.DataGridViewArtikliIzvjesca.TabStop = false;
            this.DataGridViewArtikliIzvjesca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewArtikliIzvjesca_CellDoubleClick);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Viktor\\Documents\\Visual Studio 2017\\Projects\\WindowsFormsApp1\\EasyStorag" +
    "e\\EasyStorage\\help.chm";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 540);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainFrm";
            this.Text = "EasyStorage";
            this.tabControl1.ResumeLayout(false);
            this.SkladisteTab.ResumeLayout(false);
            this.SkladisteTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikli)).EndInit();
            this.KupciTab.ResumeLayout(false);
            this.KupciTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewKupci)).EndInit();
            this.KreiranjeRacunaTab.ResumeLayout(false);
            this.KreiranjeRacunaTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStavkaRacuna)).EndInit();
            this.NaplataRacunaTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewStavkeRacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewNeobradeniRacuni)).EndInit();
            this.IzvjestajiOArtiklima.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewArtikliIzvjesca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SkladisteTab;
        private System.Windows.Forms.DataGridView dataGridViewArtikli;
        private System.Windows.Forms.TabPage KupciTab;
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
        private System.Windows.Forms.TabPage KreiranjeRacunaTab;
        private System.Windows.Forms.ComboBox ArtiklComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox KolicinaStavkaTxtbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CijenaTxtbx;
        private System.Windows.Forms.Button PonistiStavkuRacunaBtn;
        private System.Windows.Forms.Button DodajStavkuRacunaBtn;
        private System.Windows.Forms.DataGridView DataGridViewStavkaRacuna;
        private System.Windows.Forms.ComboBox KupacComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button KreirajRacunBtn;
        private System.Windows.Forms.Button PonistiRacunBtn;
        private System.Windows.Forms.TabPage NaplataRacunaTab;
        private System.Windows.Forms.Button OdgodaPlacanjaBtn;
        private System.Windows.Forms.Button RacunPlacenBtn;
        private System.Windows.Forms.Button PonistiRacunBtn1;
        private System.Windows.Forms.DataGridView DataGridViewStavkeRacuna;
        private System.Windows.Forms.DataGridView DataGridViewNeobradeniRacuni;
        private System.Windows.Forms.Button OsvjeziBtn;
        private System.Windows.Forms.Button OsvjeziBtn1;
        private System.Windows.Forms.TabPage IzvjestajiOArtiklima;
        private System.Windows.Forms.DataGridView DataGridViewArtikliIzvjesca;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

