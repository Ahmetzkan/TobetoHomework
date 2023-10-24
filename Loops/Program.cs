using System.Runtime.CompilerServices;

//ForLoop();
//WhileLoop();

int number = 10;
do
{
    Console.WriteLine(number);
    number--;
}
while (number >= 0);

Console.ReadLine();

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