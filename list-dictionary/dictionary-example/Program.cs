
var cities = new Dictionary<string, string>(){
    {"TR", "Istanbul, Ankara, Izmir"},
    {"UK", "London, Manchester, Birmingham"},
    {"USA", "Chicago, New York, Washington"},
    {"India", "Mumbai, New Delhi, Pune"}
};

System.Console.WriteLine($"*****Cities*****");
foreach (KeyValuePair<string, string> city in cities)
{
    System.Console.WriteLine($"Company: {city.Key}, Cities: {city.Value}");
}

System.Console.WriteLine($"\n*****Contains*****");

if (cities.ContainsKey("TR"))
    System.Console.WriteLine($"TR Cities: {cities["TR"]}");

System.Console.WriteLine($"\n*****TryGetValue*****");
string result;
if (cities.TryGetValue("USA", out result))
    System.Console.WriteLine(result);

System.Console.WriteLine($"\n*****Update*****");
string country = "TR";
cities[country] = "Istanbul, Ankara, Izmir, Antalya, Canakkale";
System.Console.WriteLine($"Updated City: {cities[country]}");

System.Console.WriteLine($"\n*****Remove*****");
cities.Remove(country);

foreach (KeyValuePair<string, string> city in cities)
{
    System.Console.WriteLine($"Company: {city.Key}, Cities: {city.Value}");
}
