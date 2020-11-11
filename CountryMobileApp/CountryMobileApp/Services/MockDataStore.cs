using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CountryMobileApp.Models;

namespace CountryMobileApp.Services
{
    public class MockDataStore : IDataStore<Country>
    {
        readonly List<Country> countries;

        

        public async Task<IEnumerable<Country>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(countries);
        }
    }
}