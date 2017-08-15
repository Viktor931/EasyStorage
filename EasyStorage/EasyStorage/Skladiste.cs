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
    class Skladiste
    {
        private static int artiklID = -1;
        public static int ArtiklID
        {
            get { return artiklID; }
            set { artiklID = value; }
        }
        private static SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=EasyStorageDB;Integrated Security=true;");
        private static SqlCommand cmd;
        private static SqlDataAdapter adapt;
        private static DataGridView dataGridViewArtikli;
        public static DataGridView DataGridViewArtikli
        {
            set { dataGridViewArtikli = value; }
        }
        private static TextBox kolicina;
        public static TextBox Kolicina
        {
            set { kolicina = value; }
        }
        private static TextBox naziv;
        public static TextBox Naziv
        {
            set { naziv = value; }
        }
        public static void ClearFields()
        {
            kolicina.Text = "";
            naziv.Text = "";
        }
        public static void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select Artikls.ID, Artikls.Naziv, Artikls.Datum AS 'Datum i vrijeme', Artikli_u_skladistu.Kolicina As 'Količina (kg)' from Artikls, Artikli_u_skladistu where Artikls.ID = Artikli_u_skladistu.Artikl_ID", con);
            adapt.Fill(dt);
            dataGridViewArtikli.DataSource = dt;
            dataGridViewArtikli.Columns[0].Visible = false;
            dataGridViewArtikli.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewArtikli.Columns[3].DefaultCellStyle.Format = "0.00##";
            dataGridViewArtikli.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewArtikli.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            con.Close();
        }
        public static void Dodaj()
        {
            if (naziv.Text != "" || kolicina.Text != "")
            {
                float f;
                if (float.TryParse(kolicina.Text, out f) && f >= 0)
                {
                    cmd = new SqlCommand("INSERT INTO Artikls(Naziv, Datum, Nabavljena_kolicina) OUTPUT INSERTED.ID VALUES(@Naziv, @Datum, @Kolicina)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@Naziv", naziv.Text);
                    cmd.Parameters.AddWithValue("@Datum", DateTime.Now.ToString());
                    cmd.Parameters.AddWithValue("@Kolicina", kolicina.Text);
                    int id = (int)cmd.ExecuteScalar();
                    cmd = new SqlCommand("INSERT INTO Artikli_u_skladistu(Kolicina, Artikl_ID) VALUES(@Kolicina, @Artikl_ID)", con);
                    cmd.Parameters.AddWithValue("@Kolicina", kolicina.Text);
                    cmd.Parameters.AddWithValue("@Artikl_ID", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Skladiste.DisplayData();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Količina mora biti broj veći ili jednak 0");
                    kolicina.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Oba polja moraju biti popunjena");
            }
        }
        public static void Azuriraj()
        {
            if (kolicina.Text != "" || naziv.Text != "")
            {
                float f;
                if (float.TryParse(kolicina.Text, out f) && f >= 0)
                {
                    if (ArtiklID >= 0)
                    {
                        cmd = new SqlCommand("SELECT COUNT(*) FROM Artikls, Artikli_u_skladistu WHERE Artikls.ID = @IDArtikl AND Artikls.ID = Artikli_u_skladistu.Artikl_ID", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@IDArtikl", ArtiklID);
                        Int32 count = (Int32)cmd.ExecuteScalar();
                        con.Close();
                        if (count == 1)
                        {
                            cmd = new SqlCommand("UPDATE Artikls SET Naziv = @Naziv WHERE ID = @IDArtikl", con);
                            con.Open();
                            cmd.Parameters.AddWithValue("@Naziv", naziv.Text);
                            cmd.Parameters.AddWithValue("@IDArtikl", ArtiklID);
                            cmd.ExecuteNonQuery();
                            /*cmd.CommandText = "UPDATE Artikli_u_skladistu SET Kolicina = @Kolicina WHERE Artikl_ID = @Artikl";
                            cmd.Parameters.AddWithValue("@Kolicina", kolicina.Text);
                            cmd.Parameters.AddWithValue("@Artikl", ArtiklID);
                            cmd.ExecuteNonQuery();*///ovo nemere jer je glupo "azurirat kolicinu, ona se automatski auzira kreiranjem racuna"
                            con.Close();
                            DisplayData();
                            ClearFields();
                            ArtiklID = -1;
                        }
                        else
                        {
                            MessageBox.Show("Nije pronađen artikl za ažuriranje");
                            ArtiklID = -1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nije označen artikl za ažuriranje");
                    }
                }
                else
                {
                    MessageBox.Show("Količina mora biti broj veći ili jednak 0");
                    kolicina.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Polja ne smiju biti prazna");
            }
        }
        public static void Obrisi()
        {
            if (ArtiklID >= 0)
            {
                cmd = new SqlCommand("DELETE FROM Artikli_u_skladistu WHERE Artikl_ID = @ID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ID", ArtiklID);
                cmd.ExecuteNonQuery();
                con.Close();
                Skladiste.DisplayData();
                ClearFields();
                ArtiklID = -1;
            }
            else
            {
                MessageBox.Show("Artikl nije selektiran");
            }
        }
    }
}
