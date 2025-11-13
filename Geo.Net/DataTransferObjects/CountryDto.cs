using Newtonsoft.Json;

namespace Geo.Net.DataTransferObjects
{
    public class CountryDto
    {
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("alpha-2")]
        public string Alpha2 { get; set; } = string.Empty;

        [JsonProperty("alpha-3")]
        public string Alpha3 { get; set; } = string.Empty;

        [JsonProperty("country-code")]
        public string CountryCode { get; set; } = string.Empty;

        [JsonProperty("iso_3166-2")]
        public string Iso31662 { get; set; } = string.Empty;

        [JsonProperty("region")]
        public string Region { get; set; } = string.Empty;

        [JsonProperty("sub-region")]
        public string SubRegion { get; set; } = string.Empty;

        [JsonProperty("intermediate-region")]
        public string IntermediateRegion { get; set; } = string.Empty;

        [JsonProperty("region-code")]
        public string RegionCode { get; set; } = string.Empty;

        [JsonProperty("sub-region-code")]
        public string SubRegionCode { get; set; } = string.Empty;

        [JsonProperty("intermediate-region-code")]
        public string IntermediateRegionCode { get; set; } = string.Empty;

        [JsonProperty("currency")]
        public Currency Currency { get; set; } = new Currency();
    }
    public class Currency
    {
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("code")]
        public string Code { get; set; } = string.Empty;

        [JsonProperty("symbol")]
        public string Symbol { get; set; } = string.Empty;
    }
}
