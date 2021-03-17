﻿using Advokati.Mobile.ViewModels;
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
    public partial class UrediProfilPage : ContentPage
    {
        private UrediProfilViewModel model = null;
        int KlijentId;
        public UrediProfilPage(int Klijent)
        {
            InitializeComponent();
            KlijentId = Klijent;
            BindingContext = model = new UrediProfilViewModel(KlijentId);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();

        }

     
    }
}