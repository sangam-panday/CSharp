using System;
namespace Namespace
{
    class Program
    {
        //Runs before Main method
        //Runs once per program
        static Program()
        {
            Console.WriteLine("Static Constructor");
        }
        //Runs when object is created
        //Runs once per object
        public Program()
        {
            Console.WriteLine("Instance Constructor");
        }
        int x = 10;
        static int y = 20;
        public void Method()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        public int add(){
            return x+y;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Method();
            Console.WriteLine(p.add());
        }
    }
}