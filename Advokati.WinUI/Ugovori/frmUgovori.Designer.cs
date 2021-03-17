namespace Advokati.WinUI.Ugovori
{
    partial class frmUgovori
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
            this.dgvUgovori = new System.Windows.Forms.DataGridView();
            this.UgovorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naslov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPotpisivanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRaskida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZaposleniciId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zavrsen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnraskidugovora = new System.Windows.Forms.Button();
            this.btnUcitajsve = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum potpisivanja:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvUgovori);
            this.groupBox1.Location = new System.Drawing.Point(13, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1124, 352);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ugovori";
            // 
            // dgvUgovori
            // 
            this.dgvUgovori.AllowUserToAddRows = false;
            this.dgvUgovori.AllowUserToDeleteRows = false;
            this.dgvUgovori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUgovori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUgovori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUgovori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UgovorId,
            this.Naslov,
            this.DatumPotpisivanja,
            this.DatumRaskida,
            this.ZaposleniciId,
            this.Zavrsen,
            this.Napomena});
            this.dgvUgovori.Location = new System.Drawing.Point(3, 18);
            this.dgvUgovori.Name = "dgvUgovori";
            this.dgvUgovori.ReadOnly = true;
            this.dgvUgovori.RowHeadersWidth = 51;
            this.dgvUgovori.RowTemplate.Height = 24;
            this.dgvUgovori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUgovori.Size = new System.Drawing.Size(1118, 331);
            this.dgvUgovori.TabIndex = 0;
            this.dgvUgovori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUgovori_CellContentClick);
            // 
            // UgovorId
            // 
            this.UgovorId.DataPropertyName = "UgovorId";
            this.UgovorId.HeaderText = "UgovorId";
            this.UgovorId.MinimumWidth = 6;
            this.UgovorId.Name = "UgovorId";
            this.UgovorId.ReadOnly = true;
            this.UgovorId.Visible = false;
            // 
            // Naslov
            // 
            this.Naslov.DataPropertyName = "Naslov";
            this.Naslov.HeaderText = "Naslov";
            this.Naslov.MinimumWidth = 6;
            this.Naslov.Name = "Naslov";
            this.Naslov.ReadOnly = true;
            // 
            // DatumPotpisivanja
            // 
            this.DatumPotpisivanja.DataPropertyName = "DatumPotpisivanja";
            this.DatumPotpisivanja.HeaderText = "Datum potpisivanja";
            this.DatumPotpisivanja.MinimumWidth = 6;
            this.DatumPotpisivanja.Name = "DatumPotpisivanja";
            this.DatumPotpisivanja.ReadOnly = true;
            // 
            // DatumRaskida
            // 
            this.DatumRaskida.DataPropertyName = "DatumRaskida";
            this.DatumRaskida.HeaderText = "Datum raskida";
            this.DatumRaskida.MinimumWidth = 6;
            this.DatumRaskida.Name = "DatumRaskida";
            this.DatumRaskida.ReadOnly = true;
            // 
            // ZaposleniciId
            // 
            this.ZaposleniciId.DataPropertyName = "Zaposlenik";
            this.ZaposleniciId.HeaderText = "Zaposlenik";
            this.ZaposleniciId.MinimumWidth = 6;
            this.ZaposleniciId.Name = "ZaposleniciId";
            this.ZaposleniciId.ReadOnly = true;
            // 
            // Zavrsen
            // 
            this.Zavrsen.DataPropertyName = "Zavrsen";
            this.Zavrsen.HeaderText = "Završen";
            this.Zavrsen.MinimumWidth = 6;
            this.Zavrsen.Name = "Zavrsen";
            this.Zavrsen.ReadOnly = true;
            this.Zavrsen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Zavrsen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.MinimumWidth = 6;
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.CloseUp += new System.EventHandler(this.DateTimePicker1_CloseUp);
            this.dateTimePicker1.DropDown += new System.EventHandler(this.DateTimePicker1_DropDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Za opcije uređivanja možete koristiti dupli klik na odabrani zapis ili button Ure" +
    "di";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(932, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Uredi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisi.BackColor = System.Drawing.Color.Red;
            this.btnObrisi.Location = new System.Drawing.Point(1036, 28);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(98, 32);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // btnraskidugovora
            // 
            this.btnraskidugovora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnraskidugovora.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnraskidugovora.Location = new System.Drawing.Point(783, 27);
            this.btnraskidugovora.Name = "btnraskidugovora";
            this.btnraskidugovora.Size = new System.Drawing.Size(143, 32);
            this.btnraskidugovora.TabIndex = 7;
            this.btnraskidugovora.Text = "Raskini ugovor";
            this.btnraskidugovora.UseVisualStyleBackColor = false;
            this.btnraskidugovora.Click += new System.EventHandler(this.Btnraskidugovora_Click);
            // 
            // btnUcitajsve
            // 
            this.btnUcitajsve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUcitajsve.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUcitajsve.Location = new System.Drawing.Point(367, 34);
            this.btnUcitajsve.Name = "btnUcitajsve";
            this.btnUcitajsve.Size = new System.Drawing.Size(83, 32);
            this.btnUcitajsve.TabIndex = 8;
            this.btnUcitajsve.Text = "Učitaj sve";
            this.btnUcitajsve.UseVisualStyleBackColor = false;
            this.btnUcitajsve.Click += new System.EventHandler(this.BtnUcitajsve_Click);
            // 
            // frmUgovori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 477);
            this.Controls.Add(this.btnUcitajsve);
            this.Controls.Add(this.btnraskidugovora);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmUgovori";
            this.Text = "Ugovori";
            this.Load += new System.EventHandler(this.FrmUgovori_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUgovori;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UgovorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naslov;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPotpisivanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRaskida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZaposleniciId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Zavrsen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnraskidugovora;
        private System.Windows.Forms.Button btnUcitajsve;
    }
}