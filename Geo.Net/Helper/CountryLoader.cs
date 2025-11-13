using System.Reflection;
namespace Geo.Net.Helper
{
    public class CountryLoader
    {
        public static string LoadJson()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Geo.Net.Resources.countries.json";

            using Stream stream = assembly.GetManifestResourceStream(resourceName)
                ?? throw new FileNotFoundException("Resource not found", resourceName);
            using StreamReader reader = new(stream);
            return reader.ReadToEnd();
        }
    }
}