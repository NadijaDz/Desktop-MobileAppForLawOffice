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

namespace Advokati.WinUI.Sastanci
{
    public partial class frmSastanciDetalji : Form
    {


        private readonly APIService _aPIServiceSastanci = new APIService("Sastanci");
        private readonly APIService _serviceZaposlenici = new APIService("Zaposlenici");
        private readonly APIService _serviceKlijenti = new APIService("Klijenti");
        private readonly APIService _serviceVrstaUsluge = new APIService("VrstaUsluge");

        private int? _id = null;
        frmSastanci frm2;
        public frmSastanciDetalji(int? sastanakId=null, frmSastanci frm1=null)
        {
            InitializeComponent();
            _id = sastanakId;
            frm2 = frm1;
            this.AutoValidate = AutoValidate.Disable;
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private async void FrmSastanciDetalji_Load(object sender, EventArgs e)
        {
            var zaposlenici = await _serviceZaposlenici.Get<List<Model.Korisnici>>();
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


     
            var listaKlijenata = await _serviceKlijenti.Get<List<Model.Korisnici>>();
            cbKlijent.DisplayMember = "ImePrezime";
            cbKlijent.ValueMember = "ZaposlenikId";
            cbKlijent.DataSource = listaKlijenata;

            var listaVrstaUsluge = await _serviceVrstaUsluge.Get<List<Model.VrstaUsluge>>();
            cmbVrstaUsluge.DisplayMember = "Naziv";
            cmbVrstaUsluge.ValueMember = "VrstaUslugeId";
            cmbVrstaUsluge.DataSource = listaVrstaUsluge;


            if (_id.HasValue)
            {
                var sastanci= await _aPIServiceSastanci.GetById<Model.Sastanci>(_id);
                txtMjestoOdrzavanja.Text = sastanci.MjestoOdrzavanja;
                txtPoruka.Text = sastanci.Poruka;
                dtpDatumSastanka.Value = sastanci.DatumSastanka;

                if(sastanci.Odrzan.Value)
                {
                    radioButtonDA.Checked = true;
                }
                else
                {
                    radioButtonNE.Checked = true;

                }

                if (sastanci.Odobreno== true)
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }

                int indexZaposlenika = listaZaposlenika.IndexOf(listaZaposlenika.Where(p => p.KorisnikId == sastanci.ZaposleniciId).FirstOrDefault());
                cbZaposlenik.SelectedIndex = indexZaposlenika;

                int indexKlijent = listaKlijenata.IndexOf(listaKlijenata.Where(p => p.KorisnikId == sastanci.KlijentId).FirstOrDefault());
                cbKlijent.SelectedIndex = indexKlijent;

                int indexVrstaUsluge = listaVrstaUsluge.IndexOf(listaVrstaUsluge.Where(p => p.VrstaUslugeId == sastanci.VrstaId).FirstOrDefault());
                cmbVrstaUsluge.SelectedIndex = indexVrstaUsluge;
            }
            else
            {
                cbZaposlenik.SelectedIndex = -1;

                cbKlijent.SelectedIndex = -1;
                cmbVrstaUsluge.SelectedIndex = -1;
            }




        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            bool odrzano = false;
            if (radioButtonDA.Checked)
            {
                odrzano = true;
            }
            else
            {
                odrzano = false;
            }

            bool odobreno;
            if (checkBox1.Checked)
            {
                odobreno = true;
            }
            else
            {
                odobreno = false;
            }




            if (this.ValidateChildren())
            {

              
                  int.Parse(cmbVrstaUsluge.SelectedValue.ToString());
                
             


                var request = new SastanciInsertRequest()
                {
                    ZaposleniciId = int.Parse(cbZaposlenik.SelectedValue.ToString()),
                    KlijentId = int.Parse(cbKlijent.SelectedValue.ToString()),
                    DatumSastanka = dtpDatumSastanka.Value,
                    MjestoOdrzavanja = txtMjestoOdrzavanja.Text,
                    Poruka = txtPoruka.Text,
                    Odrzan = odrzano,
                    IsDeleted = false,
                    Odobreno=odobreno,
                    VrstaId = int.Parse(cmbVrstaUsluge.SelectedValue.ToString())


            };

                if (_id.HasValue)
                {
                    await _aPIServiceSastanci.Update<Model.Sastanci>(_id, request);
                    MessageBox.Show(Properties.Resources.MessageBoxForSave);
                    this.Hide();
                    frm2.RefreshData();
                }
                else
                {
                 
                    await _aPIServiceSastanci.Insert<Model.Sastanci>(request);
                    MessageBox.Show(Properties.Resources.MessageBoxForSave);
                    this.Hide();
                    frmSastanci frm = new frmSastanci();
                    frm.Show();


                   if(request.Odobreno == true)
                    {
                        var klijent = await _serviceZaposlenici.GetById<Model.Korisnici>(request.KlijentId);
                        var zaposlenik = await _serviceZaposlenici.GetById<Model.Korisnici>(request.ZaposleniciId);
                        string subject = "Sastanak";
                        string body = "Odobren vam je sastanak";
                        string FromMail = "testRS1test123@gmail.com";

                        string tempKlijent = klijent.Email;
                        string tempZaposlenik = zaposlenik.Email;

                        MailMessage mail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                        mail.From = new MailAddress(FromMail);
                        mail.To.Add(tempKlijent);
                        mail.To.Add(tempZaposlenik);
                        mail.Subject = subject;
                        mail.Body = body;
                        SmtpServer.Port = 587;
                        SmtpServer.UseDefaultCredentials = false;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("testRS1test123@gmail.com", "Rstest123456");
                        SmtpServer.EnableSsl = true;
                        SmtpServer.Send(mail);
                    }
                    




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

        private void DtpDatumSastanka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dtpDatumSastanka.Value.ToString()))
            {
                errorProvider.SetError(dtpDatumSastanka, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;

            }
            else
            {
                errorProvider.SetError(dtpDatumSastanka, null);

            }
        }

        private void TxtMjestoOdrzavanja_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMjestoOdrzavanja.Text))
            {
                errorProvider.SetError(txtMjestoOdrzavanja, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtMjestoOdrzavanja, null);

            }
        }

        private void TxtPoruka_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPoruka.Text))
            {
                errorProvider.SetError(txtPoruka, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPoruka, null);

            }
        }

        private void BtnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPoruka_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void RadioButtonNE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonDA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TxtMjestoOdrzavanja_TextChanged(object sender, EventArgs e)
        {

        }

        private void DtpDatumSastanka_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CbKlijent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbZaposlenik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }
    }
}
