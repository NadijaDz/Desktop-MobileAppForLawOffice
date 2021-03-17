using Advokati.Model.Requests;
using Advokati.WinUI.Sastanci;
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

namespace Advokati.WinUI
{
    public partial class frmSastanci : Form
    {
        private readonly APIService _aPIService = new APIService("Sastanci");
        private readonly APIService _aPIServiceZaposlenici = new APIService("Zaposlenici");

        private bool _calendarDroppedDown = false;

        public frmSastanci()
        {
            InitializeComponent();
        }

        private async void FrmSastanci_Load(object sender, EventArgs e)
        {
            var result = await _aPIService.Get<List<Model.Sastanci>>();
            dgvSastanci.AutoGenerateColumns = false;
            dgvSastanci.DataSource = result;
           

        }

        private void DateTimePicker1_DropDown(object sender, EventArgs e)
        {
            _calendarDroppedDown = true;

        }

        private void DateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            _calendarDroppedDown = false;
            RefreshToolbox(null, null);
        }

        public async void RefreshToolbox(object sender, EventArgs e)
        {
            if (_calendarDroppedDown)
            {
                return;
            }
            else
            {
                var search = new SastanciSearchRequest
                {
                    DatumSastanka = dateTimePicker1.Value
                };

                var result = await _aPIService.Get<List<Model.Sastanci>>(search);
                dgvSastanci.DataSource = result;
                
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void DgvSastanci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvSastanci.SelectedRows[0].Cells[0].Value;
            frmSastanciDetalji frm=new frmSastanciDetalji(int.Parse(id.ToString()),this);
            frm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var id = dgvSastanci.SelectedRows[0].Cells[0].Value;
            frmSastanciDetalji frm = new frmSastanciDetalji(int.Parse(id.ToString()),this);
            if ((int.Parse(id.ToString())) != 0)
            {
                frm.Show();
            }
        }


        public async void RefreshData()
        {
            var result = await _aPIService.Get<List<Model.Sastanci>>();
            dgvSastanci.AutoGenerateColumns = false;
            dgvSastanci.DataSource = result;
        }

        private async void BtnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li ste sigurni da želite obrisati ovaj zapis?", "Obriši ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var id = dgvSastanci.SelectedRows[0].Cells[0].Value;
                var entity = await _aPIService.GetById<Model.Sastanci>(id);
                if (id != null)
                {

                    await _aPIService.UpdateDelete<Model.Sastanci>(id, entity);

                    MessageBox.Show(Properties.Resources.MessageBoxForDelete);

                    this.RefreshData();
                }
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void BtnOdobri_Click(object sender, EventArgs e)
        {

            var id = dgvSastanci.SelectedRows[0].Cells[0].Value;
            var entity = await _aPIService.GetById<Model.Sastanci>(id);
            var klijent = await _aPIServiceZaposlenici.GetById<Model.Korisnici>(entity.KlijentId);
            var zaposlenik = await _aPIServiceZaposlenici.GetById<Model.Korisnici>(entity.ZaposleniciId);

            if (entity.Odobreno == false)
            {

                try
                {
                    var request = new SastanciInsertRequest()
                    {
                        ZaposleniciId=entity.ZaposleniciId,
                        MjestoOdrzavanja=entity.MjestoOdrzavanja,
                        KlijentId=entity.KlijentId,
                        DatumSastanka=entity.DatumSastanka,
                        Poruka=entity.Poruka,
                        Odobreno=true,
                        Odrzan=entity.Odrzan,
                        IsDeleted=entity.IsDeleted,
                        VrstaId=entity.VrstaId

                    };
                    await _aPIService.Update<Model.Sastanci>(id, request);


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
                MessageBox.Show("Korisniku je već sastanak odobren!");
            }
        }

        private async void Btnucitajsve_Click(object sender, EventArgs e)
        {
            var result = await _aPIService.Get<List<Model.Sastanci>>();
            dgvSastanci.AutoGenerateColumns = false;
            dgvSastanci.DataSource = result;
        }
    }
}
