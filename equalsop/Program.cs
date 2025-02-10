using System;
namespace equalop{
    class Program{
        static void Main(string[] args){
            int a = 10;
            int b = 10;
            Console.WriteLine("Number1 == Number2: {0}",a == b);
            Console.WriteLine("Number1.Equals(Number2): {0}",a.Equals(b));
            Direction direction1 = Direction.East;
            Direction direction2 = Direction.East;
            Console.WriteLine("Direction1 == Direction2: {0}",direction1 == direction2);
            Console.WriteLine("Direction1.Equals(Direction2): {0}",direction1.Equals(direction2));
            Person person1 = new Person();
            person1.age = 25;
            person1.name = "John";
            Person person2 = person1;
            Console.WriteLine("person1 == person2: {0}",person1 == person2);
            Console.WriteLine("Person1.Equals(person2): {0}",person1.Equals(person2));
            Person person3 = new Person();
            person3.age = 25;
            person3.name = "John";
            Console.WriteLine("person1 == person3: {0}",person1 == person3);
            Console.WriteLine("Person1.Equals(person3): {0}",person1.Equals(person3));
        }
    }
    public enum Direction{
        East = 1,
        West = 2,
        North = 3,
        South = 4
    }
    public class Person{
        public int age{get;set;}
        public string name{get;set;}
        public override bool Equals(object obj){
            Person p = (Person)obj;
            return (age == p.age) && (name == p.name);
        }
    }
}