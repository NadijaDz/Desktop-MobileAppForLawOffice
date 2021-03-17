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

namespace Advokati.WinUI.Klijenti
{
    public partial class frmKlijentiDetalji : Form
    {
        private readonly APIService _aPIService = new APIService("Zaposlenici"); 
        private readonly APIService _aPIServiceUloge = new APIService("Uloge");
 

        private int? _id = null;
        private List<Model.Korisnici> zaposlenici = new List<Model.Korisnici>();


        frmKlijenti frm2;
        public frmKlijentiDetalji(int? klijentId=null,frmKlijenti frm1=null)
        {
            InitializeComponent();
            _id = klijentId;
            frm2 = frm1;
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void FrmKlijentiDetalji_Load(object sender, EventArgs e)
        {

            zaposlenici = await _aPIService.Get<List<Model.Korisnici>>();

            var listaUloga = await _aPIServiceUloge.Get<List<Model.Uloge>>();

            cbUloge.DisplayMember = "Naziv";
            cbUloge.ValueMember = "UlogaId";
            cbUloge.DataSource = listaUloga;



            if (_id.HasValue)
            {

                var klijent = await _aPIService.GetById<Model.Korisnici>(_id);
                txtIme.Text = klijent.Ime;
                txtPrezime.Text = klijent.Prezime;
                txtEmail.Text = klijent.Email;
                txtGrad.Text = klijent.Grad;
                txtJMBG.Text = klijent.JMBG;
                txtTelefon.Text = klijent.Telefon;
                txtAdresa.Text = klijent.Adresa;
               
                dtpDatumRodjenja.Value = klijent.DatumRodjenja;
                txtKorisnickoIme.Text = klijent.KorisnickoIme;

                txtPassword.Visible = false;
                password.Visible = false;
                txtPasswordPotvrda.Visible = false;
                passPotvrda.Visible = false;

                txtPassword.Text = "-";
                txtPasswordPotvrda.Text = "-";

                if (klijent.Spol.Equals("M"))
                {
                    rbMusko.Checked = true;
                }
                else
                {

                    rbZensko.Checked = true;
                }

                if(klijent.Status==true)
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }


                int indexUloge = listaUloga.IndexOf(listaUloga.Where(p => p.UlogaId == klijent.UlogeId).FirstOrDefault());
                cbUloge.SelectedIndex = indexUloge;

            }

            else
            {

                cbUloge.SelectedIndex = -1;

            }
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
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
            bool status;
            if(checkBox1.Checked)
            {
                status = true;
            }
            else
            {
                status = false;
            }


            if (this.ValidateChildren())
            {
                var request = new KorisniciInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    DatumRodjenja = dtpDatumRodjenja.Value,
                    Telefon = txtTelefon.Text,
                    Grad = txtGrad.Text,
                    Adresa = txtAdresa.Text,
                    Email = txtEmail.Text,
                    Spol = spol,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtPassword.Text,
                    PasswordConfirmation = txtPasswordPotvrda.Text,
                    UlogeId = int.Parse(cbUloge.SelectedValue.ToString()),
                    IsDeleted = false,
                    RadniStaz="0",
                    Status = status,
                    JMBG = txtJMBG.Text

                };

                if (_id.HasValue)
                {
                    await _aPIService.Update<Model.Korisnici>(_id, request);
                    MessageBox.Show(Properties.Resources.MessageBoxForSave);
                    this.Hide();
                    frm2.RefreshData();

                }
                else
                {
                    
                    await _aPIService.Insert<Model.Korisnici>(request);
                    MessageBox.Show(Properties.Resources.MessageBoxForSave);
                    this.Hide();
                    frmKlijenti frm = new frmKlijenti();
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
            if(string.IsNullOrWhiteSpace(txtPrezime.Text))
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
            if (string.IsNullOrWhiteSpace(dtpDatumRodjenja.Text))
            {
                errorProvider.SetError(dtpDatumRodjenja, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dtpDatumRodjenja, null);

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

     
        private void TxtJMBG_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJMBG.Text))
            {
                errorProvider.SetError(txtJMBG, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else if (txtJMBG.Text.Length < 13 || txtJMBG.Text.Length > 13)
            {
                errorProvider.SetError(txtJMBG, "JMBG mora biti dužine od 13 karaktera!");
                e.Cancel = true;
            }

            else if (!string.IsNullOrWhiteSpace(txtJMBG.Text))
            {

                if (_id.HasValue == false)
                {

                    foreach (var p in zaposlenici)
                    {
                        if (p.JMBG == txtJMBG.Text)
                        {
                            errorProvider.SetError(txtJMBG, "JMBG već postoji.Unesite novi!");
                            e.Cancel = true;

                        }

                    }
                    if (e.Cancel == false)
                    {
                        errorProvider.SetError(txtJMBG, null);
                    }
                }

            }

            else
            {
                errorProvider.SetError(txtJMBG, null);

            }
        }

        private void CbUloge_Validating_1(object sender, CancelEventArgs e)
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

        private  void TxtKorisnickoIme_Validating_1(object sender, CancelEventArgs e)
        {
           


            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text) )
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

        private void TxtPassword_Validating_1(object sender, CancelEventArgs e)
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

        private void TxtPasswordPotvrda_Validating_1(object sender, CancelEventArgs e)
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


            else if (string.IsNullOrWhiteSpace(txtPasswordPotvrda.Text))
            {
                errorProvider.SetError(txtPasswordPotvrda, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(txtPasswordPotvrda, null);

            }
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtKorisnickoIme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
