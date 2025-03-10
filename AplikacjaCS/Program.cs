// See https://aka.ms/new-console-template for more information

// Typy podstawowe
// Typy proste

using System.Diagnostics;

int myInt = 0;
float myFloat = 0.1f;
double myDouble = 0.1;
char myChar = 'A';
bool myBool = false;

// Typy referencyjne
string myString = "Hello World";
List<int> myList = new List<int>();

//null
int? myNullableInt = null;
string? myNullableString = null;

//sprawdzanie null
if(myNullableInt != null) {
}
if (myNullableInt is not null) {}

Console.WriteLine(myNullableInt is not null ? myNullableInt.ToString() : "null");
Console.WriteLine(myNullableString ?? "null");

//pisanie
Console.WriteLine("Hello, World!");
Console.Write("Hello, World!");
//stringi
string str1 = "Hello";
string str2 = "World";
string str3 = str1 + " " + str2;
string str4 = $"{str1} {str2}";
string myPath = @"C:\Users\Liso1\OneDrive\Obrazy";
string powerString = """ 
        ABRAKADABRA
""";
Console.WriteLine(powerString);
//var
{
        var myvar = 1;
        var myvar2 = "myvar";
        var myvar3 = new List<int>();
}
//pętle
foreach (var item in myList)
{
        
}

for (int i = 0; i < 100; i++)
{
        
}

//while(true)
//do {} while(false)

//tablice
int[] arr = new int[2];
int?[] arr2 = new int?[2];

int[] arr3 = new int[3]{1,2,3};
int[] arr4 = {1,2,3,4};

List<int> list = new List<int>();
HashSet<int> set = new HashSet<int>();
Dictionary<int, string> dictionary = new Dictionary<int, string>();
dictionary.Add(1, "one");

//sterujące
if (true)
{
        
} else if (false)
{
        
}
else
{
        
}

int h = 1;
switch (h)
{
        case 1:
                Console.WriteLine();
                break;
        default: 
                Console.WriteLine();
                break;
                        
}

var heh = new CSApproach(1, 3);
heh.Member1 = 2;

//interface
interface IInterface
{
        void Method1();
        void Method2();
        void Method3();
}

class A : IInterface
{
        void IInterface.Method1()
        {
                
        }

        void IInterface.Method2()
        {
                
        }

        void IInterface.Method3()
        {
                
        }
}


class CSApproach(int member1, int member2)
{
        public int Member1 { get; set; } = member1;
        public int Member2 { get; set; } = member2;
}



class MyExeption(string message) : Exception
{
        
}
