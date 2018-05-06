using System;
using System.Windows.Forms;

namespace EasyStorage
{
    public partial class MainFrm : Form
    {
        private Skladiste skladiste;
        private Kupci kupci;
        private KreiranjeRacuna kreiranjeRacuna;
        private NaplataRacuna naplataRacuna;
        private IzvjestajOArtiklima izvjestajOArtiklima;
        private string status;
        public MainFrm(string s)
        {
            status = s;
            InitializeComponent();
            if(s == "blagajnik ")
            {
                naplataRacuna = NaplataRacuna.GetNaplataRacuna();
                naplataRacuna.DataGridViewNeobradeniRacuni = DataGridViewNeobradeniRacuni;
                naplataRacuna.DataGridViewStavkeRacuna = DataGridViewStavkeRacuna;

                tabControl1.TabPages.RemoveByKey("SkladisteTab");
                tabControl1.TabPages.RemoveByKey("KupciTab");
                tabControl1.TabPages.RemoveByKey("KreiranjeRacunaTab");
                tabControl1.TabPages.RemoveByKey("IzvjestajiOArtiklima");
                tabControl1.SelectTab(0);
                naplataRacuna.DisplayData();
            }
            else if(s == "skladistar")
            {
                skladiste = Skladiste.GetSkladiste();
                skladiste.DataGridViewArtikli = dataGridViewArtikli;
                skladiste.Naziv = NazivArtiklaTxtbx;
                skladiste.Kolicina = KolicinaTxtbx;
                kupci = Kupci.GetKupci();
                kupci.DataGridViewKupci = DataGridViewKupci;
                kupci.Naziv = NazivKupcaTxtbx;
                kupci.Dugovanje = DugovanjeTxtbx;
                kupci.OIB = OIBTxtbx;
                kreiranjeRacuna = KreiranjeRacuna.GetKreiranjeRacuna();
                kreiranjeRacuna.DataGridViewStavkaRacuna = DataGridViewStavkaRacuna;
                kreiranjeRacuna.ArtiklComboBox = ArtiklComboBox;
                kreiranjeRacuna.KupacComboBox = KupacComboBox;
                kreiranjeRacuna.CijenaTxtbx = CijenaTxtbx;
                kreiranjeRacuna.KolicinaTxtbx = KolicinaStavkaTxtbx;


                tabControl1.TabPages.RemoveByKey("NaplataRacunaTab");
                tabControl1.TabPages.RemoveByKey("IzvjestajiOArtiklima");
                tabControl1.SelectTab(2);
                kreiranjeRacuna.DisplayData();
            }
            else if(s == "direktor  ")
            {
                skladiste = Skladiste.GetSkladiste();
                skladiste.DataGridViewArtikli = dataGridViewArtikli;
                skladiste.Naziv = NazivArtiklaTxtbx;
                skladiste.Kolicina = KolicinaTxtbx;
                kupci = Kupci.GetKupci();
                kupci.DataGridViewKupci = DataGridViewKupci;
                kupci.Naziv = NazivKupcaTxtbx;
                kupci.Dugovanje = DugovanjeTxtbx;
                kupci.OIB = OIBTxtbx;
                kreiranjeRacuna = KreiranjeRacuna.GetKreiranjeRacuna();
                kreiranjeRacuna.DataGridViewStavkaRacuna = DataGridViewStavkaRacuna;
                kreiranjeRacuna.ArtiklComboBox = ArtiklComboBox;
                kreiranjeRacuna.KupacComboBox = KupacComboBox;
                kreiranjeRacuna.CijenaTxtbx = CijenaTxtbx;
                kreiranjeRacuna.KolicinaTxtbx = KolicinaStavkaTxtbx;
                naplataRacuna = NaplataRacuna.GetNaplataRacuna();
                naplataRacuna.DataGridViewNeobradeniRacuni = DataGridViewNeobradeniRacuni;
                naplataRacuna.DataGridViewStavkeRacuna = DataGridViewStavkeRacuna;
                izvjestajOArtiklima = IzvjestajOArtiklima.GetIzvjestajOArtiklima();
                izvjestajOArtiklima.DataGridViewIzvjestajOArtiklima = DataGridViewArtikliIzvjesca;

                tabControl1.SelectTab(0);
                skladiste.DisplayData();
            }
            else
            {
                MessageBox.Show("error");
            }
        }
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Text == "Skladište")
            {
                skladiste.DisplayData();
            }
            else if (e.TabPage.Text == "Kupci")
            {
                kupci.DisplayData();
            }
            else if (e.TabPage.Text == "Kreiranje računa")
            {
                kreiranjeRacuna.DisplayData();
            }
            else if (e.TabPage.Text == "Naplata računa")
            {
                naplataRacuna.DisplayData();
            }
            else if(e.TabPage.Text == "Izvještaji o artiklima")
            {
                izvjestajOArtiklima.DisplayData();
            }
        }
        //eventi za tab artikli
        private void DodajBtn_Click(object sender, EventArgs e)
        {
            skladiste.Dodaj();
        }

        private void AzurirajBtn_Click(object sender, EventArgs e)
        {
            skladiste.Azuriraj();
        }

        private void ObrisiBtn_Click(object sender, EventArgs e)
        {
            skladiste.Obrisi();
        }

        private void dataGridViewArtikli_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int id = Convert.ToInt32(dataGridViewArtikli.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (id == skladiste.ArtiklID)
            {
                skladiste.ArtiklID = -1;
                skladiste.ClearFields();
                dataGridViewArtikli.Rows[e.RowIndex].Selected = false;
                return;
            }
            else
            {
                skladiste.ArtiklID = id;
                NazivArtiklaTxtbx.Text = dataGridViewArtikli.Rows[e.RowIndex].Cells[1].Value.ToString();
                KolicinaTxtbx.Text = dataGridViewArtikli.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void dataGridViewArtikli_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewArtikli.ClearSelection();
            skladiste.ClearFields();
        }
        //eventi za tab kupci
        private void KupciDodajBtn_Click(object sender, EventArgs e)
        {
            kupci.Dodaj();
        }

        private void KupciAzurirajBtn_Click(object sender, EventArgs e)
        {
            kupci.Azuriraj();
        }

        private void DataGridViewKupci_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int id = Convert.ToInt32(DataGridViewKupci.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (id == kupci.KupacID)
            {
                kupci.KupacID = -1;
                kupci.ClearFields();
                DataGridViewKupci.Rows[e.RowIndex].Selected = false;
                return;
            }
            else
            {
                kupci.KupacID = id;
                NazivKupcaTxtbx.Text = DataGridViewKupci.Rows[e.RowIndex].Cells[1].Value.ToString();
                OIBTxtbx.Text = DataGridViewKupci.Rows[e.RowIndex].Cells[2].Value.ToString();
                DugovanjeTxtbx.Text = DataGridViewKupci.Rows[e.RowIndex].Cells[3].Value.ToString().Substring(0, DataGridViewKupci.Rows[e.RowIndex].Cells[3].Value.ToString().Length - 2);
            }
        }

        private void DataGridViewKupci_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (status == "direktor  ")
            {
                Form graf = new PrikazDugovanja(Convert.ToInt32(DataGridViewKupci.Rows[e.RowIndex].Cells[0].Value.ToString()), "Graf dugovanja za kupca \"" + DataGridViewKupci.Rows[e.RowIndex].Cells[1].Value.ToString() + "\"");
                graf.Show();
            }
        }

        private void DataGridViewKupci_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridViewKupci.ClearSelection();
            kupci.ClearFields();
        }

        //eventi za kreiranje racuna
        private void DodajStavkuRacunaBtn_Click(object sender, EventArgs e)
        {
            kreiranjeRacuna.DodajStavku();
        }

        private void DataGridViewStavkaRacuna_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridViewStavkaRacuna.ClearSelection();
        }

        private void DataGridViewStavkaRacuna_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            kreiranjeRacuna.SelektiranRed = e.RowIndex;
        }

        private void PonistiStavkuRacunaBtn_Click(object sender, EventArgs e)
        {
            kreiranjeRacuna.PonistiStavku();
        }

        private void ArtiklComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            ArtiklComboBox.DroppedDown = false;
        }
        private void KupacComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            KupacComboBox.DroppedDown = false;
        }

        private void PonistiRacunBtn_Click(object sender, EventArgs e)
        {
            kreiranjeRacuna.Clear();
        }

        private void KreirajRacunBtn_Click(object sender, EventArgs e)
        {
            kreiranjeRacuna.KreirajRacun();
        }

        private void OsvjeziBtn1_Click(object sender, EventArgs e)
        {
            kreiranjeRacuna.DisplayData();
        }

        //Eventi za naplatu racuna
        private void RacunPlacenBtn_Click(object sender, EventArgs e)
        {
            naplataRacuna.RacunPlacen();
        }

        private void PonistiRacunBtn1_Click(object sender, EventArgs e)
        {
            naplataRacuna.PonistiRacun();
        }

        private void OdgodaPlacanjaBtn_Click(object sender, EventArgs e)
        {
            naplataRacuna.OdgodaPlacanja();
        }

        private void DataGridViewNeobradeniRacuni_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridViewNeobradeniRacuni.ClearSelection();
        }

        private void DataGridViewNeobradeniRacuni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            naplataRacuna.SelektiranRacunID = Convert.ToInt32(DataGridViewNeobradeniRacuni.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (naplataRacuna.SelektiranRacunID == -1) DataGridViewNeobradeniRacuni.Rows[e.RowIndex].Selected = false;
        }

        private void DataGridViewStavkeRacuna_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridViewStavkeRacuna.ClearSelection();
        }

        private void OsvjeziBtn_Click(object sender, EventArgs e)
        {
            naplataRacuna.DisplayData();
            naplataRacuna.SelektiranRacunID = -1;
        }

        //Eventovi za izvjestaje o artiklima
        private void DataGridViewArtikliIzvjesca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (status == "direktor  ")
            {
                ArtiklIzvjestaj a = new ArtiklIzvjestaj(Convert.ToInt32(DataGridViewArtikliIzvjesca.Rows[e.RowIndex].Cells[0].Value.ToString()), "Izvještaj o prodanoj količini (kg) za artikl \"" + DataGridViewArtikliIzvjesca.Rows[e.RowIndex].Cells[1].Value.ToString() + "\"");
                a.Show();
            }
        }

        private void tabControl1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, Application.StartupPath + @"\" + "help.chm");
        }
    }
}
