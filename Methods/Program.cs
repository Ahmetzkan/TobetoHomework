Add();
Add();

var result = Add2(20);
int number1 = 20;
int number2 = 100;
var result2 = Add3(ref number1,number2); //referans tip ile Add3 methodundaki number1 değeri 30 olur.

Console.WriteLine(result2);
Console.WriteLine(number1);
Console.ReadLine();


static void Add() 
{
    Console.WriteLine("Added!");
}

static int Add2(int number1,int number2=40)
{
    var result = number1 + number2;
    return result;

}

static int Add3(ref int number1, int number2)
{
    number1 = 30;
    return number1 + number2 ;

}
