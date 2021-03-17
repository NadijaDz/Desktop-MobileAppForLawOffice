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

namespace Advokati.WinUI.Ured
{
    public partial class frmUredDetalji : Form
    {
        private readonly APIService _aPIService = new APIService("Ured");
        private int? _id = null;
        frmUred frm2;
        public frmUredDetalji(int? uredId=null, frmUred frm1 = null)
        {
            InitializeComponent();
            _id = uredId;
            frm2 = frm1;
            this.AutoValidate = AutoValidate.Disable;
        }

        private async void FrmUredDetalji_Load(object sender, EventArgs e)
        {
            if(_id.HasValue)
            {
                var ured = await _aPIService.GetById<Model.Ured>(_id);
                txtNaziv.Text = ured.Naziv;
                txtAdresa.Text = ured.Adresa;
                txtEmail.Text = ured.Email;
                txtGrad.Text = ured.Grad;
                txtPostanskiBroj.Text = ured.PostanskiBroj;
                txtZiroRacun.Text = ured.ZiroRacun.ToString();
                txtTelefon.Text = ured.Telefon;
                
                    
            }
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new UredInsertRequest()
                {
                    Naziv=txtNaziv.Text,
                    Adresa=txtAdresa.Text,
                    Email=txtEmail.Text,
                    Grad=txtGrad.Text,
                    PostanskiBroj=txtPostanskiBroj.Text,
                    Telefon=txtTelefon.Text,
                    ZiroRacun=int.Parse(txtZiroRacun.Text),
                    IsDeleted = false

                };

                if (_id.HasValue)
                {
                    await _aPIService.Update<Model.Ured>(_id, request);
                    MessageBox.Show(Properties.Resources.MessageBoxForSave);
                    this.Hide();
                    frm2.RefreshData();


                }
                else
                {
                    
                    await _aPIService.Insert<Model.Ured>(request);
                    MessageBox.Show(Properties.Resources.MessageBoxForSave);
                    this.Hide();
                    frmUred frm = new frmUred();
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
            }
            else
            {
                errorProvider.SetError(txtEmail, null);

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

        private void TxtPostanskiBroj_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPostanskiBroj.Text))
            {
                errorProvider.SetError(txtPostanskiBroj, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPostanskiBroj, null);

            }
        }

        private void TxtZiroRacun_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtZiroRacun.Text))
            {
                errorProvider.SetError(txtZiroRacun, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtZiroRacun, null);

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
