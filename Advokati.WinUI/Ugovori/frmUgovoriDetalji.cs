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
    public partial class frmUgovoriDetalji : Form
    {
        private readonly APIService _aPIServiceUgovori= new APIService("Ugovori");
        private readonly APIService _aPIServiceZaposlenici = new APIService("Zaposlenici");

        private int? _id = null;
        frmUgovori frm2;
        public frmUgovoriDetalji(int? ugovorId=null, frmUgovori frm1 = null)
        {
            InitializeComponent();
            _id = ugovorId;
            frm2 = frm1;
            this.AutoValidate = AutoValidate.Disable;
        }

    

        private async void FrmUgovoriDetalji_Load(object sender, EventArgs e)
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
                var ugovori = await _aPIServiceUgovori.GetById<Model.Ugovori>(_id);

                txtNaslov.Text = ugovori.Naslov;
                txtNapomena.Text = ugovori.Napomena;
                dtpDatumPotpisivanja.Value = ugovori.DatumPotpisivanja;
                if(ugovori.Zavrsen.Value)
                {
                    rbZavrsenDa.Checked = true;
                }
                else
                {
                    rbZavrsenNe.Checked = true;
                }
                
                int indexZaposlenika = listaZaposlenika.IndexOf(listaZaposlenika.Where(p => p.KorisnikId == ugovori.ZaposleniciId).FirstOrDefault());
                cbZaposlenik.SelectedIndex = indexZaposlenika;
            }
            else
            {
                cbZaposlenik.SelectedIndex = -1;

            }
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {

            

                bool zavrsen = false;
                if (rbZavrsenDa.Checked)
                {
                    zavrsen = true;
                }
                else
                {
                    zavrsen = false;
                }

                DateTime? datumRaskida = null;


                if (this.ValidateChildren())
                {
                    var request = new UgovoriInsertRequest()
                    {
                        ZaposleniciId = int.Parse(cbZaposlenik.SelectedValue.ToString()),
                        Naslov = txtNaslov.Text,
                        DatumPotpisivanja = dtpDatumPotpisivanja.Value,
                        DatumRaskida = datumRaskida,
                        Napomena = txtNapomena.Text,
                        Zavrsen = zavrsen,
                        IsDeleted = false


                    };

                    if (_id.HasValue)
                    {
                        var entity1 = await _aPIServiceUgovori.GetById<Model.Ugovori>(_id);
                        request.DatumRaskida = entity1.DatumRaskida;
                        await _aPIServiceUgovori.Update<Model.Ugovori>(_id, request);
                        MessageBox.Show(Properties.Resources.MessageBoxForSave);
                        this.Hide();
                        frm2.RefreshData();

                    }
                    else
                    {
                   
                    await _aPIServiceUgovori.Insert<Model.Ugovori>(request);
                        MessageBox.Show(Properties.Resources.MessageBoxForSave);
                        this.Hide();
                        frmUgovori frm = new frmUgovori();
                        frm.Show();

                    }
                }

        }

        private void TxtNaslov_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaslov.Text))
            {
                errorProvider.SetError(txtNaslov, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNaslov, null);

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

        private void DtpDatumPotpisivanja_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dtpDatumPotpisivanja.Value.ToString()))
            {
                errorProvider.SetError(dtpDatumPotpisivanja, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(dtpDatumPotpisivanja, null);

            }
        }

       

        private void TxtNapomena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNapomena.Text))
            {
                errorProvider.SetError(txtNapomena, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(txtNapomena, null);

            }
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
