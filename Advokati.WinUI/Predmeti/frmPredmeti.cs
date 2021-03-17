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

namespace Advokati.WinUI.Predmeti
{
    public partial class frmPredmeti : Form
    {
        private readonly APIService _aPIService = new APIService("Predmeti");
        public frmPredmeti()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DgvPredmeti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void FrmPredmeti_Load(object sender, EventArgs e)
        {
            var result = await _aPIService.Get<List<Model.Predmeti>>();
            dgvPredmeti.AutoGenerateColumns = false;
            dgvPredmeti.DataSource = result;
        
        }

        private async void TxtPretraga_TextChanged(object sender, EventArgs e)
        {
            var search = new PredmetiSearchRequest
            {
                BrojPredmeta = txtPretraga.Text
            };

            var result = await _aPIService.Get < List< Model.Predmeti>>(search);
            dgvPredmeti.DataSource = result;
           
        }

        private void DgvPredmeti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvPredmeti.SelectedRows[0].Cells[0].Value;
            frmPredmetiDetalji frm = new frmPredmetiDetalji(int.Parse(id.ToString()),this);
            frm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            var id = dgvPredmeti.SelectedRows[0].Cells[0].Value;
            frmPredmetiDetalji frm = new frmPredmetiDetalji(int.Parse(id.ToString()),this);
            if ((int.Parse(id.ToString())) != 0)
            {
                frm.Show();
            }
        }


        public async void RefreshData()
        {
            var result = await _aPIService.Get<List<Model.Predmeti>>();
            dgvPredmeti.AutoGenerateColumns = false;
            dgvPredmeti.DataSource = result;
        }

        private async void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite obrisati ovaj zapis?", "Obriši ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = dgvPredmeti.SelectedRows[0].Cells[0].Value;
                var entity = await _aPIService.GetById<Model.Predmeti>(id);
                if (id != null)
                {

                    await _aPIService.UpdateDelete<Model.Predmeti>(id, entity);

                    MessageBox.Show(Properties.Resources.MessageBoxForDelete);

                    this.RefreshData();
                }
            }
        }
    }
}
