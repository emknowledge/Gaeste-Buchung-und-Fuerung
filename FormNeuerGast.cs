using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Gaeste_Buchung_und_Fuerung
{
    public partial class FormNeuerGast : Form
    {
        public FormNeuerGast()
        {
            InitializeComponent();
        }

        SqlConnection verbindung = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=GBFDB;Integrated Security=True");

        private void BtnZim101_Click(object sender, EventArgs e)                // Eintrag Vornamen und Namen der Gäste ins Zimmer Tabelle vor dem Button speichern aller Datensätze
        {
            TxtZimmernum.Text = "101";
            verbindung.Open();
            SqlCommand befehl = new SqlCommand("insert into Zimmer101 (Vorname,Name) values ('" + TxtVname.Text + "','" + TxtName.Text + "')", verbindung);
            befehl.ExecuteNonQuery();
            verbindung.Close();
        }

        private void BtnZim102_Click(object sender, EventArgs e)
        {
            TxtZimmernum.Text = "102";
            verbindung.Open();
            SqlCommand befehl = new SqlCommand("insert into Zimmer102 (Vorname,Name) values ('" + TxtVname.Text + "','" + TxtName.Text + "')", verbindung);
            befehl.ExecuteNonQuery();
            verbindung.Close();
        }

        private void BtnZim103_Click(object sender, EventArgs e)
        {
            TxtZimmernum.Text = "103";
            verbindung.Open();
            SqlCommand befehl = new SqlCommand("insert into Zimmer103 (Vorname,Name) values ('" + TxtVname.Text + "','" + TxtName.Text + "')", verbindung);
            befehl.ExecuteNonQuery();
            verbindung.Close();
        }

        private void BtnZim104_Click(object sender, EventArgs e)
        {
            TxtZimmernum.Text = "104";
            verbindung.Open();
            SqlCommand befehl = new SqlCommand("insert into Zimmer104 (Vorname,Name) values ('" + TxtVname.Text + "','" + TxtName.Text + "')", verbindung);
            befehl.ExecuteNonQuery();
            verbindung.Close();
        }

        private void BtnZim105_Click(object sender, EventArgs e)
        {
            TxtZimmernum.Text = "105";
            verbindung.Open();
            SqlCommand befehl = new SqlCommand("insert into Zimmer105 (Vorname,Name) values ('" + TxtVname.Text + "','" + TxtName.Text + "')",verbindung);
            befehl.ExecuteNonQuery();
            verbindung.Close();
        }

        private void BtnZim106_Click(object sender, EventArgs e)
        {
            TxtZimmernum.Text = "106";
            verbindung.Open();
            SqlCommand befehl = new SqlCommand("insert into Zimmer106 (Vorname,Name) values ('" + TxtVname.Text + "','" + TxtName.Text + "')", verbindung);
            befehl.ExecuteNonQuery();
            verbindung.Close();
        }

        private void BtnZim107_Click(object sender, EventArgs e)
        {
            TxtZimmernum.Text = "107";
            verbindung.Open();
            SqlCommand befehl = new SqlCommand("insert into Zimmer107 (Vorname,Name) values ('" + TxtVname.Text + "','" + TxtName.Text + "')", verbindung);
            befehl.ExecuteNonQuery();
            verbindung.Close();
        }

        private void BtnZim108_Click(object sender, EventArgs e)
        {
            TxtZimmernum.Text = "108";
            verbindung.Open();
            SqlCommand befehl = new SqlCommand("insert into Zimmer108 (Vorname,Name) values ('" + TxtVname.Text + "','" + TxtName.Text + "')", verbindung);
            befehl.ExecuteNonQuery();
            verbindung.Close();
        }

        private void BtnZim109_Click(object sender, EventArgs e)
        {
            TxtZimmernum.Text = "109";
            verbindung.Open();
            SqlCommand befehl = new SqlCommand("insert into Zimmer109 (Vorname,Name) values ('" + TxtVname.Text + "','" + TxtName.Text + "')", verbindung);
            befehl.ExecuteNonQuery();
            verbindung.Close();
        }

        private void BtnVollZim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Belegte Zimmer sind Rot gekennzeichnet");
        }

        private void BtnLeerZim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Leere Zimmer sind Grün gekennzeichnet ");
        }

        private void DtpAusgangsDat_ValueChanged(object sender, EventArgs e)
        {
            int Preis;
            DateTime KleinerDatum = Convert.ToDateTime(DtpEingangsDat.Text);
            DateTime GroeßerDatum = Convert.ToDateTime(DtpAusgangsDat.Text);

            TimeSpan Ergebnis = GroeßerDatum - KleinerDatum;                    //Errechnet den Unterschied zwischen zwei verschiedenen Zeiten im konvertiertem Kalender Format

            label11.Text = Ergebnis.TotalDays.ToString();                       // Speichert den zwischen Wert im fuer User nicht sichtbaren Label11 

            Preis = Convert.ToInt32(label11.Text) * 50;                         // Der Wert von Label11 wird Convertiert da es sich um ein Zeit&Datums Format handelt und er als Integer genutzt wird
            TxtPreis.Text = Preis.ToString();
        }

        private void BtnSpeichern_Click(object sender, EventArgs e)
        {
            verbindung.Open();
            SqlCommand befehl = new SqlCommand("insert into GaesteHinzufuegen (Vorname,Name,Geschlecht,Telefon,Mail,Ausweisnummer,Zimmernummer,Preis,EingangsDatum,AusgangsDatum) values('" + TxtVname.Text + "','" + TxtName.Text + "','" + CmbGeschlecht.Text + "','" + MskTxtTelefon.Text + "','" + TxtMail.Text + "','" + TxtAuswnum.Text + "','"+ TxtZimmernum.Text + "','" + TxtPreis.Text + "','"+ DtpEingangsDat.Value.ToString("yyyy-MM-dd") +"','"+ DtpAusgangsDat.Value.ToString("yyyy-MM-dd") +"')", verbindung);
            befehl.ExecuteNonQuery();
            verbindung.Close();
            MessageBox.Show("Eintrag Erfolgt!");
        }

        private void FormNeuerGast_Load(object sender, EventArgs e)
        {
            //Zimmer 101
            verbindung.Open();
            SqlCommand befehl1 = new SqlCommand("select *from zimmer101", verbindung);
            SqlDataReader lesen1 = befehl1.ExecuteReader();

            while (lesen1.Read())
            {
                BtnZim101.Text = lesen1["Vorname"].ToString() + " " + lesen1["Name"].ToString();
            }
            verbindung.Close();
            if (BtnZim101.Text != "101")
            {
                BtnZim101.BackColor = Color.Red;
                BtnZim101.Enabled = false;
            }

            //Zimmer 102
            verbindung.Open();
            SqlCommand befehl2 = new SqlCommand("select *from zimmer102", verbindung);
            SqlDataReader lesen2 = befehl2.ExecuteReader();

            while (lesen2.Read())
            {
                BtnZim102.Text = lesen2["Vorname"].ToString() + " " + lesen2["Name"].ToString();
            }
            verbindung.Close();
            if (BtnZim102.Text != "102")
            {
                BtnZim102.BackColor = Color.Red;
                BtnZim102.Enabled = false;
            }

            //Zimmer 103
            verbindung.Open();
            SqlCommand befehl3 = new SqlCommand("select *from zimmer103", verbindung);
            SqlDataReader lesen3 = befehl3.ExecuteReader();

            while (lesen3.Read())
            {
                BtnZim103.Text = lesen3["Vorname"].ToString() + " " + lesen3["Name"].ToString();
            }
            verbindung.Close();
            if (BtnZim103.Text != "103")
            {
                BtnZim103.BackColor = Color.Red;
                BtnZim103.Enabled = false;
            }

            //Zimmer 104
            verbindung.Open();
            SqlCommand befehl4 = new SqlCommand("select *from zimmer104", verbindung);
            SqlDataReader lesen4 = befehl4.ExecuteReader();

            while (lesen4.Read())
            {
                BtnZim104.Text = lesen4["Vorname"].ToString() + " " + lesen4["Name"].ToString();
            }
            verbindung.Close();
            if (BtnZim104.Text != "104")
            {
                BtnZim104.BackColor = Color.Red;
                BtnZim104.Enabled = false;
            }

            //Zimmer 105
            verbindung.Open();
            SqlCommand befehl5 = new SqlCommand("select *from zimmer105", verbindung);
            SqlDataReader lesen5 = befehl5.ExecuteReader();

            while (lesen5.Read())
            {
                BtnZim105.Text = lesen5["Vorname"].ToString() + " " + lesen5["Name"].ToString();
            }
            verbindung.Close();
            if (BtnZim105.Text != "105")
            {
                BtnZim105.BackColor = Color.Red;
                BtnZim105.Enabled = false;
            }

            //Zimmer 106
            verbindung.Open();
            SqlCommand befehl6 = new SqlCommand("select *from zimmer106", verbindung);
            SqlDataReader lesen6 = befehl6.ExecuteReader();

            while (lesen6.Read())
            {
                BtnZim106.Text = lesen6["Vorname"].ToString() + " " + lesen6["Name"].ToString();
            }
            verbindung.Close();
            if (BtnZim106.Text != "106")
            {
                BtnZim106.BackColor = Color.Red;
                BtnZim106.Enabled = false;
            }

            //Zimmer 107
            verbindung.Open();
            SqlCommand befehl7 = new SqlCommand("select *from zimmer107", verbindung);
            SqlDataReader lesen7 = befehl7.ExecuteReader();

            while (lesen7.Read())
            {
                BtnZim107.Text = lesen7["Vorname"].ToString() + " " + lesen7["Name"].ToString();
            }
            verbindung.Close();
            if (BtnZim107.Text != "107")
            {
                BtnZim107.BackColor = Color.Red;
                BtnZim107.Enabled = false;
            }

            //Zimmer 108
            verbindung.Open();
            SqlCommand befehl8 = new SqlCommand("select *from zimmer108", verbindung);
            SqlDataReader lesen8 = befehl8.ExecuteReader();

            while (lesen8.Read())
            {
                BtnZim108.Text = lesen8["Vorname"].ToString() + " " + lesen8["Name"].ToString();
            }
            verbindung.Close();
            if (BtnZim108.Text != "108")
            {
                BtnZim108.BackColor = Color.Red;
                BtnZim108.Enabled = false;
            }

            //Zimmer 109
            verbindung.Open();
            SqlCommand befehl9 = new SqlCommand("select *from zimmer109", verbindung);
            SqlDataReader lesen9 = befehl9.ExecuteReader();

            while (lesen9.Read())
            {
                BtnZim109.Text = lesen9["Vorname"].ToString() + " " + lesen9["Name"].ToString();
            }
            verbindung.Close();
            if (BtnZim109.Text != "109")
            {
                BtnZim109.BackColor = Color.Red;
                BtnZim109.Enabled = false;
            }
        }
    }
}
//Data Source=localhost\SQLEXPRESS;Initial Catalog=GBFDB;Integrated Security=True