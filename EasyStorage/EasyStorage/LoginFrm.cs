using System;
using System.Windows.Forms;

namespace EasyStorage
{
    public partial class LoginFrm : Form
    {
        private KorisnikDatabase database = Program.GetKorisnikDatabase();
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string status = database.GetKorisnikStatus(KImeTxtbx.Text, LozinkaTxtbx.Text);
            if (string.IsNullOrEmpty(status))
            {
                KImeTxtbx.Text = "";
                LozinkaTxtbx.Text = "";
                return;
            }
            this.Hide();
            var form2 = new MainFrm(status);
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
