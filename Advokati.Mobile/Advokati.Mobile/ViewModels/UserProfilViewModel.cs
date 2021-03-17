using Advokati.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Advokati.Mobile.ViewModels
{
    public class UserProfilViewModel
    {
        private readonly APIService _zaposleniciService = new APIService("Zaposlenici");
     
        public int KlijentId;

        public UserProfilViewModel(int Klijent)
        {
            KlijentId = Klijent;
            InitCommand = new Command(async () => await Init());
        }
        public UserProfilViewModel()
        {

            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Korisnici> ZaposleniciList { get; set; } = new ObservableCollection<Korisnici>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var listZaposlenika = await _zaposleniciService.Get<List<Korisnici>>(null);
         

            ZaposleniciList.Clear();
            foreach (var zaposlenici in listZaposlenika)
            {
                if (zaposlenici.KorisnikId == KlijentId)
                {
                   
                      ZaposleniciList.Add(zaposlenici);
                }
                    
             }
        }
    }
}
