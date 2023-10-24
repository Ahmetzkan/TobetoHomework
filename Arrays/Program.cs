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

