using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Advokati.Mobile.Services;
using Advokati.Mobile.Views;

namespace Advokati.Mobile
{
    public partial class App : Application
    {

        public static int LoggedUserId { get; set; }
        public static string LoggedUserRole { get; set; }


        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage( new LoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
