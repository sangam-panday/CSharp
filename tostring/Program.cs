using System;
namespace tostring
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = null;
            Convert.ToString(c1);
            Console.ReadLine();
        }
    }
    class Customer
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}