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
using Datenzugriff;

namespace prjLogin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEnde_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("wollen Sie die Anwendung wirklich verlassen ?",
            "Information von der :" + this.Text,
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtBenutzer.Text == "")
            {
                MessageBox.Show("Bitte Benutzername eingeben!", "Fehler vom Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtBenutzer.Focus();
                return;
            }

            if (this.txtPasswort.Text == "")
            {
                MessageBox.Show("Bitte Passwort eingeben!", "Fehler vom Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPasswort.Focus();
                return;
            }

            try
            {
                DataTable dtlogin = Dzgrf.ExecuteDataTable("uspLogin", new SqlParameter("@Benutzer", this.txtBenutzer.Text),
                                                                       new SqlParameter("@Passwort", this.txtPasswort.Text));
                if (dtlogin.Rows.Count == 1)
                {
                    MessageBox.Show("Sie haben sich erfolgreich angemeldet: " + this.txtBenutzer.Text, "Systemmeldung",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                    new frmMain().Show(this);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login nicht erfolgreich bitte nochmals!", "Zugriff verweigert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtBenutzer.Clear();
                    this.txtPasswort.Clear();
                    this.txtBenutzer.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}