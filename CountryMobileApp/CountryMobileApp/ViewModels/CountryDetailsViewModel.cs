using System;
using CountryMobileApp.Models;

namespace CountryMobileApp.ViewModels
{
    public class CountryDetailsViewModel : BaseViewModel
    {
        #region Fields
        private Country _countryDetails;
        public Country CountryDetails
        {
            get => _countryDetails;
            set => SetProperty(ref _countryDetails, value);
        }
        #endregion
        public CountryDetailsViewModel()
        {
        }
    }
}
