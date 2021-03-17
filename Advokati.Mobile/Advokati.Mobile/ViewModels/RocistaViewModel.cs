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
   public class RocistaViewModel:BaseViewModel
    {
        private readonly APIService _rocistaService = new APIService("Rocista");
        private readonly APIService _predmetiService = new APIService("Predmeti");
        public int KlijentId;

        public RocistaViewModel(int Klijent)
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
        public RocistaViewModel()
        {

            InitCommand = new Command(async () => await Init());
        }


        bool _buttonVisible = false;
        public bool ButtonVisible
        {
            get { return _buttonVisible; }
            set { SetProperty(ref _buttonVisible, value); }
        }

        public ObservableCollection<Rocista> RocistaList { get; set; } = new ObservableCollection<Rocista>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var listRocista = await _rocistaService.Get<List<Rocista>>(null);
            var listPredmeta = await _predmetiService.Get<List<Predmeti>>(null);

            RocistaList.Clear();

            if (App.LoggedUserRole == "Klijent")
            {
                foreach (var predmeti in listPredmeta)
                {
                    if (predmeti.KlijentId == KlijentId)
                    {
                        foreach (var rocista in listRocista)
                        {
                            if (predmeti.BrojPredmeta == rocista.BrojPredmeta)
                            {
                                RocistaList.Add(rocista);
                            }
                        }
                    }
                }
            }

            else
            {
                   foreach (var rocista in listRocista)
                    {
                         if (rocista.ZaposlenikId == KlijentId)
                            {
                                RocistaList.Add(rocista);
                            }
                    }
            }


            
           
        }
    }
}
