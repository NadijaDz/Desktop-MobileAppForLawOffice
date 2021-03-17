namespace Advokati.WinUI
{
    partial class frmPromjenaLozinke
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStaraLozinka = new System.Windows.Forms.TextBox();
            this.txtNovaLozinka = new System.Windows.Forms.TextBox();
            this.txtPotvrdaNoveLozinke = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite trenutnu lozinku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unesite novu lozinku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Potvrda nove lozinke";
            // 
            // txtStaraLozinka
            // 
            this.txtStaraLozinka.Location = new System.Drawing.Point(80, 127);
            this.txtStaraLozinka.Name = "txtStaraLozinka";
            this.txtStaraLozinka.PasswordChar = '*';
            this.txtStaraLozinka.Size = new System.Drawing.Size(346, 22);
            this.txtStaraLozinka.TabIndex = 3;
            // 
            // txtNovaLozinka
            // 
            this.txtNovaLozinka.Location = new System.Drawing.Point(80, 182);
            this.txtNovaLozinka.Name = "txtNovaLozinka";
            this.txtNovaLozinka.PasswordChar = '*';
            this.txtNovaLozinka.Size = new System.Drawing.Size(346, 22);
            this.txtNovaLozinka.TabIndex = 4;
            // 
            // txtPotvrdaNoveLozinke
            // 
            this.txtPotvrdaNoveLozinke.Location = new System.Drawing.Point(80, 247);
            this.txtPotvrdaNoveLozinke.Name = "txtPotvrdaNoveLozinke";
            this.txtPotvrdaNoveLozinke.PasswordChar = '*';
            this.txtPotvrdaNoveLozinke.Size = new System.Drawing.Size(346, 22);
            this.txtPotvrdaNoveLozinke.TabIndex = 5;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(239, 299);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(88, 35);
            this.btnSacuvaj.TabIndex = 7;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(344, 299);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(82, 35);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Promjena lozinke";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.AutoSize = true;
            this.txtKorisnickoIme.Location = new System.Drawing.Point(80, 52);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(149, 17);
            this.txtKorisnickoIme.TabIndex = 10;
            this.txtKorisnickoIme.Text = "Unesite korisničko ime";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(80, 73);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(346, 22);
            this.txtUsername.TabIndex = 11;
            // 
            // frmPromjenaLozinke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 368);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtPotvrdaNoveLozinke);
            this.Controls.Add(this.txtNovaLozinka);
            this.Controls.Add(this.txtStaraLozinka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPromjenaLozinke";
            this.Text = "PromjenaLozinke";
            this.Load += new System.EventHandler(this.FrmPromjenaLozinke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStaraLozinka;
        private System.Windows.Forms.TextBox txtNovaLozinka;
        private System.Windows.Forms.TextBox txtPotvrdaNoveLozinke;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtUsername;
    }
}