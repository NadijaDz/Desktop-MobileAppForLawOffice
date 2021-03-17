namespace Advokati.WinUI.Izvjestaji
{
    partial class frmTroskoviOdDo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TroskoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerOD = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDO = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.TroskoviBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TroskoviBindingSource
            // 
            this.TroskoviBindingSource.DataSource = typeof(Advokati.Model.Troskovi);
            // 
            // dateTimePickerOD
            // 
            this.dateTimePickerOD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOD.Location = new System.Drawing.Point(59, 23);
            this.dateTimePickerOD.Name = "dateTimePickerOD";
            this.dateTimePickerOD.Size = new System.Drawing.Size(207, 22);
            this.dateTimePickerOD.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "OD:";
            // 
            // dateTimePickerDO
            // 
            this.dateTimePickerDO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDO.Location = new System.Drawing.Point(341, 23);
            this.dateTimePickerDO.Name = "dateTimePickerDO";
            this.dateTimePickerDO.Size = new System.Drawing.Size(212, 22);
            this.dateTimePickerDO.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "DO:";
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrintaj.Location = new System.Drawing.Point(596, 18);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(87, 27);
            this.btnPrintaj.TabIndex = 4;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = false;
            this.btnPrintaj.Click += new System.EventHandler(this.BtnPrintaj_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.TroskoviBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Advokati.WinUI.Izvjestaji.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 77);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(130, 3, 3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(967, 706);
            this.reportViewer1.TabIndex = 5;
            // 
            // frmTroskoviOdDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 783);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerOD);
            this.MaximizeBox = false;
            this.Name = "frmTroskoviOdDo";
            this.Text = "frmTroskoviOdDo";
            this.Load += new System.EventHandler(this.FrmTroskoviOdDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TroskoviBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerOD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrintaj;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TroskoviBindingSource;
    }
}