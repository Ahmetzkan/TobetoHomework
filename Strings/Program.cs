string city = "Ankara ";
//Console.WriteLine(city[0]);

foreach (var cities in city)
{
    Console.WriteLine(cities);
}

string city2 = "İstanbul";
string result = city + city2;
Console.WriteLine(result);
Console.WriteLine(String.Format("{0} {1}",city,city2));

