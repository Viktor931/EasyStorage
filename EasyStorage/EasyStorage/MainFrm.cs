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
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=EasyStorageDB;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int IDArtikl = -1;
        public MainFrm()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select Artikls.ID, Artikls.Naziv, Artikls.Datum, Artikli_u_skladistu.Kolicina from Artikls, Artikli_u_skladistu where Artikls.ID = Artikli_u_skladistu.Artikl_ID", con);
            adapt.Fill(dt);
            dataGridViewArtikli.DataSource = dt;
            dataGridViewArtikli.Columns[0].Visible = false;
            con.Close();
        }

        private void ClearFields()
        {
            NazivArtiklaTxtbx.Text = "";
            KolicinaTxtbx.Text = "";
        }
        private void DodajBtn_Click(object sender, EventArgs e)
        {
            if(NazivArtiklaTxtbx.Text != "" || KolicinaTxtbx.Text != "")
            {
                float f;
                if (float.TryParse(KolicinaTxtbx.Text, out f) && f >= 0)
                {
                    cmd = new SqlCommand("INSERT INTO Artikls(Naziv, Datum) OUTPUT INSERTED.ID VALUES(@Naziv, @Datum)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@Naziv", NazivArtiklaTxtbx.Text);
                    cmd.Parameters.AddWithValue("@Datum", DateTime.Now.ToString());
                    int id = (int)cmd.ExecuteScalar();
                    cmd = new SqlCommand("INSERT INTO Artikli_u_skladistu(Kolicina, Artikl_ID) VALUES(@Kolicina, @Artikl_ID)", con);
                    cmd.Parameters.AddWithValue("@Kolicina", KolicinaTxtbx.Text);
                    cmd.Parameters.AddWithValue("@Artikl_ID", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DisplayData();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Količina mora biti broj veći ili jednak 0");
                    KolicinaTxtbx.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Oba polja moraju biti popunjena");
            }
        }

        private void AzurirajBtn_Click(object sender, EventArgs e)
        {
            if(KolicinaTxtbx.Text != "" || NazivArtiklaTxtbx.Text != "")
            {
                float f;
                if (float.TryParse(KolicinaTxtbx.Text, out f) && f >= 0)
                {
                    if (IDArtikl >= 0)
                    {
                        cmd = new SqlCommand("SELECT COUNT(*) FROM Artikls, Artikli_u_skladistu WHERE Artikls.ID = @IDArtikl AND Artikls.ID = Artikli_u_skladistu.Artikl_ID", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@IDArtikl", IDArtikl);
                        Int32 count = (Int32)cmd.ExecuteScalar();
                        con.Close();
                        if(count == 1)
                        {
                            cmd = new SqlCommand("UPDATE Artikls SET Naziv = @Naziv WHERE ID = @IDArtikl", con);
                            con.Open();
                            cmd.Parameters.AddWithValue("@Naziv", NazivArtiklaTxtbx.Text);
                            cmd.Parameters.AddWithValue("@IDArtikl", IDArtikl);
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = "UPDATE Artikli_u_skladistu SET Kolicina = @Kolicina WHERE Artikl_ID = @Artikl";
                            cmd.Parameters.AddWithValue("@Kolicina", KolicinaTxtbx.Text);
                            cmd.Parameters.AddWithValue("@Artikl", IDArtikl);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            DisplayData();
                            ClearFields();
                            IDArtikl = -1;
                        }
                        else
                        {
                            MessageBox.Show("Nije pronađen artikl za ažuriranje");
                            IDArtikl = -1;
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
                    KolicinaTxtbx.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Polja ne smiju biti prazna");
            }
        }

        private void ObrisiBtn_Click(object sender, EventArgs e)
        {
            if(IDArtikl >= 0)
            {
                cmd = new SqlCommand("DELETE FROM Artikli_u_skladistu WHERE Artikl_ID = @ID", con);
                con.Open();
                cmd.Parameters.AddWithValue("@ID", IDArtikl);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                ClearFields();
                IDArtikl = -1;
            }
            else
            {
                MessageBox.Show("Artikl nije selektiran");
            }
        }

        private void dataGridViewArtikli_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            int id = Convert.ToInt32(dataGridViewArtikli.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (id == IDArtikl)
            {
                IDArtikl = -1;
                NazivArtiklaTxtbx.Text = "";
                KolicinaTxtbx.Text = "";
                dataGridViewArtikli.Rows[e.RowIndex].Selected = false;
                return;
            }
            else
            {
                IDArtikl = id;
                NazivArtiklaTxtbx.Text = dataGridViewArtikli.Rows[e.RowIndex].Cells[1].Value.ToString();
                KolicinaTxtbx.Text = dataGridViewArtikli.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            //dgvGrid.Rows[index].Selected = true;
        }

        private void dataGridViewArtikli_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewArtikli.ClearSelection();
        }
    }
}
