using System;
namespace Readonly
{
    class Program
    {   
        readonly int x;
        Program(int a)
        {
            x = a;
        }
        public void Display()
        {
            //x = 20; Creates error as it is readonly   
            Console.WriteLine("Value of x is: " + x);
        }
        
        static void Main()
        {
            Program p1 = new Program(10);
            p1.Display();
            Program p2 = new Program(20);
            p2.Display();
        }
    }
            // Create a new instance of the class
}