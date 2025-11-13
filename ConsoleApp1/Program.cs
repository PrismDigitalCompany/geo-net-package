using Geo.Net;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var countries = GeoNetService.GetCountries();
Console.WriteLine($"Total countries loaded: {countries.Count}");
var usa = GeoNetService.GetCountryByRegion("asia");
Console.WriteLine(usa);
var regionCountry = GeoNetService.GetCountryByName("nigeria");
Console.WriteLine(regionCountry);
Console.WriteLine();

//         /// found for the given region. If no country matches the specified region, the method


