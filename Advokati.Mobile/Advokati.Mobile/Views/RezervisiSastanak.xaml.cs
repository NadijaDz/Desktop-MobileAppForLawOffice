using Advokati.Mobile.ViewModels;
using Advokati.Model;
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
    public partial class RezervisiSastanak : ContentPage
    {
        private RezervisiSastanakViewModel model = null;
        public int KlijentId;
        public RezervisiSastanak(int Klijent)
        {
            InitializeComponent();
            KlijentId = Klijent;
            BindingContext = model = new RezervisiSastanakViewModel(KlijentId);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Sastanci;
           // await model.UcitajZaposlenike(item.VrstaId);

        }
    }
}