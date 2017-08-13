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
    public partial class ArtiklIzvjestaj : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=EasyStorageDB;Integrated Security=true;");
        private SqlDataAdapter adapt;
        private SqlCommand cmd;

        public ArtiklIzvjestaj()
        {
            InitializeComponent();
        }
        public ArtiklIzvjestaj(int artiklID, string s)
        {
            InitializeComponent();
            naslov.Text = s;
            con.Open();
            cmd = new SqlCommand("SELECT Stavka_racuna.Cijena, Sum(Stavka_racuna.Kolicina) FROM Stavka_racuna, Racuns WHERE Stavka_racuna.ArtiklID = @ArtiklID AND Racuns.ID = Stavka_racuna.RacunID AND Racuns.Status = 'obraden' GROUP BY Cijena", con);
            cmd.Parameters.AddWithValue("@ArtiklID", artiklID);
            adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            con.Close();
            graf.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            graf.ChartAreas[0].AxisY.MajorGrid.LineWidth = 1;
            graf.ChartAreas[0].AxisX.IsMarginVisible = false;
            graf.Series[0].BorderWidth = 4;
            graf.ChartAreas[0].AxisX.Title = "Cijena (kn)";
            graf.ChartAreas[0].AxisY.Title = "Količina (kg)";
            graf.ChartAreas[0].AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            graf.Series[0].IsValueShownAsLabel = true;
            decimal suma = 0;
            foreach (DataRow row in dt.Rows)
            {
                graf.Series[0].Points.AddXY(row[0].ToString().Split(' ')[0], row[1].ToString());
                suma += decimal.Parse(row[1].ToString());
            }
            if (dt.Rows.Count == 0) return;
            con.Open();
            cmd = new SqlCommand("SELECT Nabavljena_kolicina FROM Artikls WHERE ID = @ArtiklID", con);
            cmd.Parameters.AddWithValue("@ArtiklID", artiklID);
            decimal ukupno = decimal.Parse(cmd.ExecuteScalar().ToString());
            con.Close();
            decimal ostalo = ukupno - suma;
            graf.Series[0].Points.AddXY("nije prodano", ostalo);
        }
    }
}
