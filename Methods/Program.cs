Add();
Add();

var result = Add2(20);
int number0;
int number1 = 20;
int number2 = 100;
var result2 = Add3(ref number1,number2); //referans tip ile Add3 methodundaki number1 değeri 30 olur.
var result3 = Add4(out number1,number2); //out tip ile Add3 methodundaki number1 değeri 30 olur.Farkı number 0,number1 gibi atama zorunluluğu yoktur.

Console.WriteLine(result3);
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

static int Add4(out int number1, int number2)
{
    number1 = 30;
    return number1 + number2;

}

