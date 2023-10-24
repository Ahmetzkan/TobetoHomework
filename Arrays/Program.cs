string[] students = new string[3];
students[0] = "Engin";
students[1] = "Ahmet";
students[2] = "Derin";

string[] students2 = { "Engin", "Ahmet", "Derin" };
students[0] = "Engin";
students[1] = "Ahmet";
students[2] = "Derin";

foreach (var student in students2)
{
    Console.WriteLine(student);
}

string[,] regions = new string[5, 3]
{
    { "İstanbul","İzmit","Balıkesir" },
    { "Ankara","Konya","Kırıkkale" },
    { "Antalya","Adana","Mersin" },
    { "Rize","Trabzon","Samsun" },
    { "İzmir","Muğla","Manisa" },
};

for (int i = 0; i <= regions.GetUpperBound(0); i++) //GetUpperBound: Bir dizinin son indeks numarasını verir.
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("*********");
}
