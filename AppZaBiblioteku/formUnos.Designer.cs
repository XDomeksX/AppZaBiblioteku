namespace AppZaBiblioteku
{
    partial class formUnos
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
            this.DTPposuđivanja = new System.Windows.Forms.DateTimePicker();
            this.TXTidKorisnika = new System.Windows.Forms.TextBox();
            this.LBLdatumPosuđivanja = new System.Windows.Forms.Label();
            this.LBLidKorisnika = new System.Windows.Forms.Label();
            this.LBLidKnjige = new System.Windows.Forms.Label();
            this.TXTidKnjige = new System.Windows.Forms.TextBox();
            this.BTNunesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DTPposuđivanja
            // 
            this.DTPposuđivanja.CustomFormat = "ddMMMM, yyyy";
            this.DTPposuđivanja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPposuđivanja.Location = new System.Drawing.Point(12, 142);
            this.DTPposuđivanja.Name = "DTPposuđivanja";
            this.DTPposuđivanja.Size = new System.Drawing.Size(200, 20);
            this.DTPposuđivanja.TabIndex = 19;
            this.DTPposuđivanja.Value = new System.DateTime(2022, 12, 12, 22, 13, 26, 0);
            // 
            // TXTidKorisnika
            // 
            this.TXTidKorisnika.Location = new System.Drawing.Point(12, 84);
            this.TXTidKorisnika.Name = "TXTidKorisnika";
            this.TXTidKorisnika.Size = new System.Drawing.Size(408, 20);
            this.TXTidKorisnika.TabIndex = 17;
            // 
            // LBLdatumPosuđivanja
            // 
            this.LBLdatumPosuđivanja.AutoSize = true;
            this.LBLdatumPosuđivanja.Location = new System.Drawing.Point(13, 126);
            this.LBLdatumPosuđivanja.Name = "LBLdatumPosuđivanja";
            this.LBLdatumPosuđivanja.Size = new System.Drawing.Size(99, 13);
            this.LBLdatumPosuđivanja.TabIndex = 16;
            this.LBLdatumPosuđivanja.Text = "Datum posuđivanja";
            // 
            // LBLidKorisnika
            // 
            this.LBLidKorisnika.AutoSize = true;
            this.LBLidKorisnika.Location = new System.Drawing.Point(13, 68);
            this.LBLidKorisnika.Name = "LBLidKorisnika";
            this.LBLidKorisnika.Size = new System.Drawing.Size(63, 13);
            this.LBLidKorisnika.TabIndex = 15;
            this.LBLidKorisnika.Text = "ID korisnika";
            // 
            // LBLidKnjige
            // 
            this.LBLidKnjige.AutoSize = true;
            this.LBLidKnjige.Location = new System.Drawing.Point(13, 16);
            this.LBLidKnjige.Name = "LBLidKnjige";
            this.LBLidKnjige.Size = new System.Drawing.Size(49, 13);
            this.LBLidKnjige.TabIndex = 13;
            this.LBLidKnjige.Text = "ID knjige";
            // 
            // TXTidKnjige
            // 
            this.TXTidKnjige.Location = new System.Drawing.Point(12, 32);
            this.TXTidKnjige.Name = "TXTidKnjige";
            this.TXTidKnjige.Size = new System.Drawing.Size(408, 20);
            this.TXTidKnjige.TabIndex = 12;
            // 
            // BTNunesi
            // 
            this.BTNunesi.Location = new System.Drawing.Point(245, 126);
            this.BTNunesi.Name = "BTNunesi";
            this.BTNunesi.Size = new System.Drawing.Size(175, 36);
            this.BTNunesi.TabIndex = 11;
            this.BTNunesi.Text = "Unesi";
            this.BTNunesi.UseVisualStyleBackColor = true;
            this.BTNunesi.Click += new System.EventHandler(this.BTNunesi_Click);
            // 
            // formUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 177);
            this.Controls.Add(this.DTPposuđivanja);
            this.Controls.Add(this.TXTidKorisnika);
            this.Controls.Add(this.LBLdatumPosuđivanja);
            this.Controls.Add(this.LBLidKorisnika);
            this.Controls.Add(this.LBLidKnjige);
            this.Controls.Add(this.TXTidKnjige);
            this.Controls.Add(this.BTNunesi);
            this.Name = "formUnos";
            this.Text = "Unos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTPposuđivanja;
        private System.Windows.Forms.TextBox TXTidKorisnika;
        private System.Windows.Forms.Label LBLdatumPosuđivanja;
        private System.Windows.Forms.Label LBLidKorisnika;
        private System.Windows.Forms.Label LBLidKnjige;
        private System.Windows.Forms.TextBox TXTidKnjige;
        private System.Windows.Forms.Button BTNunesi;
    }
}