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
    public partial class frmRocistaDetalji : Form
    {
        private readonly APIService _aPIServiceRociste = new APIService("Rocista");
        private readonly APIService _aPIServiceZaposlenici = new APIService("Zaposlenici");
        private readonly APIService _aPIServicePredmeti = new APIService("Predmeti");
        private int? _id = null;
        frmRocista frm2;
        public frmRocistaDetalji(int? rocisteId=null,frmRocista frm1=null)
        {
            InitializeComponent();
            _id = rocisteId;
            frm2 = frm1;
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void FrmRocistaDetalji_Load(object sender, EventArgs e)
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

            if(_id.HasValue)
            {

                var rocista = await _aPIServiceRociste.GetById<Model.Rocista>(_id);
                dtpDatumRocista.Value = rocista.DatumRocista;
                txtMjesto.Text = rocista.Mjesto;
                txtNapomena.Text = rocista.Napomena;
                if(rocista.Odrzano)
                {
                    radioButtonDA.Checked = true;
                }
                else
                {
                    radioButtonNE.Checked = true;

                }



                int indexZaposlenika = listaZaposlenika.IndexOf(listaZaposlenika.Where(p => p.KorisnikId == rocista.ZaposlenikId).FirstOrDefault());
                cbZaposlenik.SelectedIndex = indexZaposlenika;


                int indexPredmeta = listaPredmeta.IndexOf(listaPredmeta.Where(p => p.PredmetId == rocista.PredmetID).FirstOrDefault());
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

            bool odrzano=false;
            if (radioButtonDA.Checked)
            {
                odrzano=true;
            }
            else
            {
                odrzano = false;
            }

            if (this.ValidateChildren())
            {
                var request = new RocistaInsertRequest()
                {
                    ZaposlenikId = int.Parse(cbZaposlenik.SelectedValue.ToString()),
                    PredmetID = int.Parse(cbPredmet.SelectedValue.ToString()),
                    DatumRocista=dtpDatumRocista.Value,
                    Mjesto=txtMjesto.Text,
                    Napomena=txtNapomena.Text,
                    Odrzano=odrzano,
                    IsDeleted = false


                };

                if (_id.HasValue)
                {
                    await _aPIServiceRociste.Update<Model.Rocista>(_id, request);
                    MessageBox.Show(Properties.Resources.MessageBoxForSave);
                    this.Hide();
                    frm2.RefreshData();
                }
                else
                {
                   
                    await _aPIServiceRociste.Insert<Model.Rocista>(request);
                    MessageBox.Show(Properties.Resources.MessageBoxForSave);
                    this.Hide();
                    frmRocista frm = new frmRocista();
                    frm.Show();



                }
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

        private void DtpDatumRocista_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dtpDatumRocista.Value.ToString()))
            {
                errorProvider.SetError(dtpDatumRocista, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(dtpDatumRocista, null);

            }
        }

        private void TxtMjesto_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMjesto.Text))
            {
                errorProvider.SetError(txtMjesto, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtMjesto, null);

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
