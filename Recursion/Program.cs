using System;
namespace NameSpace1
{
    class Recursion
    {
        static void Main()
        {
            int number = 5;
            // display(number);
            // int result = factorial(number);
            // Console.WriteLine("Factorial of {0} is {1}", number, result);
            Console.WriteLine("Sum of {0} is {1}", number, sum(number));
        }  
        public static void display(int number)
        {
            if(number > 0)
            {
                Console.WriteLine(number);
                display(number - 1);
            }
        }
        public static int factorial(int number)
        {
            if(number == 0)
            {
                return 1;
            }
            else{
                return (number * factorial(number - 1));
            }
        }
        public static int sum(int number)
        {
            if(number == 0)
            {
                return 0;
            }
            else{
                return (number + sum(number - 1));
            }
        }
    }
}