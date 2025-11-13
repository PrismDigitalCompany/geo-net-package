using Geo.Net.DataTransferObjects;
using Geo.Net.Helper;
using Newtonsoft.Json;

namespace Geo.Net
{
    /// <summary>
    /// Provides access to geographic data, including country information.
    /// </summary>
    /// <remarks>This class follows the singleton design pattern, ensuring that only one instance of the
    /// service is created. Use the <see cref="Instance"/> property to access the singleton instance.</remarks>
    public sealed class GeoNetService
    {
        private static readonly Lazy<GeoNetService> _instance = new(() => new GeoNetService());
        private GeoNetService() { }
        public static GeoNetService Instance => _instance.Value;

        /// <summary>
        /// Retrieves a list of countries from the underlying data source.
        /// </summary>
        /// <remarks>This method deserializes country data from a JSON source into a list of <see
        /// cref="CountryDto"/> objects. The returned list will contain all available countries as defined in the data
        /// source.</remarks>
        /// <returns>A list of <see cref="CountryDto"/> objects representing the countries. The list is never null but may be
        /// empty if no data is available.</returns>
        public static List<CountryDto> GetCountries()
        {
            string json = CountryLoader.LoadJson();
            var data = JsonConvert.DeserializeObject<List<CountryDto>>(json);
            return data!;
        }

        /// <summary>
        /// Retrieves a country by its name.
        /// </summary>
        /// <param name="name">The name of the country to search for. The comparison is case-insensitive.</param>
        /// <returns>A <see cref="CountryDto"/> object representing the country with the specified name,  or <see
        /// langword="null"/> if no matching country is found.</returns>
        public static CountryDto? GetCountryByName(string name)
        {
            var countries = GetCountries();
            return countries.FirstOrDefault(c => c.Name.ToLower() == name.ToLower());
        }

        /// <summary>
        /// Retrieves a country based on its ISO country code.
        /// </summary>
        /// <param name="countryCode">The ISO 3166-1 alpha-2 country code to search for. This value is case-insensitive.</param>
        /// <returns>A <see cref="CountryDto"/> object representing the country with the specified code,  or <see
        /// langword="null"/> if no matching country is found.</returns>
        public static CountryDto? GetCountryByCode(string countryCode)
        {
            var countries = GetCountries();
            return countries.FirstOrDefault(c => c.CountryCode.ToLower() == countryCode.ToLower());
        }

        /// <summary>
        /// Retrieves the first country that matches the specified region.
        /// </summary>
        /// <remarks>This method searches through a collection of countries and returns the first match
        /// based on the region name. If multiple countries exist in the specified region, only the first one is
        /// returned.</remarks>
        /// <param name="region">The name of the region to search for. The comparison is case-insensitive.</param>
        /// <returns>A <see cref="CountryDto"/> object representing the first country in the specified region,  or <see
        /// langword="null"/> if no matching country is found.</returns>
        public static CountryDto? GetCountryByRegion(string region)
        {
            var countries = GetCountries();
            return countries.FirstOrDefault(c => c.Region.ToLower() == region.ToLower());
        }

        /// <summary>
        /// Determines whether the specified country belongs to the given region.
        /// </summary>
        /// <remarks>The comparison between the country's region and the specified region is
        /// case-insensitive.</remarks>
        /// <param name="countryName">The name of the country to check. Cannot be <see langword="null"/> or empty.</param>
        /// <param name="region">The name of the region to compare against. Cannot be <see langword="null"/> or empty.</param>
        /// <returns><see langword="true"/> if the specified country belongs to the given region; otherwise, <see
        /// langword="false"/>.</returns>
        public static bool IsCountryInRegion(string countryName, string region)
        {
            var country = GetCountryByName(countryName);
            return country != null && country.Region.ToLower() == region.ToLower();
        }

        /// <summary>
        /// Determines whether the specified country code is valid.
        /// </summary>
        /// <remarks>The comparison is case-insensitive. A valid country code is one that exists in the
        /// predefined list of country codes.</remarks>
        /// <param name="countryCode">The country code to validate. This value is compared against a predefined list of valid country codes.</param>
        /// <returns><see langword="true"/> if the specified country code is valid; otherwise, <see langword="false"/>.</returns>
        public static bool IsValidCountryCode(string countryCode)
        {
            var countries = GetCountries();
            return countries.Any(c => c.CountryCode.ToLower() == countryCode.ToLower());
        }
    }
}