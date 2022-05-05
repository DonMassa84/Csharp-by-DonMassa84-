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

        private void InitializeComponent()
        {
            this.lblLogin = new System.Windows.Forms.Button();
            this.lblEnde = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblBenutzerInfo = new System.Windows.Forms.Label();
            this.lblPasswort = new System.Windows.Forms.Label();
            this.lblBenutzername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.Location = new System.Drawing.Point(122, 161);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(75, 23);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            this.lblLogin.UseVisualStyleBackColor = true;
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblEnde
            // 
            this.lblEnde.Location = new System.Drawing.Point(259, 161);
            this.lblEnde.Name = "lblEnde";
            this.lblEnde.Size = new System.Drawing.Size(75, 23);
            this.lblEnde.TabIndex = 1;
            this.lblEnde.Text = "Ende";
            this.lblEnde.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lblBenutzerInfo
            // 
            this.lblBenutzerInfo.AutoSize = true;
            this.lblBenutzerInfo.Location = new System.Drawing.Point(119, 9);
            this.lblBenutzerInfo.Name = "lblBenutzerInfo";
            this.lblBenutzerInfo.Size = new System.Drawing.Size(116, 13);
            this.lblBenutzerInfo.TabIndex = 4;
            this.lblBenutzerInfo.Text = "Benutzer Informationen";
            // 
            // lblPasswort
            // 
            this.lblPasswort.AutoSize = true;
            this.lblPasswort.Location = new System.Drawing.Point(24, 122);
            this.lblPasswort.Name = "lblPasswort";
            this.lblPasswort.Size = new System.Drawing.Size(50, 13);
            this.lblPasswort.TabIndex = 5;
            this.lblPasswort.Text = "Passwort";
            // 
            // lblBenutzername
            // 
            this.lblBenutzername.AutoSize = true;
            this.lblBenutzername.Location = new System.Drawing.Point(24, 69);
            this.lblBenutzername.Name = "lblBenutzername";
            this.lblBenutzername.Size = new System.Drawing.Size(75, 13);
            this.lblBenutzername.TabIndex = 6;
            this.lblBenutzername.Text = "Benutzername";
            // 
            // frmLogin
            // 
            this.ClientSize = new System.Drawing.Size(551, 261);
            this.Controls.Add(this.lblBenutzername);
            this.Controls.Add(this.lblPasswort);
            this.Controls.Add(this.lblBenutzerInfo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEnde);
            this.Controls.Add(this.lblLogin);
            this.Name = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
