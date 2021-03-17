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
    public class DodajRocisteViewModel:BaseViewModel
    {
        private readonly APIService _zaposleniciService = new APIService("Zaposlenici");
        private readonly APIService _predmetiService = new APIService("Predmeti");
        private readonly APIService _rocistaService = new APIService("Rocista");


        public int KlijentId;
        public DodajRocisteViewModel(int Klijent)
        {
            KlijentId = Klijent;
            InitCommand = new Command(async () => await Init());
            AddCommand = new Command(async () => await Add());

        }
        public DodajRocisteViewModel()
        {

            InitCommand = new Command(async () => await Init());
        }



        public ObservableCollection<Korisnici> ZaposleniciList { get; set; } = new ObservableCollection<Korisnici>();
        public ObservableCollection<Predmeti> PredmetiList { get; set; } = new ObservableCollection<Predmeti>();
     

        public RocistaInsertRequest rocisteInsert { get; set; } = new RocistaInsertRequest();

        public ICommand InitCommand { get; set; }
        public ICommand AddCommand { get; set; }


        string _mjesto = string.Empty;
        public string Mjesto
        {
            get { return _mjesto; }
            set { SetProperty(ref _mjesto, value); }
        }

        string _napomena = string.Empty;
        public string Napomena
        {
            get { return _napomena; }
            set { SetProperty(ref _napomena, value); }
        }

        DateTime _datumRocista = DateTime.Now;
        public DateTime DatumRocista
        {
            get { return _datumRocista; }
            set { SetProperty(ref _datumRocista, value); }
        }

      

        Predmeti _selectedPredmet = null;
        public Predmeti SelectedPredmet
        {
            get { return _selectedPredmet; }
            set
            {
                SetProperty(ref _selectedPredmet, value);
            }
        }

      


        public async Task Init()
        {

      
            var listaPredmeta = await _predmetiService.Get<List<Predmeti>>(null);
            foreach (var p in listaPredmeta)
            {
                PredmetiList.Add(p);
            }

          
        }
        public async Task Add()
        {

            if (await Validacija())
            {
                return;
            }

            else
            {

              
                rocisteInsert.DatumRocista = DatumRocista;
                rocisteInsert.Mjesto = Mjesto;
                rocisteInsert.Napomena = Napomena;
                rocisteInsert.ZaposlenikId = KlijentId;
                rocisteInsert.PredmetID = SelectedPredmet.PredmetId;
                rocisteInsert.Odrzano = false;
                rocisteInsert.IsDeleted = false;


                try
                {
                    var entity = await _rocistaService.Insert<Model.Rocista>(rocisteInsert);
                    if (entity != null)
                    {
                        await Application.Current.MainPage.DisplayAlert("Obavijest", "Uspješno ste dodali novo ročište!", "OK");
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


        }

        string _mjestoRequired = string.Empty;
        string _datumRocistaRequired = string.Empty;
        string _predmetRequired = string.Empty;
  
  
        bool _visibleMjesto = false;
        bool _visibleDatumRocista = false;
        bool _visiblePredmet = false;
  

        public string MjestoRequired
        {
            get { return _mjestoRequired; }
            set { SetProperty(ref _mjestoRequired, value); }
        }
        public string DatumRocistaRequired
        {
            get { return _datumRocistaRequired; }
            set { SetProperty(ref _datumRocistaRequired, value); }
        }
    
        public string PredmetRequired
        {
            get { return _predmetRequired; }
            set { SetProperty(ref _predmetRequired, value); }
        }


  


        public bool VisibleMjesto
        {
            get { return _visibleMjesto; }
            set { SetProperty(ref _visibleMjesto, value); }
        }
        public bool VisibleDatumRocista
        {
            get { return _visibleDatumRocista; }
            set { SetProperty(ref _visibleDatumRocista, value); }
        }

     

        public bool VisiblePredmet
        {
            get { return _visiblePredmet; }
            set { SetProperty(ref _visiblePredmet, value); }
        }

 

        private async Task<bool> Validacija()
        {

            if (Mjesto == string.Empty)
            {
                MjestoRequired = "Mjesto je obavezno!";
                VisibleMjesto = true; 
                VisibleDatumRocista = false;
                VisiblePredmet = false;
            
                return true;
            }
          

            else if (SelectedPredmet == null)
            {
                PredmetRequired = "Predmet je obavezan!";
                VisibleMjesto = false; 
                VisibleDatumRocista = false;
                VisiblePredmet = true;
          
                return true;
            }

            return false;
        }


    }

}




