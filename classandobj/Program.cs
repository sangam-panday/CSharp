using System;
namespace ClassAndObj
{
    class Calculator{
        public int Add(int a, int b){
            return a + b;
        }
        public int Subtract(int a, int b){
            return a - b;
        }
        public int Multiply(int a, int b){
            return a * b;
        }
        public int Divide(int a, int b){
            return a/b;
        }
    }
    class Program{
        static void Main(string[] args){
            Calculator obj = new Calculator();
            int num1, num2;
            Console.Write("Enter number 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, obj.Add(num1, num2));
            Console.WriteLine("The difference of {0} and {1} is {2}", num1, num2, obj.Subtract(num1, num2));
            Console.WriteLine("The Multiply of {0} and {1} is {2}", num1, num2, obj.Multiply(num1, num2));
            Console.WriteLine("The division of {0} and {1} is {2}", num1, num2, obj.Divide(num1, num2));
        }
    }
}