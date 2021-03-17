namespace Advokati.WinUI.Zadaci
{
    partial class frmZadaciDetalji
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cbZaposlenik = new System.Windows.Forms.ComboBox();
            this.dtpDatumPocetka = new System.Windows.Forms.DateTimePicker();
            this.dtpRokZavrsetka = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonDA = new System.Windows.Forms.RadioButton();
            this.radioButtonNE = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv zadatka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zaposlenik";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(57, 71);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(261, 22);
            this.txtNaziv.TabIndex = 2;
            this.txtNaziv.TabStop = false;
            this.txtNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNaziv_Validating);
            // 
            // cbZaposlenik
            // 
            this.cbZaposlenik.FormattingEnabled = true;
            this.cbZaposlenik.Location = new System.Drawing.Point(57, 135);
            this.cbZaposlenik.Name = "cbZaposlenik";
            this.cbZaposlenik.Size = new System.Drawing.Size(261, 24);
            this.cbZaposlenik.TabIndex = 3;
            this.cbZaposlenik.TabStop = false;
            this.cbZaposlenik.Validating += new System.ComponentModel.CancelEventHandler(this.CbZaposlenik_Validating);
            // 
            // dtpDatumPocetka
            // 
            this.dtpDatumPocetka.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumPocetka.Location = new System.Drawing.Point(57, 200);
            this.dtpDatumPocetka.Name = "dtpDatumPocetka";
            this.dtpDatumPocetka.Size = new System.Drawing.Size(261, 22);
            this.dtpDatumPocetka.TabIndex = 4;
            this.dtpDatumPocetka.TabStop = false;
            this.dtpDatumPocetka.Validating += new System.ComponentModel.CancelEventHandler(this.DtpDatumPocetka_Validating);
            // 
            // dtpRokZavrsetka
            // 
            this.dtpRokZavrsetka.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRokZavrsetka.Location = new System.Drawing.Point(57, 270);
            this.dtpRokZavrsetka.Name = "dtpRokZavrsetka";
            this.dtpRokZavrsetka.Size = new System.Drawing.Size(261, 22);
            this.dtpRokZavrsetka.TabIndex = 5;
            this.dtpRokZavrsetka.TabStop = false;
            this.dtpRokZavrsetka.Validating += new System.ComponentModel.CancelEventHandler(this.DtpRokZavrsetka_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rok završetka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum početka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Završen";
            // 
            // radioButtonDA
            // 
            this.radioButtonDA.AutoSize = true;
            this.radioButtonDA.Location = new System.Drawing.Point(57, 359);
            this.radioButtonDA.Name = "radioButtonDA";
            this.radioButtonDA.Size = new System.Drawing.Size(48, 21);
            this.radioButtonDA.TabIndex = 9;
            this.radioButtonDA.Text = "DA";
            this.radioButtonDA.UseVisualStyleBackColor = true;
            // 
            // radioButtonNE
            // 
            this.radioButtonNE.AutoSize = true;
            this.radioButtonNE.Location = new System.Drawing.Point(170, 359);
            this.radioButtonNE.Name = "radioButtonNE";
            this.radioButtonNE.Size = new System.Drawing.Size(48, 21);
            this.radioButtonNE.TabIndex = 10;
            this.radioButtonNE.Text = "NE";
            this.radioButtonNE.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(432, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Opis";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(435, 90);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(306, 96);
            this.txtOpis.TabIndex = 12;
            this.txtOpis.TabStop = false;
            this.txtOpis.Text = "";
            this.txtOpis.Validating += new System.ComponentModel.CancelEventHandler(this.TxtOpis_Validating);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(502, 336);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(107, 44);
            this.btnSacuvaj.TabIndex = 13;
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
            this.btnOdustani.Location = new System.Drawing.Point(634, 336);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(107, 44);
            this.btnOdustani.TabIndex = 14;
            this.btnOdustani.TabStop = false;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // frmZadaciDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 422);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButtonNE);
            this.Controls.Add(this.radioButtonDA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpRokZavrsetka);
            this.Controls.Add(this.dtpDatumPocetka);
            this.Controls.Add(this.cbZaposlenik);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmZadaciDetalji";
            this.Text = "Zadaci";
            this.Load += new System.EventHandler(this.FrmZadaciDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cbZaposlenik;
        private System.Windows.Forms.DateTimePicker dtpDatumPocetka;
        private System.Windows.Forms.DateTimePicker dtpRokZavrsetka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonDA;
        private System.Windows.Forms.RadioButton radioButtonNE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnOdustani;
    }
}