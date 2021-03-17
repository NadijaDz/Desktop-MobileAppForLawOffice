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

namespace Advokati.WinUI.Troskovi
{
    public partial class frmTroskoviDetalji : Form
    {
        private readonly APIService _aPIServiceTroskovi = new APIService("Troskovi");
        private readonly APIService _aPIServicePredmeti = new APIService("Predmeti");

        private int? _id = null;
        frmTroskovi frm2;
        public frmTroskoviDetalji(int? trosakId=null, frmTroskovi frm1=null)
        {
            InitializeComponent();
            _id = trosakId;
            frm2 = frm1;
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void FrmTroskoviDetalji_Load(object sender, EventArgs e)
        {
            var listaPredmeta = await _aPIServicePredmeti.Get<List<Model.Predmeti>>();
            cbPredmet.DisplayMember = "BrojPredmeta";
            cbPredmet.ValueMember = "PredmetId";
            cbPredmet.DataSource = listaPredmeta;

            if(_id.HasValue)
            {
                var troskovi = await _aPIServiceTroskovi.GetById<Model.Troskovi>(_id);

                txtSifra.Text = troskovi.Sifra;
                txtOpis.Text = troskovi.Opis;
                txtIznos.Text = troskovi.Iznos.ToString();
                dtpDatumUplate.Value = troskovi.DatumUplate.Value;
               


                int indexPredmeta = listaPredmeta.IndexOf(listaPredmeta.Where(p => p.PredmetId == troskovi.PredmetID).FirstOrDefault());
                cbPredmet.SelectedIndex = indexPredmeta;
            }
            else
            {
                cbPredmet.SelectedIndex = -1;

            }
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren())
            {
                var request = new TroskoviInsertRequest()
                {

                    Sifra = txtSifra.Text,
                    PredmetID = int.Parse(cbPredmet.SelectedValue.ToString()),
                  
                    DatumUplate = dtpDatumUplate.Value,
                    Iznos = decimal.Parse(txtIznos.Text),
                    Opis = txtOpis.Text,
                    IsDeleted = false
                   

                };

                if (_id.HasValue)
                {
                    await _aPIServiceTroskovi.Update<Model.Troskovi>(_id, request);
                    MessageBox.Show(Properties.Resources.MessageBoxForSave);
                    this.Hide();
                    frm2.RefreshData();

                }
                else
                {
                   
                    await _aPIServiceTroskovi.Insert<Model.Troskovi>(request);
                    MessageBox.Show(Properties.Resources.MessageBoxForSave);
                    this.Hide();
                    frmTroskovi frm = new frmTroskovi();
                    frm.Show();

                }
            }
        }

        private  async void TxtSifra_Validating(object sender, CancelEventArgs e)
        {

            var troskovi = await _aPIServiceTroskovi.Get<List<Model.Troskovi>>();

            if (!string.IsNullOrWhiteSpace(txtSifra.Text))
            {
                foreach (var p in troskovi)
                {
                    if (p.Sifra == txtSifra.Text)
                    {
                        errorProvider.SetError(txtSifra, "Šifra  već postoji.Unesite novu!");
                        e.Cancel = true;
                    }

                }
                if (e.Cancel == false)
                {
                    errorProvider.SetError(txtSifra, null);
                }

            }


           else if (string.IsNullOrWhiteSpace(txtSifra.Text))
            {
                errorProvider.SetError(txtSifra, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtSifra, null);

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

    

        private void DtpDatumUplate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dtpDatumUplate.Value.ToString()))
            {
                errorProvider.SetError(dtpDatumUplate, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(dtpDatumUplate, null);

            }
        }

        private void TxtIznos_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIznos.Text))
            {
                errorProvider.SetError(txtIznos, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(txtIznos, null);

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

        private void DtpRokUplate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
