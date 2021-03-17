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
    public class PretragaPredmetaNoviPageViewModel:BaseViewModel
    {


        private readonly APIService _predmetiService = new APIService("Predmeti");
        private readonly APIService _radniSatiService = new APIService("RadniSati");
        public int KlijentId;
        public PretragaPredmetaNoviPageViewModel(int Klijent)
        {
            KlijentId = Klijent;
            InitCommand = new Command(async () => await Init());
            var k = App.LoggedUserRole;
         
        }
        public PretragaPredmetaNoviPageViewModel()
        {

            InitCommand = new Command(async () => await Init());
        }



        DateTime _datumOd = DateTime.Now;
        public DateTime DatumOd
        {
            get { return _datumOd; }
            set { SetProperty(ref _datumOd, value); }
        }

        DateTime _datumDo = DateTime.Now;
        public DateTime DatumDo
        {
            get { return _datumDo; }
            set { SetProperty(ref _datumDo, value); }
        }





        public ObservableCollection<Predmeti> PredmetiList { get; set; } = new ObservableCollection<Predmeti>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {

            var search = new PredmetiSearchRequest
            {
                DatumOd=DatumOd,
                DatumDo=DatumDo
            };



            var list = await _predmetiService.Get<List<Predmeti>>(search);

            //List<RadniSati> listaRadnihSati = new List<RadniSati>();

            //foreach(var l in list)
            //{
            //    listaRadnihSati = await _radniSatiService.Get<List<RadniSati>>(l.BrojPredmeta);
            //}

   
            PredmetiList.Clear();

           
                foreach (var predmeti in list)
                {
                   
                        PredmetiList.Add(predmeti);
                    
                }

          
        }

    }
}
