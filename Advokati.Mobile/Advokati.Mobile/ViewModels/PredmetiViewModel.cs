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
    public class PredmetiViewModel:BaseViewModel
    {
        private readonly APIService _predmetiService = new APIService("Predmeti");
        public int KlijentId;
        public PredmetiViewModel(int Klijent)
        {
            KlijentId = Klijent;
            InitCommand = new Command(async () => await Init());
            var k = App.LoggedUserRole;
            if (k == "Klijent")
            {
                _buttonVisible = false;
            }
            else
            {
                _buttonVisible = true;

            }
        }
        public PredmetiViewModel()
        {
           
            InitCommand = new Command(async () => await Init());
        }

         bool _buttonVisible = false;
        public bool ButtonVisible
        {
            get { return _buttonVisible; }
            set { SetProperty(ref _buttonVisible, value); }
        }

        public ObservableCollection<Predmeti> PredmetiList { get; set; } = new ObservableCollection<Predmeti>();

        public ICommand InitCommand { get; set; }

       public async Task Init()
        {
            var list =await _predmetiService.Get<List<Predmeti>>(null);
            PredmetiList.Clear();

            if (App.LoggedUserRole == "Klijent")
            {
                foreach (var predmeti in list)
                {
                    if (predmeti.KlijentId == KlijentId)
                    {
                        PredmetiList.Add(predmeti);
                    }
                }

            }

            else
            {
                foreach (var predmeti in list)
                {
                    if (predmeti.ZaposleniciId == KlijentId)
                    {
                        PredmetiList.Add(predmeti);
                    }
                }
            }



        }

    }

    

}
