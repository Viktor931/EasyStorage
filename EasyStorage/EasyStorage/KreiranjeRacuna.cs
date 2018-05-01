﻿using System.Data;
using System.Windows.Forms;

namespace EasyStorage
{
    class KreiranjeRacuna
    {
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
            DataTable dt = Database.GetDostupniArtikliTable();
            artiklComboBox.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                artiklComboBox.Items.Add(new ArtiklComboBoxItem(row["Naziv"].ToString(), int.Parse(row["Artikl_ID"].ToString())));
            }
            artiklComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            artiklComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            artiklComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            
            dt = Database.GetKupciDropdownTable();
            kupacComboBox.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                kupacComboBox.Items.Add(new KupacComboBoxItem(row["Naziv"].ToString(), row["OIB"].ToString(), int.Parse(row["ID"].ToString())));
            }
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
            if (float.TryParse(kolicinaTxtbx.Text, out f))
            {
                if(f < 0)
                {
                    MessageBox.Show("Količina ne smije biti negativan broj!");
                    kolicinaTxtbx.Text = "";
                    return;
                }
            }
            if (float.TryParse(cijenaTxtbx.Text, out f))
            {
                if(f < 0)
                {
                    MessageBox.Show("Cijena ne smije biti negativan broj!");
                    cijenaTxtbx.Text = "";
                    return;
                }
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
            kupacComboBox.SelectedIndex = kupacComboBox.FindStringExact(kupacComboBox.Text);
            Database.CreateRacun(kupacComboBox.SelectedItem == null ? -1 : ((KupacComboBoxItem)kupacComboBox.SelectedItem).ID, stavkeRacuna); 
            Clear();
        }
    }
}
