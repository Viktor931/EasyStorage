using System.Data;
using System.Windows.Forms;

namespace EasyStorage
{
    interface MainDatabase
    {

        DataTable GetIzvjestajOArtiklimaTable();

        DataTable GetKupciTable();

        DataTable GetArtikliIzvjestajTable(int artiklID);

        DataTable GetArtiklsForRacunTable(int racunID);

        DataTable GetRacunsTable();

        DataTable GetDostupniArtikliTable();

        DataTable GetSkladisteTable();

        DataTable GetKupciDropdownTable();

        DataTable GetPromjenaDugovanjaForKupacOrderedByVrijemeTable(int kupacID);

        DataTable GetPromjenaDugovanjaForKupacTable(int kupacID);

        void DeteleFromRacuns(int racunID);

        void DeteleFromArtikls(int artiklID);

        void UpdateArtikl(int artiklID, string naziv);

        string GetNabavljenaKolicinaForArtikl(int artiklID);

        bool IsArtiklNaSkladistu(int artiklID);

        void CreateRacun(int kupacID, DataTable stavkeRacuna);

        void CreateArtikl(string naziv, string kolicina);

        void SaveKupac(string naziv, string oib);

        void UpdateKupac(string naziv, int kupacID, string oib, string noviDug, float stariDug);

        void PovecajDugKupca(decimal suma, int kupacID, int racunID);

        void AzurirajStanjeRacunaISkladista(int racunID, DataGridViewRowCollection stavkeRacuna);
    }
}
