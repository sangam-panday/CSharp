using System;
namespace candunKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(int.MaxValue);
            const int a = 2147483647;
            const int b = 2147483647;
            // int c = a + b;
            // int c = checked(a + b);
            int c = unchecked(a + b);
            Console.WriteLine(c);
        }
    }
}