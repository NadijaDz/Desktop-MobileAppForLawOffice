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
   public class PocetnaViewModel:BaseViewModel
    { 
  private readonly APIService _predmetiService = new APIService("Predmeti");
    private readonly APIService _rocistaService = new APIService("Rocista");
    private readonly APIService _sastanciService = new APIService("Sastanci");

    public int KlijentId;

    public PocetnaViewModel(int Klijent)
    {
        
            KlijentId = Klijent;
        InitCommand = new Command(async () => await Init());
    }
    public PocetnaViewModel()
    {
            Title = "Law Team";
            InitCommand = new Command(async () => await Init());
    }

    //public ObservableCollection<Zaposlenici> ZaposleniciList { get; set; } = new ObservableCollection<Zaposlenici>();

    public ICommand InitCommand { get; set; }


    int _brojPredmeta;
    public int BrojPredmeta
    {
        get { return _brojPredmeta; }
        set { SetProperty(ref _brojPredmeta, value); }
    }

        int _brojRocista;
        public int BrojRocista
        {
            get { return _brojRocista; }
            set { SetProperty(ref _brojRocista, value); }
        }

        int _brojSastanaka;
        public int BrojSastanaka
        {
            get { return _brojSastanaka; }
            set { SetProperty(ref _brojSastanaka, value); }
        }



        public async Task Init()
    {
            BrojSastanaka = 0;
            BrojPredmeta = 0;

            BrojRocista = 0;


            var listaPredmeta = await _predmetiService.Get<List<Predmeti>>(null);

            foreach (var p in listaPredmeta)
            {
                if (App.LoggedUserRole == "Klijent")
                {
                    if (p.KlijentId == KlijentId)
                    {
                        BrojPredmeta++;
                    }
                }


                else if (App.LoggedUserRole == "Advokat")
                {

                    if (p.ZaposleniciId == KlijentId)
                    {
                        BrojPredmeta++;
                    }
                }
            }
                
            

          

            var listaRocista = await _rocistaService.Get<List<Rocista>>(null);

            if (App.LoggedUserRole == "Klijent")
            {
                foreach (var predmeti in listaPredmeta)
                {
                    if (predmeti.KlijentId == KlijentId)
                    {
                        foreach (var rocista in listaRocista)
                        {
                            if (predmeti.BrojPredmeta == rocista.BrojPredmeta)
                            {
                                BrojRocista++;
                            }
                        }
                    }
                }
            }

            else if (App.LoggedUserRole == "Advokat")
            {
                foreach (var rocista in listaRocista)
                {
                    if (rocista.ZaposlenikId == KlijentId)
                    {
                        BrojRocista++;
                    }
                }
            }

            var listaSastanaka = await _sastanciService.Get<List<Sastanci>>(null);

            foreach (var s in listaSastanaka)
            {
                if (App.LoggedUserRole == "Klijent")
                {
                    if (s.KlijentId == KlijentId)
                    {
                        BrojSastanaka++;
                    }
                }


                else if (App.LoggedUserRole == "Advokat")
                {

                    if (s.ZaposleniciId == KlijentId)
                    {
                        BrojSastanaka++;
                    }
                }
            }




        }
        

    }
}
