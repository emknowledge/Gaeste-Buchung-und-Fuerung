
namespace Gaeste_Buchung_und_Fuerung
{
    partial class FormAdminLogin
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNutzerName = new System.Windows.Forms.TextBox();
            this.TxtPasswort = new System.Windows.Forms.TextBox();
            this.BtnEingangBestaetigen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(204, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nutzer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(238, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passwort:";
            // 
            // TxtNutzerName
            // 
            this.TxtNutzerName.BackColor = System.Drawing.SystemColors.Info;
            this.TxtNutzerName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNutzerName.Location = new System.Drawing.Point(327, 291);
            this.TxtNutzerName.Name = "TxtNutzerName";
            this.TxtNutzerName.Size = new System.Drawing.Size(171, 25);
            this.TxtNutzerName.TabIndex = 2;
            // 
            // TxtPasswort
            // 
            this.TxtPasswort.BackColor = System.Drawing.SystemColors.Info;
            this.TxtPasswort.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPasswort.Location = new System.Drawing.Point(327, 328);
            this.TxtPasswort.Name = "TxtPasswort";
            this.TxtPasswort.Size = new System.Drawing.Size(171, 25);
            this.TxtPasswort.TabIndex = 3;
            this.TxtPasswort.UseSystemPasswordChar = true;
            // 
            // BtnEingangBestaetigen
            // 
            this.BtnEingangBestaetigen.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEingangBestaetigen.Location = new System.Drawing.Point(342, 368);
            this.BtnEingangBestaetigen.Name = "BtnEingangBestaetigen";
            this.BtnEingangBestaetigen.Size = new System.Drawing.Size(139, 25);
            this.BtnEingangBestaetigen.TabIndex = 4;
            this.BtnEingangBestaetigen.Text = "Eingang Bestätigen";
            this.BtnEingangBestaetigen.UseVisualStyleBackColor = true;
            this.BtnEingangBestaetigen.Click += new System.EventHandler(this.BtnEingangBestaetigen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gäste Buchung und Führung";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormAdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(785, 444);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnEingangBestaetigen);
            this.Controls.Add(this.TxtPasswort);
            this.Controls.Add(this.TxtNutzerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdminLogin";
            this.Text = "Admin Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNutzerName;
        private System.Windows.Forms.TextBox TxtPasswort;
        private System.Windows.Forms.Button BtnEingangBestaetigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

