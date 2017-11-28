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
    public partial class LoginFrm : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=EasyStorageDB;Integrated Security=true;");
        private SqlDataAdapter adapt;
        private SqlCommand cmd;

        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT Status FROM Korisnik WHERE Korisnik.Korisnik = @KIme AND Korisnik.Lozinka = @Lozinka", con);
            cmd.Parameters.AddWithValue("@KIme", KImeTxtbx.Text);
            cmd.Parameters.AddWithValue("@Lozinka", LozinkaTxtbx.Text);
            string str = (string) cmd.ExecuteScalar();
            con.Close();
            if (string.IsNullOrEmpty(str))
            {
                KImeTxtbx.Text = "";
                LozinkaTxtbx.Text = "";
                return;
            }
            this.Hide();
            var form2 = new MainFrm(str);
            form2.Closed += (s, args) =>
            {
                KImeTxtbx.Text = "";
                LozinkaTxtbx.Text = "";
                this.ActiveControl = KImeTxtbx;
                this.Show();
            };
            form2.Show();
        }
    }
}
