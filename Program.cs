
using System.Runtime.CompilerServices;
using Tobeto;

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
Console.WriteLine(Days.Friday);
enum Days
{
    Monday=10,Tuesday, Wednesday, Thursday, Friday,Saturday
}


//var

var numberrr = 10;
var number19 = 10;

Console.WriteLine("number7 is {0}", number19);
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
int number15 = 100;
int number25 = 200;

var result10 = Add4(ref number15, number25);
static int Add4(ref int number15, int number25 = 20)
{
    number15 = 30;
    Console.WriteLine(number15 + number25);
    Console.ReadLine();
    return number15 + number25;
}


//Out Keyword
int number16 = 100;
int number26 = 200;

var result55 = Add5(out number16, number26);
static int Add5(out int number16, int number26 = 20)
{
    number16 = 30;
    var result = number16 + number26;
    Console.WriteLine(result);
    Console.ReadLine();
    return result;
}


//Method Overloading
class Overloading
{
    static int Multiply(int number111, int number222)
    {
        return number111 * number222;
    }
    static int Multiply(int number111, int number222, int number3)
    {
        return number111 * number222 * number3;
    }
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
            break;
            
        }
    }
    Console.WriteLine(result);
    return result;
}
IsPrimeNumber(17);

//---------------------------------------Reference Types-------------------------------

//Strings
string city = "İstanbul";
string city2 = "İzmir";
var result2 = city + city2;
Console.WriteLine(result2);
foreach (var item in city)
{
    Console.WriteLine(item); ;
    
}
Console.ReadLine();

//String Methods
string sentence = "My name is Metin";
Console.WriteLine(sentence.Length);

var sentence2 = sentence.Clone();
Console.WriteLine(sentence.EndsWith('n'));
Console.WriteLine(sentence.StartsWith("My name"));
Console.WriteLine(sentence.IndexOf("name"));
Console.WriteLine(sentence.LastIndexOf("name"));
Console.WriteLine(sentence.Insert(0,"hello, "));
Console.WriteLine(sentence.Substring(3));
Console.WriteLine(sentence.Substring(3,5));
Console.WriteLine(sentence.ToUpper());
Console.WriteLine(sentence.ToLower());
Console.WriteLine(sentence.Replace(" ","-"));
Console.WriteLine(sentence.Remove(2,4));
Console.ReadLine();


//---------------------------------------Classes-------------------------------

class CustomerManager
{
    public void Add()
    {
        Console.WriteLine("Customer Added");
    }
    public void Update()
    {
        Console.WriteLine("Customer Updated");
    }

}
CustomerManager manager = new CustomerManager();
manager.Update();
Console.ReadLine();

//Props
class CustomerManager2
{
    public int CustomerId { get; set; }
    public void Add()
    {
        Console.WriteLine("Customer Added");
    }
    public void Update()
    {
        Console.WriteLine("Customer Updated");
    }

}
CustomerManager2 manager2 = new CustomerManager2();
manager2.CustomerId = 35;
CustomerManager2 manager3 = new CustomerManager2()
{
    CustomerId = 5
};
manager2.Update();
Console.ReadLine();

//Encapsulation

class Customer:IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Region { get { return "City "+  Region; } set { Region=value; } }

    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    int IPerson.FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    int IPerson.LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}


//---------------------------------------Interfaces-------------------------------
interface IPerson
{
     int Id { get; set; }
    int FirstName { get; set; }
    int LastName { get; set; }

}
class Product : IPerson
{
    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
class Product2 : IPerson
{
    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
class PersonManager 
{
  public void Add(Product product)
    {
        Console.WriteLine(product.FirstName);
    }
}
PersonManager manager5 = new PersonManager();
manager5.Add(new Product() { Id = 5, FirstName = 4 });

IPerson myPerson = new Customer();

CustomerManager5 customer2 = new CustomerManager5();
customer2.Add(new SqlServerCustomerDal());

//Polymorphizm
ICustomerDal[] customerDals = new ICustomerDal[3]
{
    new SqlServerCustomerDal(),
    new OracleServerCustomerDal(),
    new MySqlServerCustomerDal()
};

//-------------------------------------implementation--------------

//Interfaces Demo
interface IWorker
{
    void Work();
    
    
}
interface IEat
{
    void Eat();
}
interface ISalary
{
    void GetSalary();
}
class Manager : IWorker, IEat, ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}
class Worker : IWorker, IEat, ISalary
{
    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void GetSalary()
    {
        throw new NotImplementedException();
    }

    public void Work()
    {
        throw new NotImplementedException();
    }
}
class Robot : IWorker
{
    public void Work()
    {
        throw new NotImplementedException();
    }
}
IWorker[] workers = new IWorker[3]
{
    new Worker(),
    new Robot(),
    new Manager()
};

// -------------------------------INHERİTANCE------------------------

class Person 
    {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
class Customer7: Person
{
    public string City { get; set; }
}
class Student : Person
{
    public string Class { get; set; }
}
Person[] persons = new Person[3]
{
    new Person{FirstName="Mahmut" },new Customer7{FirstName="Metin" },new Student{FirstName="Koyuncu" }
};

//-------------------------------------Dama Demo---------------------------------

