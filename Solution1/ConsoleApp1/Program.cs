using ConsoleApp1;
using JsonConvert;

string json = "\"CountryName\":\"Turkey\",\"Continent\":\"Asia\",\"Population\":123";

Country country = new Converter<Country>().DeSerialize(json);
Console.WriteLine($"{country.CountryName} {country.Continent} {country.Population}");