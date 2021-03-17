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

namespace Advokati.WinUI.Predmeti
{
    public partial class frmPredmetiDetalji : Form
    {
        private readonly APIService _aPIService = new APIService("Predmeti");
        private readonly APIService _serviceZaposlenici = new APIService("Zaposlenici");
        private readonly APIService _serviceKlijenti = new APIService("Klijenti");
        private readonly APIService _serviceStatus = new APIService("Status");
        private readonly APIService _serviceVrstaUsluge = new APIService("VrstaUsluge");




        private int? _id = null;
        frmPredmeti frm2;
        public frmPredmetiDetalji(int? predmetId=null,frmPredmeti frm1=null)
        {
            InitializeComponent();
            _id = predmetId;
            frm2 = frm1;
            this.AutoValidate = AutoValidate.Disable;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private async void FrmPredmetiDetalji_Load(object sender, EventArgs e)
        {

            var zaposlenici = await _serviceZaposlenici.Get<List<Model.Korisnici>>();
            List<Model.Korisnici> listaZaposlenika = new List<Model.Korisnici>();
            foreach(var z in zaposlenici)
            {
                if(z.NazivUloge!="Klijent")
                {
                    listaZaposlenika.Add(z);
                }
            }

            cbZaposlenici.DisplayMember = "ImePrezime";
            cbZaposlenici.ValueMember = "ZaposlenikId";
            cbZaposlenici.DataSource = listaZaposlenika;

        
            var listaKlijenata = await _serviceKlijenti.Get<List<Model.Korisnici>>();
            cbKlijent.DisplayMember = "ImePrezime";
            cbKlijent.ValueMember = "ZaposlenikId";
            cbKlijent.DataSource = listaKlijenata;

            var listaStatusa = await _serviceStatus.Get<List<Model.Status>>();
            cbStatus.DisplayMember = "Naziv";
            cbStatus.ValueMember = "StatusId";
            cbStatus.DataSource = listaStatusa;


            var listaVrstaUsluge = await _serviceVrstaUsluge.Get<List<Model.VrstaUsluge>>();
            cbVrsta.DisplayMember = "Naziv";
            cbVrsta.ValueMember = "VrstaUslugeId";
            cbVrsta.DataSource = listaVrstaUsluge;



            if (_id.HasValue)
            {
                var predmeti = await _aPIService.GetById<Model.Predmeti>(_id);

                txtBrojPredmeta.Text = predmeti.BrojPredmeta;
                txtNazivPredmeta.Text = predmeti.NazivPredmeta;
                dtpDatPocetka.Value = predmeti.DatumPocetka;
                dtpRokZavrsetka.Value = predmeti.RokUplate.Value;

            
                int indexZaposlenika = listaZaposlenika.IndexOf(listaZaposlenika.Where(p => p.KorisnikId == predmeti.ZaposleniciId).FirstOrDefault());
                cbZaposlenici.SelectedIndex = indexZaposlenika;

                int indexKlijent = listaKlijenata.IndexOf(listaKlijenata.Where(p => p.KorisnikId == predmeti.KlijentId).FirstOrDefault());
                cbKlijent.SelectedIndex = indexKlijent;

                int indexStatus = listaStatusa.IndexOf(listaStatusa.Where(p => p.StatusId == predmeti.StatusId).FirstOrDefault());
                cbStatus.SelectedIndex = indexStatus;

                int indexVrstaUsluge = listaVrstaUsluge.IndexOf(listaVrstaUsluge.Where(p => p.VrstaUslugeId == predmeti.VrstaId).FirstOrDefault());
                cbVrsta.SelectedIndex = indexVrstaUsluge;


            }
            else
            {
                cbZaposlenici.SelectedIndex = -1;

                cbKlijent.SelectedIndex = -1;

                cbStatus.SelectedIndex = -1;

                cbVrsta.SelectedIndex = -1;

            }
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {

            if(this.ValidateChildren())
            {

                var request = new PredmetiInsertRequest
                {
                    BrojPredmeta=txtBrojPredmeta.Text,
                    NazivPredmeta=txtNazivPredmeta.Text,
                    DatumPocetka=dtpDatPocetka.Value,
                    RokUplate=dtpRokZavrsetka.Value,
                    ZaposleniciId=int.Parse(cbZaposlenici.SelectedValue.ToString()),
                    KlijentId=int.Parse(cbKlijent.SelectedValue.ToString()),
                    StatusId=int.Parse(cbStatus.SelectedValue.ToString()),
                    VrstaId=int.Parse(cbVrsta.SelectedValue.ToString()),
                    IsDeleted = false
                };

                if(_id.HasValue)
                {
                    await _aPIService.Update<Model.Predmeti>(_id, request);
                    MessageBox.Show(Properties.Resources.MessageBoxForSave);
                    this.Hide();
                    frm2.RefreshData();

                }
                else
                {
                   
                    await _aPIService.Insert<Model.Predmeti>(request);
                    MessageBox.Show(Properties.Resources.MessageBoxForSave);
                    this.Hide();
                    frmPredmeti frm = new frmPredmeti();
                    frm.Show();
                }
            }

        }

        private async void TxtBrojPredmeta_Validating(object sender, CancelEventArgs e)
        {

            var predmeti = await _aPIService.Get<List<Model.Predmeti>>();

            if (!string.IsNullOrWhiteSpace(txtBrojPredmeta.Text))
            {
                foreach (var p in predmeti)
                {
                    if (p.BrojPredmeta == txtBrojPredmeta.Text)
                    {
                        errorProvider.SetError(txtBrojPredmeta, "Broj predmeta već postoji.Unesite novi!");
                        e.Cancel = true;
                    }

                }
                if (e.Cancel == false)
                {
                    errorProvider.SetError(txtBrojPredmeta, null);
                }

            }


            else  if (string.IsNullOrWhiteSpace(txtBrojPredmeta.Text))
            {
                errorProvider.SetError(txtBrojPredmeta, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtBrojPredmeta, null);
            }

            
              
        }

        private void TxtNazivPredmeta_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNazivPredmeta.Text))
            {
                errorProvider.SetError(txtNazivPredmeta, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNazivPredmeta, null);

            }
        }

        private void DtpDatPocetka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dtpDatPocetka.Value.ToString()))
            {
                errorProvider.SetError(dtpDatPocetka, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dtpDatPocetka, null);

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

        private void CbZaposlenici_Validating(object sender, CancelEventArgs e)
        {
            if (cbZaposlenici.SelectedValue==null)
            {
                errorProvider.SetError(cbZaposlenici, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbZaposlenici, null);

            }
        }

        private void CbKlijent_Validating(object sender, CancelEventArgs e)
        {
            if (cbKlijent.SelectedValue == null)
            {
                errorProvider.SetError(cbKlijent, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbKlijent, null);

            }
        }

        private void CbStatus_Validating(object sender, CancelEventArgs e)
        {
            if (cbStatus.SelectedValue == null)
            {
                errorProvider.SetError(cbStatus, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbStatus, null);

            }

        }

        private void CbVrsta_Validating(object sender, CancelEventArgs e)
        {
            if (cbVrsta.SelectedValue == null)
            {
                errorProvider.SetError(cbVrsta, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cbVrsta, null);

            }
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
