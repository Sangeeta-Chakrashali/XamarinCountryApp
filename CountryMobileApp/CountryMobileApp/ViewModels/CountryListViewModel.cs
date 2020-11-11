using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using CountryMobileApp.Models;
using CountryMobileApp.Views;
using CountryMobileApp.Services;

namespace CountryMobileApp.ViewModels
{
    public class CountryListViewModel : BaseViewModel
    {
        #region Fields
        public INavigation _navigation;
        public ObservableCollection<Country> Countries { get; set; }

        private Country _countryDetails;
        public Country CountryDetails
        {
            get => _countryDetails;
            set => SetProperty(ref _countryDetails, value);
        }
        #endregion

        #region Constructor
        public CountryListViewModel(INavigation navigation)
        {
            Title = "Countries";
            _navigation = navigation;
            Countries = new ObservableCollection<Country>();
            _ = LoadCountriesCommand();
        }
        #endregion

        #region Public Functions
        public async Task LoadCountriesCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Countries.Clear();
                CountryServices countryServices = new CountryServices();
                var countries = await countryServices.GetCountryListAsync();
                foreach (var country in countries)
                {
                    Countries.Add(country);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void CountrySelected(Country country)
        {
            if (Device.Idiom == TargetIdiom.Tablet)
            {
                CountryDetails = country;
            }
            else
            {
                _navigation.PushAsync(new CountryDetailsView { Country = country });
            }
        }
        #endregion
    }
}