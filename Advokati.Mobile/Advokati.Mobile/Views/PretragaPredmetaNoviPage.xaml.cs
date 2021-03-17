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
    public partial class PretragaPredmetaNoviPage : ContentPage
    {
        private PretragaPredmetaNoviPageViewModel model = null;
        public int KlijentId;
        public PretragaPredmetaNoviPage(int Klijent)
        {
            InitializeComponent();
            KlijentId = Klijent;
            BindingContext = model = new PretragaPredmetaNoviPageViewModel(KlijentId);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void IzlistajPredmeteOdDo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IzlistajPredmetePage(KlijentId,model.DatumOd,model.DatumDo));
        }
    }
}