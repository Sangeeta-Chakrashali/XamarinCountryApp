using System;
using System.Collections.Generic;
using CountryMobileApp.Models;
using Xamarin.Forms;

namespace CountryMobileApp.Views
{
    public partial class CountryDetailsView : ContentPage
    {
        public Country Country;
        public CountryDetailsView()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Title = Country.Name;
            CountryDetails.Model = Country;
        }
    }
}
