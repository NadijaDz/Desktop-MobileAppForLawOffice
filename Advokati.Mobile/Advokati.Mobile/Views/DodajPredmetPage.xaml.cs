using Advokati.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Advokati.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DodajPredmetPage : ContentPage
    {
        private DodajPredmetViewModel model = null;
        public int KlijentId;
        public DodajPredmetPage(int Klijent)
        {
            InitializeComponent();
            KlijentId = Klijent;
            BindingContext = model = new DodajPredmetViewModel(KlijentId);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

    }
}