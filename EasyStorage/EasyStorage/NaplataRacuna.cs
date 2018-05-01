using System;
using System.Data;
using System.Windows.Forms;

namespace EasyStorage
{
    class NaplataRacuna
    {
        private static DataGridView dataGridViewNeobradeniRacuni;
        public static DataGridView DataGridViewNeobradeniRacuni
        {
            set { dataGridViewNeobradeniRacuni = value; }
        }
        private static DataGridView dataGridViewStavkeRacuna;
        public static DataGridView DataGridViewStavkeRacuna
        {
            set { dataGridViewStavkeRacuna = value; }
        }
        private static int selektiranRacunID = -1;
        public static int SelektiranRacunID
        {
            set
            {
                if(value == selektiranRacunID)
                {
                    selektiranRacunID = -1;
                    dataGridViewStavkeRacuna.DataSource = null;
                } 
                else
                {
                    selektiranRacunID = value;
                    DataTable dt = Database.GetArtiklsForRacunTable(selektiranRacunID);
                    dataGridViewStavkeRacuna.DataSource = null;
                    dataGridViewStavkeRacuna.DataSource = dt;
                    dataGridViewStavkeRacuna.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewStavkeRacuna.Columns[2].DefaultCellStyle.Format = "0.00##";
                    dataGridViewStavkeRacuna.Columns[3].DefaultCellStyle.Format = "0.00##";
                    dataGridViewStavkeRacuna.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridViewStavkeRacuna.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridViewStavkeRacuna.Columns[4].Visible = false;
                    dataGridViewStavkeRacuna.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
            }
            get { return selektiranRacunID; }
        }

        public static void DisplayData()
        {
            DataTable dt = Database.GetRacunsTable();
            dataGridViewNeobradeniRacuni.DataSource = dt;
            dataGridViewNeobradeniRacuni.Columns[0].Visible = false;
            dataGridViewNeobradeniRacuni.Columns[1].Visible = false;
            dataGridViewNeobradeniRacuni.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewNeobradeniRacuni.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewNeobradeniRacuni.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewNeobradeniRacuni.DefaultCellStyle.NullValue = "Nepoznati kupac";
            selektiranRacunID = -1;
            dataGridViewStavkeRacuna.DataSource = null;
        }
        
        public static void PonistiRacun()
        {
            if (selektiranRacunID >= 0)
            {
                Database.DeteleFromRacuns(selektiranRacunID);
                DisplayData();
                selektiranRacunID = -1;
                dataGridViewStavkeRacuna.DataSource = null;
            }
            else
            {
                MessageBox.Show("Račun nije selektiran!");
            }
        }
        public static void RacunPlacen()
        {
            if (selektiranRacunID >= 0)
            {
                Database.AzurirajStanjeRacunaISkladista(selektiranRacunID, dataGridViewStavkeRacuna.Rows);
                DisplayData();
                selektiranRacunID = -1;
                dataGridViewStavkeRacuna.DataSource = null;
            }
            else
            {
                MessageBox.Show("Račun nije selektiran!");
            }
        }
        public static void OdgodaPlacanja()
        {
            if(selektiranRacunID == -1)
            {
                MessageBox.Show("Račun nije selektiran!");
                return;
            }
            if (string.IsNullOrEmpty(dataGridViewNeobradeniRacuni.SelectedRows[0].Cells["KupacID"].Value.ToString()))
            {
                MessageBox.Show("Račun mora imati kupca za provedbu odgode plaćanja!");
                return;
            }
            decimal suma = 0;
            foreach(DataGridViewRow row in dataGridViewStavkeRacuna.Rows)
            {
                suma += Convert.ToDecimal(row.Cells[3].Value.ToString()) * Convert.ToDecimal(row.Cells[2].Value.ToString());
            }
            Database.PovecajDugKupca(suma, Convert.ToInt32(dataGridViewNeobradeniRacuni.SelectedRows[0].Cells["KupacID"].Value.ToString()), selektiranRacunID);
            RacunPlacen();
        }
    }
}
