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
   public class DodajRadniSatViewModel:BaseViewModel
    {

        private readonly APIService _radniSatiService = new APIService("RadniSati");
        private readonly APIService _predmetiService = new APIService("Predmeti");
   
        public int KlijentId;
        public DodajRadniSatViewModel(int Klijent)
        {
            KlijentId = Klijent;
            InitCommand = new Command(async () => await Init());
            AddCommand = new Command(async () => await Add());

        }
        public DodajRadniSatViewModel()
        {

            InitCommand = new Command(async () => await Init());
        }


        public ObservableCollection<Predmeti> PredmetiList { get; set; } = new ObservableCollection<Predmeti>();


        public RadniSatiInsertRequest radniSatiInsert { get; set; } = new RadniSatiInsertRequest();

        public ICommand InitCommand { get; set; }
        public ICommand AddCommand { get; set; }


        decimal _brojRadnihSati;
        public decimal BrojRadnihSati
        {
            get { return _brojRadnihSati; }
            set { SetProperty(ref _brojRadnihSati, value); }
        }

        decimal _prekovremeniSati;
        public decimal PrekovremeniSati
        {
            get { return _prekovremeniSati; }
            set { SetProperty(ref _prekovremeniSati, value); }
        }

        decimal _cijenaPoSatu;
        public decimal CijenaPoSatu
        {
            get { return _cijenaPoSatu; }
            set { SetProperty(ref _cijenaPoSatu, value); }
        }


        decimal _cijenaPrekovremenogSata;
        public decimal CijenaPrekovremenogSata
        {
            get { return _cijenaPrekovremenogSata; }
            set { SetProperty(ref _cijenaPrekovremenogSata, value); }
        }
      
        string _opis = string.Empty;
        public string Opis
        {
            get { return _opis; }
            set { SetProperty(ref _opis, value); }
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


                radniSatiInsert.BrojRadnihSati = BrojRadnihSati;
                radniSatiInsert.PrekovremeniSati = PrekovremeniSati;
                radniSatiInsert.CijenaPoSatu = CijenaPoSatu;
                radniSatiInsert.CijenaPrekovremenogSata = CijenaPrekovremenogSata;
                radniSatiInsert.Opis = Opis;
                radniSatiInsert.ZaposleniciId = KlijentId;
                radniSatiInsert.PredmetId = SelectedPredmet.PredmetId;
                radniSatiInsert.IsDeleted = false;



                try
                {
                    var entity = await _radniSatiService.Insert<Model.Rocista>(radniSatiInsert);
                    if (entity != null)
                    {
                        await Application.Current.MainPage.DisplayAlert("Obavijest", "Uspješno ste dodali novi radni sat!", "OK");
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

        string _radniSatiRequired = string.Empty;
        string _cijenaPoSatuRequired = string.Empty;
        string _predmetRequired = string.Empty;


        bool _visibleRadniSati = false;
        bool _visibleCijenaPoSatu = false;
        bool _visiblePredmet = false;


        public string RadniSatiRequired
        {
            get { return _radniSatiRequired; }
            set { SetProperty(ref _radniSatiRequired, value); }
        }
        public string CijenaPoSatuRequired
        {
            get { return _cijenaPoSatuRequired; }
            set { SetProperty(ref _cijenaPoSatuRequired, value); }
        }

        public string PredmetRequired
        {
            get { return _predmetRequired; }
            set { SetProperty(ref _predmetRequired, value); }
        }



        public bool VisibleRadniSati
        {
            get { return _visibleRadniSati; }
            set { SetProperty(ref _visibleRadniSati, value); }
        }
        public bool VisibleCijenaPoSatu
        {
            get { return _visibleCijenaPoSatu; }
            set { SetProperty(ref _visibleCijenaPoSatu, value); }
        }

        public bool VisiblePredmet
        {
            get { return _visiblePredmet; }
            set { SetProperty(ref _visiblePredmet, value); }
        }



        private async Task<bool> Validacija()
        {

             if (SelectedPredmet == null)
            {
                PredmetRequired = "Predmet je obavezan!";
                VisibleRadniSati = false;
                VisibleCijenaPoSatu = true;
                VisiblePredmet = true;

                return true;
            }

           else if (BrojRadnihSati == decimal.Zero)
            {
                RadniSatiRequired = "Broj radnih sati je obavezno!";
                VisibleRadniSati = true;
                VisibleCijenaPoSatu= false;
                VisiblePredmet = false;

                return true;
            }

            else if (CijenaPoSatu == decimal.Zero)
            {
                CijenaPoSatuRequired = "Cijena po satu je obavezna!";
                VisibleRadniSati = false;
                VisibleCijenaPoSatu = true;
                VisiblePredmet = false;

                return true;
            }

         

            return false;
        }
    }
}
