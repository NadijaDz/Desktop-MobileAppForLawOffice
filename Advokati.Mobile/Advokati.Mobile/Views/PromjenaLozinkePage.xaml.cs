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
    public partial class PromjenaLozinkePage : ContentPage
    {
        private PromjenaLozinkeViewModel model = null;
        public int KlijentId;
        public PromjenaLozinkePage(int Klijent)
        {
            InitializeComponent();
            KlijentId = Klijent;
            BindingContext = model = new PromjenaLozinkeViewModel { KlijentID=Klijent};
        }

        public PromjenaLozinkePage()
        {
            InitializeComponent();
        }
        private async void ButtonSacuvaj_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.DisplayAlert("Obavijest", "Uspješno ste izmjenili lozinku", "OK");
            await Navigation.PopAsync();
        }

        private async void Entry_Unfocused(object sender, FocusEventArgs e)
        {
            await model.OldPasswordCheck();
        }


    }
}