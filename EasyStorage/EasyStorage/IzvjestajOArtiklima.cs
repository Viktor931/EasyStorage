using System.Windows.Forms;

namespace EasyStorage
{
    class IzvjestajOArtiklima
    {
        private MainDatabase database = Program.GetMainDatabase();
        private DataGridView dataGridViewIzvjestajOArtiklima;
        public DataGridView DataGridViewIzvjestajOArtiklima
        {
            set { dataGridViewIzvjestajOArtiklima = value; }
        }
        private static IzvjestajOArtiklima izvjestajOArtiklima;
        public static IzvjestajOArtiklima GetIzvjestajOArtiklima()
        {
            if(izvjestajOArtiklima == null)
            {
                izvjestajOArtiklima = new IzvjestajOArtiklima();
            }
            return izvjestajOArtiklima;
        }
        private IzvjestajOArtiklima() { }
        public void DisplayData()
        {
            dataGridViewIzvjestajOArtiklima.DataSource = database.GetIzvjestajOArtiklimaTable();
            dataGridViewIzvjestajOArtiklima.Columns[0].Visible = false;
            dataGridViewIzvjestajOArtiklima.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewIzvjestajOArtiklima.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewIzvjestajOArtiklima.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
