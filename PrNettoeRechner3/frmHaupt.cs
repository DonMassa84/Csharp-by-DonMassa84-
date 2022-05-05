using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrNettoeRechner3
{
    public partial class frmHaupt : Form
    {
        public frmHaupt()
        {
            InitializeComponent();
        }

        private void ProgrammEnde_Click(object sender, EventArgs e)
        {
            DialogResult  result = MessageBox.Show("Wollen Sie die Anwendung wirklich verlassen?",
                "Information von der Applikation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btoBerechnen_Click(object sender, EventArgs e)
        {
            double dblBrutto, dblSteuer, dblNetto;

            if (double.TryParse(this.txtBrutto.Text,out dblBrutto))
            {
                if (double.TryParse(this.txtSteuer.Text, out dblSteuer))
                {
                    dblNetto = dblBrutto - ((dblSteuer / 100) * dblBrutto);
                    this.txtNetto.Text = dblNetto.ToString("N2");
                }
                else
                {
                    this.txtSteuer.Text = null;
                    MessageBox.Show("Der Steuerwert ist ungültig");
                    this.txtSteuer.Focus();
                }
            }
                    
                   else
                   { this.txtBrutto = null; 
                    
                    MessageBox.Show("Der Bruttowert ist ungültig");
                    this.txtBrutto.Focus();
                   }
          
           
                
        }

        private void btoNeueBerechnung_Click(object sender, EventArgs e)
        {
            this.txtBrutto.Clear();
            this.txtNetto.Clear();
            this.txtSteuer.Clear();

            this.txtBrutto.Focus();
        }
    }
}
