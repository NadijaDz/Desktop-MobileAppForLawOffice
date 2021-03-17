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

namespace Advokati.WinUI.Zadaci
{
    public partial class frmZadaci : Form
    {
        private readonly APIService _aPIService = new APIService("Zadaci");
        public frmZadaci()
        {
            InitializeComponent();
        }

        private async void FrmZadaci_Load(object sender, EventArgs e)
        {
            var result = await _aPIService.Get<List<Model.Zadaci>>();
            dgvZadaci.AutoGenerateColumns = false;
            dgvZadaci.DataSource = result;
          
        }

        private async void TxtPretraga_TextChanged(object sender, EventArgs e)
        {
            var search = new ZadaciSearchRequest
            {
                Naziv=txtPretraga.Text
            };

            var result = await _aPIService.Get<List<Model.Zadaci>>(search);
            dgvZadaci.DataSource = result;
          

        }

        private void DgvZadaci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvZadaci.SelectedRows[0].Cells[0].Value;
            frmZadaciDetalji frm = new frmZadaciDetalji(int.Parse(id.ToString()),this);
            frm.Show();
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var id = dgvZadaci.SelectedRows[0].Cells[0].Value;
            frmZadaciDetalji frm = new frmZadaciDetalji(int.Parse(id.ToString()),this);
            if ((int.Parse(id.ToString())) != 0)
            {
                frm.Show();
            }
        }

        public async void RefreshData()
        {
            var result = await _aPIService.Get<List<Model.Zadaci>>();
            dgvZadaci.AutoGenerateColumns = false;
            dgvZadaci.DataSource = result;
        }

    

        private async void BtnObrisi_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite obrisati ovaj zapis?", "Obriši ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = dgvZadaci.SelectedRows[0].Cells[0].Value;
                var entity = await _aPIService.GetById<Model.Zadaci>(id);
                if (id != null)
                {

                    await _aPIService.UpdateDelete<Model.Zadaci>(id, entity);

                    MessageBox.Show(Properties.Resources.MessageBoxForDelete);

                    this.RefreshData();
                }
            }
        }
    }
}
