namespace Advokati.WinUI
{
    partial class frmSastanci
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSastanci = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnOdobri = new System.Windows.Forms.Button();
            this.btnucitajsve = new System.Windows.Forms.Button();
            this.SastanakId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumSastanka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjestoOdrzavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poruka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZaposleniciId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KlijentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odrzan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Odobreno = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.VrstaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastanci)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum sastanka:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvSastanci);
            this.groupBox1.Location = new System.Drawing.Point(13, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1355, 359);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sastanci";
            // 
            // dgvSastanci
            // 
            this.dgvSastanci.AllowUserToAddRows = false;
            this.dgvSastanci.AllowUserToDeleteRows = false;
            this.dgvSastanci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSastanci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSastanci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSastanci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SastanakId,
            this.DatumSastanka,
            this.MjestoOdrzavanja,
            this.Poruka,
            this.ZaposleniciId,
            this.KlijentId,
            this.Odrzan,
            this.Odobreno,
            this.VrstaId});
            this.dgvSastanci.Location = new System.Drawing.Point(3, 18);
            this.dgvSastanci.Name = "dgvSastanci";
            this.dgvSastanci.ReadOnly = true;
            this.dgvSastanci.RowHeadersWidth = 51;
            this.dgvSastanci.RowTemplate.Height = 24;
            this.dgvSastanci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSastanci.Size = new System.Drawing.Size(1349, 338);
            this.dgvSastanci.TabIndex = 0;
            this.dgvSastanci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSastanci_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.CloseUp += new System.EventHandler(this.DateTimePicker1_CloseUp);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            this.dateTimePicker1.DropDown += new System.EventHandler(this.DateTimePicker1_DropDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(861, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Za opcije uređivanja možete koristiti dupli klik na odabrani zapis ili button Ure" +
    "di";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(1181, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Uredi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisi.BackColor = System.Drawing.Color.Red;
            this.btnObrisi.Location = new System.Drawing.Point(1276, 38);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(89, 33);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // btnOdobri
            // 
            this.btnOdobri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdobri.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOdobri.Location = new System.Drawing.Point(1086, 38);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(89, 33);
            this.btnOdobri.TabIndex = 6;
            this.btnOdobri.Text = "Odobri";
            this.btnOdobri.UseVisualStyleBackColor = false;
            this.btnOdobri.Click += new System.EventHandler(this.BtnOdobri_Click);
            // 
            // btnucitajsve
            // 
            this.btnucitajsve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnucitajsve.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnucitajsve.Location = new System.Drawing.Point(359, 34);
            this.btnucitajsve.Name = "btnucitajsve";
            this.btnucitajsve.Size = new System.Drawing.Size(84, 34);
            this.btnucitajsve.TabIndex = 7;
            this.btnucitajsve.Text = "Učitaj sve";
            this.btnucitajsve.UseVisualStyleBackColor = false;
            this.btnucitajsve.Click += new System.EventHandler(this.Btnucitajsve_Click);
            // 
            // SastanakId
            // 
            this.SastanakId.DataPropertyName = "SastanakId";
            this.SastanakId.HeaderText = "SastanakId";
            this.SastanakId.MinimumWidth = 6;
            this.SastanakId.Name = "SastanakId";
            this.SastanakId.ReadOnly = true;
            this.SastanakId.Visible = false;
            // 
            // DatumSastanka
            // 
            this.DatumSastanka.DataPropertyName = "DatumSastanka";
            this.DatumSastanka.HeaderText = "Datum sastanka";
            this.DatumSastanka.MinimumWidth = 6;
            this.DatumSastanka.Name = "DatumSastanka";
            this.DatumSastanka.ReadOnly = true;
            // 
            // MjestoOdrzavanja
            // 
            this.MjestoOdrzavanja.DataPropertyName = "MjestoOdrzavanja";
            this.MjestoOdrzavanja.HeaderText = "Mjesto održavanja";
            this.MjestoOdrzavanja.MinimumWidth = 6;
            this.MjestoOdrzavanja.Name = "MjestoOdrzavanja";
            this.MjestoOdrzavanja.ReadOnly = true;
            // 
            // Poruka
            // 
            this.Poruka.DataPropertyName = "Poruka";
            this.Poruka.HeaderText = "Poruka";
            this.Poruka.MinimumWidth = 6;
            this.Poruka.Name = "Poruka";
            this.Poruka.ReadOnly = true;
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
            // Odrzan
            // 
            this.Odrzan.DataPropertyName = "Odrzan";
            this.Odrzan.HeaderText = "Održan";
            this.Odrzan.MinimumWidth = 6;
            this.Odrzan.Name = "Odrzan";
            this.Odrzan.ReadOnly = true;
            // 
            // Odobreno
            // 
            this.Odobreno.DataPropertyName = "Odobreno";
            this.Odobreno.HeaderText = "Odobreno";
            this.Odobreno.MinimumWidth = 6;
            this.Odobreno.Name = "Odobreno";
            this.Odobreno.ReadOnly = true;
            // 
            // VrstaId
            // 
            this.VrstaId.DataPropertyName = "VrstaPredmeta";
            this.VrstaId.HeaderText = "Vrsta usluge";
            this.VrstaId.MinimumWidth = 6;
            this.VrstaId.Name = "VrstaId";
            this.VrstaId.ReadOnly = true;
            // 
            // frmSastanci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 484);
            this.Controls.Add(this.btnucitajsve);
            this.Controls.Add(this.btnOdobri);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmSastanci";
            this.Text = "Sastanci";
            this.Load += new System.EventHandler(this.FrmSastanci_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastanci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSastanci;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOdobri;
        private System.Windows.Forms.Button btnucitajsve;
        private System.Windows.Forms.DataGridViewTextBoxColumn SastanakId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumSastanka;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjestoOdrzavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poruka;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZaposleniciId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odrzan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odobreno;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaId;
    }
}