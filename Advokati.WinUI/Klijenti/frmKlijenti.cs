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
    public partial class frmKlijenti : Form
    {

        private readonly APIService _aPIService = new APIService("Zaposlenici");
        private readonly APIService _aPIServiceKlijenti = new APIService("Klijenti");

        public frmKlijenti()
        {
            InitializeComponent();
        }

        private async void FrmKlijenti_Load(object sender, EventArgs e)
        {
            var search = new KorisniciSearchRequest
            {
                Korisnik = "Klijent"
            };
            var result =await _aPIServiceKlijenti.Get<List<Model.Korisnici>>(search);
            dgvKlijenti.AutoGenerateColumns = false;
            dgvKlijenti.DataSource = result;
            
        }

        private async void TxtPretraga_TextChanged(object sender, EventArgs e)
        {
            var search = new KorisniciSearchRequest
            {
                ImePrezime=txtPretraga.Text
            };

            var result =await _aPIServiceKlijenti.Get<List<Model.Korisnici>>(search);
            dgvKlijenti.DataSource = result;
           

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            var id = dgvKlijenti.SelectedRows[0].Cells[0].Value;
            frmKlijentiDetalji frm = new frmKlijentiDetalji(int.Parse(id.ToString()),this);
            if ((int.Parse(id.ToString())) != 0)
            {
                frm.Show();
            }
        }

        private void FrmKlijenti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        

        }

        private void DgvKlijenti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKlijenti.SelectedRows[0].Cells[0].Value;
            frmKlijentiDetalji frm = new frmKlijentiDetalji(int.Parse(id.ToString()),this);
            frm.Show();
        }

        public async void RefreshData()
        {
            var search = new KorisniciSearchRequest
            {
                Korisnik = "Klijent"
            };
            var result = await _aPIServiceKlijenti.Get<List<Model.Korisnici>>(search);
            dgvKlijenti.AutoGenerateColumns = false;
            dgvKlijenti.DataSource = result;
        }

        private async void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite obrisati ovaj zapis?", "Obriši ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = dgvKlijenti.SelectedRows[0].Cells[0].Value;
                var entity = await _aPIService.GetById<Model.Korisnici>(id);
                if (id != null)
                {

                    var request = new KorisniciInsertRequest()
                    {
                        Ime = entity.Ime,
                        Prezime = entity.Prezime,
                        DatumRodjenja = entity.DatumRodjenja,
                        Telefon = entity.Telefon,
                        Grad = entity.Grad,
                        Adresa = entity.Adresa,
                        Email = entity.Email,
                        Spol = entity.Spol,
                        KorisnickoIme = entity.KorisnickoIme,
                        Password = "-",
                        PasswordConfirmation = "-",
                        UlogeId = entity.UlogeId,
                        IsDeleted = true,
                        RadniStaz = entity.RadniStaz,
                        Status = entity.Status,
                        JMBG = entity.JMBG,

                        };
                        await _aPIService.UpdateDelete<Model.Korisnici>(id, request);
                    MessageBox.Show(Properties.Resources.MessageBoxForDelete);

                    this.RefreshData();
                }
            }
        }

        private void DgvKlijenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void BtnOdobri_Click(object sender, EventArgs e)
        {
            

            var id = dgvKlijenti.SelectedRows[0].Cells[0].Value;
            var entity = await _aPIService.GetById<Model.Korisnici>(id);

            if (entity.Status == false)
            {

                try
                {
                    var request = new KorisniciInsertRequest()
                    {
                        Ime = entity.Ime,
                        Prezime = entity.Prezime,
                        DatumRodjenja = entity.DatumRodjenja,
                        Telefon = entity.Telefon,
                        Grad = entity.Grad,
                        Adresa = entity.Adresa,
                        Email = entity.Email,
                        Spol = entity.Spol,
                        KorisnickoIme = entity.KorisnickoIme,
                        Password = "-",
                        PasswordConfirmation = "-",
                        UlogeId = entity.UlogeId,
                        IsDeleted = entity.IsDeleted,
                        RadniStaz = entity.RadniStaz,
                        Status = true,
                        JMBG = entity.JMBG

                    };
                    await _aPIService.Update<Model.Korisnici>(id, request);


                    string subject = "Registracija";
                    string body = "Odobrena vam je registarcija";
                    string FromMail = "testRS1test123@gmail.com";

                    string temp = entity.Email;

                    string emailTo = temp;

                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                    mail.From = new MailAddress(FromMail);
                    mail.To.Add(emailTo);
                    mail.Subject = subject;
                    mail.Body = body;
                    SmtpServer.Port = 587;
                    SmtpServer.UseDefaultCredentials = false;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("testRS1test123@gmail.com", "Rstest123456");
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);
                    MessageBox.Show("Uspješno odobreno");

                  
                    
                    RefreshData();
                }
                catch (Exception)
                {
                    MessageBox.Show("Operacija neuspješna");

                }
            }

            else
            {
                MessageBox.Show("Korisniku je već status odobren!");
            }


        }
    }
}
