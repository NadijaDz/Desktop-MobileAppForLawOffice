namespace Advokati.WinUI.RadniSati
{
    partial class frmRadniSatiDetalji
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbZaposlenik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojRadnihSati = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPredmet = new System.Windows.Forms.ComboBox();
            this.txtPrekovremeniSati = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCijenaPoSatu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtCijenaPrekovremenogSata = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zaposlenik";
            // 
            // cbZaposlenik
            // 
            this.cbZaposlenik.FormattingEnabled = true;
            this.cbZaposlenik.Location = new System.Drawing.Point(49, 77);
            this.cbZaposlenik.Name = "cbZaposlenik";
            this.cbZaposlenik.Size = new System.Drawing.Size(254, 24);
            this.cbZaposlenik.TabIndex = 1;
            this.cbZaposlenik.TabStop = false;
            this.cbZaposlenik.SelectedIndexChanged += new System.EventHandler(this.CbZaposlenik_SelectedIndexChanged);
            this.cbZaposlenik.Validating += new System.ComponentModel.CancelEventHandler(this.CbZaposlenik_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj radnih sati";
            // 
            // txtBrojRadnihSati
            // 
            this.txtBrojRadnihSati.Location = new System.Drawing.Point(49, 210);
            this.txtBrojRadnihSati.Name = "txtBrojRadnihSati";
            this.txtBrojRadnihSati.Size = new System.Drawing.Size(254, 22);
            this.txtBrojRadnihSati.TabIndex = 3;
            this.txtBrojRadnihSati.TabStop = false;
            this.txtBrojRadnihSati.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBrojRadnihSati_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Predmet";
            // 
            // cbPredmet
            // 
            this.cbPredmet.FormattingEnabled = true;
            this.cbPredmet.Location = new System.Drawing.Point(49, 140);
            this.cbPredmet.Name = "cbPredmet";
            this.cbPredmet.Size = new System.Drawing.Size(254, 24);
            this.cbPredmet.TabIndex = 5;
            this.cbPredmet.TabStop = false;
            this.cbPredmet.Validating += new System.ComponentModel.CancelEventHandler(this.CbPredmet_Validating);
            // 
            // txtPrekovremeniSati
            // 
            this.txtPrekovremeniSati.Location = new System.Drawing.Point(49, 276);
            this.txtPrekovremeniSati.Name = "txtPrekovremeniSati";
            this.txtPrekovremeniSati.Size = new System.Drawing.Size(254, 22);
            this.txtPrekovremeniSati.TabIndex = 7;
            this.txtPrekovremeniSati.TabStop = false;
            this.txtPrekovremeniSati.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPrekovremeniSati_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Broj prekovremenih sati";
            // 
            // txtCijenaPoSatu
            // 
            this.txtCijenaPoSatu.Location = new System.Drawing.Point(49, 336);
            this.txtCijenaPoSatu.Name = "txtCijenaPoSatu";
            this.txtCijenaPoSatu.Size = new System.Drawing.Size(254, 22);
            this.txtCijenaPoSatu.TabIndex = 9;
            this.txtCijenaPoSatu.TabStop = false;
            this.txtCijenaPoSatu.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCijenaPoSatu_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "CIjena po satu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cijena prekovremenog sata";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(444, 77);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(254, 96);
            this.txtOpis.TabIndex = 13;
            this.txtOpis.TabStop = false;
            this.txtOpis.Text = "";
            this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.TxtOpis_Validating);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(471, 343);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(102, 39);
            this.btnSacuvaj.TabIndex = 15;
            this.btnSacuvaj.TabStop = false;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // txtCijenaPrekovremenogSata
            // 
            this.txtCijenaPrekovremenogSata.Location = new System.Drawing.Point(49, 385);
            this.txtCijenaPrekovremenogSata.Name = "txtCijenaPrekovremenogSata";
            this.txtCijenaPrekovremenogSata.Size = new System.Drawing.Size(254, 22);
            this.txtCijenaPrekovremenogSata.TabIndex = 16;
            this.txtCijenaPrekovremenogSata.TabStop = false;
            this.txtCijenaPrekovremenogSata.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCijenaPrekovremenogSata_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(596, 343);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(102, 39);
            this.btnOdustani.TabIndex = 17;
            this.btnOdustani.TabStop = false;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // frmRadniSatiDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 441);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtCijenaPrekovremenogSata);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCijenaPoSatu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrekovremeniSati);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbPredmet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrojRadnihSati);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbZaposlenik);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmRadniSatiDetalji";
            this.Text = "Radni sati";
            this.Load += new System.EventHandler(this.FrmRadniSatiDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbZaposlenik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojRadnihSati;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPredmet;
        private System.Windows.Forms.TextBox txtPrekovremeniSati;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCijenaPoSatu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtCijenaPrekovremenogSata;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnOdustani;
    }
}