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
            DataTable dt = Database.GetSkladisteTable();
            dataGridViewArtikli.DataSource = dt;
            dataGridViewArtikli.Columns[0].Visible = false;
            dataGridViewArtikli.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewArtikli.Columns[3].DefaultCellStyle.Format = "0.00##";
            dataGridViewArtikli.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewArtikli.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public static void Dodaj()
        {
            if (naziv.Text != "" || kolicina.Text != "")
            {
                float f;
                if (float.TryParse(kolicina.Text, out f) && f >= 0)
                {
                    Database.CreateArtikl(naziv.Text, kolicina.Text);
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
                        if(Database.IsArtiklNaSkladistu(ArtiklID))
                        {
                            Database.UpdateArtikl(ArtiklID, naziv.Text);
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
                Database.DeteleFromArtikls(ArtiklID);
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
