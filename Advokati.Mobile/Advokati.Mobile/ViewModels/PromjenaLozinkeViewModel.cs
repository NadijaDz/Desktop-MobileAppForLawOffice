using Advokati.Model;
using Advokati.Model.Requests;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace Advokati.Mobile.ViewModels
{
    public class PromjenaLozinkeViewModel : BaseViewModel
    {


        private readonly APIService _serviceKlijent = new APIService("Zaposlenici");
        private readonly APIService _serviceUloge = new APIService("Uloge");


        public PromjenaLozinkeViewModel()
        {
        
            SaveCommand = new Command(async () => await Save());
            OldPasswordCheckCommand = new Command(async () => await OldPasswordCheck());

        }
    
        public int KlijentID { get; set; }

        public KorisniciInsertRequest klijentInsert { get; set; } = new KorisniciInsertRequest();


        string _oldPassword = string.Empty;

        public string OldPassword
        {
            get { return _oldPassword; }
            set { SetProperty(ref _oldPassword, value); }
        }


        public async Task OldPasswordCheck()
        {
            var z = await _serviceKlijent.GetById<Model.Korisnici>(KlijentID);

            string Hash = GenerateHash(z.LozinkaSalt, OldPassword);

            if (Hash != z.LozinkaHash)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Stara lozinka nije ispravna", "OK");
                
            }
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


        public ICommand SaveCommand { get; set; }
        public ICommand OldPasswordCheckCommand { get; set; }


        public async Task Save()
        {
            
            var k = await _serviceKlijent.GetById<Korisnici>(KlijentID);

            var uloge = await _serviceUloge.Get<List<Model.Uloge>>();
            var id = -1;

            klijentInsert.Ime = k.Ime;
            klijentInsert.Prezime = k.Prezime;
            klijentInsert.Email = k.Email;
            klijentInsert.KorisnickoIme = k.KorisnickoIme;
            klijentInsert.DatumRodjenja = k.DatumRodjenja;
            klijentInsert.Adresa = k.Adresa;
            klijentInsert.Telefon = k.Telefon;
            klijentInsert.Grad = k.Grad;
            klijentInsert.RadniStaz = "0";
            klijentInsert.Status = true;
            klijentInsert.Spol = k.Spol;
            klijentInsert.JMBG = k.JMBG;
            klijentInsert.IsDeleted = false;
            foreach (var u in uloge)
            {
                if (u.Naziv == "Klijent")
                {
                    id = u.UlogaId;
                }
            }
            klijentInsert.UlogeId = id;



            if (!string.IsNullOrEmpty(Password))
            {
                klijentInsert.Password = Password;
                klijentInsert.PasswordConfirmation = ConfirmPassword;
            }

            //provjera stare lozinke
            string Hash = GenerateHash(k.LozinkaSalt, OldPassword);

            if (Hash == k.LozinkaHash)
            {
                try
                {
                    await _serviceKlijent.Update<Model.Korisnici>(k.KorisnikId, klijentInsert);

                }
                catch (Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", ex.Message, "OK");

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

    }
}
