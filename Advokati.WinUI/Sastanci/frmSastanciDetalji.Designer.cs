namespace Advokati.WinUI.Sastanci
{
    partial class frmSastanciDetalji
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
            this.cbKlijent = new System.Windows.Forms.ComboBox();
            this.dtpDatumSastanka = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMjestoOdrzavanja = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonDA = new System.Windows.Forms.RadioButton();
            this.radioButtonNE = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPoruka = new System.Windows.Forms.RichTextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbVrstaUsluge = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klijent";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zaposlenik";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum sastanka";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // cbZaposlenik
            // 
            this.cbZaposlenik.FormattingEnabled = true;
            this.cbZaposlenik.Location = new System.Drawing.Point(55, 77);
            this.cbZaposlenik.Name = "cbZaposlenik";
            this.cbZaposlenik.Size = new System.Drawing.Size(269, 24);
            this.cbZaposlenik.TabIndex = 3;
            this.cbZaposlenik.TabStop = false;
            this.cbZaposlenik.SelectedIndexChanged += new System.EventHandler(this.CbZaposlenik_SelectedIndexChanged);
            this.cbZaposlenik.Validating += new System.ComponentModel.CancelEventHandler(this.CbZaposlenik_Validating);
            // 
            // cbKlijent
            // 
            this.cbKlijent.FormattingEnabled = true;
            this.cbKlijent.Location = new System.Drawing.Point(55, 140);
            this.cbKlijent.Name = "cbKlijent";
            this.cbKlijent.Size = new System.Drawing.Size(269, 24);
            this.cbKlijent.TabIndex = 4;
            this.cbKlijent.TabStop = false;
            this.cbKlijent.SelectedIndexChanged += new System.EventHandler(this.CbKlijent_SelectedIndexChanged);
            this.cbKlijent.Validating += new System.ComponentModel.CancelEventHandler(this.CbKlijent_Validating);
            // 
            // dtpDatumSastanka
            // 
            this.dtpDatumSastanka.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumSastanka.Location = new System.Drawing.Point(55, 201);
            this.dtpDatumSastanka.Name = "dtpDatumSastanka";
            this.dtpDatumSastanka.Size = new System.Drawing.Size(269, 22);
            this.dtpDatumSastanka.TabIndex = 5;
            this.dtpDatumSastanka.TabStop = false;
            this.dtpDatumSastanka.ValueChanged += new System.EventHandler(this.DtpDatumSastanka_ValueChanged);
            this.dtpDatumSastanka.Validating += new System.ComponentModel.CancelEventHandler(this.DtpDatumSastanka_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mjesto održavanja";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txtMjestoOdrzavanja
            // 
            this.txtMjestoOdrzavanja.Location = new System.Drawing.Point(55, 271);
            this.txtMjestoOdrzavanja.Name = "txtMjestoOdrzavanja";
            this.txtMjestoOdrzavanja.Size = new System.Drawing.Size(269, 22);
            this.txtMjestoOdrzavanja.TabIndex = 7;
            this.txtMjestoOdrzavanja.TabStop = false;
            this.txtMjestoOdrzavanja.TextChanged += new System.EventHandler(this.TxtMjestoOdrzavanja_TextChanged);
            this.txtMjestoOdrzavanja.Validating += new System.ComponentModel.CancelEventHandler(this.TxtMjestoOdrzavanja_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Održano";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // radioButtonDA
            // 
            this.radioButtonDA.AutoSize = true;
            this.radioButtonDA.Location = new System.Drawing.Point(55, 343);
            this.radioButtonDA.Name = "radioButtonDA";
            this.radioButtonDA.Size = new System.Drawing.Size(48, 21);
            this.radioButtonDA.TabIndex = 9;
            this.radioButtonDA.Text = "DA";
            this.radioButtonDA.UseVisualStyleBackColor = true;
            this.radioButtonDA.CheckedChanged += new System.EventHandler(this.RadioButtonDA_CheckedChanged);
            // 
            // radioButtonNE
            // 
            this.radioButtonNE.AutoSize = true;
            this.radioButtonNE.Location = new System.Drawing.Point(171, 343);
            this.radioButtonNE.Name = "radioButtonNE";
            this.radioButtonNE.Size = new System.Drawing.Size(48, 21);
            this.radioButtonNE.TabIndex = 10;
            this.radioButtonNE.Text = "NE";
            this.radioButtonNE.UseVisualStyleBackColor = true;
            this.radioButtonNE.CheckedChanged += new System.EventHandler(this.RadioButtonNE_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Poruka";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // txtPoruka
            // 
            this.txtPoruka.Location = new System.Drawing.Point(441, 87);
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(296, 96);
            this.txtPoruka.TabIndex = 12;
            this.txtPoruka.TabStop = false;
            this.txtPoruka.Text = "";
            this.txtPoruka.TextChanged += new System.EventHandler(this.TxtPoruka_TextChanged);
            this.txtPoruka.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPoruka_Validating);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(491, 313);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(114, 39);
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
            this.btnOdustani.Location = new System.Drawing.Point(623, 313);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(114, 39);
            this.btnOdustani.TabIndex = 14;
            this.btnOdustani.TabStop = false;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Odobreno";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(528, 202);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmbVrstaUsluge
            // 
            this.cmbVrstaUsluge.FormattingEnabled = true;
            this.cmbVrstaUsluge.Location = new System.Drawing.Point(444, 269);
            this.cmbVrstaUsluge.Name = "cmbVrstaUsluge";
            this.cmbVrstaUsluge.Size = new System.Drawing.Size(293, 24);
            this.cmbVrstaUsluge.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Vrsta usluge";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // frmSastanciDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 404);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbVrstaUsluge);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtPoruka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButtonNE);
            this.Controls.Add(this.radioButtonDA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMjestoOdrzavanja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDatumSastanka);
            this.Controls.Add(this.cbKlijent);
            this.Controls.Add(this.cbZaposlenik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmSastanciDetalji";
            this.Text = "Sastanci";
            this.Load += new System.EventHandler(this.FrmSastanciDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbZaposlenik;
        private System.Windows.Forms.ComboBox cbKlijent;
        private System.Windows.Forms.DateTimePicker dtpDatumSastanka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMjestoOdrzavanja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonDA;
        private System.Windows.Forms.RadioButton radioButtonNE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtPoruka;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbVrstaUsluge;
    }
}