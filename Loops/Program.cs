using System.Runtime.CompilerServices;

//ForLoop();
//WhileLoop();
//DoWhileLoop()
//ForEach();

if (isPrimeNumber(6))
{
    Console.WriteLine("This is a prime number");
}
else
{
    Console.WriteLine( "This isn't a prime number" );
}

Console.ReadLine();

 static bool isPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number - 1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            i = number;
        }
    }
    return result;
}

static void ForLoop()
{
    for (int i = 1; i <= 100; i += 2)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished!");
}

static void WhileLoop()
{
    int number = 100;
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;
    }
    Console.WriteLine("Now number {0}", number);
}

static void DoWhileLoop()
{
    int number = 10;
    do
    {
        Console.WriteLine(number);
        number--;
    }
    while (number >= 0);
}

static void ForEach()
{
    string[] students = new string[3] { "Engin", "Ahmet", "Derin" };

    foreach (var student in students)
    {
        Console.WriteLine(student);
    }
}

