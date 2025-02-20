using System;
namespace PrivateConstructor
{
   class Program
   {
        private Program(int x){
            Console.WriteLine("Private Constructor of Program");
        }
        public Program(){
            Console.WriteLine("Public Constructor of program");
        }
        public static void Main(string[] args)
        {
            Program p1 = new Program();
            Test t1 = new Test(10);
            Test t2 = new Test();
        }
   }
   class Test
   {
        private Test(float x){
            Console.WriteLine("Private constructor of test");
        }
        public Test(){
            Console.WriteLine("Public Constructor.");
        }
        public Test(int x){
            Console.WriteLine("Parameterized Constructor.");
        }
   }
}