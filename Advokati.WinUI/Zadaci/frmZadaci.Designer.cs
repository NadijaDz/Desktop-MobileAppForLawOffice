namespace Advokati.WinUI.Zadaci
{
    partial class frmZadaci
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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvZadaci = new System.Windows.Forms.DataGridView();
            this.ZadatakId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZaposleniciId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zavrsen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZadaci)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(117, 37);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(211, 22);
            this.txtPretraga.TabIndex = 0;
            this.txtPretraga.TextChanged += new System.EventHandler(this.TxtPretraga_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv zadatka:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvZadaci);
            this.groupBox1.Location = new System.Drawing.Point(13, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(988, 339);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zadaci";
            // 
            // dgvZadaci
            // 
            this.dgvZadaci.AllowUserToAddRows = false;
            this.dgvZadaci.AllowUserToDeleteRows = false;
            this.dgvZadaci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZadaci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZadaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZadaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZadatakId,
            this.Naziv,
            this.Opis,
            this.DatumPocetka,
            this.Rok,
            this.ZaposleniciId,
            this.Zavrsen});
            this.dgvZadaci.Location = new System.Drawing.Point(3, 18);
            this.dgvZadaci.Name = "dgvZadaci";
            this.dgvZadaci.ReadOnly = true;
            this.dgvZadaci.RowHeadersWidth = 51;
            this.dgvZadaci.RowTemplate.Height = 24;
            this.dgvZadaci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZadaci.Size = new System.Drawing.Size(982, 318);
            this.dgvZadaci.TabIndex = 0;
            this.dgvZadaci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvZadaci_CellContentClick);
            // 
            // ZadatakId
            // 
            this.ZadatakId.DataPropertyName = "ZadatakId";
            this.ZadatakId.HeaderText = "ZadatakId";
            this.ZadatakId.MinimumWidth = 6;
            this.ZadatakId.Name = "ZadatakId";
            this.ZadatakId.ReadOnly = true;
            this.ZadatakId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Opis";
            this.Opis.MinimumWidth = 6;
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // DatumPocetka
            // 
            this.DatumPocetka.DataPropertyName = "DatumPocetka";
            this.DatumPocetka.HeaderText = "Datum početka";
            this.DatumPocetka.MinimumWidth = 6;
            this.DatumPocetka.Name = "DatumPocetka";
            this.DatumPocetka.ReadOnly = true;
            // 
            // Rok
            // 
            this.Rok.DataPropertyName = "Rok";
            this.Rok.HeaderText = "Rok";
            this.Rok.MinimumWidth = 6;
            this.Rok.Name = "Rok";
            this.Rok.ReadOnly = true;
            // 
            // ZaposleniciId
            // 
            this.ZaposleniciId.DataPropertyName = "Zaposlenik";
            this.ZaposleniciId.HeaderText = "Zaposlenik";
            this.ZaposleniciId.MinimumWidth = 6;
            this.ZaposleniciId.Name = "ZaposleniciId";
            this.ZaposleniciId.ReadOnly = true;
            this.ZaposleniciId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ZaposleniciId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Zavrsen
            // 
            this.Zavrsen.DataPropertyName = "Zavrsen";
            this.Zavrsen.HeaderText = "Završen";
            this.Zavrsen.MinimumWidth = 6;
            this.Zavrsen.Name = "Zavrsen";
            this.Zavrsen.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 93);
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
            this.button1.Location = new System.Drawing.Point(792, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Uredi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisi.BackColor = System.Drawing.Color.Red;
            this.btnObrisi.Location = new System.Drawing.Point(898, 32);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 32);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click_1);
            // 
            // frmZadaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 464);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.MaximizeBox = false;
            this.Name = "frmZadaci";
            this.Text = "Zadaci";
            this.Load += new System.EventHandler(this.FrmZadaci_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZadaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvZadaci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZadatakId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPocetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rok;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZaposleniciId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Zavrsen;
        private System.Windows.Forms.Button btnObrisi;
    }
}