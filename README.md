# Geo.Net Package

**Geo.Net** is a modern, lightweight, and easy-to-use .NET library designed to provide geographical and location-based utilities for .NET applications. Whether you are building mapping applications, location services, or data-driven tools that rely on country, city, or regional information, Geo.Net simplifies your workflow with a clean, intuitive API.

---

![NuGet](https://img.shields.io/nuget/v/Geo.Net?style=for-the-badge)
![License](https://img.shields.io/badge/license-MIT-blue?style=for-the-badge)
![.NET](https://img.shields.io/badge/.NET-6%2B-blueviolet?style=for-the-badge)

---

## 🚀 Features

- ✅ Access standardized **country codes, names, and currencies**  
- ✅ **Location utilities** for geographical calculations and validations  
- ✅ Singleton-ready design for **efficient global access**  
- ✅ Lightweight, fast, and **minimal dependencies**  
- ✅ Cross-platform support: .NET 6+, .NET 7, and .NET Core  
- ✅ Embedded resources for **offline usage**  

---

## 📜 MIT License

© 2025 Kenneth Otoro

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE, AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES, OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT, OR OTHERWISE, ARISING FROM,
OUT OF, OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

---

## 💿 Installation

Install via **NuGet**:

```bash
dotnet add package Geo.Net

```csharp
using Geo.Net;

// Access singleton instance
var countries = GeoService.GetCountries();
foreach (var country in countries)
{
    Console.WriteLine($"{country.Name} - {country.Currency}");
}
