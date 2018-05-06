using System;
using System.Data;
using System.Windows.Forms;

namespace EasyStorage
{
    class NaplataRacuna
    {
        private MainDatabase database = Program.GetMainDatabase();
        private DataGridView dataGridViewNeobradeniRacuni;
        public DataGridView DataGridViewNeobradeniRacuni
        {
            set { dataGridViewNeobradeniRacuni = value; }
        }
        private DataGridView dataGridViewStavkeRacuna;
        public DataGridView DataGridViewStavkeRacuna
        {
            set { dataGridViewStavkeRacuna = value; }
        }
        private int selektiranRacunID = -1;
        public int SelektiranRacunID
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
                    DataTable dt = database.GetArtiklsForRacunTable(selektiranRacunID);
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
        private static NaplataRacuna naplataRacuna;
        public static NaplataRacuna GetNaplataRacuna()
        {
            if(naplataRacuna == null)
            {
                naplataRacuna = new NaplataRacuna();
            }
            return naplataRacuna;
        }
        private NaplataRacuna() { }
        public void DisplayData()
        {
            DataTable dt = database.GetRacunsTable();
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
        
        public void PonistiRacun()
        {
            if (selektiranRacunID >= 0)
            {
                database.DeteleFromRacuns(selektiranRacunID);
                DisplayData();
                selektiranRacunID = -1;
                dataGridViewStavkeRacuna.DataSource = null;
            }
            else
            {
                MessageBox.Show("Račun nije selektiran!");
            }
        }
        public void RacunPlacen()
        {
            if (selektiranRacunID >= 0)
            {
                database.AzurirajStanjeRacunaISkladista(selektiranRacunID, dataGridViewStavkeRacuna.Rows);
                DisplayData();
                selektiranRacunID = -1;
                dataGridViewStavkeRacuna.DataSource = null;
            }
            else
            {
                MessageBox.Show("Račun nije selektiran!");
            }
        }
        public void OdgodaPlacanja()
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
            database.PovecajDugKupca(suma, Convert.ToInt32(dataGridViewNeobradeniRacuni.SelectedRows[0].Cells["KupacID"].Value.ToString()), selektiranRacunID);
            RacunPlacen();
        }
    }
}
