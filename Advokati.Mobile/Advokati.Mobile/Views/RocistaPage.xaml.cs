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
    public partial class RocistaPage : ContentPage
    {
        private RocistaViewModel model = null;
        public int KlijentId;
        public RocistaPage(int Klijent)
        {
            InitializeComponent();
            KlijentId = Klijent;
            BindingContext = model = new RocistaViewModel(KlijentId);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DodajRocistePage(KlijentId));
        }
    }
}