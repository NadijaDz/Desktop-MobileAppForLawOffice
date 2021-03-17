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
    public partial class frmZadaciDetalji : Form
    {
        private readonly APIService _aPIServiceZadaci = new APIService("Zadaci");
        private readonly APIService _aPIServiceZaposlenici = new APIService("Zaposlenici");

        private int? _id = null;
        frmZadaci frm2;

        public frmZadaciDetalji(int? zadaciId=null, frmZadaci frm1 = null)
        {
            InitializeComponent();
            _id = zadaciId;
            frm2 = frm1;
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void FrmZadaciDetalji_Load(object sender, EventArgs e)
        {
            var zaposlenici = await _aPIServiceZaposlenici.Get<List<Model.Korisnici>>();
            List<Model.Korisnici> listaZaposlenika = new List<Model.Korisnici>();
            foreach (var z in zaposlenici)
            {
                if (z.NazivUloge != "Klijent")
                {
                    listaZaposlenika.Add(z);
                }
            }
            cbZaposlenik.DisplayMember = "ImePrezime";
            cbZaposlenik.ValueMember = "ZaposlenikId";
            cbZaposlenik.DataSource = listaZaposlenika;

            if (_id.HasValue)
            {
                var zadaci = await _aPIServiceZadaci.GetById<Model.Zadaci>(_id);

                txtNaziv.Text = zadaci.Naziv;
                txtOpis.Text = zadaci.Opis;
                dtpDatumPocetka.Value = zadaci.DatumPocetka;
                dtpRokZavrsetka.Value = zadaci.Rok;


                if (zadaci.Zavrsen.Value)
                {
                    radioButtonDA.Checked = true;
                }
                else
                {
                    radioButtonNE.Checked = true;
                }
             

                int indexZaposlenika = listaZaposlenika.IndexOf(listaZaposlenika.Where(p => p.KorisnikId == zadaci.ZaposleniciId).FirstOrDefault());
                cbZaposlenik.SelectedIndex = indexZaposlenika;
            }
            else
            {
                cbZaposlenik.SelectedIndex = -1;
                

            }
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            bool zavrseno = false;
            if (radioButtonDA.Checked)
            {
                zavrseno = true;
            }
            else
            {
                zavrseno = false;
            }

            if (this.ValidateChildren())
            {
                var request = new ZadaciInsertRequest()
                {
                    ZaposleniciId = int.Parse(cbZaposlenik.SelectedValue.ToString()),
                    Naziv = txtNaziv.Text,
                    Opis = txtOpis.Text,

                    DatumPocetka = dtpDatumPocetka.Value,
                    Rok = dtpRokZavrsetka.Value,
                    Zavrsen = zavrseno,
                    IsDeleted = false
                  


                };

                if (_id.HasValue)
                {
                    await _aPIServiceZadaci.Update<Model.Zadaci>(_id, request);
                    MessageBox.Show(Properties.Resources.MessageBoxForSave);

                    this.Hide();
                    frm2.RefreshData();
                }
                else
                {
                
                    await _aPIServiceZadaci.Insert<Model.Zadaci>(request);
                    MessageBox.Show(Properties.Resources.MessageBoxForSave);
                    this.Hide();
                    frmZadaci frm = new frmZadaci();
                    frm.Show();
                }
              
            }
        }

        private void TxtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);

            }
        }

        private void CbZaposlenik_Validating(object sender, CancelEventArgs e)
        {
            if (cbZaposlenik.SelectedValue == null)
            {
                errorProvider.SetError(cbZaposlenik, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbZaposlenik, null);
            }
        }

        private void DtpDatumPocetka_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(dtpDatumPocetka.Value.ToString()))
            {
                errorProvider.SetError(dtpDatumPocetka, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(dtpDatumPocetka, null);

            }
        }

        private void DtpRokZavrsetka_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(dtpRokZavrsetka.Value.ToString()))
            {
                errorProvider.SetError(dtpRokZavrsetka, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(dtpRokZavrsetka, null);

            }
        }

        private void TxtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOpis.Text))
            {
                errorProvider.SetError(txtOpis, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtOpis, null);

            }
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
