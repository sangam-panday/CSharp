using System;
namespace Namespace1{
    class Program{
        static void Main(string[] args){
            int a = 10;
            int b = 20;
            int c = 30;
            int sum = Add(a, b);
            Console.WriteLine("Sum of Integers:");
            Console.WriteLine($"Sum of {a} and {b} : " + sum);
            sum = Add(a, b, c);
            Console.WriteLine($"Sum of {a}, {b} and {c} : " + sum);
            float x = 10.5f;
            float y = 20.5f;
            float fsum = Add(x, y);
            Console.WriteLine("Sum of Floats:" );
            Console.WriteLine($"Sum of {x} and {y} : " + fsum);
        }
        static int Add(int a, int b){
            return a + b;
        }
        static int Add(int a, int b, int c){
            return a + b + c;
        }
        static float Add(float a, float b){
            return a + b;
        }
    }
}