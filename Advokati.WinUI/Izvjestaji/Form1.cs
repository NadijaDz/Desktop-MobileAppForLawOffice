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
    public partial class Form1 : Form
    {
        public Model.Troskovi troskovi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Model.Troskovi> lista = new List<Model.Troskovi>();
            lista.Add(troskovi);
            

            this.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = lista;
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("BrojPredmeta",troskovi.BrojPredmeta));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Ukupno", troskovi.Iznos.ToString()));
            this.reportViewer1.RefreshReport();
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {
           

        }
    }
}
