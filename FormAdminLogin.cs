using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaeste_Buchung_und_Fuerung
{
    public partial class FormAdminLogin : Form
    {
        public FormAdminLogin()
        {
            InitializeComponent();
        }

        private void BtnEingangBestaetigen_Click(object sender, EventArgs e)
        {
            if (TxtNutzerName.Text == "admin" && TxtPasswort.Text == "12345")
            {
                FormHauptForm frm = new FormHauptForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nutzername oder Passwort wurde nicht Korrekt eingegeben");
            }
        }
    }
}
