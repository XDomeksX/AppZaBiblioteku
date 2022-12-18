namespace AppZaBiblioteku
{
    partial class formPretraga
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
            this.LBLpretraga = new System.Windows.Forms.Label();
            this.LBLidKnjige = new System.Windows.Forms.Label();
            this.TXTidKnjige = new System.Windows.Forms.TextBox();
            this.BTNpretrazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLpretraga
            // 
            this.LBLpretraga.AutoSize = true;
            this.LBLpretraga.Location = new System.Drawing.Point(91, 9);
            this.LBLpretraga.Name = "LBLpretraga";
            this.LBLpretraga.Size = new System.Drawing.Size(47, 13);
            this.LBLpretraga.TabIndex = 0;
            this.LBLpretraga.Text = "Pretraga";
            // 
            // LBLidKnjige
            // 
            this.LBLidKnjige.AutoSize = true;
            this.LBLidKnjige.Location = new System.Drawing.Point(13, 36);
            this.LBLidKnjige.Name = "LBLidKnjige";
            this.LBLidKnjige.Size = new System.Drawing.Size(81, 13);
            this.LBLidKnjige.TabIndex = 1;
            this.LBLidKnjige.Text = "Ime ili ID knjige:";
            // 
            // TXTidKnjige
            // 
            this.TXTidKnjige.Location = new System.Drawing.Point(13, 53);
            this.TXTidKnjige.Name = "TXTidKnjige";
            this.TXTidKnjige.Size = new System.Drawing.Size(222, 20);
            this.TXTidKnjige.TabIndex = 2;
            // 
            // BTNpretrazi
            // 
            this.BTNpretrazi.Location = new System.Drawing.Point(79, 182);
            this.BTNpretrazi.Name = "BTNpretrazi";
            this.BTNpretrazi.Size = new System.Drawing.Size(75, 23);
            this.BTNpretrazi.TabIndex = 3;
            this.BTNpretrazi.Text = "Pretraži";
            this.BTNpretrazi.UseVisualStyleBackColor = true;
            // 
            // formPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 214);
            this.Controls.Add(this.BTNpretrazi);
            this.Controls.Add(this.TXTidKnjige);
            this.Controls.Add(this.LBLidKnjige);
            this.Controls.Add(this.LBLpretraga);
            this.Name = "formPretraga";
            this.Text = "formPretraga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLpretraga;
        private System.Windows.Forms.Label LBLidKnjige;
        private System.Windows.Forms.TextBox TXTidKnjige;
        private System.Windows.Forms.Button BTNpretrazi;
    }
}