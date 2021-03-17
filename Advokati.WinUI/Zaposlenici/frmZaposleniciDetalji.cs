using Advokati.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advokati.WinUI.Zaposlenici
{
    public partial class frmZaposleniciDetalji : Form
    {
        private readonly APIService _service = new APIService("Zaposlenici");
        private readonly APIService _aPIServiceUloge = new APIService("Uloge");

        private int? _id = null;
        frmZaposlenici frm2;
        private List<Model.Korisnici> zaposlenici = new List<Model.Korisnici>();

        public frmZaposleniciDetalji(int? zaposlenikId = null, frmZaposlenici frm1=null)
        {
            InitializeComponent();
            _id = zaposlenikId;
             frm2 = frm1;
            this.AutoValidate = AutoValidate.Disable;

        }

        private async void FrmZaposleniciDetalji_Load(object sender, EventArgs e)
        {

            zaposlenici = await _service.Get<List<Model.Korisnici>>();

            var listaUloga = await _aPIServiceUloge.Get<List<Model.Uloge>>();

                cbUloge.DisplayMember = "Naziv";
                cbUloge.ValueMember = "UlogaId";
                cbUloge.DataSource = listaUloga;



                if (_id.HasValue)
                {

                    var zaposlenik = await _service.GetById<Model.Korisnici>(_id);
                    txtIme.Text = zaposlenik.Ime;
                    txtPrezime.Text = zaposlenik.Prezime;
                    txtEmail.Text = zaposlenik.Email;
                    txtGrad.Text = zaposlenik.Grad;
                    txtJMBG.Text = zaposlenik.JMBG;
                    txtTelefon.Text = zaposlenik.Telefon;
                    txtAdresa.Text = zaposlenik.Adresa;
                    txtRadniStaz.Text = zaposlenik.RadniStaz;
                    dtpDatumRodjenja.Value = zaposlenik.DatumRodjenja;
                    txtKorisnickoIme.Text = zaposlenik.KorisnickoIme;

                    txtPassword.Visible = false;
                    password.Visible = false;
                    txtPasswordPotvrda.Visible = false;
                    passPotvrda.Visible = false;

                    txtPassword.Text = "-";
                    txtPasswordPotvrda.Text = "-";

                    if (zaposlenik.Spol.Equals("M"))
                    {
                        rbMusko.Checked = true;
                    }
                    else
                    {

                        rbZensko.Checked = true;
                    }

                    int indexUloge = listaUloga.IndexOf(listaUloga.Where(p => p.UlogaId == zaposlenik.UlogeId).FirstOrDefault());
                    cbUloge.SelectedIndex = indexUloge;

                }

                else
                {

                    cbUloge.SelectedIndex = -1;

                }


         

        }

        private async void BtnSnimi_Click(object sender, EventArgs e)
        {



                var spol = " ";
                if (rbMusko.Checked)
                {
                    spol = rbMusko.Text;
                }
                else
                {
                    spol = rbZensko.Text;
                }

                if (this.ValidateChildren())
                {


                    var request = new KorisniciInsertRequest()
                    {

                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        DatumRodjenja = dtpDatumRodjenja.Value,
                        Telefon = txtTelefon.Text,
                        RadniStaz = txtRadniStaz.Text,
                        JMBG = txtJMBG.Text,
                        Grad = txtGrad.Text,
                        Email = txtEmail.Text,
                        Adresa = txtAdresa.Text,
                        KorisnickoIme = txtKorisnickoIme.Text,
                        Password = txtPassword.Text,
                        PasswordConfirmation = txtPasswordPotvrda.Text,
                        Spol = spol,
                        UlogeId = int.Parse(cbUloge.SelectedValue.ToString()),
                        Status = true,
                        IsDeleted = false

                    };

                    if (_id.HasValue)
                    {

                        await _service.Update<Model.Korisnici>(_id, request);
                        MessageBox.Show(Properties.Resources.MessageBoxForSave);
                        this.Hide();
                        frm2.RefreshData();

                    }
                    else
                    {
                      
                        await _service.Insert<Model.Korisnici>(request);
                        MessageBox.Show(Properties.Resources.MessageBoxForSave);
                        this.Hide();
                        frmZaposlenici frm = new frmZaposlenici();
                        frm.Show();

                    }
                }


            

           

        }





        private void TxtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIme, null);

            }
        }

        private void TxtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(txtPrezime, null);

            }
        }

        private void DtpDatumRodjenja_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dtpDatumRodjenja.Value.ToString()))
            {
                errorProvider.SetError(dtpDatumRodjenja, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(dtpDatumRodjenja, null);

            }
        }

        private void TxtJMBG_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJMBG.Text))
            {
                errorProvider.SetError(txtJMBG, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else if(txtJMBG.Text.Length<13 || txtJMBG.Text.Length>13)
            {
                errorProvider.SetError(txtJMBG, "JMBG mora biti dužine od 13 karaktera!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtJMBG, null);

            }
        }

        private void TxtGrad_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGrad.Text))
            {
                errorProvider.SetError(txtGrad, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(txtGrad, null);

            }
        }

        private void TxtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                errorProvider.SetError(txtAdresa, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(txtAdresa, null);

            }

        }

        private void TxtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider.SetError(txtTelefon, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(txtTelefon, null);

            }
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
                return;

            }
            else
            {
                try
                {
                    MailAddress mail = new MailAddress(txtEmail.Text);


                }
                catch (Exception)
                {

                    errorProvider.SetError(txtEmail, Properties.Resources.Email_Error);
                    e.Cancel = true;
                    return;
                }

            }

            errorProvider.SetError(txtEmail, null);
        }

        private void TxtRadniStaz_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRadniStaz.Text))
            {
                errorProvider.SetError(txtRadniStaz, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(txtRadniStaz, null);

            }
        }

        private  void TxtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {



            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                errorProvider.SetError(txtKorisnickoIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else if (txtKorisnickoIme.Text.Length < 3)
            {
                errorProvider.SetError(txtKorisnickoIme, "Korisničko mora biti duže od 3 karaktera");
                e.Cancel = true;
            }


            else if (!string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {

                if (_id.HasValue == false)
                {

                    foreach (var p in zaposlenici)
                    {
                        if (p.KorisnickoIme == txtKorisnickoIme.Text)
                        {
                            errorProvider.SetError(txtKorisnickoIme, "Korisničko ime već postoji.Unesite novi!");
                            e.Cancel = true;

                        }

                    }
                    if (e.Cancel == false)
                    {
                        errorProvider.SetError(txtKorisnickoIme, null);
                    }
                }

            }

            else
            {
                errorProvider.SetError(txtKorisnickoIme, null);

            }
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(txtPassword, null);

            }
        }

        private void TxtPasswordPotvrda_Validating(object sender, CancelEventArgs e)
        {

           if (!string.IsNullOrWhiteSpace(txtPasswordPotvrda.Text))
            {
                if (txtPasswordPotvrda.Text != txtPassword.Text)
                {
                    errorProvider.SetError(txtPasswordPotvrda, "Password i password potvrda se ne slažu. Unesite ponovo!");
                    e.Cancel = true;
                }
                if (e.Cancel == false)
                {
                    errorProvider.SetError(txtPasswordPotvrda, null);
                }
            }


              else  if (string.IsNullOrWhiteSpace(txtPasswordPotvrda.Text))
            {
                errorProvider.SetError(txtPasswordPotvrda, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(txtPasswordPotvrda, null);

            }
        }

        private void CbUloge_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbUloge.Text))
            {
                errorProvider.SetError(cbUloge, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(cbUloge, null);

            }
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
