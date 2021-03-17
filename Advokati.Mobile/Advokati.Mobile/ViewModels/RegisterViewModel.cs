using Advokati.Mobile.Views;
using Advokati.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;



namespace Advokati.Mobile.ViewModels
{
  public  class RegisterViewModel:BaseViewModel
    {
        private readonly APIService _serviceKlijent = new APIService("Zaposlenici");
        private readonly APIService _serviceUloge = new APIService("Uloge");

        public RegisterViewModel()
        {
          
            RegisterCommand = new Command(async () => await  Register());
           
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
        string _passwordRequired = string.Empty;
        string _passwordConfirmationRequired = string.Empty;
        string _validEmail = string.Empty;


        bool _visibleIme = false;
        bool _visiblePrezime = false;
        bool _visibleDatumRodjenja = false;
        bool _visibleSpol = false;
        bool _visibleJMBG = false;
        bool _visibleAdresa = false;
        bool _visibleGrad= false;
        bool _visibleTelefon = false;
        bool _visibleEmail = false;
        bool _visibleKorisnickoIme = false;
        bool _visiblePassword = false;
        bool _visiblePasswordConfirmation = false;
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
        public string PasswordRequired
        {
            get { return _passwordRequired; }
            set { SetProperty(ref _passwordRequired, value); }
        }
        public string PasswordConfirmationRequired
        {
            get { return _passwordConfirmationRequired; }
            set { SetProperty(ref _passwordConfirmationRequired, value); }
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
        public bool VisiblePassword
        {
            get { return _visiblePassword; }
            set { SetProperty(ref _visiblePassword, value); }
        }
        public bool VisiblePasswordConfirmation
        {
            get { return _visiblePasswordConfirmation; }
            set { SetProperty(ref _visiblePasswordConfirmation, value); }
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

        string _jmbg= string.Empty;
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
        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        string _confirmPassword = string.Empty;
        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set { SetProperty(ref _confirmPassword, value); }
        }

       

        public KorisniciInsertRequest klijentInsert { get; set; } = new KorisniciInsertRequest();
       
       
        public ICommand RegisterCommand { get; set; }
    

     

        public async Task Register()
        {
          

            if (await Validacija())
            {
                return;
            }

            else
            {

                IsBusy = true;


                bool usernameexists = await CheckUsername(Username);
                bool emailexists = await CheckEmail(Email);

                var uloge = await _serviceUloge.Get<List<Model.Uloge>>();
                var id = -1;

                if (!usernameexists && !emailexists)
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
                    klijentInsert.Password = Password;
                    klijentInsert.PasswordConfirmation = ConfirmPassword;
                    klijentInsert.Status = false;
                    klijentInsert.Spol = Spol;
                    klijentInsert.JMBG = JMBG;
                    klijentInsert.IsDeleted = false;

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
                        var entity = await _serviceKlijent.Insert<Model.Korisnici>(klijentInsert);
                        if (entity != null)
                        {
                            await Application.Current.MainPage.DisplayAlert("Obavijest", "Uspješno ste se registrovali. Nakon odobravanja vaše registracije dobit ćete obavijest putem maila.", "OK");
                            Application.Current.MainPage = new LoginPage();
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
                    await Application.Current.MainPage.DisplayAlert("Greška", "Korisničko ime i mail već postoje!", "OK");

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
                VisiblePassword = false;
                VisiblePasswordConfirmation = false;
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
                VisiblePassword = false;
                VisiblePasswordConfirmation = false;
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
                VisiblePassword = false;
                VisiblePasswordConfirmation = false;
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
                VisiblePassword = false;
                VisiblePasswordConfirmation = false;
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
                VisiblePassword = false;
                VisiblePasswordConfirmation = false;
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
                VisiblePassword = false;
                VisiblePasswordConfirmation = false;
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
                VisiblePassword = false;
                VisiblePasswordConfirmation = false;
                return true;
            }

            else if (Email != string.Empty)
            {

                try
                {
                    var addr = new System.Net.Mail.MailAddress(Email);
                    if(addr.Address==Email)
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
                    VisiblePassword = false;
                    VisiblePasswordConfirmation = false;
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
                VisiblePassword = false;
                VisiblePasswordConfirmation = false;
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
                VisiblePassword = false;
                VisiblePasswordConfirmation = false;
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
                VisiblePassword = false;
                VisiblePasswordConfirmation = false;
                return true;
            }
            else if (Password == string.Empty)
            {
                PasswordRequired = "Password je obavezan!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleAdresa = false;
                VisibleDatumrodjenja = false;
                VisibleEmail = false;
                VisibleGrad = false;
                VisibleJMBG = false;
                VisibleSpol = false;
                VisibleTelefon = false;
                VisibleKorisnickoIme = false;
                VisiblePassword = true;
                VisiblePasswordConfirmation = false;
                return true;
            }
            else if (ConfirmPassword == string.Empty)
            {
                PasswordConfirmationRequired = "Password potvrda je obavezno!";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleAdresa = false;
                VisibleDatumrodjenja = false;
                VisibleEmail = false;
                VisibleGrad = false;
                VisibleJMBG = false;
                VisibleSpol = false;
                VisibleTelefon = false;
                VisibleKorisnickoIme = false;
                VisiblePassword = false;
                VisiblePasswordConfirmation = true;
                return true;
            }
            else if (Password != ConfirmPassword)
            {
                PasswordConfirmationRequired = "Passwordi se ne slažu";
                VisibleIme = false;
                VisiblePrezime = false;
                VisibleAdresa = false;
                VisibleDatumrodjenja = false;
                VisibleEmail = false;
                VisibleGrad = false;
                VisibleJMBG = false;
                VisibleSpol = false;
                VisibleTelefon = false;
                VisibleKorisnickoIme = false;
                VisiblePassword = false;
                VisiblePasswordConfirmation = true;
                return true;
            }


            return false;
        }



            //provjera username-a da li je zauzet
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

        //provjera email-a da li je zauzet
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
