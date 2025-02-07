using System;
namespace Namespace1
{
    class Program{
        static void Main(string[] args){
            // Type Casting
            //Process to change one data type to another data type
            string name = "100";
            int nami = int.Parse(name);
            Console.WriteLine($"Original Name: {name}, After converted to int: {nami}");

            // TryParse: It will not throw exception if conversion fails
            string number = "100";
            bool IsConverted = int.TryParse(number, out int num);
            if(IsConverted){
                Console.WriteLine($"Original Name: {number}, After converted to int: {num}");
            }else{
                Console.WriteLine("Conversion failed");
            }
        }

    }
}