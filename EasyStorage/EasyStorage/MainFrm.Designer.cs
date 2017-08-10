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
            this.Skladiste = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KolicinaTxtbx = new System.Windows.Forms.TextBox();
            this.NazivArtiklaTxtbx = new System.Windows.Forms.TextBox();
            this.ObrisiBtn = new System.Windows.Forms.Button();
            this.AzurirajBtn = new System.Windows.Forms.Button();
            this.DodajBtn = new System.Windows.Forms.Button();
            this.dataGridViewArtikli = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Skladiste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Skladiste);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 393);
            this.tabControl1.TabIndex = 0;
            // 
            // Skladiste
            // 
            this.Skladiste.Controls.Add(this.label2);
            this.Skladiste.Controls.Add(this.label1);
            this.Skladiste.Controls.Add(this.KolicinaTxtbx);
            this.Skladiste.Controls.Add(this.NazivArtiklaTxtbx);
            this.Skladiste.Controls.Add(this.ObrisiBtn);
            this.Skladiste.Controls.Add(this.AzurirajBtn);
            this.Skladiste.Controls.Add(this.DodajBtn);
            this.Skladiste.Controls.Add(this.dataGridViewArtikli);
            this.Skladiste.Location = new System.Drawing.Point(4, 22);
            this.Skladiste.Name = "Skladiste";
            this.Skladiste.Padding = new System.Windows.Forms.Padding(3);
            this.Skladiste.Size = new System.Drawing.Size(545, 367);
            this.Skladiste.TabIndex = 0;
            this.Skladiste.Text = "Skladište";
            this.Skladiste.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Količina";
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
            this.dataGridViewArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtikli.Location = new System.Drawing.Point(80, 136);
            this.dataGridViewArtikli.Name = "dataGridViewArtikli";
            this.dataGridViewArtikli.ReadOnly = true;
            this.dataGridViewArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArtikli.Size = new System.Drawing.Size(343, 207);
            this.dataGridViewArtikli.TabIndex = 0;
            this.dataGridViewArtikli.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewArtikli_CellMouseClick);
            this.dataGridViewArtikli.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewArtikli_DataBindingComplete);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(545, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.Skladiste.ResumeLayout(false);
            this.Skladiste.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Skladiste;
        private System.Windows.Forms.DataGridView dataGridViewArtikli;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KolicinaTxtbx;
        private System.Windows.Forms.TextBox NazivArtiklaTxtbx;
        private System.Windows.Forms.Button ObrisiBtn;
        private System.Windows.Forms.Button AzurirajBtn;
        private System.Windows.Forms.Button DodajBtn;
    }
}

