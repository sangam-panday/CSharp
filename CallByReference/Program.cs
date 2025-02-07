using System;
namespace Namespace1
{
    class Employee
    {
        public string Name = "";
        public int Age;
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "John";
            emp.Age = 30;
            Console.WriteLine("Before calling the method: Name = {0}, Age = {1}", emp.Name, emp.Age);
            Change(emp);
            Console.WriteLine("After calling the method: Name = {0}, Age = {1}", emp.Name, emp.Age);
            UpdateName(/*ref*/ emp);
            Console.WriteLine($"Emp1 Name = {emp.Name}");
        }
        public static void Change(/*ref*/ Employee emp)
        {
            emp.Name = "Mark";
            emp.Age = 35;
            Console.WriteLine("Inside the method: Name = {0}, Age = {1}", emp.Name, emp.Age);
        }
        public static void UpdateName(Employee Emp2)
        {
            Emp2 = null;
        }
    }
}