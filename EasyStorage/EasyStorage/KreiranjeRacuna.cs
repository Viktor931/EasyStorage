using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Windows;

namespace EasyStorage
{
    class KreiranjeRacuna
    {
        private static SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=EasyStorageDB;Integrated Security=true;");
        private static SqlCommand cmd;
        private static SqlDataAdapter adapt;
        private static DataTable stavkeRacuna;
        private static int selektiranRed = -1;
        public static int SelektiranRed
        {
            set
            {
                if (selektiranRed == value)
                {
                    selektiranRed = -1;
                    dataGridViewStavkaRacuna.Rows[value].Selected = false;
                }
                else selektiranRed = value;
            }
        }
        private static DataGridView dataGridViewStavkaRacuna;
        public static DataGridView DataGridViewStavkaRacuna
        {
            set { dataGridViewStavkaRacuna = value; }
        }
        private static ComboBox kupacComboBox;
        public static ComboBox KupacComboBox
        {
            set
            {
                kupacComboBox = value;
            }
        }
        private static ComboBox artiklComboBox;
        public static ComboBox ArtiklComboBox
        {
            set
            {
                artiklComboBox = value;
            }
        }
        private static TextBox kolicinaTxtbx;
        public static TextBox KolicinaTxtbx
        {
            set { kolicinaTxtbx = value; }
        }
        private static TextBox cijenaTxtbx;
        public static TextBox CijenaTxtbx
        {
            set { cijenaTxtbx = value; }
        }

        class KupacComboBoxItem
        {
            public string Naziv;
            public string OIB;
            public int ID;
            public KupacComboBoxItem(string naziv, string oib, int id)
            {
                this.Naziv = naziv;
                this.OIB = oib;
                this.ID = id;
            }
            public override string ToString()
            {
                return this.OIB + " " + this.Naziv;
            }
        }
        class ArtiklComboBoxItem
        {
            public string Naziv;
            public int ID;
            public ArtiklComboBoxItem(string Name, int value)
            {
                this.Naziv = Name;
                this.ID = value;
            }
            public override string ToString()
            {
                return this.Naziv;
            }
        }

        public static void ClearFields()
        {
            artiklComboBox.Text = "";
            kolicinaTxtbx.Text = "";
            cijenaTxtbx.Text = "";
        }
        private static void inicijalizirajStavke()
        {
            stavkeRacuna = new DataTable();
            DataColumn stupac;

            stupac = new DataColumn();
            stupac.DataType = System.Type.GetType("System.Int32");
            stupac.ColumnName = "ArtiklID";
            stavkeRacuna.Columns.Add(stupac);

            stupac = new DataColumn();
            stupac.DataType = System.Type.GetType("System.String");
            stupac.ColumnName = "Naziv artikla";
            stavkeRacuna.Columns.Add(stupac);

            stupac = new DataColumn();
            stupac.DataType = System.Type.GetType("System.Single");
            stupac.ColumnName = "Količina (kg)";
            stavkeRacuna.Columns.Add(stupac);

            stupac = new DataColumn();
            stupac.DataType = System.Type.GetType("System.Decimal");
            stupac.ColumnName = "Cijena (kn/kg)";
            stavkeRacuna.Columns.Add(stupac);
        }
        public static void DisplayData()
        {

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT Artikli_u_skladistu.Artikl_ID, Artikls.Naziv FROM Artikli_u_skladistu, Artikls WHERE Artikli_u_skladistu.Artikl_ID = Artikls.ID", con);
            adapt.Fill(dt);
            artiklComboBox.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                artiklComboBox.Items.Add(new ArtiklComboBoxItem(row["Naziv"].ToString(), int.Parse(row["Artikl_ID"].ToString())));
            }
            con.Close();
            artiklComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            artiklComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            artiklComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;

            con.Open();
            dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT ID, Naziv, OIB FROM Kupacs", con);
            adapt.Fill(dt);
            kupacComboBox.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                kupacComboBox.Items.Add(new KupacComboBoxItem(row["Naziv"].ToString(), row["OIB"].ToString(), int.Parse(row["ID"].ToString())));
            }
            con.Close();
            kupacComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            kupacComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            kupacComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;

