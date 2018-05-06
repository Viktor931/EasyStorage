using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EasyStorage
{
    class DatabaseImpl : MainDatabase, KorisnikDatabase
    {
        private SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=EasyStorageDB;Integrated Security=true;");
        private SqlCommand cmd;
        private SqlDataAdapter adapt;
        private static DatabaseImpl database;
        public static MainDatabase GetMainDatabase()
        {
            if(database == null)
            {
                database = new DatabaseImpl();
            }
            return database;
        }
        public static KorisnikDatabase GetKorisnikDatabase()
        {
            if(database == null)
            {
                database = new DatabaseImpl();
            }
            return database;
        }
        private DatabaseImpl() { }

        public DataTable GetIzvjestajOArtiklimaTable()
        {
            return getData("SELECT ID, Naziv, Datum FROM Artikls ORDER BY Datum DESC");
        }

        public DataTable GetKupciTable()
        {
            return getData("SELECT ID, Naziv, OIB, Dug as 'Dugovanje (kn)' FROM Kupacs");
        }

        public DataTable GetArtikliIzvjestajTable(int artiklID)
        {
            return getData("SELECT Stavka_racuna.Cijena, Sum(Stavka_racuna.Kolicina) FROM Stavka_racuna, Racuns WHERE Stavka_racuna.ArtiklID = " + artiklID + " AND Racuns.ID = Stavka_racuna.RacunID AND Racuns.Status = 'obraden' GROUP BY Cijena");
        }

        public DataTable GetArtiklsForRacunTable(int racunID)
        {
            return getData("SELECT Artikls.Naziv, Artikls.Datum, Stavka_racuna.Kolicina AS 'Količina (kg)', Stavka_racuna.Cijena AS 'Cijena (kn/kg)', Artikls.ID FROM Artikls, Stavka_racuna WHERE Artikls.ID = Stavka_racuna.ArtiklID AND Stavka_racuna.RacunID = " + racunID);
        }

        public DataTable GetRacunsTable()
        {
            return getData("SELECT Racuns.ID AS 'RacunID', Kupacs.ID AS 'KupacID', Kupacs.Naziv, Kupacs.OIB, Racuns.Vrijeme FROM Racuns LEFT OUTER JOIN Kupacs ON Racuns.Kupac_ID = Kupacs.ID WHERE Racuns.Status = 'ceka'");
        }

        public DataTable GetDostupniArtikliTable()
        {
            return getData("SELECT Artikli_u_skladistu.Artikl_ID, Artikls.Naziv FROM Artikli_u_skladistu, Artikls WHERE Artikli_u_skladistu.Artikl_ID = Artikls.ID");
        }

        public DataTable GetSkladisteTable()
        {
            return getData("select Artikls.ID, Artikls.Naziv, Artikls.Datum AS 'Datum i vrijeme', Artikli_u_skladistu.Kolicina As 'Količina (kg)' from Artikls, Artikli_u_skladistu where Artikls.ID = Artikli_u_skladistu.Artikl_ID");
        }

        public DataTable GetKupciDropdownTable()
        {
            return getData("SELECT ID, Naziv, OIB FROM Kupacs");
        }

        public DataTable GetPromjenaDugovanjaForKupacOrderedByVrijemeTable(int kupacID)
        {
            return getData("SELECT Iznos AS 'Iznos promjene', Ukupno_dugovanje AS 'Ukupno dugovanje', Vrijeme, RacunID FROM Promjena_dugovanja WHERE KupacID = " + kupacID + " ORDER BY Vrijeme DESC");
        }

        public DataTable GetPromjenaDugovanjaForKupacTable(int kupacID)
        {
            return getData("SELECT Iznos AS 'Iznos promjene', Ukupno_dugovanje AS 'Ukupno dugovanje', Vrijeme, RacunID FROM Promjena_dugovanja WHERE KupacID = " + kupacID);
        }

        private DataTable getData(string query)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter(query, con);
            adapt.Fill(dt);
            con.Close();
            return dt;
        }

        public void DeteleFromRacuns(int racunID)
        {
            executeQuery("DELETE FROM Racuns WHERE ID = " + racunID);
        }

        public void DeteleFromArtikls(int artiklID)
        {
            executeQuery("DELETE FROM Artikli_u_skladistu WHERE Artikl_ID = " + artiklID);
        }

        public void UpdateArtikl(int artiklID, string naziv)
        {
            executeQuery("UPDATE Artikls SET Naziv = '" + naziv + "' WHERE ID = " + artiklID);
        }

        private void executeQuery(string query)
        {
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string GetNabavljenaKolicinaForArtikl(int artiklID)
        {
            return getSingleValueString("SELECT Nabavljena_kolicina FROM Artikls WHERE ID = " + artiklID);
        }

        public string GetKorisnikStatus(string username, string password)
        {
            return getSingleValueString("SELECT Status FROM Korisnik WHERE Korisnik.Korisnik = '" + username + "' AND Korisnik.Lozinka = '" + password + "'");
        }

        public bool IsArtiklNaSkladistu(int artiklID)
        {
            return "1".Equals(getSingleValueString("SELECT COUNT(*) FROM Artikls, Artikli_u_skladistu WHERE Artikls.ID = " + artiklID + " AND Artikls.ID = Artikli_u_skladistu.Artikl_ID"));
        }

        private string getSingleValueString(string query)
        {
            con.Open();
            cmd = new SqlCommand(query, con);
            string result = cmd.ExecuteScalar().ToString();
            con.Close();
            return result;
        }

        public void CreateRacun(int kupacID, DataTable stavkeRacuna)
        {
            cmd = new SqlCommand("INSERT INTO Racuns(Vrijeme, Kupac_ID, Status) OUTPUT INSERTED.ID VALUES(@Vrijeme, @Kupac_ID, 'ceka')", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Vrijeme", DateTime.Now.ToString());
            if (kupacID < 0) cmd.Parameters.AddWithValue("@Kupac_ID", DBNull.Value);
            else cmd.Parameters.AddWithValue("@Kupac_ID", kupacID);
            int id = (int)cmd.ExecuteScalar();
            foreach (DataRow r in stavkeRacuna.Rows)
            {
                cmd = new SqlCommand("INSERT INTO Stavka_racuna(Kolicina, Cijena, RacunID, ArtiklID) VALUES (@Kolicina, @Cijena, @RacunID, @ArtiklID)", con);
                cmd.Parameters.AddWithValue("@Kolicina", r["Količina (kg)"].ToString());
                cmd.Parameters.AddWithValue("@Cijena", r["Cijena (kn/kg)"].ToString());
                cmd.Parameters.AddWithValue("@RacunID", id);
                cmd.Parameters.AddWithValue("@ArtiklID", r["ArtiklID"]);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        public void CreateArtikl(string naziv, string kolicina)
        {
            cmd = new SqlCommand("INSERT INTO Artikls(Naziv, Datum, Nabavljena_kolicina) OUTPUT INSERTED.ID VALUES(@Naziv, @Datum, @Kolicina)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Naziv", naziv);
            cmd.Parameters.AddWithValue("@Datum", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@Kolicina", kolicina);
            int id = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("INSERT INTO Artikli_u_skladistu(Kolicina, Artikl_ID) VALUES(@Kolicina, @Artikl_ID)", con);
            cmd.Parameters.AddWithValue("@Kolicina", kolicina);
            cmd.Parameters.AddWithValue("@Artikl_ID", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void SaveKupac(string naziv, string oib)
        {
            cmd = new SqlCommand("INSERT INTO Kupacs(Naziv, OIB, Dug) OUTPUT INSERTED.ID VALUES(@Naziv, @OIB, 0)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Naziv", naziv);
            cmd.Parameters.AddWithValue("@OIB", oib);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.CommandText = "INSERT INTO Promjena_dugovanja(KupacID, Iznos, Ukupno_dugovanje, Vrijeme, RacunID) VALUES(@KupacID, 0, 0, @Vrijeme, NULL)";
            cmd.Parameters.AddWithValue("@KupacID", id);
            cmd.Parameters.AddWithValue("@Vrijeme", DateTime.Now.ToString());
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateKupac(string naziv, int kupacID, string oib, string noviDug, float stariDug)
        {
            cmd = new SqlCommand("UPDATE kupacs SET Naziv = @Naziv, OIB = @OIB, Dug = @Dug WHERE ID = @IDKupac", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Naziv", naziv);
            cmd.Parameters.AddWithValue("@IDKupac", kupacID);
            cmd.Parameters.AddWithValue("@OIB", oib);
            cmd.Parameters.AddWithValue("@Dug", noviDug);
            cmd.ExecuteNonQuery();
            stariDug = float.Parse(noviDug) - stariDug;//razlika novog duga i prijasnjeg duga
            if (stariDug != 0)
            {
                cmd.CommandText = "INSERT INTO Promjena_dugovanja(KupacID, Iznos, Ukupno_dugovanje, Vrijeme, RacunID) VALUES(@KupacID, @Iznos, @Ukupno, @Vrijeme, NULL)";
                cmd.Parameters.AddWithValue("@KupacID", kupacID);
                cmd.Parameters.AddWithValue("@Iznos", stariDug);
                cmd.Parameters.AddWithValue("@Ukupno", noviDug);
                cmd.Parameters.AddWithValue("@Vrijeme", DateTime.Now.ToString());
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        public void PovecajDugKupca(decimal suma, int kupacID, int racunID)
        {
            cmd = new SqlCommand("UPDATE Kupacs SET Dug = Dug + @Suma OUTPUT INSERTED.Dug WHERE ID = @IDKupac", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Suma", suma);
            cmd.Parameters.AddWithValue("@IDKupac", kupacID);
            decimal iznos = Convert.ToDecimal(cmd.ExecuteScalar());
            cmd = new SqlCommand("INSERT INTO Promjena_dugovanja(KupacID, Iznos, Ukupno_dugovanje, Vrijeme, RacunID) VALUES (@KupacID, @Suma, @Ukupno, @Vrijeme, @RacunID)", con);
            cmd.Parameters.AddWithValue("@KupacID", kupacID);
            cmd.Parameters.AddWithValue("@Suma", suma);
            cmd.Parameters.AddWithValue("@Ukupno", iznos);
            cmd.Parameters.AddWithValue("@Vrijeme", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@RacunID", racunID);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void AzurirajStanjeRacunaISkladista(int racunID, DataGridViewRowCollection stavkeRacuna)
        {
            cmd = new SqlCommand("UPDATE Racuns SET Status = 'obraden' WHERE ID = @ID", con);
            con.Open();
            cmd.Parameters.AddWithValue("@ID", racunID);
            cmd.ExecuteNonQuery();
            foreach (DataGridViewRow row in stavkeRacuna)
            {
                cmd = new SqlCommand("UPDATE Artikli_u_skladistu SET Kolicina = Kolicina - @Kolicina WHERE Artikl_ID = @ArtiklID ", con);
                cmd.Parameters.AddWithValue("@Kolicina", row.Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@ArtiklID", row.Cells[4].Value.ToString());
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}
