using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EasyStorage
{
    public partial class PrikazDugovanja : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=EasyStorageDB;Integrated Security=true;");
        private SqlDataAdapter adapt;
        private SqlCommand cmd;
        private DataTable popisPromjena;
        private int selektiranRed = -1;
        private int SelektiranRed
        {
            set
            {
                if (selektiranRed == value)
                    selektiranRed = -1;
                else
                    selektiranRed = value;
            }
        }
        public PrikazDugovanja()
        {
            InitializeComponent();
        }
        public PrikazDugovanja(int kupacID, string s)
        {
            InitializeComponent();
            naslov.Text = s;
            con.Open();
            cmd = new SqlCommand("SELECT Iznos AS 'Iznos promjene', Ukupno_dugovanje, Vrijeme, RacunID FROM Promjena_dugovanja WHERE KupacID = @KupacID ORDER BY Vrijeme DESC", con);
            cmd.Parameters.AddWithValue("@KupacID", kupacID);
            adapt = new SqlDataAdapter(cmd);
            popisPromjena = new DataTable();
            adapt.Fill(popisPromjena);
            con.Close();
            popisPromjena.Columns.Add("Razlog promjene");
            foreach (DataRow row in popisPromjena.Rows)
            {
                int i;
                if (int.TryParse(row[3].ToString(), out i))
                {
                    row[4] = "Odgoda plaćanja";
                }
                else
                {
                    row[4] = "Ažurirano stanje";
                }
            }
            DataGridViewPopisPromjena.DataSource = popisPromjena;
            DataGridViewPopisPromjena.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewPopisPromjena.Columns[0].DefaultCellStyle.Format = "0.00##";
            DataGridViewPopisPromjena.Columns[1].DefaultCellStyle.Format = "0.00##";
            DataGridViewPopisPromjena.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridViewPopisPromjena.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridViewPopisPromjena.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewPopisPromjena.Columns[3].Visible = false;
            sakrijRacun();
            //graf
            con.Open();
            cmd = new SqlCommand("SELECT Iznos AS 'Iznos promjene', Ukupno_dugovanje, Vrijeme, RacunID FROM Promjena_dugovanja WHERE KupacID = @KupacID", con);
            cmd.Parameters.AddWithValue("@KupacID", kupacID);
            adapt = new SqlDataAdapter(cmd);
            popisPromjena = new DataTable();
            adapt.Fill(popisPromjena);
            con.Close();
            graf.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            graf.ChartAreas[0].AxisY.MajorGrid.LineWidth = 1;
            graf.ChartAreas[0].AxisX.IsMarginVisible = false;
            graf.Series[0].BorderWidth = 4;
            graf.ChartAreas[0].AxisX.Title = "Vrijeme";
            graf.ChartAreas[0].AxisY.Title = "Dugovanje (kn)";
            graf.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            foreach (DataRow row in popisPromjena.Rows)
            {
                graf.Series[0].Points.AddXY(row["Vrijeme"].ToString().Split(' ')[0], row["Ukupno_dugovanje"].ToString());
            }
        }
        private void sakrijRacun()
        {
            DataGridViewRacun.Visible = false;
            stavkeRacuna.Visible = false;
        }
        private void prikaziRacun(int id)
        {
            con.Open();
            cmd = new SqlCommand("SELECT Artikls.Naziv, Artikls.Datum, Stavka_racuna.Kolicina, Stavka_racuna.Cijena, Artikls.ID FROM Artikls, Stavka_racuna WHERE Artikls.ID = Stavka_racuna.ArtiklID AND Stavka_racuna.RacunID = @RacunID", con);
            cmd.Parameters.AddWithValue("@RacunID", id);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            DataGridViewRacun.DataSource = null;
            DataGridViewRacun.DataSource = dt;
            DataGridViewRacun.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewRacun.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewRacun.Columns[2].DefaultCellStyle.Format = "0.00##";
            DataGridViewRacun.Columns[3].DefaultCellStyle.Format = "0.00##";
            DataGridViewRacun.Columns[4].Visible = false;
            DataGridViewRacun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            con.Close();
            DataGridViewRacun.Visible = true;
            stavkeRacuna.Visible = true;
        }
        private void DataGridViewPopisPromjena_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelektiranRed = e.RowIndex;
            if(selektiranRed == -1)
            {
                sakrijRacun();
                return;
            }
            else
            {
                int id;
                if (int.TryParse(DataGridViewPopisPromjena.Rows[e.RowIndex].Cells[3].Value.ToString(), out id))
                {
                    prikaziRacun(id);
                    return;
                }
                sakrijRacun();
            }
        }

        private void DataGridViewPopisPromjena_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridViewPopisPromjena.ClearSelection();
        }

        private void DataGridViewRacun_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridViewRacun.ClearSelection();
        }
    }
}
