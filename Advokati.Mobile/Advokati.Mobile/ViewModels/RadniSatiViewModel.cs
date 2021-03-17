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
   public class RadniSatiViewModel:BaseViewModel
    {
        private readonly APIService _radniSatiService = new APIService("RadniSati");

        public int KlijentId;

        public RadniSatiViewModel(int Klijent)
        {
            KlijentId = Klijent;
            InitCommand = new Command(async () => await Init());
          
        }
        public RadniSatiViewModel()
        {

            InitCommand = new Command(async () => await Init());
        }


   
        public ObservableCollection<RadniSati> RadniSatiList { get; set; } = new ObservableCollection<RadniSati>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var listRadnihSati = await _radniSatiService.Get<List<RadniSati>>(null);
      

            RadniSatiList.Clear();

                foreach (var r in listRadnihSati)
                {
                    if (r.ZaposleniciId == KlijentId)
                    {

                          RadniSatiList.Add(r);
                    }
                }
        }
    }
}
