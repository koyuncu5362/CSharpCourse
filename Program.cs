
using System.Runtime.CompilerServices;

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

//Multiple If
number9 = 2;
if (number9>=0 && number9<=100)
{
    Console.WriteLine("Number is between 0-100");
    Console.ReadLine();
}else if (number9>200 || number9<0)
{
    Console.WriteLine("number is less than  0 or greater than 200");
    Console.ReadLine();
}

//Integrate If
if (number9 >= 0 && number9 <= 100)
{
    if (number9 == 0 && number9 == 100)
    {
        Console.WriteLine("Number is equal 0-100");
        Console.ReadLine();
    }
}

//-----------------Methods-------------

static void Add()
{
    Console.WriteLine("Added");
}
Add();
Console.ReadLine();

//Parameters
static void Add2(int number1,int number2)
{
    var result = number1 + number2;
    Console.WriteLine(result);
    Console.ReadLine();
}
Add2(20,30);

//Default Parameter
static void Add3(int number1, int number2=20)
{
    var result = number1 + number2;
    Console.WriteLine(result);
    Console.ReadLine();
}
Add3(20, 30);

//Ref Keyword
static void Add4(ref int number1, int number2 = 20)
{
    number1 = 30;
    var result = number1 + number2;
    Console.WriteLine(result);
    Console.ReadLine();
}
var result = Add4(ref number1, 30);

//Out Keyword
static int void Add5(out int number1, int number2 = 20)
{
    number1 = 30;
    var result = number1 + number2;
    Console.WriteLine(result);
    Console.ReadLine();
    return result;
}
var result = Add5(out number1, 20);

//Method Overloading
static int Multiply(int number1, int number2)
{
    return number1 * number2;
}
static int Multiply(int number1, int number2,int number3)
{
    return number1 * number2*number3;
}

//Params Keyword
static int Add6(params int[] numbers)
{
    return numbers.Sum();
}
Console.WriteLine(Add6(35,37,72));
Console.ReadKey();


//----------------------------Arrays------------------------
string[] students = new string[3] {"Metin","Koyuncu","KK"};
students[0] = "Metin";
students[2] = "koyuncu";
string[] students2 = { "Metin", "Koyuncu", "KK" };
Console.WriteLine(students);
Console.WriteLine(students2);

//multidimensional arrays
string[,] regions = new string[2, 1]
{{
"İstanbul"
},{"Rize"}
};
for (int i = 0; i < regions.GetUpperBound(0); i++)
{
    for (global::System.Int32 j = 0; j <= regions.GetLowerBound(0); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
}

//----------------------------Loops------------------------


//For
for (int i = 0; i < 100; i++)
{
    Console.WriteLine(i);
}
Console.ReadLine();

//While

int number20 = 100;
while (number20>=0)
{
    number20--;
    Console.WriteLine(number20);
}

//Do While

 number20 = 100;
do
{
    Console.WriteLine(number20);
    number20--;
} while (number20>=0);

//ForEach
string[] students3 = new string[3] { "Metin", "Koyuncu", "KK" };
foreach (var student in students)
{
    Console.WriteLine(student);
}

//---------------------------------------Prime Number-------------------------------
 static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (global::System.Int32 i = 2; i < number-1; i++)
    {
        if (number%i==0)
        {
            result = false;
            break
            
        }
    }
    Console.WriteLine(result);
    return result;
}
IsPrimeNumber(17);