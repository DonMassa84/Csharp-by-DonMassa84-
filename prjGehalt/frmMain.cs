using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace prjGehalt
{
    public partial class frmMain : Form
    {
        private ArrayList listeEingabe;
        public frmMain()
        {
            InitializeComponent();
            this.listeEingabe = new ArrayList();

        }

        private void btnHinzufügen_Click(object sender, EventArgs e)
        {
            Person person = new Person(this.txtName.Text,Convert.ToInt32(this.txtAlter.Text),
                Convert.ToInt32(this.txtGehalt.Text));

            this.listeEingabe.Add(person);
            AnzeigenListe(this.listeEingabe);

            this.txtName.Clear();
            this.txtAlter.Clear();
            this.txtGehalt.Clear();
        }
    }
}
