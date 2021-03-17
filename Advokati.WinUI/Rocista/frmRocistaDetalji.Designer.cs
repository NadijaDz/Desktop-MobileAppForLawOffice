namespace Advokati.WinUI.Rocista
{
    partial class frmRocistaDetalji
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbZaposlenik = new System.Windows.Forms.ComboBox();
            this.cbPredmet = new System.Windows.Forms.ComboBox();
            this.dtpDatumRocista = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMjesto = new System.Windows.Forms.TextBox();
            this.radioButtonDA = new System.Windows.Forms.RadioButton();
            this.radioButtonNE = new System.Windows.Forms.RadioButton();
            this.txtNapomena = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zaposlenik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Predmet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum ročišta";
            // 
            // cbZaposlenik
            // 
            this.cbZaposlenik.FormattingEnabled = true;
            this.cbZaposlenik.Location = new System.Drawing.Point(55, 73);
            this.cbZaposlenik.Name = "cbZaposlenik";
            this.cbZaposlenik.Size = new System.Drawing.Size(281, 24);
            this.cbZaposlenik.TabIndex = 3;
            this.cbZaposlenik.TabStop = false;
            this.cbZaposlenik.Validating += new System.ComponentModel.CancelEventHandler(this.CbZaposlenik_Validating);
            // 
            // cbPredmet
            // 
            this.cbPredmet.FormattingEnabled = true;
            this.cbPredmet.Location = new System.Drawing.Point(55, 132);
            this.cbPredmet.Name = "cbPredmet";
            this.cbPredmet.Size = new System.Drawing.Size(281, 24);
            this.cbPredmet.TabIndex = 4;
            this.cbPredmet.TabStop = false;
            this.cbPredmet.Validating += new System.ComponentModel.CancelEventHandler(this.CbPredmet_Validating);
            // 
            // dtpDatumRocista
            // 
            this.dtpDatumRocista.CustomFormat = "";
            this.dtpDatumRocista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumRocista.Location = new System.Drawing.Point(55, 194);
            this.dtpDatumRocista.Name = "dtpDatumRocista";
            this.dtpDatumRocista.Size = new System.Drawing.Size(281, 22);
            this.dtpDatumRocista.TabIndex = 5;
            this.dtpDatumRocista.TabStop = false;
            this.dtpDatumRocista.Validating += new System.ComponentModel.CancelEventHandler(this.DtpDatumRocista_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mjesto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Održano";
            // 
            // txtMjesto
            // 
            this.txtMjesto.Location = new System.Drawing.Point(55, 256);
            this.txtMjesto.Name = "txtMjesto";
            this.txtMjesto.Size = new System.Drawing.Size(281, 22);
            this.txtMjesto.TabIndex = 8;
            this.txtMjesto.TabStop = false;
            this.txtMjesto.Validating += new System.ComponentModel.CancelEventHandler(this.TxtMjesto_Validating);
            // 
            // radioButtonDA
            // 
            this.radioButtonDA.AutoSize = true;
            this.radioButtonDA.Location = new System.Drawing.Point(55, 330);
            this.radioButtonDA.Name = "radioButtonDA";
            this.radioButtonDA.Size = new System.Drawing.Size(48, 21);
            this.radioButtonDA.TabIndex = 9;
            this.radioButtonDA.Text = "DA";
            this.radioButtonDA.UseVisualStyleBackColor = true;
            // 
            // radioButtonNE
            // 
            this.radioButtonNE.AutoSize = true;
            this.radioButtonNE.Location = new System.Drawing.Point(169, 330);
            this.radioButtonNE.Name = "radioButtonNE";
            this.radioButtonNE.Size = new System.Drawing.Size(48, 21);
            this.radioButtonNE.TabIndex = 10;
            this.radioButtonNE.Text = "NE";
            this.radioButtonNE.UseVisualStyleBackColor = true;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(465, 73);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(279, 96);
            this.txtNapomena.TabIndex = 11;
            this.txtNapomena.TabStop = false;
            this.txtNapomena.Text = "";
            this.txtNapomena.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNapomena_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Napomena";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(507, 297);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(110, 42);
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
            this.btnOdustani.Location = new System.Drawing.Point(634, 297);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(110, 42);
            this.btnOdustani.TabIndex = 14;
            this.btnOdustani.TabStop = false;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // frmRocistaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 389);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.radioButtonNE);
            this.Controls.Add(this.radioButtonDA);
            this.Controls.Add(this.txtMjesto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDatumRocista);
            this.Controls.Add(this.cbPredmet);
            this.Controls.Add(this.cbZaposlenik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmRocistaDetalji";
            this.Text = "Ročišta";
            this.Load += new System.EventHandler(this.FrmRocistaDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbZaposlenik;
        private System.Windows.Forms.ComboBox cbPredmet;
        private System.Windows.Forms.DateTimePicker dtpDatumRocista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMjesto;
        private System.Windows.Forms.RadioButton radioButtonDA;
        private System.Windows.Forms.RadioButton radioButtonNE;
        private System.Windows.Forms.RichTextBox txtNapomena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnOdustani;
    }
}