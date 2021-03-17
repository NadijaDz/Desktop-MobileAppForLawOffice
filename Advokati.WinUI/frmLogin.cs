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
    public partial class frmLogin : Form
    {
        APIService _aPIService = new APIService("Zaposlenici");
     

        private bool ulogaAdvokat = false, ulogaMenadzer = false, ulogaSekretar = false;
        private string ulogaAdvokatIme=null , ulogaMenadzerIme=null , ulogaSekretarIme=null;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPrijaviSe_Enter(object sender, EventArgs e)
        {
            
        }

        private void TxtLozinka_Enter(object sender, EventArgs e)
        {
         
        }

        private void TxtLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                BtnPrijaviSe_Click(sender, e);
            }
        }

        private void LinkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPromjenaLozinke frm = new frmPromjenaLozinke();
            frm.Show();
        }

        private async void BtnPrijaviSe_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.KorisnickoIme = txtKorisnickoIme.Text;
                APIService.Lozinka = txtLozinka.Text;

               await _aPIService.Get<dynamic>(null);

                KorisniciSearchRequest zaposleniciSearch = new KorisniciSearchRequest();
                zaposleniciSearch.KorisnickoIme = APIService.KorisnickoIme;

                var zaposlenici = await _aPIService.Login<List<Model.Korisnici>>(zaposleniciSearch);
                var z = zaposlenici.FirstOrDefault();



                if (z.NazivUloge == "Menadzer")
                {
                    ulogaMenadzer = true;
                    ulogaMenadzerIme = z.Ime + " " + z.Prezime;
                }
                else if (z.NazivUloge == "Sekretar")
                {
                    ulogaSekretar = true;
                    ulogaSekretarIme = z.Ime + " " + z.Prezime;

                }
                else if (z.NazivUloge == "Advokat")
                {
                    ulogaAdvokat = true;
                    ulogaAdvokatIme = z.Ime + " " + z.Prezime;
                }
                else 
                {
                    
                    throw new System.ArgumentException("Nemate pravo pristupa");
                }



                frmIndex frm = new frmIndex(ulogaAdvokat,ulogaMenadzer,ulogaSekretar,ulogaAdvokatIme,ulogaMenadzerIme,ulogaSekretarIme);
                frm.Show();
                this.Hide();
            }
            
            catch (Exception ex)
            {
                if(ex.Message == "Nemate pravo pristupa")
                {
                    MessageBox.Show("Nemate pravo pristupa", "Autorizacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Korisničko ime ili lozinka nisu ispravno uneseni! Pokušajte ponovo.", "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
