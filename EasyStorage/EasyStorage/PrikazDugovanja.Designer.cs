namespace EasyStorage
{
    partial class PrikazDugovanja
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.naslov = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.graf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.stavkeRacuna = new System.Windows.Forms.Label();
            this.DataGridViewRacun = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridViewPopisPromjena = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graf)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRacun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPopisPromjena)).BeginInit();
            this.SuspendLayout();
            // 
            // naslov
            // 
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslov.Location = new System.Drawing.Point(116, 9);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(943, 49);
            this.naslov.TabIndex = 1;
            this.naslov.Text = "Naslov";
            this.naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1199, 577);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.graf);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1191, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Graf";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // graf
            // 
            chartArea1.Name = "ChartArea1";
            this.graf.ChartAreas.Add(chartArea1);
            this.graf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graf.Location = new System.Drawing.Point(3, 3);
            this.graf.Name = "graf";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.graf.Series.Add(series1);
            this.graf.Size = new System.Drawing.Size(1185, 545);
            this.graf.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.stavkeRacuna);
            this.tabPage2.Controls.Add(this.DataGridViewRacun);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.DataGridViewPopisPromjena);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1191, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabela";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // stavkeRacuna
            // 
            this.stavkeRacuna.AutoSize = true;
            this.stavkeRacuna.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.stavkeRacuna.Location = new System.Drawing.Point(734, 28);
            this.stavkeRacuna.Name = "stavkeRacuna";
            this.stavkeRacuna.Size = new System.Drawing.Size(102, 18);
            this.stavkeRacuna.TabIndex = 32;
            this.stavkeRacuna.Text = "Stavke računa";
            // 
            // DataGridViewRacun
            // 
            this.DataGridViewRacun.AllowUserToAddRows = false;
            this.DataGridViewRacun.AllowUserToDeleteRows = false;
            this.DataGridViewRacun.AllowUserToResizeRows = false;
            this.DataGridViewRacun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewRacun.Enabled = false;
            this.DataGridViewRacun.Location = new System.Drawing.Point(737, 49);
            this.DataGridViewRacun.MinimumSize = new System.Drawing.Size(343, 0);
            this.DataGridViewRacun.MultiSelect = false;
            this.DataGridViewRacun.Name = "DataGridViewRacun";
            this.DataGridViewRacun.ReadOnly = true;
            this.DataGridViewRacun.RowHeadersVisible = false;
            this.DataGridViewRacun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewRacun.Size = new System.Drawing.Size(394, 494);
            this.DataGridViewRacun.TabIndex = 31;
            this.DataGridViewRacun.TabStop = false;
            this.DataGridViewRacun.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewRacun_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(33, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Promjene dugovanja";
            // 
            // DataGridViewPopisPromjena
            // 
            this.DataGridViewPopisPromjena.AllowUserToAddRows = false;
            this.DataGridViewPopisPromjena.AllowUserToDeleteRows = false;
            this.DataGridViewPopisPromjena.AllowUserToResizeRows = false;
            this.DataGridViewPopisPromjena.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewPopisPromjena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewPopisPromjena.Location = new System.Drawing.Point(36, 28);
            this.DataGridViewPopisPromjena.MinimumSize = new System.Drawing.Size(343, 0);
            this.DataGridViewPopisPromjena.MultiSelect = false;
            this.DataGridViewPopisPromjena.Name = "DataGridViewPopisPromjena";
            this.DataGridViewPopisPromjena.ReadOnly = true;
            this.DataGridViewPopisPromjena.RowHeadersVisible = false;
            this.DataGridViewPopisPromjena.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewPopisPromjena.Size = new System.Drawing.Size(610, 513);
            this.DataGridViewPopisPromjena.TabIndex = 29;
            this.DataGridViewPopisPromjena.TabStop = false;
            this.DataGridViewPopisPromjena.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewPopisPromjena_CellMouseClick);
            this.DataGridViewPopisPromjena.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewPopisPromjena_DataBindingComplete);
            // 
            // PrikazDugovanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 642);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.naslov);
            this.Name = "PrikazDugovanja";
            this.Text = "Prikaz Dugovanja";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graf)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewRacun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPopisPromjena)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DataGridViewPopisPromjena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stavkeRacuna;
        private System.Windows.Forms.DataGridView DataGridViewRacun;
    }
}