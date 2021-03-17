using Advokati.Mobile.Views;
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
    public class RezervisiSastanakViewModel : BaseViewModel
    {
        private readonly APIService _zaposleniciService = new APIService("Zaposlenici");
        private readonly APIService _sastanciService = new APIService("Sastanci");
        private readonly APIService _vrstePredmetaService = new APIService("VrstaUsluge");
        public int KlijentId;
        public RezervisiSastanakViewModel(int Klijent)
        {
            KlijentId = Klijent;
            InitCommand = new Command(async () => await Init());
            RezervisiCommand = new Command(async () => await Rezervisi());
        }
        public RezervisiSastanakViewModel()
        {

            InitCommand = new Command(async () => await Init());
        }


        public ObservableCollection<Korisnici> ZaposleniciList { get; set; } = new ObservableCollection<Korisnici>();

        public ObservableCollection<VrstaUsluge> VrstaUslugeList { get; set; } = new ObservableCollection<VrstaUsluge>();
        public ObservableCollection<Korisnici> AdvokatiList { get; set; } = new ObservableCollection<Korisnici>();


        public SastanciInsertRequest sastanakInsert { get; set; } = new SastanciInsertRequest();

        public ICommand InitCommand { get; set; }
        public ICommand RezervisiCommand { get; set; }


        DateTime _datumSastanka = DateTime.Now;
        public DateTime DatumSastanka
        {
            get { return _datumSastanka; }
            set { SetProperty(ref _datumSastanka, value); }
        }


        string _mjestoOdrzavanja = string.Empty;
        public string MjestoOdrzavanja
        {
            get { return _mjestoOdrzavanja; }
            set { SetProperty(ref _mjestoOdrzavanja, value); }
        }

        string _poruka = string.Empty;
        public string Poruka
        {
            get { return _poruka; }
            set { SetProperty(ref _poruka, value); }
        }

        Korisnici _selectedZaposlenik = null;

        public Korisnici SelectedZaposlenik
        {
            get { return _selectedZaposlenik; }
            set
            {
                SetProperty(ref _selectedZaposlenik, value);
            }
        }
        VrstaUsluge _selectedVrstaUsluge = null;
        public VrstaUsluge SelectedVrstaUsluge
        {
            get { return _selectedVrstaUsluge; }
            set
            {
                SetProperty(ref _selectedVrstaUsluge, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }


        public async Task Init()
        {

            var listaZaposlenika = await _zaposleniciService.Get<List<Korisnici>>(null);
            if (ZaposleniciList.Count == 0)
            {
                foreach (var z in listaZaposlenika)
                {
                    if (z.NazivUloge == "Advokat")
                    {
                        ZaposleniciList.Add(z);
                    }
                }
            }
           
            var listaVrstaUsluge = await _vrstePredmetaService.Get<List<VrstaUsluge>>(null);
            if (VrstaUslugeList.Count == 0)
            {
                foreach (var z in listaVrstaUsluge)
                {
                    VrstaUslugeList.Add(z);
                }
            }
            VisibleAdvokatiPreporukaNaslov = false;
            AdvokatiList.Clear();
            if (SelectedVrstaUsluge != null)
            {
                var listaAdvokata = await _sastanciService.GetAdvokatiPreporuka<List<Korisnici>>(SelectedVrstaUsluge.VrstaUslugeId);
                foreach (var z in listaAdvokata)
                {
                    AdvokatiList.Add(z);
                    VisibleAdvokatiPreporukaNaslov = true;
                }
                
            }
            else
            {
                VisibleAdvokatiPreporukaNaslov = false;
                AdvokatiList.Clear(); 
            }
        }

        public async Task UcitajZaposlenike(int id)
        {
            if (SelectedVrstaUsluge != null)
            {
                var listaAdvokata = await _sastanciService.GetAdvokatiPreporuka<List<Korisnici>>(id);
                foreach (var z in listaAdvokata)
                {
                    AdvokatiList.Add(z);
                }
            }
        }


        public async Task Rezervisi()
        {

            if (await Validacija())
            {
                return;
            }

            else
            {
                sastanakInsert.DatumSastanka = DatumSastanka;
                sastanakInsert.MjestoOdrzavanja = MjestoOdrzavanja;
                sastanakInsert.Poruka = Poruka;
                sastanakInsert.ZaposleniciId = SelectedZaposlenik.KorisnikId;
                sastanakInsert.KlijentId = KlijentId;
                sastanakInsert.IsDeleted = false;
                sastanakInsert.Odrzan = false;
                sastanakInsert.Odobreno = false;
                sastanakInsert.VrstaId = SelectedVrstaUsluge.VrstaUslugeId;


                try
                {
                    var entity = await _sastanciService.Insert<Model.Sastanci>(sastanakInsert);
                    if (entity != null)
                    {
                        await Application.Current.MainPage.DisplayAlert("Obavijest", "Uspješno ste rezervisali sastanak. Nakon odobravanja vaše rezervacije dobit ćete obavijest putem maila.", "OK");
                        
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

        string _datumSastankaRequired = string.Empty;
        string _mjestoRequired = string.Empty;
        string _zaposlenikRequired = string.Empty;
        string _porukaRequired = string.Empty;

        bool _visibleDatumSastanka = false;
        bool _visibleMjesto = false;
        bool _visibleZaposlenik = false;
        bool _visiblePoruka = false;
        bool _VisibleAdvokatiPreporukaNaslov = false;

        

        public string ZaposlenikRequired
        {
            get { return _zaposlenikRequired; }
            set { SetProperty(ref _zaposlenikRequired, value); }
        }
        public string DatumSastankaRequired
        {
            get { return _datumSastankaRequired; }
            set { SetProperty(ref _datumSastankaRequired, value); }
        }
        public string MjestoRequired
        {
            get { return _mjestoRequired; }
            set { SetProperty(ref _mjestoRequired, value); }
        }
        public string PorukaRequired
        {
            get { return _porukaRequired; }
            set { SetProperty(ref _porukaRequired, value); }
        }

        public bool VisibleZaposlenik
        {
            get { return _visibleZaposlenik; }
            set { SetProperty(ref _visibleZaposlenik, value); }
        }
        public bool VisibleDatumSastanka
        {
            get { return _visibleDatumSastanka; }
            set { SetProperty(ref _visibleDatumSastanka, value); }
        }

        public bool VisibleMjesto
        {
            get { return _visibleMjesto; }
            set { SetProperty(ref _visibleMjesto, value); }
        }

        public bool VisiblePoruka
        {
            get { return _visiblePoruka; }
            set { SetProperty(ref _visiblePoruka, value); }
        }

        public bool VisibleAdvokatiPreporukaNaslov
        {
            get { return _VisibleAdvokatiPreporukaNaslov; }
            set { SetProperty(ref _VisibleAdvokatiPreporukaNaslov, value); }
        }



        


        private async Task<bool> Validacija()
        {

            if (SelectedZaposlenik == null)
            {
                ZaposlenikRequired = "Zaposlenik je obavezan!";
                VisibleZaposlenik = true;
                VisibleDatumSastanka = false;
                VisibleMjesto = false;
                VisiblePoruka = false;

                return true;
            }


            else if (DatumSastanka.Date == DateTime.Now.Date)
            {
                DatumSastankaRequired = "Datum sastanka  ne može biti današnji!";
                VisibleZaposlenik = false;
                VisibleDatumSastanka = true;
                VisibleMjesto = false;
                VisiblePoruka = false;
                return true;
            }
            else if (MjestoOdrzavanja == string.Empty)
            {
                MjestoRequired = "Mjesto održavanja je obavezno!";
                VisibleZaposlenik = false;
                VisibleDatumSastanka = false;
                VisibleMjesto = true;
                VisiblePoruka = false;
                return true;
            }

            else if (Poruka == string.Empty)
            {
                PorukaRequired = "Poruka  je obavezna!";
                VisibleZaposlenik = false;
                VisibleDatumSastanka = false;
                VisibleMjesto = false;
                VisiblePoruka = true;
                return true;
            }
            return false;
        }


    }
}
