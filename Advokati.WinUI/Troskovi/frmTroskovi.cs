using Advokati.Model.Requests;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advokati.WinUI.Troskovi
{
    public partial class frmTroskovi : Form
    {
        private readonly APIService _aPIService = new APIService("Troskovi");



        public frmTroskovi()
        {
            InitializeComponent();

        }

        private async void FrmTroskovi_Load(object sender, EventArgs e)
        {
           
            var result = await _aPIService.Get<List<Model.Troskovi>>();
            dgvTroskovi.AutoGenerateColumns = false;
            dgvTroskovi.DataSource = result;

            
        }

        private async void TxtPretraga_TextChanged(object sender, EventArgs e)
        {
            var search = new TroskoviSearchRequest
            {
                Sifra = txtPretraga.Text
            };

            var result = await _aPIService.Get<List<Model.Troskovi>>(search);
            dgvTroskovi.DataSource = result;


        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void DgvTroskovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvTroskovi.SelectedRows[0].Cells[0].Value;

            if (e.ColumnIndex == 7)
            {
              
                int idTroska = int.Parse(id.ToString());
                var troskovi = await _aPIService.GetById<Model.Troskovi>(id);
                var listaTroskova = await _aPIService.Get<List<Model.Troskovi>>();
                foreach (var t in listaTroskova)
                {
                    if (t.TrosakId == idTroska)
                    {
                        troskovi.BrojPredmeta = t.BrojPredmeta;
                    }
                }

                Izvjestaji.Form1 frmR = new Izvjestaji.Form1();
                frmR.troskovi = troskovi;
                frmR.Show();
                return;
            }


            frmTroskoviDetalji frm = new frmTroskoviDetalji(int.Parse(id.ToString()), this);
            frm.Show();


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var id = dgvTroskovi.SelectedRows[0].Cells[0].Value;
            frmTroskoviDetalji frm = new frmTroskoviDetalji(int.Parse(id.ToString()), this);
            if (int.Parse(id.ToString()) != 0)
            {
                frm.Show();
            }
        }


        public async void RefreshData()
        {
            var result = await _aPIService.Get<List<Model.Troskovi>>();
            dgvTroskovi.AutoGenerateColumns = false;
            dgvTroskovi.DataSource = result;
        }

        private async void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite obrisati ovaj zapis?", "Obriši ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = dgvTroskovi.SelectedRows[0].Cells[0].Value;
                var entity = await _aPIService.GetById<Model.Troskovi>(id);
                if (id != null)
                {

                    await _aPIService.UpdateDelete<Model.Troskovi>(id, entity);

                    MessageBox.Show(Properties.Resources.MessageBoxForDelete);

                    this.RefreshData();
                }
            }
        }

        //private async void Button2_Click(object sender, EventArgs e)
        //{
        //    var id = dgvTroskovi.SelectedRows[0].Cells[0].Value;
        //    int idTroska = int.Parse(id.ToString());
        //    var troskovi = await _aPIService.GetById<Model.Troskovi>(id);
        //    var listaTroskova = await _aPIService.Get<List<Model.Troskovi>>();
        //    foreach (var t in listaTroskova)
        //    {
        //        if (t.TrosakId == idTroska)
        //        {
        //            troskovi.BrojPredmeta = t.BrojPredmeta;
        //        }
        //    }

        //    Izvjestaji.Form1 frmR = new Izvjestaji.Form1();
        //    frmR.troskovi = troskovi;
        //    frmR.Show();


        //}
    }
}
