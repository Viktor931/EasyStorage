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
            dataGridViewKupci.DataSource = Database.GetKupciTable();
            dataGridViewKupci.Columns[0].Visible = false;
            dataGridViewKupci.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewKupci.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewKupci.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewKupci.Columns[3].DefaultCellStyle.Format = "0.00##";
            dataGridViewKupci.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
                    Database.SaveKupac(naziv.Text, oib.Text);
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
                        Database.UpdateKupac(naziv.Text, KupacID, oib.Text, dugovanje.Text, dug);
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
