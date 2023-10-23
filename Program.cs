
Console.WriteLine("Hello World");
Console.ReadKey();

//-----------------Value Types-------------

//int
int number1 = 10;
Console.WriteLine("Number1 is {0}",number1);
Console.ReadLine();

//long
long number2 = 915555555555555555;
Console.WriteLine("number2 is {0}", number2);
Console.ReadLine();

//short
short number3 = 32767;
Console.WriteLine("number3 is {0}", number3);
Console.ReadLine();

//byte
byte number4 = 255;
Console.WriteLine("number4 is {0}", number4);
Console.ReadLine();

//bool
bool condition = true; 
Console.ReadLine();

//char
char character = 'A';
Console.WriteLine("character is {0}", character);
Console.ReadLine();

//double
double number5 = 255.15;
Console.WriteLine("number5 is {0}", number5);
Console.ReadLine();

//decimal
decimal number6 = 255.1m;
Console.WriteLine("number6 is {0}", number6);
Console.ReadLine();

//enums
enum Days
{
    Monday,Tuesday, Wednesday, Thursday, Friday,Saturday
}
Console.WriteLine(Days.Friday);

//var
var number7 = 10;
number7 = 'A';
Console.WriteLine("number7 is {0}", number7);
Console.ReadLine();

//-----------------Conditionals-------------

//If
var number8 = 10;
if (number8==50)
{
    Console.WriteLine("number8 is not {0}", number8);

}
else
{
    Console.WriteLine("number8 is {0}", number8);
}
Console.ReadLine();

//Line If
Console.WriteLine(number8 ==10?"Number is 10":"Number is not 10");


// Else IF
number8 = 10;
if (number8 == 50)
{
    Console.WriteLine("number8 is not {0}", number8);

}
else if (number8 == 90)
{
    Console.WriteLine("number8 is {0}", number8);
}
else
{
    Console.WriteLine("number8 is {0}", number8);
}
Console.ReadLine();

//Switch Case
var number9 = 20;
switch (number9)
{
    case 50:
        Console.WriteLine("Is Not {0}",number9);
        break;
    case 20:
        Console.WriteLine("Is  {0}", number9);
        break;
    default:
        break;
}