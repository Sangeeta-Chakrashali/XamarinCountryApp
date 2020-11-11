using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CountryMobileApp.Models;
using Newtonsoft.Json;

namespace CountryMobileApp.Services
{
    public class CountryServices
    {
        private string baseURL = "https://restcountries.eu/rest/v2/";
        public async Task<IList<Country>> GetCountryListAsync()
        {
            try
            {
                List<Country> countries = new List<Country>();
                using (var httpClient = new HttpClient())
                {
                    HttpResponseMessage authResponse =
                        await httpClient.GetAsync(baseURL + "all");
                    if (authResponse.IsSuccessStatusCode)
                    {
                        var data = await authResponse.Content.ReadAsStringAsync();
                        countries = JsonConvert.DeserializeObject<List<Country>>(data);
                    }
                }
                return countries;
            }
            catch (Exception e)
            {
                return null;
            }

        }
    }
}
