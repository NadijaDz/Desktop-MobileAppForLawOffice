namespace Advokati.WinUI.Rocista
{
    partial class frmRocista
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
            this.dgvRocista = new System.Windows.Forms.DataGridView();
            this.RocisteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRocista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mjesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PredmetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZaposlenikId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odrzano = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnucitajsve = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRocista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvRocista);
            this.groupBox1.Location = new System.Drawing.Point(24, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ročišta";
            // 
            // dgvRocista
            // 
            this.dgvRocista.AllowUserToAddRows = false;
            this.dgvRocista.AllowUserToDeleteRows = false;
            this.dgvRocista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRocista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRocista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRocista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RocisteId,
            this.DatumRocista,
            this.Mjesto,
            this.PredmetID,
            this.ZaposlenikId,
            this.Odrzano,
            this.Napomena});
            this.dgvRocista.Location = new System.Drawing.Point(3, 18);
            this.dgvRocista.Name = "dgvRocista";
            this.dgvRocista.ReadOnly = true;
            this.dgvRocista.RowHeadersWidth = 51;
            this.dgvRocista.RowTemplate.Height = 24;
            this.dgvRocista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRocista.Size = new System.Drawing.Size(1038, 312);
            this.dgvRocista.TabIndex = 0;
            this.dgvRocista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRocista_CellContentClick);
            // 
            // RocisteId
            // 
            this.RocisteId.DataPropertyName = "RocisteId";
            this.RocisteId.HeaderText = "RocisteId";
            this.RocisteId.MinimumWidth = 6;
            this.RocisteId.Name = "RocisteId";
            this.RocisteId.ReadOnly = true;
            this.RocisteId.Visible = false;
            // 
            // DatumRocista
            // 
            this.DatumRocista.DataPropertyName = "DatumRocista";
            this.DatumRocista.HeaderText = "Datum ročišta";
            this.DatumRocista.MinimumWidth = 6;
            this.DatumRocista.Name = "DatumRocista";
            this.DatumRocista.ReadOnly = true;
            // 
            // Mjesto
            // 
            this.Mjesto.DataPropertyName = "Mjesto";
            this.Mjesto.HeaderText = "Mjesto";
            this.Mjesto.MinimumWidth = 6;
            this.Mjesto.Name = "Mjesto";
            this.Mjesto.ReadOnly = true;
            // 
            // PredmetID
            // 
            this.PredmetID.DataPropertyName = "BrojPredmeta";
            this.PredmetID.HeaderText = "Broj predmeta";
            this.PredmetID.MinimumWidth = 6;
            this.PredmetID.Name = "PredmetID";
            this.PredmetID.ReadOnly = true;
            // 
            // ZaposlenikId
            // 
            this.ZaposlenikId.DataPropertyName = "Zaposlenik";
            this.ZaposlenikId.HeaderText = "Zaposlenik";
            this.ZaposlenikId.MinimumWidth = 6;
            this.ZaposlenikId.Name = "ZaposlenikId";
            this.ZaposlenikId.ReadOnly = true;
            // 
            // Odrzano
            // 
            this.Odrzano.DataPropertyName = "Odrzano";
            this.Odrzano.HeaderText = "Održano";
            this.Odrzano.MinimumWidth = 6;
            this.Odrzano.Name = "Odrzano";
            this.Odrzano.ReadOnly = true;
            // 
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "Napomena";
            this.Napomena.MinimumWidth = 6;
            this.Napomena.Name = "Napomena";
            this.Napomena.ReadOnly = true;
            this.Napomena.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Napomena.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datum ročišta:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.CloseUp += new System.EventHandler(this.DateTimePicker1_CloseUp);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            this.dateTimePicker1.DropDown += new System.EventHandler(this.DateTimePicker1_DropDown);
            this.dateTimePicker1.VisibleChanged += new System.EventHandler(this.DateTimePicker1_VisibleChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(871, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Uredi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Za opcije uređivanja možete koristiti dupli klik na odabrani zapis ili button Ure" +
    "di";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisi.BackColor = System.Drawing.Color.Red;
            this.btnObrisi.Location = new System.Drawing.Point(971, 21);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(94, 33);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // btnucitajsve
            // 
            this.btnucitajsve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnucitajsve.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnucitajsve.Location = new System.Drawing.Point(369, 29);
            this.btnucitajsve.Name = "btnucitajsve";
            this.btnucitajsve.Size = new System.Drawing.Size(87, 33);
            this.btnucitajsve.TabIndex = 7;
            this.btnucitajsve.Text = "Učitaj sve";
            this.btnucitajsve.UseVisualStyleBackColor = false;
            this.btnucitajsve.Click += new System.EventHandler(this.Btnucitajsve_Click);
            // 
            // frmRocista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 450);
            this.Controls.Add(this.btnucitajsve);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmRocista";
            this.Text = "Ročišta";
            this.Load += new System.EventHandler(this.FrmRocista_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRocista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRocista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RocisteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRocista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mjesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PredmetID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZaposlenikId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odrzano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnucitajsve;
    }
}