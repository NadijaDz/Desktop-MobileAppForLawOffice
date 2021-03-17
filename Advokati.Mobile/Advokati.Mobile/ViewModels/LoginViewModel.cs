using Advokati.Mobile.Views;
using Advokati.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace Advokati.Mobile.ViewModels
{
    public class LoginViewModel:BaseViewModel
    {

        private readonly APIService _apiService = new APIService("Zaposlenici");
        public int KlijentId;

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
            //RegisterCommand = new Command( () => Register());
            
        }

        string _usernameError = string.Empty;
        string _passwordError = string.Empty;
        bool _visibleUsername = false;
        bool _visiblePassword = false;

        public string UsernameError
        {
            get { return _usernameError; }
            set { SetProperty(ref _usernameError, value); }

        }

        public string PasswordError
        {
            get { return _passwordError; }
            set { SetProperty(ref _passwordError, value); }

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

        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }


        //public  void Register()
        //{
        //     Application.Current.MainPage =new RegistrationPage();
            
             
           
        //}

        async Task Login()
        {
            IsBusy = true;
            APIService.KorisnickoIme = Username;
            APIService.Lozinka = Password;


             if (Validacija())
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Korisničko ime i password su obavezeni za unos!", "OK");
            }

        
            else
            {

                try
                {
                    await _apiService.Get<List<dynamic>>(null);


                    KorisniciSearchRequest klijentSearch = new KorisniciSearchRequest();
                    klijentSearch.KorisnickoIme = APIService.KorisnickoIme;


                    var korisnici = await _apiService.Get<List<Model.Korisnici>>(klijentSearch);

                    if (korisnici.Count > 0)
                    {
                        var k = korisnici.FirstOrDefault();
                        string pwHash = GenerateHash(k.LozinkaSalt, APIService.Lozinka);

                        if (k.KorisnickoIme == klijentSearch.KorisnickoIme && k.LozinkaHash == pwHash && k.Status==true)
                        {
                            KlijentId = k.KorisnikId;
                            App.LoggedUserId = KlijentId;

                            App.LoggedUserRole = k.NazivUloge;
                            Application.Current.MainPage = new MainPage(KlijentId);
                        }
                        else
                            throw new Exception("Password nije ispravan!");
                    }
                    else
                        throw new Exception("User ne postoji");
                }
                catch (Exception ex)
                {
                    string msg = "";
                    if (ex.InnerException != null)
                        msg = ex.InnerException.ToString() + " - ";
                    await Application.Current.MainPage.DisplayAlert("Greška", msg + ex.Message, "OK");
                }
            }
            
        }


        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = System.Security.Cryptography.SHA1.Create();
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

 

     
   

        public bool VisibleUsername
        {
            get { return _visibleUsername; }
            set { SetProperty(ref _visibleUsername, value); }

        }
        public bool VisiblePassword
        {
            get { return _visiblePassword; }
            set { SetProperty(ref _visiblePassword, value); }

        }


        private bool Validacija()
        {
            if(Username==string.Empty)
            {
                UsernameError = "Korisničko ime je obavezno!";
                VisibleUsername = true;
                VisiblePassword = false;
                return true;
            }
            else if(Password==string.Empty)
            {
                PasswordError = "Password je obavezan!";
                VisiblePassword = true;
                VisibleUsername = false;
                return true;
                

            }
            else
            {
                VisiblePassword = false;
                return false;
            }

        }




    }
}
