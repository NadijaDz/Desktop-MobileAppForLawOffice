namespace Advokati.WinUI.RadniSati
{
    partial class frmRadniSati
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
            this.cbZaposlenici = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRadniSati = new System.Windows.Forms.DataGridView();
            this.RadniSatiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZaposleniciId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PredmetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojRadnihSati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrekovremeniSati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaPoSatu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CijenaPrekovremenogsata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadniSati)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zaposlenik:";
            // 
            // cbZaposlenici
            // 
            this.cbZaposlenici.FormattingEnabled = true;
            this.cbZaposlenici.Location = new System.Drawing.Point(112, 45);
            this.cbZaposlenici.Name = "cbZaposlenici";
            this.cbZaposlenici.Size = new System.Drawing.Size(251, 24);
            this.cbZaposlenici.TabIndex = 1;
            this.cbZaposlenici.DropDownClosed += new System.EventHandler(this.CbZaposlenici_DropDownClosed);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvRadniSati);
            this.groupBox1.Location = new System.Drawing.Point(13, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1294, 367);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Radni sati";
            // 
            // dgvRadniSati
            // 
            this.dgvRadniSati.AllowUserToAddRows = false;
            this.dgvRadniSati.AllowUserToDeleteRows = false;
            this.dgvRadniSati.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRadniSati.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRadniSati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadniSati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RadniSatiId,
            this.ZaposleniciId,
            this.PredmetId,
            this.BrojRadnihSati,
            this.PrekovremeniSati,
            this.CijenaPoSatu,
            this.CijenaPrekovremenogsata,
            this.Opis});
            this.dgvRadniSati.Location = new System.Drawing.Point(3, 18);
            this.dgvRadniSati.Name = "dgvRadniSati";
            this.dgvRadniSati.ReadOnly = true;
            this.dgvRadniSati.RowHeadersWidth = 51;
            this.dgvRadniSati.RowTemplate.Height = 24;
            this.dgvRadniSati.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRadniSati.Size = new System.Drawing.Size(1288, 346);
            this.dgvRadniSati.TabIndex = 0;
            this.dgvRadniSati.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRadniSati_CellContentClick);
            // 
            // RadniSatiId
            // 
            this.RadniSatiId.DataPropertyName = "RadniSatiId";
            this.RadniSatiId.HeaderText = "RadniSatiId";
            this.RadniSatiId.MinimumWidth = 6;
            this.RadniSatiId.Name = "RadniSatiId";
            this.RadniSatiId.ReadOnly = true;
            this.RadniSatiId.Visible = false;
            // 
            // ZaposleniciId
            // 
            this.ZaposleniciId.DataPropertyName = "Zaposlenik";
            this.ZaposleniciId.HeaderText = "Zaposlenik";
            this.ZaposleniciId.MinimumWidth = 6;
            this.ZaposleniciId.Name = "ZaposleniciId";
            this.ZaposleniciId.ReadOnly = true;
            // 
            // PredmetId
            // 
            this.PredmetId.DataPropertyName = "BrojPredmeta";
            this.PredmetId.HeaderText = "Broj predmeta";
            this.PredmetId.MinimumWidth = 6;
            this.PredmetId.Name = "PredmetId";
            this.PredmetId.ReadOnly = true;
            // 
            // BrojRadnihSati
            // 
            this.BrojRadnihSati.DataPropertyName = "BrojRadnihSati";
            this.BrojRadnihSati.HeaderText = "Broj radnih sati";
            this.BrojRadnihSati.MinimumWidth = 6;
            this.BrojRadnihSati.Name = "BrojRadnihSati";
            this.BrojRadnihSati.ReadOnly = true;
            // 
            // PrekovremeniSati
            // 
            this.PrekovremeniSati.DataPropertyName = "PrekovremeniSati";
            this.PrekovremeniSati.HeaderText = "Prekovremeni sati";
            this.PrekovremeniSati.MinimumWidth = 6;
            this.PrekovremeniSati.Name = "PrekovremeniSati";
            this.PrekovremeniSati.ReadOnly = true;
            // 
            // CijenaPoSatu
            // 
            this.CijenaPoSatu.DataPropertyName = "CijenaPoSatu";
            this.CijenaPoSatu.HeaderText = "Cijena po satu";
            this.CijenaPoSatu.MinimumWidth = 6;
            this.CijenaPoSatu.Name = "CijenaPoSatu";
            this.CijenaPoSatu.ReadOnly = true;
            // 
            // CijenaPrekovremenogsata
            // 
            this.CijenaPrekovremenogsata.DataPropertyName = "CijenaPrekovremenogSata";
            this.CijenaPrekovremenogsata.HeaderText = "Cijena prekovremenog sata";
            this.CijenaPrekovremenogsata.MinimumWidth = 6;
            this.CijenaPrekovremenogsata.Name = "CijenaPrekovremenogsata";
            this.CijenaPrekovremenogsata.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 6;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(800, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Za opcije uređivanja možete koristiti dupli klik na odabrani zapis ili button Ure" +
    "di";
            // 
            // btnUredi
            // 
            this.btnUredi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUredi.BackColor = System.Drawing.Color.LightGreen;
            this.btnUredi.Location = new System.Drawing.Point(1094, 40);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(102, 33);
            this.btnUredi.TabIndex = 4;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisi.BackColor = System.Drawing.Color.Red;
            this.btnObrisi.Location = new System.Drawing.Point(1202, 40);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(102, 33);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // frmRadniSati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 512);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbZaposlenici);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmRadniSati";
            this.Text = "Radni sati";
            this.Load += new System.EventHandler(this.FrmRadniSati_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadniSati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbZaposlenici;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRadniSati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadniSatiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZaposleniciId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PredmetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojRadnihSati;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrekovremeniSati;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaPoSatu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CijenaPrekovremenogsata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.Button btnObrisi;
    }
}