using System.Windows.Forms;

namespace EasyStorage
{
    class Kupci
    {
        private MainDatabase database = DatabaseImpl.GetMainDatabase();
        private int kupacID = -1;
        public int KupacID
        {
            get { return kupacID; }
            set { kupacID = value; }
        }
        private DataGridView dataGridViewKupci;
        public DataGridView DataGridViewKupci
        {
            set { dataGridViewKupci = value; }
        }
        private TextBox dugovanje;
        public TextBox Dugovanje
        {
            set { dugovanje = value; }
        }
        private TextBox naziv;
        public TextBox Naziv
        {
            set { naziv = value; }
        }
        private TextBox oib;
        public TextBox OIB
        {
            set { oib = value; }
        }
        private static Kupci kupci;
        public static Kupci GetKupci()
        {
            if(kupci == null)
            {
                kupci = new Kupci();
            }
            return kupci;
        }
        private Kupci() { }
        public void ClearFields()
        {
            dugovanje.Text = "";
            naziv.Text = "";
            oib.Text = "";
        }
        public void DisplayData()
        {
            dataGridViewKupci.DataSource = database.GetKupciTable();
            dataGridViewKupci.Columns[0].Visible = false;
            dataGridViewKupci.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewKupci.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewKupci.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewKupci.Columns[3].DefaultCellStyle.Format = "0.00##";
            dataGridViewKupci.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        public void Dodaj()
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
                    database.SaveKupac(naziv.Text, oib.Text);
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
        public void Azuriraj()
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
                        database.UpdateKupac(naziv.Text, KupacID, oib.Text, dugovanje.Text, dug);
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
