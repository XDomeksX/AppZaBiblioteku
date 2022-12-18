namespace AppZaBiblioteku
{
    partial class formPregled
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
            this.LBLunesiPodatke = new System.Windows.Forms.Label();
            this.TXTidKorisnika = new System.Windows.Forms.TextBox();
            this.LBLidKorisnika = new System.Windows.Forms.Label();
            this.LBLidKnjige = new System.Windows.Forms.Label();
            this.TXTidKnjige = new System.Windows.Forms.TextBox();
            this.BTNpregledaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLunesiPodatke
            // 
            this.LBLunesiPodatke.AutoSize = true;
            this.LBLunesiPodatke.Location = new System.Drawing.Point(63, 9);
            this.LBLunesiPodatke.Name = "LBLunesiPodatke";
            this.LBLunesiPodatke.Size = new System.Drawing.Size(79, 13);
            this.LBLunesiPodatke.TabIndex = 0;
            this.LBLunesiPodatke.Text = "Unesi podatke:";
            // 
            // TXTidKorisnika
            // 
            this.TXTidKorisnika.Location = new System.Drawing.Point(12, 59);
            this.TXTidKorisnika.Name = "TXTidKorisnika";
            this.TXTidKorisnika.Size = new System.Drawing.Size(187, 20);
            this.TXTidKorisnika.TabIndex = 1;
            // 
            // LBLidKorisnika
            // 
            this.LBLidKorisnika.AutoSize = true;
            this.LBLidKorisnika.Location = new System.Drawing.Point(15, 40);
            this.LBLidKorisnika.Name = "LBLidKorisnika";
            this.LBLidKorisnika.Size = new System.Drawing.Size(66, 13);
            this.LBLidKorisnika.TabIndex = 2;
            this.LBLidKorisnika.Text = "ID korisnika:";
            // 
            // LBLidKnjige
            // 
            this.LBLidKnjige.AutoSize = true;
            this.LBLidKnjige.Location = new System.Drawing.Point(15, 98);
            this.LBLidKnjige.Name = "LBLidKnjige";
            this.LBLidKnjige.Size = new System.Drawing.Size(52, 13);
            this.LBLidKnjige.TabIndex = 4;
            this.LBLidKnjige.Text = "ID knjige:";
            // 
            // TXTidKnjige
            // 
            this.TXTidKnjige.Location = new System.Drawing.Point(12, 117);
            this.TXTidKnjige.Name = "TXTidKnjige";
            this.TXTidKnjige.Size = new System.Drawing.Size(187, 20);
            this.TXTidKnjige.TabIndex = 3;
            // 
            // BTNpregledaj
            // 
            this.BTNpregledaj.Location = new System.Drawing.Point(66, 160);
            this.BTNpregledaj.Name = "BTNpregledaj";
            this.BTNpregledaj.Size = new System.Drawing.Size(76, 23);
            this.BTNpregledaj.TabIndex = 5;
            this.BTNpregledaj.Text = "Pregledaj";
            this.BTNpregledaj.UseVisualStyleBackColor = true;
            this.BTNpregledaj.Click += new System.EventHandler(this.BTNpregledaj_Click);
            // 
            // formPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 196);
            this.Controls.Add(this.BTNpregledaj);
            this.Controls.Add(this.LBLidKnjige);
            this.Controls.Add(this.TXTidKnjige);
            this.Controls.Add(this.LBLidKorisnika);
            this.Controls.Add(this.TXTidKorisnika);
            this.Controls.Add(this.LBLunesiPodatke);
            this.Name = "formPregled";
            this.Text = "formPregled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLunesiPodatke;
        private System.Windows.Forms.TextBox TXTidKorisnika;
        private System.Windows.Forms.Label LBLidKorisnika;
        private System.Windows.Forms.Label LBLidKnjige;
        private System.Windows.Forms.TextBox TXTidKnjige;
        private System.Windows.Forms.Button BTNpregledaj;
    }
}