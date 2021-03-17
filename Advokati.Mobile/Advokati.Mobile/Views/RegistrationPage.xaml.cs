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
    public partial class RegistrationPage : ContentPage
    {
        private RegisterViewModel model = null;

        public RegistrationPage()
        {
            InitializeComponent();
            BindingContext = model = new RegisterViewModel();
        }

        protected  override void OnAppearing()
        {
            base.OnAppearing();
            

        }

   

    }
}