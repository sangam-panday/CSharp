using System;
namespace unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;
            int j = (int)o;
        }
    }
}