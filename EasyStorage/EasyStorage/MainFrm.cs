using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EasyStorage
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            Skladiste.DataGridViewArtikli = dataGridViewArtikli;
            Skladiste.Naziv = NazivArtiklaTxtbx;
            Skladiste.Kolicina = KolicinaTxtbx;
            Kupci.DataGridViewKupci = DataGridViewKupci;
            Kupci.Naziv = NazivKupcaTxtbx;
            Kupci.Dugovanje = DugovanjeTxtbx;
            Kupci.OIB = OIBTxtbx;
            tabControl1.SelectTab(0);
            Skladiste.DisplayData();
        }
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(e.TabPage.Text == "Skladište")
            {
                Skladiste.DisplayData();
            }
            else if(e.TabPage.Text == "Kupci")
            {
                Kupci.DisplayData();
            }
        }
        //eventi za tab artikli
        private void DodajBtn_Click(object sender, EventArgs e)
        {
            Skladiste.Dodaj();
        }

        private void AzurirajBtn_Click(object sender, EventArgs e)
        {
            Skladiste.Azuriraj();
        }

        private void ObrisiBtn_Click(object sender, EventArgs e)
        {
            Skladiste.Obrisi();
        }

        private void dataGridViewArtikli_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int id = Convert.ToInt32(dataGridViewArtikli.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (id == Skladiste.ArtiklID)
            {
                Skladiste.ArtiklID = -1;
                Skladiste.ClearFields();
                dataGridViewArtikli.Rows[e.RowIndex].Selected = false;
                return;
            }
            else
            {
                Skladiste.ArtiklID = id;
                NazivArtiklaTxtbx.Text = dataGridViewArtikli.Rows[e.RowIndex].Cells[1].Value.ToString();
                KolicinaTxtbx.Text = dataGridViewArtikli.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void dataGridViewArtikli_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewArtikli.ClearSelection();
        }
        //eventi za tab kupci
        private void KupciDodajBtn_Click(object sender, EventArgs e)
        {
            Kupci.Dodaj();
        }

        private void KupciAzurirajBtn_Click(object sender, EventArgs e)
        {
            Kupci.Azuriraj();
        }

        private void DataGridViewKupci_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int id = Convert.ToInt32(DataGridViewKupci.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (id == Kupci.KupacID)
            {
                Kupci.KupacID = -1;
                Kupci.ClearFields();
                DataGridViewKupci.Rows[e.RowIndex].Selected = false;
                return;
            }
            else
            {
                Kupci.KupacID = id;
                NazivKupcaTxtbx.Text = DataGridViewKupci.Rows[e.RowIndex].Cells[1].Value.ToString();
                OIBTxtbx.Text = DataGridViewKupci.Rows[e.RowIndex].Cells[2].Value.ToString();
                DugovanjeTxtbx.Text = DataGridViewKupci.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void DataGridViewKupci_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //todo izvjestaj o dugovanju kupca
        }

        private void DataGridViewKupci_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridViewKupci.ClearSelection();
        }
    }
}
