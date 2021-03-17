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

    public partial class PredmetiPage : ContentPage
    {
        private PredmetiViewModel model = null;
        public int KlijentId;
        public PredmetiPage(int Klijent)
        {
            InitializeComponent();
            KlijentId = Klijent;
            BindingContext = model = new PredmetiViewModel(KlijentId);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
           await model.Init();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DodajPredmetPage(KlijentId));
        }
    }
}