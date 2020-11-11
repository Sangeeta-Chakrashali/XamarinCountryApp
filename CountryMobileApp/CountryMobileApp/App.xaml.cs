using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CountryMobileApp.Services;
using CountryMobileApp.Views;

namespace CountryMobileApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new CountryListView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
