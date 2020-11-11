using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CountryMobileApp.Services
{
    public interface IDataStore<T>
    {
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
