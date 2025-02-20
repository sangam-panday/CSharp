using System;
namespace ConstructorOnInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent.Child ch = new Parent.Child();
            Console.WriteLine("Square of 5 is {0}",Squar.GetSquare(5));
        }
    }
    public /*sealed*/ class Parent
    {
        private Parent(){
            Console.WriteLine("Private Parent constructor. ");
        }
        public Parent(string message){
            Console.WriteLine("Hello {0}",message);
        }
        public class Child : Parent
        {
            public Child(){
                Console.WriteLine("Public Child Constructor");
            }
        }
    }
    public static class Squar
    {
        public static double PI = 3.14;
        public static int GetSquare(int x){
            return x * x;
        }
    }
    // public class Child: Parent
    // {
    //     public Child() : base("Sangam")
    //     {
    //         Console.WriteLine("Public Child Class");
    //     }
    // }
}