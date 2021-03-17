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

namespace Advokati.WinUI.Ured
{
    public partial class frmUred : Form
    {
        private readonly APIService _aPIService = new APIService("Ured");

        public frmUred()
        {
            InitializeComponent();
        }

        private async void FrmUred_Load(object sender, EventArgs e)
        {
            var result = await _aPIService.Get<List<Model.Ured>>();
            dgvUred.AutoGenerateColumns = false;
            dgvUred.DataSource = result;
        
           

        }

        private async void TxtPretraga_TextChanged(object sender, EventArgs e)
        {
            var search = new UredSearchRequest
            {
                Naziv = txtPretraga.Text
            };

            var result = await _aPIService.Get<List<Model.Ured>>(search);
            dgvUred.DataSource = result;
         

        }

        private void DgvUred_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvUred.SelectedRows[0].Cells[0].Value;
            frmUredDetalji frm = new frmUredDetalji(int.Parse(id.ToString()),this);
            frm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var id = dgvUred.SelectedRows[0].Cells[0].Value;

            frmUredDetalji frm = new frmUredDetalji(int.Parse(id.ToString()),this);
            if ((int.Parse(id.ToString())) != 0)
            {
                frm.Show();
            }
        }
        public async void RefreshData()
        {
            var result = await _aPIService.Get<List<Model.Ured>>();
            dgvUred.AutoGenerateColumns = false;
            dgvUred.DataSource = result;
        }

        private async void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite obrisati ovaj zapis?", "Obriši ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = dgvUred.SelectedRows[0].Cells[0].Value;
                var entity = await _aPIService.GetById<Model.Ured>(id);
                if (id != null)
                {

                    await _aPIService.UpdateDelete<Model.Ured>(id, entity);

                    MessageBox.Show(Properties.Resources.MessageBoxForDelete);

                    this.RefreshData();
                }
            }
        }
    }
}
