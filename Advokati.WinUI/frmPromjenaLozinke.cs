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

namespace Advokati.WinUI
{
    public partial class frmPromjenaLozinke : Form
    {

        private readonly APIService _service = new APIService("Zaposlenici");

        public frmPromjenaLozinke()
        {
            InitializeComponent();
        }

        private async void BtnSacuvaj_Click(object sender, EventArgs e)
        {

            if (txtKorisnickoIme.Text == "" || txtStaraLozinka.Text == "")
            {
                MessageBox.Show("Niste unijeli korisničko ime ili lozinku", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                KorisniciSearchRequest zaposleniciSearch = new KorisniciSearchRequest();
                zaposleniciSearch.KorisnickoIme = txtUsername.Text;

                var zaposlenici = await _service.Get2<List<Model.Korisnici>>(zaposleniciSearch);
                var z = zaposlenici.FirstOrDefault();

                if (txtNovaLozinka.Text == txtPotvrdaNoveLozinke.Text)
                {

                    var request = new KorisniciInsertRequest()
                    {

                        Ime=z.Ime,
                        Prezime=z.Prezime,
                        DatumRodjenja = z.DatumRodjenja,
                        Telefon = z.Telefon,
                        RadniStaz = z.RadniStaz,
                        JMBG = z.JMBG,
                        Grad = z.Grad,
                        Email =z.Email,
                        Adresa = z.Adresa,
                        KorisnickoIme =z.KorisnickoIme,
                
                        Spol = z.Spol,
                        UlogeId =z.UlogeId,
                        Status = true,



                        Password = txtNovaLozinka.Text,
                        PasswordConfirmation = txtPotvrdaNoveLozinke.Text

                    };

                    await _service.Update<Model.Korisnici>(z.KorisnikId, request);
                    MessageBox.Show(Properties.Resources.MessageBoxForSave);
                    this.Hide();
                }
            }
         }

        private void FrmPromjenaLozinke_Load(object sender, EventArgs e)
        {

        }
    }
}
