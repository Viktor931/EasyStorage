using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace EasyStorage
{
    class Kupci
    {
        private static int kupacID = -1;
        public static int KupacID
        {
            get { return kupacID; }
            set { kupacID = value; }
        }
        private static SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=EasyStorageDB;Integrated Security=true;");
        private static SqlCommand cmd;
        private static SqlDataAdapter adapt;
        private static DataGridView dataGridViewKupci;
        public static DataGridView DataGridViewKupci
        {
            set { dataGridViewKupci = value; }
        }
        private static TextBox dugovanje;
        public static TextBox Dugovanje
        {
            set { dugovanje = value; }
        }
        private static TextBox naziv;
        public static TextBox Naziv
        {
            set { naziv = value; }
        }
        private static TextBox oib;
        public static TextBox OIB
        {
            set { oib = value; }
        }
        public static void ClearFields()
        {
            dugovanje.Text = "";
            naziv.Text = "";
            oib.Text = "";
        }
        public static void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT ID, Naziv, OIB, Dug as 'Dugovanje (kn)' FROM Kupacs", con);
            adapt.Fill(dt);
            dataGridViewKupci.DataSource = dt;
            dataGridViewKupci.Columns[0].Visible = false;
            dataGridViewKupci.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewKupci.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewKupci.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewKupci.Columns[3].DefaultCellStyle.Format = "0.00##";
            dataGridViewKupci.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            con.Close();
        }
        public static void Dodaj()
        {
            if (naziv.Text != "" || oib.Text != "")
            {
                long o;
                if (long.TryParse(oib.Text, out o) && oib.Text.Length == 11)
                {
                    float f = 0;
                    float.TryParse(dugovanje.Text, out f);
                    if(f > 0)
                    {
                        MessageBox.Show("Novokreirani kupac uvijek ima početno dugovanje 0, koristite opciju ažuriraj kako biste promjenili dugovanje!");
                    }
                    cmd = new SqlCommand("INSERT INTO Kupacs(Naziv, OIB, Dug) OUTPUT INSERTED.ID VALUES(@Naziv, @OIB, 0)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@Naziv", naziv.Text);
                    cmd.Parameters.AddWithValue("@OIB", oib.Text);
                    int id = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.CommandText = "INSERT INTO Promjena_dugovanja(KupacID, Iznos, Ukupno_dugovanje, Vrijeme, RacunID) VALUES(@KupacID, 0, 0, @Vrijeme, NULL)";
                    cmd.Parameters.AddWithValue("@KupacID", id);
                    cmd.Parameters.AddWithValue("@Vrijeme", DateTime.Now.ToString());
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ClearFields();
                    DisplayData();
                }
                else
                {
                    MessageBox.Show("Neispravno unesen OIB!");
                }
            }
            else
            {
                MessageBox.Show("Oba polja moraju biti popunjena");
            }
        }
        public static void Azuriraj()
        {
            if (naziv.Text != "" || naziv.Text != "" || oib.Text != "")
            {

                float dug; 
                if (float.TryParse(dugovanje.Text, out dug))
                {
                    dug = float.Parse(dataGridViewKupci.SelectedRows[0].Cells["Dugovanje (kn)"].Value.ToString());
                    long o;//oib
                    if (long.TryParse(oib.Text, out o) && oib.Text.Length == 11)
                    {
                        cmd = new SqlCommand("UPDATE kupacs SET Naziv = @Naziv, OIB = @OIB, Dug = @Dug WHERE ID = @IDKupac", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@Naziv", naziv.Text);
                        cmd.Parameters.AddWithValue("@IDKupac", KupacID);
                        cmd.Parameters.AddWithValue("@OIB", oib.Text);
                        cmd.Parameters.AddWithValue("@Dug", dugovanje.Text);
                        cmd.ExecuteNonQuery();
                        dug = float.Parse(dugovanje.Text) - dug;//razlika novog duga i prijasnjeg duga
                        if(dug != 0)
                        {
                            cmd.CommandText = "INSERT INTO Promjena_dugovanja(KupacID, Iznos, Ukupno_dugovanje, Vrijeme, RacunID) VALUES(@KupacID, @Iznos, @Ukupno, @Vrijeme, NULL)";
                            cmd.Parameters.AddWithValue("@KupacID", KupacID);
                            cmd.Parameters.AddWithValue("@Iznos", dug);
                            cmd.Parameters.AddWithValue("@Ukupno", dugovanje.Text);
                            cmd.Parameters.AddWithValue("@Vrijeme", DateTime.Now.ToString());
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();
                        DisplayData();
                        ClearFields();
                        KupacID = -1;
                    }
                    else
                    {
                        MessageBox.Show("Neispravno unesen OIB!");
                    }
                }
                else
                {
                    MessageBox.Show("Neispravan unos dugovanja!");
                    dugovanje.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Polja ne smiju biti prazna!");
            }
        }
    }
}
