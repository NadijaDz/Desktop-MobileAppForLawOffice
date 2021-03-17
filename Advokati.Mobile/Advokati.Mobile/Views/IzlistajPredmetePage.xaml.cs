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
    public partial class IzlistajPredmetePage : ContentPage
    {
        private IzlistajPredmeteViewModel model = null;
        public int KlijentId;
        public DateTime DatumOd;
        public DateTime DatumDo;
        public IzlistajPredmetePage(int Klijent, DateTime datumOd, DateTime datumDo)
        {
            InitializeComponent();
            KlijentId = Klijent;
            DatumOd = datumOd;
            DatumDo = datumDo;
            BindingContext = model = new IzlistajPredmeteViewModel(KlijentId,DatumOd,DatumDo);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

       
    }
}