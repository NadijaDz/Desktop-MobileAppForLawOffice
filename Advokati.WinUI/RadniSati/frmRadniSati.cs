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

namespace Advokati.WinUI.RadniSati
{
    public partial class frmRadniSati : Form
    {
        private readonly APIService _aPIService = new APIService("RadniSati");
        private readonly APIService _aPIServiceZaposlenici = new APIService("Zaposlenici");
   


        public frmRadniSati()
        {
            InitializeComponent();
        }

       

        private async void FrmRadniSati_Load(object sender, EventArgs e)
        {

            var result = await _aPIService.Get<List<Model.RadniSati>>();
            dgvRadniSati.AutoGenerateColumns = false;
            dgvRadniSati.DataSource = result;
           

            var listaZaposlenih = await _aPIServiceZaposlenici.Get<List<Model.Korisnici>>();
            List<Model.Korisnici> resultZaposlenici = new List<Model.Korisnici>();
            foreach (var z in listaZaposlenih)
            {
                if (z.NazivUloge != "Klijent")
                {
                    resultZaposlenici.Add(z);
                }
            }
            cbZaposlenici.DisplayMember = "ImePrezime";
            cbZaposlenici.ValueMember = "ZaposlenikId";
            cbZaposlenici.DataSource = resultZaposlenici;
            cbZaposlenici.SelectedIndex = -1;

        }

        private async void CbZaposlenici_DropDownClosed(object sender, EventArgs e)
        {
            var search = new RadniSatiSearchRequest
            {
                ZaposleniciId=Convert.ToInt32(cbZaposlenici.SelectedValue)
            };
            
            var result = await _aPIService.Get<List<Model.RadniSati>>(search);
            dgvRadniSati.DataSource = result;
           
        }

        private void DgvRadniSati_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvRadniSati.SelectedRows[0].Cells[0].Value;
            frmRadniSatiDetalji frm = new frmRadniSatiDetalji(int.Parse(id.ToString()),this);
            frm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var id = dgvRadniSati.SelectedRows[0].Cells[0].Value;
            frmRadniSatiDetalji frm = new frmRadniSatiDetalji(int.Parse(id.ToString()),this);
            if ((int.Parse(id.ToString())) != 0)
            {
                frm.Show();
            }
        }

        public async void RefreshData()
        {
            var result = await _aPIService.Get<List<Model.RadniSati>>();
            dgvRadniSati.AutoGenerateColumns = false;
            dgvRadniSati.DataSource = result;
        }

        private async void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite obrisati ovaj zapis?", "Obriši ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = dgvRadniSati.SelectedRows[0].Cells[0].Value;
                var entity = await _aPIService.GetById<Model.RadniSati>(id);
                if (id != null)
                {

                    await _aPIService.UpdateDelete<Model.RadniSati>(id, entity);

                    MessageBox.Show(Properties.Resources.MessageBoxForDelete);

                    this.RefreshData();
                }
            }
        }
    }
}
