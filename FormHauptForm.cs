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
    public partial class FormHauptForm : Form
    {
        public FormHauptForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminLogin frm = new FormAdminLogin();          
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormNeuerGast frm = new FormNeuerGast();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormZimmer frm = new FormZimmer();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormGaeste frm = new FormGaeste();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gaeste Buchung und Fuerung");
        }
    }
}
