using System.Windows.Forms;

namespace EasyStorage
{
    class IzvjestajOArtiklima
    {
        private static DataGridView dataGridViewIzvjestajOArtiklima;
        public static DataGridView DataGridViewIzvjestajOArtiklima
        {
            set { dataGridViewIzvjestajOArtiklima = value; }
        }
        public static void DisplayData()
        {
            dataGridViewIzvjestajOArtiklima.DataSource = Database.GetIzvjestajOArtiklimaTable();
            dataGridViewIzvjestajOArtiklima.Columns[0].Visible = false;
            dataGridViewIzvjestajOArtiklima.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewIzvjestajOArtiklima.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewIzvjestajOArtiklima.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
