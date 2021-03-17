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
    public class IzlistajPredmeteViewModel:BaseViewModel
    {
        private readonly APIService _predmetiService = new APIService("Predmeti");
        private readonly APIService _radniSatiService = new APIService("RadniSati");
        public int KlijentId;
        public DateTime DatumOd;
        public DateTime DatumDo;
        public IzlistajPredmeteViewModel(int Klijent,DateTime datumOd,DateTime datumDo)
        {
            KlijentId = Klijent;
            DatumOd = datumOd;
            DatumDo = datumDo;
            InitCommand = new Command(async () => await Init());
            var k = App.LoggedUserRole;

        }
        public IzlistajPredmeteViewModel()
        {

            InitCommand = new Command(async () => await Init());
        }




        public ObservableCollection<Predmeti> PredmetiList { get; set; } = new ObservableCollection<Predmeti>();

        public ICommand InitCommand { get; set; }


        decimal _ukupno;
        public decimal Ukupno
        {
            get { return _ukupno; }
            set { SetProperty(ref _ukupno, value); }
        }

        decimal _total;
        public decimal Total
        {
            get { return _ukupno; }
            set { SetProperty(ref _ukupno, value); }
        }



        public async Task Init()
        {

            var search = new PredmetiSearchRequest
            {
                DatumOd = DatumOd,
                DatumDo = DatumDo
            };


            var list = await _predmetiService.Get<List<Predmeti>>(search);

            List<RadniSati> listaRadnihSati = new List<RadniSati>();

            foreach (var l in list)
            {
                listaRadnihSati = await _radniSatiService.Get<List<RadniSati>>(l.BrojPredmeta);
            }

            decimal suma=0;
           
            foreach(var l in list)
            {
                foreach(var r in listaRadnihSati)
                {
                    if (l.BrojPredmeta == r.BrojPredmeta)
                    {
                        l.Ukupno += r.BrojRadnihSati * r.CijenaPoSatu;
                        suma += l.Ukupno;
                    }
                }
            }

            Total = suma;

            PredmetiList.Clear();

         
                foreach (var predmeti in list)
                {
                   
                        PredmetiList.Add(predmeti);
                    
                }

           
        }

    }
}
