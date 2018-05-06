using System.Data;
using System.Windows.Forms;

namespace EasyStorage
{
    public partial class ArtiklIzvjestaj : Form
    {
        private MainDatabase database = DatabaseImpl.GetMainDatabase();
        public ArtiklIzvjestaj()
        {
            InitializeComponent();
        }
        public ArtiklIzvjestaj(int artiklID, string s)
        {
            InitializeComponent();
            naslov.Text = s;
            DataTable dt = database.GetArtikliIzvjestajTable(artiklID);
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
            decimal ukupno = decimal.Parse(database.GetNabavljenaKolicinaForArtikl(artiklID));
            decimal ostalo = ukupno - suma;
            graf.Series[0].Points.AddXY("nije prodano", ostalo);
        }
    }
}
