using System.Collections.Generic;
using SophartBlazorFundamental.Shared;

namespace SophartBlazorFundamental.Api.Models
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int countryId);
    }
}
