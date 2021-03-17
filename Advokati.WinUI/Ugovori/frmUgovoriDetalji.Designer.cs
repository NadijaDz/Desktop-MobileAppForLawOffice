namespace Advokati.WinUI.Ugovori
{
    partial class frmUgovoriDetalji
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
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.dtpDatumPotpisivanja = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbZaposlenik = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbZavrsenDa = new System.Windows.Forms.RadioButton();
            this.rbZavrsenNe = new System.Windows.Forms.RadioButton();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtNapomena = new System.Windows.Forms.RichTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov";
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(40, 76);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.Size = new System.Drawing.Size(319, 22);
            this.txtNaslov.TabIndex = 1;
            this.txtNaslov.TabStop = false;
            this.txtNaslov.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNaslov_Validating);
            // 
            // dtpDatumPotpisivanja
            // 
            this.dtpDatumPotpisivanja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumPotpisivanja.Location = new System.Drawing.Point(40, 204);
            this.dtpDatumPotpisivanja.Name = "dtpDatumPotpisivanja";
            this.dtpDatumPotpisivanja.Size = new System.Drawing.Size(319, 22);
            this.dtpDatumPotpisivanja.TabIndex = 2;
            this.dtpDatumPotpisivanja.TabStop = false;
            this.dtpDatumPotpisivanja.Validating += new System.ComponentModel.CancelEventHandler(this.DtpDatumPotpisivanja_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Napomena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum potpisivanja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Zaposlenik";
            // 
            // cbZaposlenik
            // 
            this.cbZaposlenik.FormattingEnabled = true;
            this.cbZaposlenik.Location = new System.Drawing.Point(40, 131);
            this.cbZaposlenik.Name = "cbZaposlenik";
            this.cbZaposlenik.Size = new System.Drawing.Size(319, 24);
            this.cbZaposlenik.TabIndex = 7;
            this.cbZaposlenik.TabStop = false;
            this.cbZaposlenik.Validating += new System.ComponentModel.CancelEventHandler(this.CbZaposlenik_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Završen";
            // 
            // rbZavrsenDa
            // 
            this.rbZavrsenDa.AutoSize = true;
            this.rbZavrsenDa.Location = new System.Drawing.Point(45, 276);
            this.rbZavrsenDa.Name = "rbZavrsenDa";
            this.rbZavrsenDa.Size = new System.Drawing.Size(48, 21);
            this.rbZavrsenDa.TabIndex = 11;
            this.rbZavrsenDa.Text = "DA";
            this.rbZavrsenDa.UseVisualStyleBackColor = true;
            // 
            // rbZavrsenNe
            // 
            this.rbZavrsenNe.AutoSize = true;
            this.rbZavrsenNe.Location = new System.Drawing.Point(161, 276);
            this.rbZavrsenNe.Name = "rbZavrsenNe";
            this.rbZavrsenNe.Size = new System.Drawing.Size(48, 21);
            this.rbZavrsenNe.TabIndex = 12;
            this.rbZavrsenNe.Text = "NE";
            this.rbZavrsenNe.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(555, 258);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(109, 39);
            this.btnSacuvaj.TabIndex = 13;
            this.btnSacuvaj.TabStop = false;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(476, 76);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(319, 150);
            this.txtNapomena.TabIndex = 14;
            this.txtNapomena.TabStop = false;
            this.txtNapomena.Text = "";
            this.txtNapomena.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNapomena_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(686, 258);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(109, 39);
            this.btnOdustani.TabIndex = 15;
            this.btnOdustani.TabStop = false;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.BtnOdustani_Click);
            // 
            // frmUgovoriDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 345);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.rbZavrsenNe);
            this.Controls.Add(this.rbZavrsenDa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbZaposlenik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDatumPotpisivanja);
            this.Controls.Add(this.txtNaslov);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmUgovoriDetalji";
            this.Text = "Ugovori";
            this.Load += new System.EventHandler(this.FrmUgovoriDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.DateTimePicker dtpDatumPotpisivanja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbZaposlenik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbZavrsenDa;
        private System.Windows.Forms.RadioButton rbZavrsenNe;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.RichTextBox txtNapomena;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnOdustani;
    }
}