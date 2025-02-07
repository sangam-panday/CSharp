using System;
namespace NameSpace1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello ");//Write does not add a new line
            Console.WriteLine("World");//WriteLine adds a new line

            //Different ways to print a string
            string name = "Sangam";
            Console.WriteLine(name);
            Console.WriteLine("Hello " + name);
            Console.WriteLine($"Hello {name}");
            // Console.ReadKey(); is used to hold the console window until a key is pressed

            //Reading value from the user
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");

            //Reading integer value from the user
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hi {name}, You are {age} years old");

            //Adding two numbers
            Console.WriteLine("Enter first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = number1 + number2;
            Console.WriteLine($"Sum of {number1} and {number2} is {sum}");

            //What does read method do in CSharp
            Console.WriteLine("Enter a number: ");
            int number = Console.Read();
            Console.WriteLine($"You ASCII value of the number entered: {number}");
            //Read Method returns the ASCII value of the first character entered by the user
        }
    }
}