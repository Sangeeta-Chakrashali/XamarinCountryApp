using System;
using System.Collections.Generic;
using CountryMobileApp.Models;
using CountryMobileApp.ViewModels;
using Xamarin.Forms;

namespace CountryMobileApp.Views
{
    public partial class CountryListView : ContentPage
    {
        CountryListViewModel _viewModel;
        public CountryListView()
        {
            InitializeComponent();
            _viewModel = new CountryListViewModel(Navigation);
            BindingContext = _viewModel;
        }

        void CountryListView_ItemSelected(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var country = e.Item as Country;
            _viewModel.CountrySelected(country);
        }
    }
}
