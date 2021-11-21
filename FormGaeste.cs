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
    public partial class FormGaeste : Form
    {
        public FormGaeste()
        {
            InitializeComponent();
        }

        SqlConnection verbindung = new SqlConnection(@"Data Source=DESKTOP-DEV-E\SQLEXPRESS;Initial Catalog=GBFDB;Integrated Security=True");

        private void zeigedaten()
        {
            listView1.Items.Clear();
            verbindung.Open();
            SqlCommand befehl = new SqlCommand("select * from GaesteHinzufuegen", verbindung);
            SqlDataReader lesen = befehl.ExecuteReader();

            while (lesen.Read())
            {
                ListViewItem hinzuFuegen = new ListViewItem();
                hinzuFuegen.Text = lesen["GaesteId"].ToString();
                hinzuFuegen.SubItems.Add(lesen["Vorname"].ToString());
                hinzuFuegen.SubItems.Add(lesen["Name"].ToString());
                hinzuFuegen.SubItems.Add(lesen["Geschlecht"].ToString());
                hinzuFuegen.SubItems.Add(lesen["Telefon"].ToString());
                hinzuFuegen.SubItems.Add(lesen["Mail"].ToString());
                hinzuFuegen.SubItems.Add(lesen["Ausweisnummer"].ToString());
                hinzuFuegen.SubItems.Add(lesen["Zimmernummer"].ToString());
                hinzuFuegen.SubItems.Add(lesen["Preis"].ToString());
                hinzuFuegen.SubItems.Add(lesen["EingangsDatum"].ToString());
                hinzuFuegen.SubItems.Add(lesen["AusgangsDatum"].ToString());

                listView1.Items.Add(hinzuFuegen);
            }
            verbindung.Close();
        }

        private void BtnListeGBuch_Click(object sender, EventArgs e)
        {
            zeigedaten();
        }


        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtVname.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtName.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CmbGeschlecht.Text = listView1.SelectedItems[0].SubItems[3].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtAuswnum.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtZimmernum.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtPreis.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpEingangsDat.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpAusgangsDat.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnEntf_Click(object sender, EventArgs e)
        {   //Zimmer 101
            if (TxtZimmernum.Text == "101")
            {
                verbindung.Open();
                SqlCommand befehl = new SqlCommand("delete from Zimmer101", verbindung);
                befehl.ExecuteNonQuery();
                verbindung.Close();
                zeigedaten();
            }

            //Zimmer 102
            if (TxtZimmernum.Text == "102")
            {
                verbindung.Open();
                SqlCommand befehl = new SqlCommand("delete from Zimmer102", verbindung);
                befehl.ExecuteNonQuery();
                verbindung.Close();
                zeigedaten();
            }

            //Zimmer 103
            if (TxtZimmernum.Text == "103")
            {
                verbindung.Open();
                SqlCommand befehl = new SqlCommand("delete from Zimmer103", verbindung);
                befehl.ExecuteNonQuery();
                verbindung.Close();
                zeigedaten();
            }

            //Zimmer 104
            if (TxtZimmernum.Text == "104")
            {
                verbindung.Open();
                SqlCommand befehl = new SqlCommand("delete from Zimmer104", verbindung);
                befehl.ExecuteNonQuery();
                verbindung.Close();
                zeigedaten();
            }

            //Zimmer 105
            if (TxtZimmernum.Text == "105")
            {
                verbindung.Open();
                SqlCommand befehl = new SqlCommand("delete from Zimmer105", verbindung);
                befehl.ExecuteNonQuery();
                verbindung.Close();
                zeigedaten();
            }

            //Zimmer 106
            if (TxtZimmernum.Text == "106")
            {
                verbindung.Open();
                SqlCommand befehl = new SqlCommand("delete from Zimmer106", verbindung);
                befehl.ExecuteNonQuery();
                verbindung.Close();
                zeigedaten();
            }

            //Zimmer 107
            if (TxtZimmernum.Text == "107")
            {
                verbindung.Open();
                SqlCommand befehl = new SqlCommand("delete from Zimmer107", verbindung);
                befehl.ExecuteNonQuery();
                verbindung.Close();
                zeigedaten();
            }

            //Zimmer 108
            if (TxtZimmernum.Text == "108")
            {
                verbindung.Open();
                SqlCommand befehl = new SqlCommand("delete from Zimmer108", verbindung);
                befehl.ExecuteNonQuery();
                verbindung.Close();
                zeigedaten();
            }

            //Zimmer 109
            if (TxtZimmernum.Text == "109")
            {
                verbindung.Open();
                SqlCommand befehl = new SqlCommand("delete from Zimmer109", verbindung);
                befehl.ExecuteNonQuery();
                verbindung.Close();
                zeigedaten();
            }
        }

        private void BtnAkt_Click(object sender, EventArgs e)
        {
            TxtVname.Clear();
            TxtName.Clear();
            CmbGeschlecht.Text = "";
            MskTxtTelefon.Clear();
            TxtMail.Clear();
            TxtAuswnum.Clear();
            TxtZimmernum.Clear();
            TxtPreis.Clear();
            DtpEingangsDat.Text = "";
            DtpAusgangsDat.Text = "";
            //ZeigeDATEN()?
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            verbindung.Open();
            SqlCommand befehl = new SqlCommand("update GaesteHinzufuegen set Vorname='" + TxtVname.Text + "',Name='" + TxtName.Text + "',Geschlecht='" + CmbGeschlecht.Text + "',Telefon='" + MskTxtTelefon.Text + "',Mail='" + TxtMail.Text + "',Ausweisnummer='" + TxtAuswnum.Text + "',Zimmernummer='" + TxtZimmernum.Text + "',Preis='" + TxtPreis.Text + "',EingangsDatum='" + DtpEingangsDat.Value.ToString("yyyy-MM-dd") + "',AusgangsDatum='" + DtpAusgangsDat.Value.ToString("yyyy-MM-dd") + "' where GaesteId =" + id + "", verbindung);
            befehl.ExecuteNonQuery();
            verbindung.Close();
            zeigedaten();
        }

        private void BtnSuche_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            verbindung.Open();
            SqlCommand befehl = new SqlCommand("select * from GaesteHinzufuegen where Ausweisnummer like '%"+textBox1.Text+"%'", verbindung);
            SqlDataReader lesen = befehl.ExecuteReader();

            while (lesen.Read())
            {
                ListViewItem hinzuFuegen = new ListViewItem();
                hinzuFuegen.Text = lesen["GaesteId"].ToString();
                hinzuFuegen.SubItems.Add(lesen["Vorname"].ToString());
                hinzuFuegen.SubItems.Add(lesen["Name"].ToString());
                hinzuFuegen.SubItems.Add(lesen["Geschlecht"].ToString());
                hinzuFuegen.SubItems.Add(lesen["Telefon"].ToString());
                hinzuFuegen.SubItems.Add(lesen["Mail"].ToString());
                hinzuFuegen.SubItems.Add(lesen["Ausweisnummer"].ToString());
                hinzuFuegen.SubItems.Add(lesen["Zimmernummer"].ToString());
                hinzuFuegen.SubItems.Add(lesen["Preis"].ToString());
                hinzuFuegen.SubItems.Add(lesen["EingangsDatum"].ToString());
                hinzuFuegen.SubItems.Add(lesen["AusgangsDatum"].ToString());

                listView1.Items.Add(hinzuFuegen);
            }
            verbindung.Close();
        }
    }
}
//Data Source=DESKTOP-DEV-E\SQLEXPRESS;Initial Catalog=GBFDB;Integrated Security=True

//SqlCommand befehl = new SqlCommand("delete from GaesteHinzufuegen where GaesteId= (" + id + ")", verbindung);