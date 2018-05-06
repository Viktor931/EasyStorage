using System.Data;
using System.Windows.Forms;

namespace EasyStorage
{
    class Skladiste
    {
        private MainDatabase database = Program.GetMainDatabase();
        private int artiklID = -1;
        public int ArtiklID
        {
            get { return artiklID; }
            set { artiklID = value; }
        }
        private DataGridView dataGridViewArtikli;
        public DataGridView DataGridViewArtikli
        {
            set { dataGridViewArtikli = value; }
        }
        private TextBox kolicina;
        public TextBox Kolicina
        {
            set { kolicina = value; }
        }
        private TextBox naziv;
        public TextBox Naziv
        {
            set { naziv = value; }
        }
        private static Skladiste skladiste;
        public static Skladiste GetSkladiste()
        {
            if(skladiste == null)
            {
                skladiste = new Skladiste();
            }
            return skladiste;
        }
        private Skladiste() { }
        public void ClearFields()
        {
            kolicina.Text = "";
            naziv.Text = "";
        }
        public void DisplayData()
        {
            DataTable dt = database.GetSkladisteTable();
            dataGridViewArtikli.DataSource = dt;
            dataGridViewArtikli.Columns[0].Visible = false;
            dataGridViewArtikli.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewArtikli.Columns[3].DefaultCellStyle.Format = "0.00##";
            dataGridViewArtikli.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewArtikli.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void Dodaj()
        {
            if (naziv.Text != "" || kolicina.Text != "")
            {
                float f;
                if (float.TryParse(kolicina.Text, out f) && f >= 0)
                {
                    database.CreateArtikl(naziv.Text, kolicina.Text);
                    this.DisplayData();
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
        public void Azuriraj()
        {
            if (kolicina.Text != "" || naziv.Text != "")
            {
                float f;
                if (float.TryParse(kolicina.Text, out f) && f >= 0)
                {
                    if (ArtiklID >= 0)
                    {
                        if(database.IsArtiklNaSkladistu(ArtiklID))
                        {
                            database.UpdateArtikl(ArtiklID, naziv.Text);
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
        public void Obrisi()
        {
            if (ArtiklID >= 0)
            {
                database.DeteleFromArtikls(ArtiklID);
                this.DisplayData();
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