            if (stavkeRacuna == null) inicijalizirajStavke();
            dataGridViewStavkaRacuna.DataSource = stavkeRacuna;
            dataGridViewStavkaRacuna.Columns[0].Visible = false;
            dataGridViewStavkaRacuna.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewStavkaRacuna.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewStavkaRacuna.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewStavkaRacuna.Columns[2].DefaultCellStyle.Format = "0.00##";
            dataGridViewStavkaRacuna.Columns[3].DefaultCellStyle.Format = "0.00##";
            dataGridViewStavkaRacuna.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewStavkaRacuna.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        public static void DodajStavku()
        {
            float f;
            if(!float.TryParse(kolicinaTxtbx.Text, out f))
            {
                MessageBox.Show("Neispravan unos količine!");
                kolicinaTxtbx.Text = "";
                return;
            }
            if(!float.TryParse(cijenaTxtbx.Text, out f))
            {
                MessageBox.Show("Neispravan unos cijene!");
                cijenaTxtbx.Text = "";
                return;
            }
            artiklComboBox.SelectedIndex = artiklComboBox.FindStringExact(artiklComboBox.Text);
            if(artiklComboBox.SelectedItem == null)
            {
                MessageBox.Show("Neispravan unos artikla!");
                artiklComboBox.Text = "";
                return;
            }
            DataRow[] redoviArtiklID = stavkeRacuna.Select("ArtiklID = '" + ((ArtiklComboBoxItem)artiklComboBox.SelectedItem).ID + "'");
            if(redoviArtiklID.Length != 0)
            {
                MessageBox.Show("Već postoji stavka s tim artiklom!");
                ClearFields();
                return;
            }
            DataRow red = stavkeRacuna.NewRow();
            red["ArtiklID"] = ((ArtiklComboBoxItem)artiklComboBox.SelectedItem).ID;
            red["Naziv artikla"] = ((ArtiklComboBoxItem)artiklComboBox.SelectedItem).Naziv;
            red["Količina (kg)"] = kolicinaTxtbx.Text;
            red["Cijena (kn/kg)"] = cijenaTxtbx.Text;
            stavkeRacuna.Rows.Add(red);
            DisplayData();
            ClearFields();
        }
        public static void PonistiStavku()
        {
            if(selektiranRed == -1)
            {
                MessageBox.Show("Nije selektirana stavka računa za poništavanje!");
                return;
            }
            stavkeRacuna.Rows[selektiranRed].Delete();
            DisplayData();
        }
        public static void Clear()
        {
            selektiranRed = -1;
            stavkeRacuna = null;
            kupacComboBox.Text = "";
            kupacComboBox.SelectedIndex = -1;
            ClearFields();
            DisplayData();
        }
        public static void KreirajRacun()
        {
            if(stavkeRacuna.Rows.Count == 0)
            {
                MessageBox.Show("Nemogu kreirati račun bez stavki!");
                return;
            }
            int id;
            cmd = new SqlCommand("INSERT INTO Racuns(Vrijeme, Kupac_ID, Status) OUTPUT INSERTED.ID VALUES(@Vrijeme, @Kupac_ID, 'ceka')", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Vrijeme", DateTime.Now.ToString());
            if (kupacComboBox.SelectedItem == null) cmd.Parameters.AddWithValue("@Kupac_ID", DBNull.Value);
            else cmd.Parameters.AddWithValue("@Kupac_ID", ((KupacComboBoxItem)kupacComboBox.SelectedItem).ID);
            id = (int)cmd.ExecuteScalar();
            foreach(DataRow r in stavkeRacuna.Rows)
            {
                cmd = new SqlCommand("INSERT INTO Stavka_racuna(Kolicina, Cijena, RacunID, ArtiklID) VALUES (@Kolicina, @Cijena, @RacunID, @ArtiklID)", con);
                cmd.Parameters.AddWithValue("@Kolicina", r["Količina (kg)"].ToString());
                cmd.Parameters.AddWithValue("@Cijena", r["Cijena (kn/kg)"].ToString());
                cmd.Parameters.AddWithValue("@RacunID", id);
                cmd.Parameters.AddWithValue("@ArtiklID", r["ArtiklID"]);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            Clear();
        }
    }
}
