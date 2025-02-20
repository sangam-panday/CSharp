using System;
namespace Constructor
{
    class Rectangle
    {
        public Rectangle(){
            Console.WriteLine("Constructor is Created.");
        }
    }
    public class Sangam{
        static Sangam(){
            Console.WriteLine("Static Constructor is called");
        }
    }
    class Program{
        // static int i;
        // static int j;
        // static Program(){
        //     i = 100;
        //     j = 100;
        //     Console.WriteLine("The value of i is {0} and j is {1}",i, j);
        //     Console.WriteLine("Static Constructor is Called. ");
        // }
        // private Program(){
        //     Console.WriteLine("Constructor. ");
        // }
        public int x;
        Program(int x){
            this.x = x;
        }
        static void Main(string[] args)
        {
            // Rectangle r1 = new Rectangle();
            // i = 100;
            // j = 200;
            // Console.WriteLine("The value of i is {0} and j is {1}",i,j);
            // Console.WriteLine("Inside main function ");
            Program p1 = new Program(1);
            Program p2 = new Program(2);
            Console.WriteLine("Value of first constructor is {0} and second is {1}", p1.x, p2.x);
        }
    }
}