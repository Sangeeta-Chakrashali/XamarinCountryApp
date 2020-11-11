using System;
using System.Collections.Generic;
using CountryMobileApp.Models;
using Xamarin.Forms;

namespace CountryMobileApp.Views.Common
{
    public partial class DetailsView : ContentView
    {
        public DetailsView()
        {
            InitializeComponent();
        }
        public Country Model
        {
            get => (Country)GetValue(ModelProperty);
            set => SetValue(ModelProperty, value);
        }
        public static readonly BindableProperty ModelProperty =
            BindableProperty.Create(
               propertyName: "Model",
               returnType: typeof(Country),
               declaringType: typeof(DetailsView),
               defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: AssignProperty);

        private static void AssignProperty(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (DetailsView)bindable;
            control.CapitalAndCurrency.Text = ((Country)newValue).CapitalAndCurrency;
            control.Name.Text = "Name : " +((Country)newValue).Name;
            control.Alpha2Code.Text = "Alpha2Code : " + ((Country)newValue).Alpha2Code;
            control.Alpha3Code.Text = "Alpha3Code : " + ((Country)newValue).Alpha3Code;
            control.Region.Text = "Region : " + ((Country)newValue).Region;
            control.Subregion.Text = "Subregion : " + ((Country)newValue).Subregion;
            control.Population.Text = "Population : " + ((Country)newValue).Population.ToString();
            control.Demonym.Text = "Demonym : " + ((Country)newValue).Demonym;
            control.Area.Text = "Area : " + ((Country)newValue).Area.ToString();
            control.Gini.Text = "Gini : " + ((Country)newValue).Gini.ToString();
            control.NativeName.Text = "NativeName : " + ((Country)newValue).NativeName;
            control.NumericCode.Text = "NumericCode : " + ((Country)newValue).NumericCode;
            control.TopLevelDomain.Text = "TopLevelDomain : " + String.Join(",", ((Country)newValue).TopLevelDomain);
            control.CallingCodes.Text = "CallingCodes : " + String.Join(",", ((Country)newValue).CallingCodes);
            control.AltSpellings.Text = "AltSpellings : " + String.Join(",", ((Country)newValue).AltSpellings);
            control.Latlng.Text = "Latlng : " + String.Join(",", ((Country)newValue).Latlng);
            control.Timezones.Text = "Timezones : " + String.Join(",", ((Country)newValue).Timezones);
            control.Borders.Text = "Borders : " + String.Join(",", ((Country)newValue).Borders);
            control.Borders.Text = "Borders : " + String.Join(",", ((Country)newValue).Borders);
            control.Flag.Source= ((Country)newValue).Flag;
        }

    }

}
