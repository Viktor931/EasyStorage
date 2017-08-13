namespace EasyStorage
{
    partial class ArtiklIzvjestaj
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.naslov = new System.Windows.Forms.Label();
            this.graf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.graf)).BeginInit();
            this.SuspendLayout();
            // 
            // naslov
            // 
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslov.Location = new System.Drawing.Point(119, 9);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(943, 49);
            this.naslov.TabIndex = 2;
            this.naslov.Text = "Naslov";
            this.naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // graf
            // 
            chartArea3.Name = "ChartArea1";
            this.graf.ChartAreas.Add(chartArea3);
            this.graf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.graf.Location = new System.Drawing.Point(0, 61);
            this.graf.Name = "graf";
            series3.ChartArea = "ChartArea1";
            series3.Name = "Series1";
            this.graf.Series.Add(series3);
            this.graf.Size = new System.Drawing.Size(1199, 581);
            this.graf.TabIndex = 3;
            // 
            // ArtiklIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 642);
            this.Controls.Add(this.graf);
            this.Controls.Add(this.naslov);
            this.Name = "ArtiklIzvjestaj";
            this.Text = "Artikl izvještaj";
            ((System.ComponentModel.ISupportInitialize)(this.graf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.DataVisualization.Charting.Chart graf;
    }
}