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

namespace Advokati.WinUI.Rocista
{
    public partial class frmRocista : Form
    {
        private readonly APIService _aPIService = new APIService("Rocista");
        private bool _calendarDroppedDown = false;
        public frmRocista()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private async void FrmRocista_Load(object sender, EventArgs e)
        {
          

            var result = await _aPIService.Get<List<Model.Rocista>>();
            dgvRocista.AutoGenerateColumns = false;
            dgvRocista.DataSource = result;
            
        }

 

        private void DateTimePicker1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_DropDown(object sender, EventArgs e)
        {
            _calendarDroppedDown = true;
        }

        private void DateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            _calendarDroppedDown = false;
            RefreshToolbox(null, null);

        }
        public async void RefreshToolbox(object sender, EventArgs e)
        {
            if (_calendarDroppedDown)
            {
                return;
            }
            else
            {
                var search = new RocistaSearchRequest
                {
                    DatumRocista = dateTimePicker1.Value
                };

                var result = await _aPIService.Get<List<Model.Rocista>>(search);
                dgvRocista.DataSource = result;
             
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private  void DgvRocista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvRocista.SelectedRows[0].Cells[0].Value;
            frmRocistaDetalji frm = new frmRocistaDetalji(int.Parse(id.ToString()),this);
            frm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var id = dgvRocista.SelectedRows[0].Cells[0].Value;
            frmRocistaDetalji frm = new frmRocistaDetalji(int.Parse(id.ToString()),this);
            if ((int.Parse(id.ToString()))!=0)
            {
                frm.Show();

            }
        }

        public async void RefreshData()
        {
            var result = await _aPIService.Get<List<Model.Rocista>>();
            dgvRocista.AutoGenerateColumns = false;
            dgvRocista.DataSource = result;
        }

        private async void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite obrisati ovaj zapis?", "Obriši ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = dgvRocista.SelectedRows[0].Cells[0].Value;
                var entity = await _aPIService.GetById<Model.Rocista>(id);
                if (id != null)
                {


                    await _aPIService.UpdateDelete<Model.Rocista>(id, entity);
                    MessageBox.Show(Properties.Resources.MessageBoxForDelete);

                    this.RefreshData();
                }
            }
        }

        private async void Btnucitajsve_Click(object sender, EventArgs e)
        {
            var result = await _aPIService.Get<List<Model.Rocista>>();
            dgvRocista.AutoGenerateColumns = false;
            dgvRocista.DataSource = result;
        }
    }
}
