using System;
namespace stringoverriding{
    class over{
        static void Main(string[] args){
            // Console.Write("Input a number: ");
            // int num = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(num.ToString());
            Employee e = new Employee();
            e.Name = "John";
            e.Age = 30;
            Console.WriteLine(e.ToString());
        }
    }
    class Employee{
        public string Name;
        public int Age;
        public override string ToString(){
            return "Name: " + Name + " Age: " + Age;
        }
    }
}