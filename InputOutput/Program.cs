using System;
namespace Namespace
{
    class InputOutput
    {
        static void Main()
        {
            int num1 = 10, num2 = 20, sum;
            sum = num1 + num2;
            Console.WriteLine("Sum of {0} and {1} is {2}", num1, num2, sum);
            // Console.WriteLine("Enter a string:");
            // int str = Console.Read();
            // Console.WriteLine("ASCII value: {0}", str); 
            Console.Write("Enter your name:");
            string name = Console.ReadLine();
            Console.Write("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your height:");
            float height = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter your weight:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Name: {0}, Age: {1}, Height: {2}, Weight: {3}", name, age, height, weight);
        }
    }
}