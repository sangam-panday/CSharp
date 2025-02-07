
//Types of variables in a class in c#
using System;
namespace Namespace1
{
    class Program{
        const float PI = 3.14f;//Constant variable
        static int x = 10;//static variable
        int y = 20;//Non-Static variable
        readonly int z = 30;//Readonly variable(Like constant but can be assigned a value at runtime)
        //Class Constructor
        public Program(int a = 0){
            x = a;//Initialising static variable
            y = a;//Initialising Non-Static variable
        }
        static void Main(string[] args){
            Program program = new Program();
            int z = 30;//Static variable as it is declareed inside a static method 
            //static variable is created when class is created so it can be accessed without creating object of class
            //same with void main method
            Console.WriteLine("Static variable: "+x+"\nNon-Static variable: "+program.y);
            Console.WriteLine("Local variable: "+z);
            Program obj1 = new Program(40);
            Console.WriteLine("Non-Static variable of obj1: "+obj1.y);
            Console.WriteLine("Static variable of obj1: "+x);   
            Console.WriteLine("Readonly for obj1: "+obj1.z);
            Program obj2 = new Program(50);
            Console.WriteLine("Static variable of obj2: "+x);
            Console.WriteLine("Non-Static variable of obj2: "+obj2.y);
            Console.WriteLine("Constant variable: "+PI);
            Console.WriteLine("Readonly for obj2: "+obj2.z);
        }
    }
}