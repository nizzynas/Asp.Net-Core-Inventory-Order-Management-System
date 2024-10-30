using Indotalent.Applications.Companies;
using Indotalent.Infrastructures.Countries;
using Indotalent.Infrastructures.Currencies;
using Indotalent.Infrastructures.TimeZones;
using Indotalent.Models.Entities;

namespace Indotalent.Data.System
{
    public static class DefaultCompany
    {
        public static async Task GenerateAsync(
            CompanyService? companyService,
            ICurrencyService? currencyService,
            ITimeZoneService? timezoneService,
            ICountryService? countryService,
            ApplicationUser? creator
            )
        {
            if (companyService != null)
            {

                var defaultCompany = new Company
                {
                    Name = "John Abbott College",
                    Currency = currencyService?.GetCurrencies().FirstOrDefault(x => x.Value.Equals("US$"))?.Value ?? "US$",
                    TimeZone = timezoneService?.GetAllTimeZones().FirstOrDefault(x => x.Value.Equals("SE Asia Standard Time"))?.Value ?? "SE Asia Standard Time",
                    Street = "21 275 Rue Lakeshore Road",
                    City = "Sainte-Anne-de-Bellevue",
                    State = "Quebec (QC)",
                    ZipCode = "H9X 3L9",
                    Country = countryService?.GetCountries().FirstOrDefault(x => x.Value.Equals("United States"))?.Value ?? "United States",
                    CreatedByUserId = creator?.Id

                };

                await companyService.AddAsync(defaultCompany);

            }
        }
    }
}
