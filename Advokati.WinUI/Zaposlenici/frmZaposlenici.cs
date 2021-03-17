using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advokati.Model.Requests;
using Flurl;
using Flurl.Http;

namespace Advokati.WinUI.Zaposlenici
{
    public partial class frmZaposlenici : Form
    {

        private readonly APIService _aPIService = new APIService("Zaposlenici");
        public frmZaposlenici()
        {
            InitializeComponent();

        }

      

        private void DgvZaposlenici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void FrmZaposlenici_Load(object sender, EventArgs e)
        {
            var zaposlenici = await _aPIService.Get<List<Model.Korisnici>>();

            List<Model.Korisnici> result = new List<Model.Korisnici>();
            foreach (var z in zaposlenici)
            {
                if (z.NazivUloge != "Klijent")
                {
                    result.Add(z);
                }
            }


            dgvZaposlenici.AutoGenerateColumns = false;
            dgvZaposlenici.DataSource = result;
          

        }

        private async void TxtPretraga_TextChanged(object sender, EventArgs e)
        {

            var search = new KorisniciSearchRequest()
            {
                ImePrezime = txtPretraga.Text
        
            };

            var result = await _aPIService.Get<List<Model.Korisnici>>(search);
            List<Model.Korisnici> resultZaposlenici = new List<Model.Korisnici>();
            foreach (var z in result)
            {
                if (z.NazivUloge != "Klijent")
                {
                    resultZaposlenici.Add(z);
                }
            }
            dgvZaposlenici.DataSource = resultZaposlenici;
           




        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DgvZaposlenici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvZaposlenici.SelectedRows[0].Cells[0].Value;

            frmZaposleniciDetalji frm = new frmZaposleniciDetalji(int.Parse(id.ToString()),this);
            frm.Show();

        }

        private void BtnUredi_Click(object sender, EventArgs e)
        {

           
            var id = dgvZaposlenici.SelectedRows[0].Cells[0].Value;

            frmZaposleniciDetalji frm = new frmZaposleniciDetalji(int.Parse(id.ToString()),this);
            if ((int.Parse(id.ToString())) != 0)
            {
                frm.Show();
            }
       
        }


        public async void RefreshData()
        {
            var zaposlenici = await _aPIService.Get<List<Model.Korisnici>>();

            List<Model.Korisnici> result = new List<Model.Korisnici>();
            foreach (var z in zaposlenici)
            {
                if (z.NazivUloge != "Klijent")
                {
                    result.Add(z);
                }
            }



            dgvZaposlenici.AutoGenerateColumns = false;
            dgvZaposlenici.DataSource = result;
        }

        private async void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite obrisati ovaj zapis?", "Obriši ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = dgvZaposlenici.SelectedRows[0].Cells[0].Value;
                var entity = await _aPIService.GetById<Model.Korisnici>(id);
                if (id != null)
                {

                    var request = new KorisniciInsertRequest()
                    {
                        Ime = entity.Ime,
                        Prezime = entity.Prezime,
                        DatumRodjenja = entity.DatumRodjenja,
                        Telefon = entity.Telefon,
                        Grad = entity.Grad,
                        Adresa = entity.Adresa,
                        Email = entity.Email,
                        Spol = entity.Spol,
                        KorisnickoIme = entity.KorisnickoIme,
                        Password = "-",
                        PasswordConfirmation = "-",
                        UlogeId = entity.UlogeId,
                        IsDeleted = true,
                        RadniStaz = entity.RadniStaz,
                        Status = entity.Status,
                        JMBG = entity.JMBG,

                    };
                    await _aPIService.UpdateDelete<Model.Korisnici>(id, request);

                    MessageBox.Show(Properties.Resources.MessageBoxForDelete);

                    this.RefreshData();
                }
            }
        }
    }
}
