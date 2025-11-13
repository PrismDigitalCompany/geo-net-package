using Geo.Net;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Testing dll, World!");
Console.WriteLine();

var countries = GeoNetService.GetCountries();

Console.WriteLine($"Total Countries: {countries.Count}");
Console.WriteLine();
foreach (var country in countries)
{
    Console.WriteLine($"Name: {country.Name}, Alpha-2: {country.Alpha2}, Currency: {country.Currency.Name} ({country.Currency.Code})");
}


