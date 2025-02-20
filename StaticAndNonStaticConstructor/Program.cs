using System;
namespace StaticAndNonStaticConstructor
{
    class Program
    {
        static int x;
        int y;
        static Program()
        {
            Console.WriteLine("Static Constructor Called.");
        }
        public Program(int y)
        {
            this.y = y;
            Console.WriteLine("Non static Constructor called.");
        }
        static void Main(string[] args)
        {
            Program p1 = new Program(10);
            Program p2 = new Program(20);
            Console.WriteLine(p1.y);
        }
    }
}