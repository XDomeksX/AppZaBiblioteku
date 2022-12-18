namespace AppZaBiblioteku
{
    partial class Form1
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
            this.BTNupis = new System.Windows.Forms.Button();
            this.BTNpregled = new System.Windows.Forms.Button();
            this.BTNpretraga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNupis
            // 
            this.BTNupis.Location = new System.Drawing.Point(13, 13);
            this.BTNupis.Name = "BTNupis";
            this.BTNupis.Size = new System.Drawing.Size(193, 54);
            this.BTNupis.TabIndex = 0;
            this.BTNupis.Text = "Upis";
            this.BTNupis.UseVisualStyleBackColor = true;
            this.BTNupis.Click += new System.EventHandler(this.BTNupis_Click);
            // 
            // BTNpregled
            // 
            this.BTNpregled.Location = new System.Drawing.Point(12, 133);
            this.BTNpregled.Name = "BTNpregled";
            this.BTNpregled.Size = new System.Drawing.Size(193, 54);
            this.BTNpregled.TabIndex = 1;
            this.BTNpregled.Text = "Pregled";
            this.BTNpregled.UseVisualStyleBackColor = true;
            this.BTNpregled.Click += new System.EventHandler(this.BTNpregled_Click);
            // 
            // BTNpretraga
            // 
            this.BTNpretraga.Location = new System.Drawing.Point(13, 73);
            this.BTNpretraga.Name = "BTNpretraga";
            this.BTNpretraga.Size = new System.Drawing.Size(193, 54);
            this.BTNpretraga.TabIndex = 2;
            this.BTNpretraga.Text = "Pretraga";
            this.BTNpretraga.UseVisualStyleBackColor = true;
            this.BTNpretraga.Click += new System.EventHandler(this.BTNpretraga_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 199);
            this.Controls.Add(this.BTNpretraga);
            this.Controls.Add(this.BTNpregled);
            this.Controls.Add(this.BTNupis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNupis;
        private System.Windows.Forms.Button BTNpregled;
        private System.Windows.Forms.Button BTNpretraga;
    }
}

