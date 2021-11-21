
namespace Gaeste_Buchung_und_Fuerung
{
    partial class FormNeuerGast
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CmbGeschlecht = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtPreis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnSpeichern = new System.Windows.Forms.Button();
            this.DtpAusgangsDat = new System.Windows.Forms.DateTimePicker();
            this.DtpEingangsDat = new System.Windows.Forms.DateTimePicker();
            this.MskTxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtZimmernum = new System.Windows.Forms.TextBox();
            this.TxtAuswnum = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtVname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnZim109 = new System.Windows.Forms.Button();
            this.BtnZim108 = new System.Windows.Forms.Button();
            this.BtnZim107 = new System.Windows.Forms.Button();
            this.BtnZim106 = new System.Windows.Forms.Button();
            this.BtnZim105 = new System.Windows.Forms.Button();
            this.BtnZim104 = new System.Windows.Forms.Button();
            this.BtnZim103 = new System.Windows.Forms.Button();
            this.BtnZim102 = new System.Windows.Forms.Button();
            this.BtnZim101 = new System.Windows.Forms.Button();
            this.BtnZimLeer = new System.Windows.Forms.Button();
            this.BtnZimBelegt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.CmbGeschlecht);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtPreis);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.BtnSpeichern);
            this.groupBox1.Controls.Add(this.DtpAusgangsDat);
            this.groupBox1.Controls.Add(this.DtpEingangsDat);
            this.groupBox1.Controls.Add(this.MskTxtTelefon);
            this.groupBox1.Controls.Add(this.TxtZimmernum);
            this.groupBox1.Controls.Add(this.TxtAuswnum);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.TxtVname);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kunden Daten";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(405, 410);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "0";
            this.label11.Visible = false;
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
            this.CmbGeschlecht.Location = new System.Drawing.Point(125, 100);
            this.CmbGeschlecht.Name = "CmbGeschlecht";
            this.CmbGeschlecht.Size = new System.Drawing.Size(254, 28);
            this.CmbGeschlecht.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Geschlecht:";
            // 
            // TxtPreis
            // 
            this.TxtPreis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtPreis.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPreis.Location = new System.Drawing.Point(124, 246);
            this.TxtPreis.Name = "TxtPreis";
            this.TxtPreis.Size = new System.Drawing.Size(255, 27);
            this.TxtPreis.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(75, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Preis:";
            // 
            // BtnSpeichern
            // 
            this.BtnSpeichern.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSpeichern.Location = new System.Drawing.Point(182, 346);
            this.BtnSpeichern.Name = "BtnSpeichern";
            this.BtnSpeichern.Size = new System.Drawing.Size(96, 32);
            this.BtnSpeichern.TabIndex = 34;
            this.BtnSpeichern.Text = "Speichern";
            this.BtnSpeichern.UseVisualStyleBackColor = true;
            this.BtnSpeichern.Click += new System.EventHandler(this.BtnSpeichern_Click);
            // 
            // DtpAusgangsDat
            // 
            this.DtpAusgangsDat.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpAusgangsDat.Location = new System.Drawing.Point(124, 309);
            this.DtpAusgangsDat.Name = "DtpAusgangsDat";
            this.DtpAusgangsDat.Size = new System.Drawing.Size(257, 28);
            this.DtpAusgangsDat.TabIndex = 33;
            this.DtpAusgangsDat.ValueChanged += new System.EventHandler(this.DtpAusgangsDat_ValueChanged);
            // 
            // DtpEingangsDat
            // 
            this.DtpEingangsDat.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEingangsDat.Location = new System.Drawing.Point(124, 275);
            this.DtpEingangsDat.Name = "DtpEingangsDat";
            this.DtpEingangsDat.Size = new System.Drawing.Size(257, 28);
            this.DtpEingangsDat.TabIndex = 32;
            // 
            // MskTxtTelefon
            // 
            this.MskTxtTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MskTxtTelefon.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskTxtTelefon.Location = new System.Drawing.Point(125, 130);
            this.MskTxtTelefon.Mask = "(999) 000-0000000";
            this.MskTxtTelefon.Name = "MskTxtTelefon";
            this.MskTxtTelefon.Size = new System.Drawing.Size(255, 27);
            this.MskTxtTelefon.TabIndex = 31;
            // 
            // TxtZimmernum
            // 
            this.TxtZimmernum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtZimmernum.Enabled = false;
            this.TxtZimmernum.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtZimmernum.Location = new System.Drawing.Point(124, 218);
            this.TxtZimmernum.Name = "TxtZimmernum";
            this.TxtZimmernum.Size = new System.Drawing.Size(255, 27);
            this.TxtZimmernum.TabIndex = 30;
            // 
            // TxtAuswnum
            // 
            this.TxtAuswnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtAuswnum.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAuswnum.Location = new System.Drawing.Point(124, 188);
            this.TxtAuswnum.MaxLength = 50;
            this.TxtAuswnum.Name = "TxtAuswnum";
            this.TxtAuswnum.Size = new System.Drawing.Size(255, 27);
            this.TxtAuswnum.TabIndex = 29;
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtMail.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMail.Location = new System.Drawing.Point(124, 158);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(255, 27);
            this.TxtMail.TabIndex = 28;
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(125, 71);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(255, 27);
            this.TxtName.TabIndex = 27;
            // 
            // TxtVname
            // 
            this.TxtVname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtVname.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVname.Location = new System.Drawing.Point(125, 41);
            this.TxtVname.Name = "TxtVname";
            this.TxtVname.Size = new System.Drawing.Size(255, 27);
            this.TxtVname.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Ausgangs Datum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Eingangs Datum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Zimmernummer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ausweisnummer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Vorname:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnZim109);
            this.groupBox2.Controls.Add(this.BtnZim108);
            this.groupBox2.Controls.Add(this.BtnZim107);
            this.groupBox2.Controls.Add(this.BtnZim106);
            this.groupBox2.Controls.Add(this.BtnZim105);
            this.groupBox2.Controls.Add(this.BtnZim104);
            this.groupBox2.Controls.Add(this.BtnZim103);
            this.groupBox2.Controls.Add(this.BtnZim102);
            this.groupBox2.Controls.Add(this.BtnZim101);
            this.groupBox2.Location = new System.Drawing.Point(465, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 384);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zimmer";
            // 
            // BtnZim109
            // 
            this.BtnZim109.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnZim109.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZim109.Location = new System.Drawing.Point(205, 181);
            this.BtnZim109.Name = "BtnZim109";
            this.BtnZim109.Size = new System.Drawing.Size(53, 46);
            this.BtnZim109.TabIndex = 8;
            this.BtnZim109.Text = "109";
            this.BtnZim109.UseVisualStyleBackColor = false;
            this.BtnZim109.Click += new System.EventHandler(this.BtnZim109_Click);
            // 
            // BtnZim108
            // 
            this.BtnZim108.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnZim108.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZim108.Location = new System.Drawing.Point(112, 180);
            this.BtnZim108.Name = "BtnZim108";
            this.BtnZim108.Size = new System.Drawing.Size(53, 46);
            this.BtnZim108.TabIndex = 7;
            this.BtnZim108.Text = "108";
            this.BtnZim108.UseVisualStyleBackColor = false;
            this.BtnZim108.Click += new System.EventHandler(this.BtnZim108_Click);
            // 
            // BtnZim107
            // 
            this.BtnZim107.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnZim107.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZim107.Location = new System.Drawing.Point(21, 181);
            this.BtnZim107.Name = "BtnZim107";
            this.BtnZim107.Size = new System.Drawing.Size(52, 46);
            this.BtnZim107.TabIndex = 6;
            this.BtnZim107.Text = "107";
            this.BtnZim107.UseVisualStyleBackColor = false;
            this.BtnZim107.Click += new System.EventHandler(this.BtnZim107_Click);
            // 
            // BtnZim106
            // 
            this.BtnZim106.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnZim106.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZim106.Location = new System.Drawing.Point(205, 105);
            this.BtnZim106.Name = "BtnZim106";
            this.BtnZim106.Size = new System.Drawing.Size(53, 45);
            this.BtnZim106.TabIndex = 5;
            this.BtnZim106.Text = "106";
            this.BtnZim106.UseVisualStyleBackColor = false;
            this.BtnZim106.Click += new System.EventHandler(this.BtnZim106_Click);
            // 
            // BtnZim105
            // 
            this.BtnZim105.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnZim105.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZim105.Location = new System.Drawing.Point(112, 105);
            this.BtnZim105.Name = "BtnZim105";
            this.BtnZim105.Size = new System.Drawing.Size(53, 45);
            this.BtnZim105.TabIndex = 4;
            this.BtnZim105.Text = "105";
            this.BtnZim105.UseVisualStyleBackColor = false;
            this.BtnZim105.Click += new System.EventHandler(this.BtnZim105_Click);
            // 
            // BtnZim104
            // 
            this.BtnZim104.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnZim104.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZim104.Location = new System.Drawing.Point(21, 106);
            this.BtnZim104.Name = "BtnZim104";
            this.BtnZim104.Size = new System.Drawing.Size(52, 44);
            this.BtnZim104.TabIndex = 3;
            this.BtnZim104.Text = "104";
            this.BtnZim104.UseVisualStyleBackColor = false;
            this.BtnZim104.Click += new System.EventHandler(this.BtnZim104_Click);
            // 
            // BtnZim103
            // 
            this.BtnZim103.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnZim103.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZim103.Location = new System.Drawing.Point(205, 31);
            this.BtnZim103.Name = "BtnZim103";
            this.BtnZim103.Size = new System.Drawing.Size(53, 45);
            this.BtnZim103.TabIndex = 2;
            this.BtnZim103.Text = "103";
            this.BtnZim103.UseVisualStyleBackColor = false;
            this.BtnZim103.Click += new System.EventHandler(this.BtnZim103_Click);
            // 
            // BtnZim102
            // 
            this.BtnZim102.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnZim102.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZim102.Location = new System.Drawing.Point(112, 30);
            this.BtnZim102.Name = "BtnZim102";
            this.BtnZim102.Size = new System.Drawing.Size(53, 45);
            this.BtnZim102.TabIndex = 1;
            this.BtnZim102.Text = "102";
            this.BtnZim102.UseVisualStyleBackColor = false;
            this.BtnZim102.Click += new System.EventHandler(this.BtnZim102_Click);
            // 
            // BtnZim101
            // 
            this.BtnZim101.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnZim101.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZim101.Location = new System.Drawing.Point(21, 31);
            this.BtnZim101.Name = "BtnZim101";
            this.BtnZim101.Size = new System.Drawing.Size(52, 47);
            this.BtnZim101.TabIndex = 0;
            this.BtnZim101.Text = "101";
            this.BtnZim101.UseVisualStyleBackColor = false;
            this.BtnZim101.Click += new System.EventHandler(this.BtnZim101_Click);
            // 
            // BtnZimLeer
            // 
            this.BtnZimLeer.BackColor = System.Drawing.Color.GreenYellow;
            this.BtnZimLeer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZimLeer.Location = new System.Drawing.Point(692, 403);
            this.BtnZimLeer.Name = "BtnZimLeer";
            this.BtnZimLeer.Size = new System.Drawing.Size(75, 46);
            this.BtnZimLeer.TabIndex = 9;
            this.BtnZimLeer.Text = "Leer";
            this.BtnZimLeer.UseVisualStyleBackColor = false;
            this.BtnZimLeer.Click += new System.EventHandler(this.BtnLeerZim_Click);
            // 
            // BtnZimBelegt
            // 
            this.BtnZimBelegt.BackColor = System.Drawing.Color.Red;
            this.BtnZimBelegt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZimBelegt.Location = new System.Drawing.Point(773, 403);
            this.BtnZimBelegt.Name = "BtnZimBelegt";
            this.BtnZimBelegt.Size = new System.Drawing.Size(75, 46);
            this.BtnZimBelegt.TabIndex = 10;
            this.BtnZimBelegt.Text = "Belegt";
            this.BtnZimBelegt.UseVisualStyleBackColor = false;
            this.BtnZimBelegt.Click += new System.EventHandler(this.BtnVollZim_Click);
            // 
            // FormNeuerGast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(186)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(872, 461);
            this.Controls.Add(this.BtnZimLeer);
            this.Controls.Add(this.BtnZimBelegt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNeuerGast";
            this.Text = "Gast Neu Hinzufügen";
            this.Load += new System.EventHandler(this.FormNeuerGast_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSpeichern;
        private System.Windows.Forms.DateTimePicker DtpAusgangsDat;
        private System.Windows.Forms.DateTimePicker DtpEingangsDat;
        private System.Windows.Forms.MaskedTextBox MskTxtTelefon;
        private System.Windows.Forms.TextBox TxtZimmernum;
        private System.Windows.Forms.TextBox TxtAuswnum;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtVname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnZim109;
        private System.Windows.Forms.Button BtnZim108;
        private System.Windows.Forms.Button BtnZim107;
        private System.Windows.Forms.Button BtnZim106;
        private System.Windows.Forms.Button BtnZim105;
        private System.Windows.Forms.Button BtnZim104;
        private System.Windows.Forms.Button BtnZim103;
        private System.Windows.Forms.Button BtnZim102;
        private System.Windows.Forms.Button BtnZim101;
        private System.Windows.Forms.Button BtnZimLeer;
        private System.Windows.Forms.Button BtnZimBelegt;
        private System.Windows.Forms.TextBox TxtPreis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbGeschlecht;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}