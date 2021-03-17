namespace Advokati.WinUI.Predmeti
{
    partial class frmPredmetiDetalji
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
            this.txtBrojPredmeta = new System.Windows.Forms.TextBox();
            this.txtNazivPredmeta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDatPocetka = new System.Windows.Forms.DateTimePicker();
            this.dtpRokZavrsetka = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbZaposlenici = new System.Windows.Forms.ComboBox();
            this.cbKlijent = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbVrsta = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBrojPredmeta
            // 
            this.txtBrojPredmeta.Location = new System.Drawing.Point(57, 102);
            this.txtBrojPredmeta.Name = "txtBrojPredmeta";
            this.txtBrojPredmeta.Size = new System.Drawing.Size(274, 22);
            this.txtBrojPredmeta.TabIndex = 0;
            this.txtBrojPredmeta.TabStop = false;
            this.txtBrojPredmeta.Validating += new System.ComponentModel.CancelEventHandler(this.TxtBrojPredmeta_Validating);
            // 
            // txtNazivPredmeta
            // 
            this.txtNazivPredmeta.Location = new System.Drawing.Point(57, 159);
            this.txtNazivPredmeta.Name = "txtNazivPredmeta";
            this.txtNazivPredmeta.Size = new System.Drawing.Size(274, 22);
            this.txtNazivPredmeta.TabIndex = 1;
            this.txtNazivPredmeta.TabStop = false;
            this.txtNazivPredmeta.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNazivPredmeta_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Broj predmeta";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Naziv predmeta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum početka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rok završetka";
            // 
            // dtpDatPocetka
            // 
            this.dtpDatPocetka.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatPocetka.Location = new System.Drawing.Point(61, 224);
            this.dtpDatPocetka.Name = "dtpDatPocetka";
            this.dtpDatPocetka.Size = new System.Drawing.Size(270, 22);
            this.dtpDatPocetka.TabIndex = 6;
            this.dtpDatPocetka.TabStop = false;
            this.dtpDatPocetka.Validating += new System.ComponentModel.CancelEventHandler(this.DtpDatPocetka_Validating);
            // 
            // dtpRokZavrsetka
            // 
            this.dtpRokZavrsetka.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRokZavrsetka.Location = new System.Drawing.Point(61, 283);
            this.dtpRokZavrsetka.Name = "dtpRokZavrsetka";
            this.dtpRokZavrsetka.Size = new System.Drawing.Size(270, 22);
            this.dtpRokZavrsetka.TabIndex = 7;
            this.dtpRokZavrsetka.TabStop = false;
            this.dtpRokZavrsetka.Validating += new System.ComponentModel.CancelEventHandler(this.DtpRokZavrsetka_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Zaposlenik";
            // 
            // cbZaposlenici
            // 
            this.cbZaposlenici.FormattingEnabled = true;
            this.cbZaposlenici.Location = new System.Drawing.Point(61, 345);
            this.cbZaposlenici.Name = "cbZaposlenici";
            this.cbZaposlenici.Size = new System.Drawing.Size(270, 24);
            this.cbZaposlenici.TabIndex = 9;
            this.cbZaposlenici.TabStop = false;
            this.cbZaposlenici.Validating += new System.ComponentModel.CancelEventHandler(this.CbZaposlenici_Validating);
            // 
            // cbKlijent
            // 
            this.cbKlijent.FormattingEnabled = true;
            this.cbKlijent.Location = new System.Drawing.Point(61, 402);
            this.cbKlijent.Name = "cbKlijent";
            this.cbKlijent.Size = new System.Drawing.Size(270, 24);
            this.cbKlijent.TabIndex = 11;
            this.cbKlijent.TabStop = false;
            this.cbKlijent.Validating += new System.ComponentModel.CancelEventHandler(this.CbKlijent_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Klijent";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(476, 100);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(270, 24);
            this.cbStatus.TabIndex = 13;
            this.cbStatus.TabStop = false;
            this.cbStatus.Validating += new System.ComponentModel.CancelEventHandler(this.CbStatus_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Status predmeta";
            // 
            // cbVrsta
            // 
            this.cbVrsta.FormattingEnabled = true;
            this.cbVrsta.Location = new System.Drawing.Point(476, 159);
            this.cbVrsta.Name = "cbVrsta";
            this.cbVrsta.Size = new System.Drawing.Size(270, 24);
            this.cbVrsta.TabIndex = 15;
            this.cbVrsta.TabStop = false;
            this.cbVrsta.Validating += new System.ComponentModel.CancelEventHandler(this.CbVrsta_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Vrsta predmeta";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(505, 368);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(110, 42);
            this.btnSacuvaj.TabIndex = 16;
            this.btnSacuvaj.TabStop = false;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(636, 368);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(110, 42);
            this.btnOdustani.TabIndex = 17;
            this.btnOdustani.TabStop = false;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // frmPredmetiDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 458);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cbVrsta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbKlijent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbZaposlenici);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpRokZavrsetka);
            this.Controls.Add(this.dtpDatPocetka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazivPredmeta);
            this.Controls.Add(this.txtBrojPredmeta);
            this.MaximizeBox = false;
            this.Name = "frmPredmetiDetalji";
            this.Text = "Predmeti";
            this.Load += new System.EventHandler(this.FrmPredmetiDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrojPredmeta;
        private System.Windows.Forms.TextBox txtNazivPredmeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDatPocetka;
        private System.Windows.Forms.DateTimePicker dtpRokZavrsetka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbZaposlenici;
        private System.Windows.Forms.ComboBox cbKlijent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbVrsta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnOdustani;
    }
}