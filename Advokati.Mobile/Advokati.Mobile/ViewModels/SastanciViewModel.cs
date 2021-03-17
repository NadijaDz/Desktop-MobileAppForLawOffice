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
    public class SastanciViewModel:BaseViewModel
    {

        private readonly APIService _sastanciService = new APIService("Sastanci");
        public int KlijentId;
        public SastanciViewModel(int Klijent)
        {
            KlijentId = Klijent;
            InitCommand = new Command(async () => await Init());
            var k = App.LoggedUserRole;
            if(k == "Klijent")
            {
                _buttonVisible = true;
            }
            else
            {
                _buttonVisible = false;

            }
        }
        public SastanciViewModel()
        {

            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Sastanci> SastanciList { get; set; } = new ObservableCollection<Sastanci>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var list = await _sastanciService.Get<List<Sastanci>>(null);
            SastanciList.Clear();
            foreach (var sastanci in list)
            {
                if (sastanci.KlijentId == KlijentId)
                {
                    SastanciList.Add(sastanci);
                }
                if (sastanci.ZaposleniciId == KlijentId)
                {
                    SastanciList.Add(sastanci);
                }
            }
        }

        bool _buttonVisible = false;

        public bool ButtonVisible
        {
            get { return _buttonVisible; }
            set { SetProperty(ref _buttonVisible, value); }
        }

    }
}
