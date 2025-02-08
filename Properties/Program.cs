using System;
namespace Namespace
{
    // class Rect{
    //     private int length;
    //     private int width;
    //     public Rect(int l, int w){
    //         length = l;
    //         width = w;
    //     }
    //     public int Area(){
    //         return length * width;
    //     }
    //     public int getLength(){
    //         return length;
    //     }
    //     public int getWidth(){
    //         return width;
    //     }
    // }
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Rect r = new Rect(10, 20);
    //         Console.WriteLine("Area of rectangle whose length is {0},  width is {1} is: {2} ", r.getLength(), r.getWidth(), r.Area());
    //     }
    // }

 //----------------------------------------------------------------------------------------------------------------------------   
    // class Rect{
    //     private int _length;
    //     private int _width;
    //     public int length{
    //         set{
    //             _length = value;
    //         }
    //         get{
    //             return _length;
    //         }
    //     }
    //     public int width{
    //         set{
    //             _width = value;
    //         }
    //         get{
    //             return _width;
    //         }
    //     }
    // }
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Rect r = new Rect();
    //         r.length = 10;
    //         r.width = 20;
    //         Console.WriteLine("Area of rectangle whose length is {0},  width is {1} is: {2} ", r.length, r.width, r.length * r.width);
    //     }
    // }
//----------------------------------------------------------------------------------------------------------------------------
    // class calculator{
    //     private int _num1;
    //     private int _num2;
    //     public int Setnumber1{
    //         set{
    //             _num1 = value;
    //         }
    //         private get {
    //             return _num1;
    //         }
    //     }
    //     public int Setnumber2{
    //         set{
    //             _num2 = value;
    //         }
    //         private get{
    //             return _num2;
    //         }
    //     }
    //     public int Add(){
    //         return _num1 + _num2;
    //     }
    //     public int Sub(){
    //         return _num1 - _num2;
    //     }
    // }
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         calculator c = new calculator();
    //         c.Setnumber1 = 10;
    //         c.Setnumber2 = 20;
    //         Console.WriteLine("Addition of two numbers is: {0}", c.Add());
    //         Console.WriteLine("Subtraction of two numbers is: {0}", c.Sub());
    //     }
    // }
//----------------------------------------------------------------------------------------------------------------------------  
    //Example of Auto Implementation
    // class calculator{
    //     public int number1{get;set;}
    //     public int number2{get; set;}
    //     public int Add(){
    //         return number1 + number2;
    //     }
    //     public int Sub(){
    //         return number1 - number2;
    //     }
    // }
    // class Program{
    //     static void Main(string[] args){
    //         calculator c = new calculator();
    //         c.number1 = 10;
    //         c.number2 = 20;
    //         Console.WriteLine("Addition of two numbers is: {0}", c.Add());
    //         Console.WriteLine("Subtraction of two numbers is: {0}", c.Sub());
    //     }
    // }
//----------------------------------------------------------------------------------------------------------------------------
    //Real life exapmle 
    // class Person{
    //     private string _name;
    //     private int _age;
    //     public void setname(string name){
    //         _name = name;
    //     }
    //     public void setage(int age){
    //         _age = age;
    //     }
    //     public string getname(){
    //         return _name;
    //     }
    //     public int getage(){
    //         return _age;
    //     }
    // }
    // class Program{
    //     static void Main(string[] args){
    //         Person p = new Person();
    //         p.setname("John");
    //         p.setage(20);
    //         Console.WriteLine("Name: {0}, Age: {1}", p.getname(), p.getage());
    //     }
    // }
//----------------------------------------------------------------------------------------------------------------------------
    //Using Properties
    class Person{
        private string _name;
        private int _age;
        public string name{
            set{
                name = value;
            }
            get{
                return _name;
            }
        }
        public int age{
            set{
                _age = value;
            }
            get{
                return _age;
            }
        }
    }
    class Program{
        static void Main(string[] args){
            Person p = new Person();
            p.name = "John";
            p.age = 20;
            Console.WriteLine("Name: {0}, Age: {1}", p.name, p.age);
        }
    }
}