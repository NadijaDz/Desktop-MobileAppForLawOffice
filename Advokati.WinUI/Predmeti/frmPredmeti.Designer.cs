namespace Advokati.WinUI.Predmeti
{
    partial class frmPredmeti
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPredmeti = new System.Windows.Forms.DataGridView();
            this.PredmetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojPredmeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivPredmeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RokZavrsetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZaposleniciId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KlijentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvPredmeti);
            this.groupBox1.Location = new System.Drawing.Point(13, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1264, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Predmeti";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // dgvPredmeti
            // 
            this.dgvPredmeti.AllowUserToAddRows = false;
            this.dgvPredmeti.AllowUserToDeleteRows = false;
            this.dgvPredmeti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPredmeti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PredmetId,
            this.BrojPredmeta,
            this.NazivPredmeta,
            this.DatumPocetka,
            this.RokZavrsetka,
            this.ZaposleniciId,
            this.KlijentId,
            this.StatusId,
            this.VrstaId});
            this.dgvPredmeti.Location = new System.Drawing.Point(3, 18);
            this.dgvPredmeti.Name = "dgvPredmeti";
            this.dgvPredmeti.ReadOnly = true;
            this.dgvPredmeti.RowHeadersWidth = 51;
            this.dgvPredmeti.RowTemplate.Height = 24;
            this.dgvPredmeti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPredmeti.Size = new System.Drawing.Size(1258, 377);
            this.dgvPredmeti.TabIndex = 0;
            this.dgvPredmeti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPredmeti_CellContentClick);
            this.dgvPredmeti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvPredmeti_MouseDoubleClick);
            // 
            // PredmetId
            // 
            this.PredmetId.DataPropertyName = "PredmetId";
            this.PredmetId.HeaderText = "PredmetId";
            this.PredmetId.MinimumWidth = 6;
            this.PredmetId.Name = "PredmetId";
            this.PredmetId.ReadOnly = true;
            this.PredmetId.Visible = false;
            // 
            // BrojPredmeta
            // 
            this.BrojPredmeta.DataPropertyName = "BrojPredmeta";
            this.BrojPredmeta.HeaderText = "Broj predmeta";
            this.BrojPredmeta.MinimumWidth = 6;
            this.BrojPredmeta.Name = "BrojPredmeta";
            this.BrojPredmeta.ReadOnly = true;
            // 
            // NazivPredmeta
            // 
            this.NazivPredmeta.DataPropertyName = "NazivPredmeta";
            this.NazivPredmeta.HeaderText = "Naziv predmeta";
            this.NazivPredmeta.MinimumWidth = 6;
            this.NazivPredmeta.Name = "NazivPredmeta";
            this.NazivPredmeta.ReadOnly = true;
            // 
            // DatumPocetka
            // 
            this.DatumPocetka.DataPropertyName = "DatumPocetka";
            this.DatumPocetka.HeaderText = "Datum početka";
            this.DatumPocetka.MinimumWidth = 6;
            this.DatumPocetka.Name = "DatumPocetka";
            this.DatumPocetka.ReadOnly = true;
            // 
            // RokZavrsetka
            // 
            this.RokZavrsetka.DataPropertyName = "RokZavrsetka";
            this.RokZavrsetka.HeaderText = "Rok završetka";
            this.RokZavrsetka.MinimumWidth = 6;
            this.RokZavrsetka.Name = "RokZavrsetka";
            this.RokZavrsetka.ReadOnly = true;
            // 
            // ZaposleniciId
            // 
            this.ZaposleniciId.DataPropertyName = "Zaposlenik";
            this.ZaposleniciId.HeaderText = "Zaposlenik";
            this.ZaposleniciId.MinimumWidth = 6;
            this.ZaposleniciId.Name = "ZaposleniciId";
            this.ZaposleniciId.ReadOnly = true;
            // 
            // KlijentId
            // 
            this.KlijentId.DataPropertyName = "Klijent";
            this.KlijentId.HeaderText = "Klijent";
            this.KlijentId.MinimumWidth = 6;
            this.KlijentId.Name = "KlijentId";
            this.KlijentId.ReadOnly = true;
            // 
            // StatusId
            // 
            this.StatusId.DataPropertyName = "Status";
            this.StatusId.HeaderText = "Status predmeta";
            this.StatusId.MinimumWidth = 6;
            this.StatusId.Name = "StatusId";
            this.StatusId.ReadOnly = true;
            // 
            // VrstaId
            // 
            this.VrstaId.DataPropertyName = "VrstaUsluge";
            this.VrstaId.HeaderText = "Vrsta usluge";
            this.VrstaId.MinimumWidth = 6;
            this.VrstaId.Name = "VrstaId";
            this.VrstaId.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broj predmeta:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(120, 33);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(228, 22);
            this.txtPretraga.TabIndex = 2;
            this.txtPretraga.TextChanged += new System.EventHandler(this.TxtPretraga_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(770, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Za opcije uređivanja možete koristiti dupli klik na odabrani zapis ili button Ure" +
    "di";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(1080, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Uredi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisi.BackColor = System.Drawing.Color.Red;
            this.btnObrisi.Location = new System.Drawing.Point(1180, 33);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(94, 33);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // frmPredmeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 513);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmPredmeti";
            this.Text = "Predmeti";
            this.Load += new System.EventHandler(this.FrmPredmeti_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPredmeti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PredmetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojPredmeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivPredmeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPocetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn RokZavrsetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZaposleniciId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaId;
        private System.Windows.Forms.Button btnObrisi;
    }
}