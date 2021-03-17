using Advokati.Mobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Advokati.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();
            int LoggedUserId = App.LoggedUserId;
            string LoggedUserRole = App.LoggedUserRole;
            if (LoggedUserRole == "Advokat")
            {
                menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Početna" },
                new HomeMenuItem {Id = MenuItemType.Predmeti, Title="Predmeti" },
                new HomeMenuItem {Id = MenuItemType.Rocista, Title="Ročišta" },
                new HomeMenuItem {Id = MenuItemType.RadniSati, Title="Radni sati" },
                 new HomeMenuItem {Id = MenuItemType.Sastanci, Title="Sastanci" },
                new HomeMenuItem {Id = MenuItemType.UserProfil, Title="Moj profil" },
                new HomeMenuItem {Id = MenuItemType.OdjaviSe, Title="Odjavi se" },
                new HomeMenuItem {Id = MenuItemType.PretragaPredmeta, Title="Pretraga predmeta" }

            };
            }
            else if (LoggedUserRole == "Klijent")
            {
                menuItems = new List<HomeMenuItem>
            {
               new HomeMenuItem {Id = MenuItemType.Browse, Title="Početna" },
              //new HomeMenuItem {Id = MenuItemType.About, Title="About" },
                new HomeMenuItem {Id = MenuItemType.Predmeti, Title="Predmeti" },
                new HomeMenuItem {Id = MenuItemType.Rocista, Title="Ročišta" },
                new HomeMenuItem {Id = MenuItemType.Sastanci, Title="Sastanci" },
                new HomeMenuItem {Id = MenuItemType.UserProfil, Title="Moj profil" },

                new HomeMenuItem {Id = MenuItemType.OdjaviSe, Title="Odjavi se" }

            };
            }
           

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };

           
        }
    }
}