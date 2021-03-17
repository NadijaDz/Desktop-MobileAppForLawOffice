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
    public partial class frmRadniSatiDetalji : Form
    {
        private readonly APIService _aPIServiceRadniSati = new APIService("RadniSati");
        private readonly APIService _aPIServiceZaposlenici = new APIService("Zaposlenici");
        private readonly APIService _aPIServicePredmeti = new APIService("Predmeti");


        private int? _id = null;
        frmRadniSati frm2;
        public frmRadniSatiDetalji(int? radniSatiId=null, frmRadniSati frm1=null)
        {
            InitializeComponent();
            _id = radniSatiId;
            frm2 = frm1;
            this.AutoValidate = AutoValidate.Disable;
        }

        private void CbZaposlenik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void FrmRadniSatiDetalji_Load(object sender, EventArgs e)
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

            var listaPredmeta = await _aPIServicePredmeti.Get<List<Model.Predmeti>>();
            cbPredmet.DisplayMember = "BrojPredmeta";
            cbPredmet.ValueMember = "PredmetId";
            cbPredmet.DataSource = listaPredmeta;


            if (_id.HasValue)
            {
                var radniSati = await _aPIServiceRadniSati.GetById<Model.RadniSati>(_id);

                txtBrojRadnihSati.Text = radniSati.BrojRadnihSati.ToString();
                txtPrekovremeniSati.Text = radniSati.PrekovremeniSati.ToString();
                txtCijenaPoSatu.Text = radniSati.CijenaPoSatu.ToString();
                txtCijenaPrekovremenogSata.Text = radniSati.CijenaPrekovremenogSata.ToString();
                txtOpis.Text = radniSati.Opis;

                int indexZaposlenika = listaZaposlenika.IndexOf(listaZaposlenika.Where(p => p.KorisnikId == radniSati.ZaposleniciId).FirstOrDefault());
                cbZaposlenik.SelectedIndex = indexZaposlenika;


                int indexPredmeta = listaPredmeta.IndexOf(listaPredmeta.Where(p => p.PredmetId == radniSati.PredmetId).FirstOrDefault());
                cbPredmet.SelectedIndex = indexPredmeta;

            }
            else
            {
                cbZaposlenik.SelectedIndex = -1;
                cbPredmet.SelectedIndex = -1;
            }

        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {

            if(this.ValidateChildren())
            {
                var request = new RadniSatiInsertRequest()
                {
                    ZaposleniciId=int.Parse(cbZaposlenik.SelectedValue.ToString()),
                    PredmetId = int.Parse(cbPredmet.SelectedValue.ToString()),
                    BrojRadnihSati=decimal.Parse(txtBrojRadnihSati.Text),
                    PrekovremeniSati= decimal.Parse(txtPrekovremeniSati.Text),
                    CijenaPoSatu= decimal.Parse(txtCijenaPoSatu.Text),
                    CijenaPrekovremenogSata=decimal.Parse(txtCijenaPrekovremenogSata.Text),
                    Opis=txtOpis.Text,
                    IsDeleted = false

                };

                if(_id.HasValue)
                {
                    await _aPIServiceRadniSati.Update<Model.RadniSati>(_id,request);
                    MessageBox.Show(Properties.Resources.MessageBoxForSave);
                    this.Hide();
                    frm2.RefreshData();

                }
                else
                {
                    
                    await _aPIServiceRadniSati.Insert<Model.RadniSati>(request);
                    MessageBox.Show(Properties.Resources.MessageBoxForSave);
                    this.Hide();
                    frmRadniSati frm = new frmRadniSati();
                    frm.Show();

                }
            }

        }

        private void CbZaposlenik_Validating(object sender, CancelEventArgs e)
        {
            if(cbZaposlenik.SelectedValue==null)
            {
                errorProvider.SetError(cbZaposlenik, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbZaposlenik, null);
            }
        }

        private void CbPredmet_Validating(object sender, CancelEventArgs e)
        {
            if (cbPredmet.SelectedValue == null)
            {
                errorProvider.SetError(cbPredmet, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbPredmet, null);
            }
        }

        private void TxtBrojRadnihSati_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrojRadnihSati.Text))
            {
                errorProvider.SetError(txtBrojRadnihSati, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtBrojRadnihSati, null);
            }
        }

        private void TxtPrekovremeniSati_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrekovremeniSati.Text))
            {
                errorProvider.SetError(txtPrekovremeniSati, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrekovremeniSati, null);
            }
        }

        private void TxtCijenaPoSatu_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCijenaPoSatu.Text))
            {
                errorProvider.SetError(txtCijenaPoSatu, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtCijenaPoSatu, null);
            }
        }

        private void TxtCijenaPrekovremenogSata_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCijenaPrekovremenogSata.Text))
            {
                errorProvider.SetError(txtCijenaPrekovremenogSata, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtCijenaPrekovremenogSata, null);
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
