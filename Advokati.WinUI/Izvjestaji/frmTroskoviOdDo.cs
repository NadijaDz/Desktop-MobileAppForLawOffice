using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advokati.WinUI.Izvjestaji
{
    public partial class frmTroskoviOdDo : Form
    {

        private readonly APIService _aPIService = new APIService("Troskovi");
        public frmTroskoviOdDo()
        {
            InitializeComponent();
         
        
        }

        private void FrmTroskoviOdDo_Load(object sender, EventArgs e)
        {
            
           
        }

        private async void BtnPrintaj_Click(object sender, EventArgs e)
        {
            var listaTroskova = await _aPIService.GetAllForReport<List<Model.Troskovi>>(dateTimePickerOD.Value,dateTimePickerDO.Value);
        

            this.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet2";
            rds.Value = listaTroskova;

            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumOd",dateTimePickerOD.Value.ToShortDateString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DatumDo", dateTimePickerDO.Value.ToShortDateString()));
            reportViewer1.RefreshReport();
        }
    }
}
