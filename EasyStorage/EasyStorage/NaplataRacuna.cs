using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Timers;

namespace EasyStorage
{
    class NaplataRacuna
    {
        private static SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=EasyStorageDB;Integrated Security=true;");
        private static SqlCommand cmd;
        private static SqlDataAdapter adapt;
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
                    con.Open();
                    cmd = new SqlCommand("SELECT Artikls.Naziv, Artikls.Datum, Stavka_racuna.Kolicina, Stavka_racuna.Cijena, Artikls.ID FROM Artikls, Stavka_racuna WHERE Artikls.ID = Stavka_racuna.ArtiklID AND Stavka_racuna.RacunID = @RacunID", con);
                    cmd.Parameters.AddWithValue("@RacunID", selektiranRacunID);
                    adapt = new SqlDataAdapter(cmd); 
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);
                    dataGridViewStavkeRacuna.DataSource = null;
                    dataGridViewStavkeRacuna.DataSource = dt;
                    dataGridViewStavkeRacuna.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewStavkeRacuna.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewStavkeRacuna.Columns[2].DefaultCellStyle.Format = "0.00##";
                    dataGridViewStavkeRacuna.Columns[3].DefaultCellStyle.Format = "0.00##";
                    dataGridViewStavkeRacuna.Columns[4].Visible = false;
                    dataGridViewStavkeRacuna.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    con.Close();
                }
            }
            get { return selektiranRacunID; }
        }

        public static void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT Racuns.ID AS 'RacunID', Kupacs.ID AS 'KupacID', Kupacs.Naziv, Kupacs.OIB, Racuns.Vrijeme FROM Racuns LEFT OUTER JOIN Kupacs ON Racuns.Kupac_ID = Kupacs.ID WHERE Racuns.Status = 'ceka'", con);
            adapt.Fill(dt);
            dataGridViewNeobradeniRacuni.DataSource = dt;
            dataGridViewNeobradeniRacuni.Columns[0].Visible = false;
            dataGridViewNeobradeniRacuni.Columns[1].Visible = false;
            dataGridViewNeobradeniRacuni.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewNeobradeniRacuni.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewNeobradeniRacuni.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewNeobradeniRacuni.DefaultCellStyle.NullValue = "Nepoznati kupac";
            con.Close();
            selektiranRacunID = -1;
            dataGridViewStavkeRacuna.DataSource = null;
        }
        
        public static void PonistiRacun()
        {
            if (selektiranRacunID >= 0)
            {
                cmd = new SqlCommand("DELETE FROM Racuns WHERE ID = @ID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ID", selektiranRacunID);
                cmd.ExecuteNonQuery();
                con.Close();
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
                cmd = new SqlCommand("UPDATE Racuns SET Status = 'obraden' WHERE ID = @ID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ID", selektiranRacunID);
                cmd.ExecuteNonQuery();
                foreach (DataGridViewRow row in dataGridViewStavkeRacuna.Rows)
                {
                    cmd = new SqlCommand("UPDATE Artikli_u_skladistu SET Kolicina = Kolicina - @Kolicina WHERE Artikl_ID = @ArtiklID ", con);
                    cmd.Parameters.AddWithValue("@Kolicina", row.Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("@ArtiklID", row.Cells[4].Value.ToString());
                    cmd.ExecuteNonQuery();
                }
                con.Close();
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
            cmd = new SqlCommand("UPDATE Kupacs SET Dug = Dug + @Suma OUTPUT INSERTED.Dug WHERE ID = @IDKupac", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Suma", suma);
            cmd.Parameters.AddWithValue("@IDKupac", Convert.ToInt32(dataGridViewNeobradeniRacuni.SelectedRows[0].Cells["KupacID"].Value.ToString()));
            decimal iznos = Convert.ToDecimal(cmd.ExecuteScalar());
            cmd = new SqlCommand("INSERT INTO Promjena_dugovanja(KupacID, Iznos, Ukupno_dugovanje, Vrijeme, RacunID) VALUES (@KupacID, @Suma, @Ukupno, @Vrijeme, @RacunID)", con);
            cmd.Parameters.AddWithValue("@KupacID", Convert.ToInt32(dataGridViewNeobradeniRacuni.SelectedRows[0].Cells["KupacID"].Value.ToString()));
            cmd.Parameters.AddWithValue("@Suma", suma);
            cmd.Parameters.AddWithValue("@Ukupno", iznos);
            cmd.Parameters.AddWithValue("@Vrijeme", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@RacunID", selektiranRacunID);
            cmd.ExecuteNonQuery();      
            con.Close();
            RacunPlacen();
        }
    }
}
