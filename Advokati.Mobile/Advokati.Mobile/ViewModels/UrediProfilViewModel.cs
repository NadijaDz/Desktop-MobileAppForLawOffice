using Advokati.Mobile.Views;
using Advokati.Model;
using Advokati.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Advokati.Mobile.ViewModels
{
   public class UrediProfilViewModel: BaseViewModel
    {

        private readonly APIService _serviceKlijent = new APIService("Zaposlenici");
        private readonly APIService _serviceUloge = new APIService("Uloge");
        public int KlijentId;
        public UrediProfilViewModel()
        {

            InitCommand = new Command(async () => await Init());
           
        }
        public UrediProfilViewModel(int Klijent)
        {
            KlijentId = Klijent;
            
            UrediProfilCommand = new Command(async () => await UrediProfil());
          
        }
     


        string _imeRequired = string.Empty;
        string _prezimeRequired = string.Empty;
        string _datumRodjenjaRequired = string.Empty;
        string _spolRequired = string.Empty;
        string _JMBGRequired = string.Empty;
        string _adresaRequired = string.Empty;
        string _gradRequired = string.Empty;
        string _telefonRequired = string.Empty;
        string _emailRequired = string.Empty;
        string _korisnickoImeRequired = string.Empty;
        string _validEmail = string.Empty;


        bool _visibleIme = false;
        bool _visiblePrezime = false;
        bool _visibleDatumRodjenja = false;
        bool _visibleSpol = false;
        bool _visibleJMBG = false;
        bool _visibleAdresa = false;
        bool _visibleGrad = false;
        bool _visibleTelefon = false;
        bool _visibleEmail = false;
        bool _visibleKorisnickoIme = false;
        bool _visibleValidEmail = false;


        public string ImeRequired
        {
            get { return _imeRequired; }
            set { SetProperty(ref _imeRequired, value); }
        }
        public string PrezimeRequired
        {
            get { return _prezimeRequired; }
            set { SetProperty(ref _prezimeRequired, value); }
        }
        public string DatumrodjenjaRequired
        {
            get { return _datumRodjenjaRequired; }
            set { SetProperty(ref _datumRodjenjaRequired, value); }
        }
        public string SpolRequired
        {
            get { return _spolRequired; }
            set { SetProperty(ref _spolRequired, value); }
        }
        public string AdresaRequired
        {
            get { return _adresaRequired; }
            set { SetProperty(ref _adresaRequired, value); }
        }
        public string TelefonRequired
        {
            get { return _telefonRequired; }
            set { SetProperty(ref _telefonRequired, value); }
        }
        public string GradRequired
        {
            get { return _gradRequired; }
            set { SetProperty(ref _gradRequired, value); }
        }
        public string JMBGRequired
        {
            get { return _JMBGRequired; }
            set { SetProperty(ref _JMBGRequired, value); }
        }
        public string EmailRequired
        {
            get { return _emailRequired; }
            set { SetProperty(ref _emailRequired, value); }
        }
        public string KorisnickoImeRequired
        {
            get { return _korisnickoImeRequired; }
            set { SetProperty(ref _korisnickoImeRequired, value); }
        }
      
        public string ValidEmail
        {
            get { return _validEmail; }
            set { SetProperty(ref _validEmail, value); }
        }


        public bool VisibleIme
        {
            get { return _visibleIme; }
            set { SetProperty(ref _visibleIme, value); }
        }
        public bool VisiblePrezime
        {
            get { return _visiblePrezime; }
            set { SetProperty(ref _visiblePrezime, value); }
        }

        public bool VisibleDatumrodjenja
        {
            get { return _visibleDatumRodjenja; }
            set { SetProperty(ref _visibleDatumRodjenja, value); }
        }

        public bool VisibleSpol
        {
            get { return _visibleSpol; }
            set { SetProperty(ref _visibleSpol, value); }
        }

        public bool VisibleAdresa
        {
            get { return _visibleAdresa; }
            set { SetProperty(ref _visibleAdresa, value); }
        }

        public bool VisibleGrad
        {
            get { return _visibleGrad; }
            set { SetProperty(ref _visibleGrad, value); }
        }

        public bool VisibleJMBG
        {
            get { return _visibleJMBG; }
            set { SetProperty(ref _visibleJMBG, value); }
        }

        public bool VisibleEmail
        {
            get { return _visibleEmail; }
            set { SetProperty(ref _visibleEmail, value); }
        }

        public bool VisibleTelefon
        {
            get { return _visibleTelefon; }
            set { SetProperty(ref _visibleTelefon, value); }
        }

        public bool VisibleKorisnickoIme
        {
            get { return _visibleKorisnickoIme; }
            set { SetProperty(ref _visibleKorisnickoIme, value); }
        }
     
        public bool VisibleValidEmail
        {
            get { return _visibleValidEmail; }
            set { SetProperty(ref _visibleValidEmail, value); }
        }





        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }

        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }

        string _adresa = string.Empty;
        public string Adresa
        {
            get { return _adresa; }
            set { SetProperty(ref _adresa, value); }
        }

        DateTime _datumRodjenja = DateTime.Now;
        public DateTime DatumRodjenja
        {
            get { return _datumRodjenja; }
            set { SetProperty(ref _datumRodjenja, value); }
        }

        string _telefon = string.Empty;
        public string Telefon
        {
            get { return _telefon; }
            set { SetProperty(ref _telefon, value); }
        }

        string _grad = string.Empty;
        public string Grad
        {
            get { return _grad; }
            set { SetProperty(ref _grad, value); }
        }

        string _jmbg = string.Empty;
        public string JMBG
        {
            get { return _jmbg; }
            set { SetProperty(ref _jmbg, value); }
        }

        string _spol = string.Empty;
        public string Spol
        {
            get { return _spol; }
            set { SetProperty(ref _spol, value); }
        }

        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        

        public KorisniciInsertRequest klijentInsert { get; set; } = new KorisniciInsertRequest();
       

        public ICommand UrediProfilCommand { get; set; }
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var k = await _serviceKlijent.GetById<Korisnici>(KlijentId);
         

            Ime = k.Ime;
            Prezime = k.Prezime;
            DatumRodjenja = k.DatumRodjenja;
            JMBG = k.JMBG;
            Adresa = k.Adresa;
            Telefon = k.Telefon;
            Grad = k.Grad;
            Spol = k.Spol;
            Email = k.Email;
            Username = k.KorisnickoIme;
            
        }

        public async Task UrediProfil()
        {


            if (await Validacija())
            {
                return;
            }

            else
            {

                IsBusy = true;
          
                bool emailexists = false;
                bool usernamexists = false;
                var k = await _serviceKlijent.GetById<Korisnici>(KlijentId);

                if(k.Email!=Email || k.KorisnickoIme!=Username)
                {
                   
                    emailexists = await CheckEmail(Email);
                    usernamexists = await CheckUsername(Username);
                }


                var uloge = await _serviceUloge.Get<List<Model.Uloge>>();
                var id = -1;

                if ( !emailexists && !usernamexists)
                {
                    klijentInsert.Ime = Ime;
                    klijentInsert.Prezime = Prezime;
                    klijentInsert.Email = Email;
                    klijentInsert.KorisnickoIme = Username;
                    klijentInsert.DatumRodjenja = DatumRodjenja;
                    klijentInsert.Adresa = Adresa;
                    klijentInsert.Telefon = Telefon;
                    klijentInsert.Grad = Grad;
                    klijentInsert.RadniStaz = "0";
                    klijentInsert.Status = true;
                    klijentInsert.Spol = Spol;
                    klijentInsert.JMBG = JMBG;
                    klijentInsert.IsDeleted = false;
                   

                    klijentInsert.Password = "-";
                    klijentInsert.PasswordConfirmation = "-";

                    foreach (var u in uloge)
                    {
                        if (u.Naziv == "Klijent")
                        {
                            id = u.UlogaId;
                        }
                    }
                    klijentInsert.UlogeId = id;

                    try
                    {
                        var entity = await _serviceKlijent.Update<Model.Korisnici>(KlijentId,klijentInsert);
                        if (entity != null)
                        {
                            await Application.Current.MainPage.DisplayAlert("Obavijest", "Uspješno ste izmjenili podatke!", "OK");
                   
                        
                        }

                    }
                    catch (Exception ex)
                    {
                        string msg = "";
                        if (ex.InnerException != null)
                            msg = ex.InnerException.ToString() + " - ";
                        await Application.Current.MainPage.DisplayAlert("Greška", msg + ex.Message, "OK");
                    }
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Mail već postoje!", "OK");

                }
            }
        }


        private async Task<bool> Validacija()
        {

            if (Ime == string.Empty)
            {
                ImeRequired = "Ime je obavezno!";
                VisibleIme = true;
                VisiblePrezime = false;
                VisibleAdresa = false;
                VisibleDatumrodjenja = false;
                VisibleEmail = false;
                VisibleGrad = false;
                VisibleJMBG = false;
                VisibleSpol = false;
                VisibleTelefon = false;
                VisibleKorisnickoIme = false;
                return true;
            }

            else if (Prezime == string.Empty)
            {
                PrezimeRequired = "Prezime je obavezno!";
                VisibleIme = false;
                VisiblePrezime = true;
                VisibleAdresa = false;
                VisibleDatumrodjenja = false;
                VisibleEmail = false;
                VisibleGrad = false;
                VisibleJMBG = false;
                VisibleSpol = false;
                VisibleTelefon = false;
                VisibleKorisnickoIme = false;
                return true;
            }

            else if (DatumRodjenja.Date == DateTime.Now.Date)
            {
                DatumrodjenjaRequired = "Datum rođenja  je obavezno!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleAdresa = false;
                VisibleDatumrodjenja = true;
                VisibleEmail = false;
                VisibleGrad = false;
                VisibleJMBG = false;
                VisibleSpol = false;
                VisibleTelefon = false;
                VisibleKorisnickoIme = false;
                return true;
            }

            else if (Spol == string.Empty)
            {
                SpolRequired = "Spol je obavezan!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleAdresa = false;
                VisibleDatumrodjenja = false;
                VisibleEmail = false;
                VisibleGrad = false;
                VisibleJMBG = false;
                VisibleSpol = true;
                VisibleTelefon = false;
                VisibleKorisnickoIme = false;
                return true;
            }

            else if (JMBG == string.Empty)
            {
                JMBGRequired = "JMBG  je obavezan!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleAdresa = false;
                VisibleDatumrodjenja = false;
                VisibleEmail = false;
                VisibleGrad = false;
                VisibleJMBG = true;
                VisibleSpol = false;
                VisibleTelefon = false;
                VisibleKorisnickoIme = false;
                return true;
            }

            else if (Adresa == string.Empty)
            {
                AdresaRequired = "Adresa je obavezna!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleAdresa = true;
                VisibleDatumrodjenja = false;
                VisibleEmail = false;
                VisibleGrad = false;
                VisibleJMBG = false;
                VisibleSpol = false;
                VisibleTelefon = false;
                VisibleKorisnickoIme = false;
                return true;
            }

            else if (Email == string.Empty)
            {
                EmailRequired = "Email  je obavezno!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleAdresa = false;
                VisibleDatumrodjenja = false;
                VisibleEmail = true;
                VisibleGrad = false;
                VisibleJMBG = false;
                VisibleSpol = false;
                VisibleTelefon = false;
                VisibleKorisnickoIme = false;
                return true;
            }

            else if (Email != string.Empty)
            {

                try
                {
                    var addr = new System.Net.Mail.MailAddress(Email);
                    if (addr.Address == Email)
                    {
                        return false;
                    }
                }
                catch
                {
                    ValidEmail = "Email nije u dobrom formatu!";
                    VisibleIme = false;
                    VisiblePrezime = false;
                    VisibleAdresa = false;
                    VisibleDatumrodjenja = false;
                    VisibleEmail = false;
                    VisibleValidEmail = true;
                    VisibleGrad = false;
                    VisibleJMBG = false;
                    VisibleSpol = false;
                    VisibleTelefon = false;
                    VisibleKorisnickoIme = false;
                    return true;
                }
            }


            else if (Telefon == string.Empty)
            {
                TelefonRequired = "Telefon  je obavezan!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleAdresa = false;
                VisibleDatumrodjenja = false;
                VisibleEmail = false;
                VisibleGrad = false;
                VisibleJMBG = false;
                VisibleSpol = false;
                VisibleTelefon = true;
                VisibleKorisnickoIme = false;
                return true;
            }

            else if (Grad == string.Empty)
            {
                GradRequired = "Grad  je obavezan!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleAdresa = false;
                VisibleDatumrodjenja = false;
                VisibleEmail = false;
                VisibleGrad = true;
                VisibleJMBG = false;
                VisibleSpol = false;
                VisibleTelefon = false;
                VisibleKorisnickoIme = false;
                return true;
            }

            else if (Username == string.Empty)
            {
                KorisnickoImeRequired = "Korisničko ime je obavezno!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleAdresa = false;
                VisibleDatumrodjenja = false;
                VisibleEmail = false;
                VisibleGrad = false;
                VisibleJMBG = false;
                VisibleSpol = false;
                VisibleTelefon = false;
                VisibleKorisnickoIme = true;
                return true;
            }

            return false;
        }


        public async Task<bool> CheckUsername(string text)
        {
            bool postoji = false;
            KorisniciSearchRequest klijentSearch = new KorisniciSearchRequest()
            {

                KorisnickoIme = text
            };


            var users = await _serviceKlijent.Get<List<Model.Korisnici>>(klijentSearch);
            if (users.Count > 0)
            {
                postoji = true;
            }
            return postoji;
        }


        public async Task<bool> CheckEmail(string text)
        {
            bool postoji = false;
            KorisniciSearchRequest klijentSearch = new KorisniciSearchRequest()
            {

                Email = text
            };
            var users = await _serviceKlijent.Get<List<Model.Korisnici>>(klijentSearch);
            if (users.Count > 0)
            {
                postoji = true;
            }
            return postoji;
        }

    }
}
