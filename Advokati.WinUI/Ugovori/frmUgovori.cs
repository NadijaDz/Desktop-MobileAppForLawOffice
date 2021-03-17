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

namespace Advokati.WinUI.Ugovori
{
    public partial class frmUgovori : Form
    {
        private readonly APIService _aPIService = new APIService("Ugovori");
        private bool _calendarDroppedDown = false;
        public frmUgovori()
        {
            InitializeComponent();
        }

        private async void FrmUgovori_Load(object sender, EventArgs e)
        {
            var result = await _aPIService.Get<List<Model.Ugovori>>();
            dgvUgovori.AutoGenerateColumns = false;
            dgvUgovori.DataSource = result;
           

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
                var search = new UgovoriSearchRequest
                {
                    DatumPotpisivanja = dateTimePicker1.Value
                };

                var result = await _aPIService.Get<List<Model.Ugovori>>(search);
                dgvUgovori.DataSource = result;
             

            }
        }

        private void DgvUgovori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvUgovori.SelectedRows[0].Cells[0].Value;
            frmUgovoriDetalji frm = new frmUgovoriDetalji(int.Parse(id.ToString()),this);
            frm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var id = dgvUgovori.SelectedRows[0].Cells[0].Value;
            frmUgovoriDetalji frm = new frmUgovoriDetalji(int.Parse(id.ToString()),this);
            if ((int.Parse(id.ToString())) != 0)
            {
                frm.Show();
            }
        }
        public async void RefreshData()
        {
            var result = await _aPIService.Get<List<Model.Ugovori>>();
            dgvUgovori.AutoGenerateColumns = false;
            dgvUgovori.DataSource = result;
        }

        private async void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite obrisati ovaj zapis?", "Obriši ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = dgvUgovori.SelectedRows[0].Cells[0].Value;
                var entity = await _aPIService.GetById<Model.Ugovori>(id);
                if (id != null)
                {

                    await _aPIService.UpdateDelete<Model.Ugovori>(id, entity);

                    MessageBox.Show(Properties.Resources.MessageBoxForDelete);
                    this.RefreshData();
                }
            }
        }

        private async void Btnraskidugovora_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite raskinuti ovaj ugovor?", "Raskini ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = dgvUgovori.SelectedRows[0].Cells[0].Value;
                var entity = await _aPIService.GetById<Model.Ugovori>(id);
                if (id != null)
                {

                    var request = new UgovoriInsertRequest()
                    {
                        ZaposleniciId = entity.ZaposleniciId,
                        Naslov = entity.Naslov,
                        DatumPotpisivanja = entity.DatumPotpisivanja,
                        DatumRaskida = DateTime.Today,
                        Napomena = entity.Napomena,
                        Zavrsen = true,
                        IsDeleted = entity.IsDeleted


                    };

                    await _aPIService.Update<Model.Ugovori>(id, request);
                    MessageBox.Show(Properties.Resources.MessageBoxForSave);
                    this.RefreshData();
                }
            }
        }

        private async void BtnUcitajsve_Click(object sender, EventArgs e)
        {
            var result = await _aPIService.Get<List<Model.Ugovori>>();
            dgvUgovori.AutoGenerateColumns = false;
            dgvUgovori.DataSource = result;
        }
    }
}
