
namespace Gaeste_Buchung_und_Fuerung
{
    partial class FormGaeste
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnListeGBuch = new System.Windows.Forms.Button();
            this.BtnAkt = new System.Windows.Forms.Button();
            this.BtnEntf = new System.Windows.Forms.Button();
            this.BtnSuche = new System.Windows.Forms.Button();
            this.CmbGeschlecht = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MskTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtZimmernum = new System.Windows.Forms.TextBox();
            this.TxtAuswnum = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtVname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPreis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DtpAusgangsDat = new System.Windows.Forms.DateTimePicker();
            this.DtpEingangsDat = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 260);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1113, 224);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nr.";
            this.columnHeader1.Width = 39;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Vorname";
            this.columnHeader2.Width = 69;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 114;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Geschlecht";
            this.columnHeader4.Width = 82;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefon";
            this.columnHeader5.Width = 84;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mail";
            this.columnHeader6.Width = 83;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ausweisnummer";
            this.columnHeader7.Width = 129;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Zimmernummer";
            this.columnHeader8.Width = 112;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Preis";
            this.columnHeader9.Width = 64;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Eingangs Datum";
            this.columnHeader10.Width = 125;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Ausgangs Datum";
            this.columnHeader11.Width = 123;
            // 
            // BtnListeGBuch
            // 
            this.BtnListeGBuch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListeGBuch.Location = new System.Drawing.Point(12, 12);
            this.BtnListeGBuch.Name = "BtnListeGBuch";
            this.BtnListeGBuch.Size = new System.Drawing.Size(153, 30);
            this.BtnListeGBuch.TabIndex = 1;
            this.BtnListeGBuch.Text = "Liste Gäste Buch";
            this.BtnListeGBuch.UseVisualStyleBackColor = true;
            this.BtnListeGBuch.Click += new System.EventHandler(this.BtnListeGBuch_Click);
            // 
            // BtnAkt
            // 
            this.BtnAkt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAkt.Location = new System.Drawing.Point(12, 83);
            this.BtnAkt.Name = "BtnAkt";
            this.BtnAkt.Size = new System.Drawing.Size(153, 30);
            this.BtnAkt.TabIndex = 2;
            this.BtnAkt.Text = "Aktualisieren";
            this.BtnAkt.UseVisualStyleBackColor = true;
            this.BtnAkt.Click += new System.EventHandler(this.BtnAkt_Click);
            // 
            // BtnEntf
            // 
            this.BtnEntf.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntf.Location = new System.Drawing.Point(12, 47);
            this.BtnEntf.Name = "BtnEntf";
            this.BtnEntf.Size = new System.Drawing.Size(153, 30);
            this.BtnEntf.TabIndex = 3;
            this.BtnEntf.Text = "Eintrag Entfernen";
            this.BtnEntf.UseVisualStyleBackColor = true;
            this.BtnEntf.Click += new System.EventHandler(this.BtnEntf_Click);
            // 
            // BtnSuche
            // 
            this.BtnSuche.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSuche.Location = new System.Drawing.Point(12, 155);
            this.BtnSuche.Name = "BtnSuche";
            this.BtnSuche.Size = new System.Drawing.Size(153, 30);
            this.BtnSuche.TabIndex = 4;
            this.BtnSuche.Text = "Suche";
            this.BtnSuche.UseVisualStyleBackColor = true;
            this.BtnSuche.Click += new System.EventHandler(this.BtnSuche_Click);
            // 
            // CmbGeschlecht
            // 
            this.CmbGeschlecht.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CmbGeschlecht.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbGeschlecht.FormattingEnabled = true;
            this.CmbGeschlecht.Items.AddRange(new object[] {
            "Männlich",
            "Weiblich",
            "als Frau geboren, jetzt Männlich",
            "als Mann geboren, jetzt Weiblich",
            "ohne Geschlechterrolle",
            "andere Identität"});
            this.CmbGeschlecht.Location = new System.Drawing.Point(447, 71);
            this.CmbGeschlecht.Name = "CmbGeschlecht";
            this.CmbGeschlecht.Size = new System.Drawing.Size(254, 28);
            this.CmbGeschlecht.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(365, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "Geschlecht:";
            // 
            // MskTxtTelefon
            // 
            this.MskTxtTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MskTxtTelefon.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskTxtTelefon.Location = new System.Drawing.Point(447, 101);
            this.MskTxtTelefon.Mask = "(999) 000-0000000";
            this.MskTxtTelefon.Name = "MskTxtTelefon";
            this.MskTxtTelefon.Size = new System.Drawing.Size(255, 27);
            this.MskTxtTelefon.TabIndex = 50;
            // 
            // TxtZimmernum
            // 
            this.TxtZimmernum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtZimmernum.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtZimmernum.Location = new System.Drawing.Point(446, 189);
            this.TxtZimmernum.Name = "TxtZimmernum";
            this.TxtZimmernum.Size = new System.Drawing.Size(255, 27);
            this.TxtZimmernum.TabIndex = 49;
            // 
            // TxtAuswnum
            // 
            this.TxtAuswnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtAuswnum.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAuswnum.Location = new System.Drawing.Point(446, 159);
            this.TxtAuswnum.MaxLength = 50;
            this.TxtAuswnum.Name = "TxtAuswnum";
            this.TxtAuswnum.Size = new System.Drawing.Size(255, 27);
            this.TxtAuswnum.TabIndex = 48;
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtMail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMail.Location = new System.Drawing.Point(446, 129);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(255, 27);
            this.TxtMail.TabIndex = 47;
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(447, 42);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(255, 27);
            this.TxtName.TabIndex = 46;
            // 
            // TxtVname
            // 
            this.TxtVname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtVname.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVname.Location = new System.Drawing.Point(447, 12);
            this.TxtVname.Name = "TxtVname";
            this.TxtVname.Size = new System.Drawing.Size(255, 27);
            this.TxtVname.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Zimmernummer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Ausweisnummer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Vorname:";
            // 
            // TxtPreis
            // 
            this.TxtPreis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtPreis.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPreis.Location = new System.Drawing.Point(845, 10);
            this.TxtPreis.Name = "TxtPreis";
            this.TxtPreis.Size = new System.Drawing.Size(255, 27);
            this.TxtPreis.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(796, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 57;
            this.label9.Text = "Preis:";
            // 
            // DtpAusgangsDat
            // 
            this.DtpAusgangsDat.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpAusgangsDat.Location = new System.Drawing.Point(845, 73);
            this.DtpAusgangsDat.Name = "DtpAusgangsDat";
            this.DtpAusgangsDat.Size = new System.Drawing.Size(257, 28);
            this.DtpAusgangsDat.TabIndex = 56;
            // 
            // DtpEingangsDat
            // 
            this.DtpEingangsDat.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEingangsDat.Location = new System.Drawing.Point(845, 39);
            this.DtpEingangsDat.Name = "DtpEingangsDat";
            this.DtpEingangsDat.Size = new System.Drawing.Size(257, 28);
            this.DtpEingangsDat.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(723, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "Ausgangs Datum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(725, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Eingangs Datum:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(114, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 27);
            this.textBox1.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 17);
            this.label11.TabIndex = 59;
            this.label11.Text = "Ausweisnummer:";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.Location = new System.Drawing.Point(12, 119);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(153, 30);
            this.BtnEdit.TabIndex = 61;
            this.BtnEdit.Text = "Editieren";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // FormGaeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1114, 485);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtPreis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DtpAusgangsDat);
            this.Controls.Add(this.DtpEingangsDat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbGeschlecht);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MskTxtTelefon);
            this.Controls.Add(this.TxtZimmernum);
            this.Controls.Add(this.TxtAuswnum);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtVname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSuche);
            this.Controls.Add(this.BtnEntf);
            this.Controls.Add(this.BtnAkt);
            this.Controls.Add(this.BtnListeGBuch);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGaeste";
            this.Text = "Gäste Informationen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button BtnListeGBuch;
        private System.Windows.Forms.Button BtnAkt;
        private System.Windows.Forms.Button BtnEntf;
        private System.Windows.Forms.Button BtnSuche;
        private System.Windows.Forms.ComboBox CmbGeschlecht;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox MskTxtTelefon;
        private System.Windows.Forms.TextBox TxtZimmernum;
        private System.Windows.Forms.TextBox TxtAuswnum;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtVname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPreis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DtpAusgangsDat;
        private System.Windows.Forms.DateTimePicker DtpEingangsDat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnEdit;
    }
}