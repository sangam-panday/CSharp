using System;
namespace Strings
{
    class Program
    {
        static void Main()
        {
            string s1 = "Hello";
            string s2 = "World";
            string s3 = s1 + " " + s2;
            Console.WriteLine(s3);
            string s4  = String.Concat(s1, " ", s2);
            Console.WriteLine(s4);
        }
    }
}