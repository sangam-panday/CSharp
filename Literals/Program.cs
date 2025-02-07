using System;
namespace Literals
{
    class Program{
        public static void Main(string[] args)
        {
            //Literals are fixed value that we assign to variables
            //For example x = 100, here 100 is a literal
            //There are different types of literals
            //Integer literals
            int x = 100;
            Console.WriteLine(x);

            //Floating point literals
            float y = 100.5f;
            Console.WriteLine(y);

            //Character literals
            char z = 'A';
            Console.WriteLine(z);

            //Different types of integer literals
            int a = 101; // Decimal
            int b = 0x123f; // Hexadecimal
            int c = 0b101001; // Binary
            Console.WriteLine($"Decimal Literal: {a}, Hexadecimal Literal: {b}, Binary Literal: {c}");

            //Suffix
            int d = 100; //Integer
            uint e = 100U; //Unsigned integer
            long f = 100L; //Long
            Console.WriteLine($"Integer: {d}, Unsigned Integer: {e}, Long: {f}");

            //Different type of floating point literals
            float g = 100.5f; //Float
            double h = 100.5d; //Double
            decimal i = 100.5m; //Decimal
            Console.WriteLine($"Float: {g}, Double: {h}, Decimal: {i}");

            //Character literals   
            char j = 'A'; //Character
            char k = '\u0058'; //Unicode
            Console.WriteLine($"Character: {j}, Unicode: {k}");

            //String literals
            //Regular string Literal
            string l = "Hello\nWorld";
            Console.WriteLine(l);
            //verbatim string Literal
            string m = @"Hello\nWorld";//It prints as it is
            Console.WriteLine(m);

            //Boolean literals
            bool b1 = true;
            bool b2 = false;
            Console.WriteLine($"Boolean 1: {b1}, Boolean 2: {b2}");
        }
    }
}