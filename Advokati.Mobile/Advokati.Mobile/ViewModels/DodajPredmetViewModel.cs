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
   public class DodajPredmetViewModel:BaseViewModel
    {
        private readonly APIService _zaposleniciService = new APIService("Zaposlenici");
        private readonly APIService _predmetiService = new APIService("Predmeti");
        private readonly APIService _statusService = new APIService("Status");
        private readonly APIService _vrstaUslugeService = new APIService("VrstaUsluge");

        public int KlijentId;
        public DodajPredmetViewModel(int Klijent)
        {
            KlijentId = Klijent;
            InitCommand = new Command(async () => await Init());
            AddCommand = new Command(async () => await Add());
          
        }
        public DodajPredmetViewModel()
        {

            InitCommand = new Command(async () => await Init());
        }

      

        public ObservableCollection<Korisnici> KlijentiList { get; set; } = new ObservableCollection<Korisnici>();
        public ObservableCollection<Status> StatusList { get; set; } = new ObservableCollection<Status>();
        public ObservableCollection<VrstaUsluge> VrstaUslugeList { get; set; } = new ObservableCollection<VrstaUsluge>();

        public PredmetiInsertRequest predmetiInsert { get; set; } = new PredmetiInsertRequest();

        public ICommand InitCommand { get; set; }
        public ICommand AddCommand { get; set; }


        string _brojPredmeta = string.Empty;
        public string BrojPredmeta
        {
            get { return _brojPredmeta; }
            set { SetProperty(ref _brojPredmeta, value); }
        }

        string _nazivPredmeta = string.Empty;
        public string NazivPredmeta
        {
            get { return _nazivPredmeta; }
            set { SetProperty(ref _nazivPredmeta, value); }
        }

        DateTime _datumPocetka = DateTime.Now;
        public DateTime DatumPocetka
        {
            get { return _datumPocetka; }
            set { SetProperty(ref _datumPocetka, value); }
        }

        DateTime _rokZavrsetka = DateTime.Now;
        public DateTime RokZavrsetka
        {
            get { return _rokZavrsetka; }
            set { SetProperty(ref _rokZavrsetka, value); }
        }


        Korisnici _selectedKlijent = null;
        public Korisnici SelectedKlijent
        {
            get { return _selectedKlijent; }
            set
            {
                SetProperty(ref _selectedKlijent, value);
            }
        }

        Status _selectedStatus = null;
        public Status SelectedStatus
        {
            get { return _selectedStatus; }
            set
            {
                SetProperty(ref _selectedStatus, value);
            }
        }

        VrstaUsluge _selectedVrstaUsluge = null;
        public VrstaUsluge SelectedVrstaUsluge
        {
            get { return _selectedVrstaUsluge; }
            set
            {
                SetProperty(ref _selectedVrstaUsluge, value);
            }
        }



        public async Task Init()
        {

            var listaKlijenata= await _zaposleniciService.Get<List<Korisnici>>(null);
            foreach (var z in listaKlijenata)
            {
                if (z.NazivUloge == "Klijent")
                {
                    KlijentiList.Add(z);
                }
            }

            var listaStatusa = await _statusService.Get<List<Status>>(null);
            foreach (var s in listaStatusa)
            {
                StatusList.Add(s);
            }

            var listaVrstaUsluge = await _vrstaUslugeService.Get<List<VrstaUsluge>>(null);
            foreach (var v in listaVrstaUsluge)
            {
                VrstaUslugeList.Add(v);
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
              
                predmetiInsert.NazivPredmeta = NazivPredmeta;
                predmetiInsert.BrojPredmeta = BrojPredmeta;
                predmetiInsert.DatumPocetka = DatumPocetka;
                predmetiInsert.RokUplate = RokZavrsetka;
                predmetiInsert.KlijentId = SelectedKlijent.KorisnikId;
                predmetiInsert.StatusId = SelectedStatus.StatusId;
                predmetiInsert.VrstaId = SelectedVrstaUsluge.VrstaUslugeId;
                predmetiInsert.IsDeleted = false;
                predmetiInsert.ZaposleniciId = KlijentId;


                try
                {
                    var entity = await _predmetiService.Insert<Model.Predmeti>(predmetiInsert);
                    if (entity != null)
                    {
                        await Application.Current.MainPage.DisplayAlert("Obavijest", "Uspješno ste dodali novi predmet!", "OK");
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

        string _brojPredmetaRequired = string.Empty;
        string _nazivPredmetaRequired = string.Empty;
        string _datumPocetkaRequired = string.Empty;
        string _rokZavrsetkaRequired = string.Empty;
        string _klijentRequired = string.Empty;
        string _statusRequired = string.Empty;
        string _vrstaUslugeRequired = string.Empty;
     


        bool _visibleBrojPredmeta = false;
        bool _visibleNazivPredmeta = false;
        bool _visibleDatumPocetka = false;
        bool _visibleRokZavrsetka = false;
        bool _visibleKlijent = false;
        bool _visibleStatus = false;
        bool _visibleVrstaUsluge = false;


        public string BrojPredmetaRequired
        {
            get { return _brojPredmetaRequired; }
            set { SetProperty(ref _brojPredmetaRequired, value); }
        }
        public string NazivPredmetaRequired
        {
            get { return _nazivPredmetaRequired; }
            set { SetProperty(ref _nazivPredmetaRequired, value); }
        }
        public string DatumPocetkaRequired
        {
            get { return _datumPocetkaRequired; }
            set { SetProperty(ref _datumPocetkaRequired, value); }
        }
        public string RokZavrsetkaRequired
        {
            get { return _rokZavrsetkaRequired; }
            set { SetProperty(ref _rokZavrsetkaRequired, value); }
        }
        public string KlijentRequired
        {
            get { return _klijentRequired; }
            set { SetProperty(ref _klijentRequired, value); }
        }

        public string StatusRequired
        {
            get { return _statusRequired; }
            set { SetProperty(ref _statusRequired, value); }
        }
        public string VrstaUslugeRequired
        {
            get { return _vrstaUslugeRequired; }
            set { SetProperty(ref _vrstaUslugeRequired, value); }
        }



        public bool VisibleBrojPredmeta
        {
            get { return _visibleBrojPredmeta; }
            set { SetProperty(ref _visibleBrojPredmeta, value); }
        }
        public bool VisibleNazivPredmeta
        {
            get { return _visibleNazivPredmeta; }
            set { SetProperty(ref _visibleNazivPredmeta, value); }
        }

        public bool VisibleDatumPocetka
        {
            get { return _visibleDatumPocetka; }
            set { SetProperty(ref _visibleDatumPocetka, value); }
        }

        public bool VisibleRokZavrsetka
        {
            get { return _visibleRokZavrsetka; }
            set { SetProperty(ref _visibleRokZavrsetka, value); }
        }

        public bool VisibleKlijent
        {
            get { return _visibleKlijent; }
            set { SetProperty(ref _visibleKlijent, value); }
        }

        public bool VisibleStatus
        {
            get { return _visibleStatus; }
            set { SetProperty(ref _visibleStatus, value); }
        }

        public bool VisibleVrstaUsluge
        {
            get { return _visibleVrstaUsluge; }
            set { SetProperty(ref _visibleVrstaUsluge, value); }
        }


        private async Task<bool> Validacija()
        {

            if (BrojPredmeta == string.Empty)
            {
                BrojPredmetaRequired = "Broj predmeta  je obavezno!";
                VisibleKlijent = false; ;
                VisibleNazivPredmeta = false;
                VisibleBrojPredmeta = true;
                VisibleDatumPocetka = false;
                VisibleRokZavrsetka = false;
                VisibleStatus = false;
                VisibleVrstaUsluge = false;
                return true;
            }
            else if (NazivPredmeta == string.Empty)
            {
                NazivPredmetaRequired = "Naziv predmeta  je obavezno!";
                VisibleKlijent = false; ;
                VisibleNazivPredmeta = true;
                VisibleBrojPredmeta = false;
                VisibleDatumPocetka = false;
                VisibleRokZavrsetka = false;
                VisibleStatus = false;
                VisibleVrstaUsluge = false;
                return true;
            }



           else if (SelectedKlijent == null)
            {
                KlijentRequired = "Klijent je obavezan!";
                VisibleKlijent = true;
                VisibleNazivPredmeta = false;
                VisibleBrojPredmeta = false;
                VisibleDatumPocetka = false;
                VisibleRokZavrsetka = false;
                VisibleStatus = false;
                VisibleVrstaUsluge = false;

                return true;
            }


            else if (SelectedStatus == null)
            {
                StatusRequired = "Status je obavezno!";
                VisibleKlijent = false; ;
                VisibleNazivPredmeta = false;
                VisibleBrojPredmeta = false;
                VisibleDatumPocetka = false;
                VisibleRokZavrsetka = false;
                VisibleStatus = true;
                VisibleVrstaUsluge = false;
                return true;
            }
            else if (SelectedVrstaUsluge == null)
            {
                VrstaUslugeRequired = "Vrsta usluge je obavezno!";
                VisibleKlijent = false; ;
                VisibleNazivPredmeta = false;
                VisibleBrojPredmeta = false;
                VisibleDatumPocetka = false;
                VisibleRokZavrsetka = false;
                VisibleStatus = false;
                VisibleVrstaUsluge = true;
                return true;
            }


       
            return false;
        }


    }

}
