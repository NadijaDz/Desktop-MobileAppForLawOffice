using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Advokati.Mobile.Models;

namespace Advokati.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public int KlijentId;
        public MainPage(int Klijent)
        {
            InitializeComponent();
            KlijentId = Klijent;


            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.UserProfil:
                        MenuPages.Add(id, new NavigationPage(new UserProfilPage(KlijentId)));
                        break;
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage(KlijentId)));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.Predmeti:
                        MenuPages.Add(id, new NavigationPage(new PredmetiPage(KlijentId)));
                        break;
                    case (int)MenuItemType.Rocista:
                        MenuPages.Add(id, new NavigationPage(new RocistaPage(KlijentId)));
                        break;
                    case (int)MenuItemType.Sastanci:
                        MenuPages.Add(id, new NavigationPage(new SastanciPage(KlijentId)));
                        break;
                    case (int)MenuItemType.RadniSati:
                        MenuPages.Add(id, new NavigationPage(new RadniSatiPage(KlijentId)));
                        break;
                    case (int)MenuItemType.OdjaviSe:
                        MenuPages.Add(id, new NavigationPage(new LoginPage()));
                        break;

                    case (int)MenuItemType.PretragaPredmeta:
                        MenuPages.Add(id, new NavigationPage(new PretragaPredmetaNoviPage(KlijentId)));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}