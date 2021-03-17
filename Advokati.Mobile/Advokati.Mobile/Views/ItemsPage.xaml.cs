using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Advokati.Mobile.Models;
using Advokati.Mobile.Views;
using Advokati.Mobile.ViewModels;

namespace Advokati.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;
        private PocetnaViewModel model = null;
        int KlijentId;

        public ItemsPage(int Klijent)
        {
            InitializeComponent();
            KlijentId = Klijent;

            BindingContext = model = new PocetnaViewModel(KlijentId);
        }
        public ItemsPage()
        {
            InitializeComponent();
            KlijentId = App.LoggedUserId;

            BindingContext = model = new PocetnaViewModel(KlijentId);
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            //Pozivanje za otvaranje detalja u listi item-a
            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            //ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

           await model.Init();
            //if (viewModel.Items.Count == 0)
            //    viewModel.LoadItemsCommand.Execute(null);
        }
    }
}