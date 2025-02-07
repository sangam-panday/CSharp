using System;
namespace TempConv
{
    public static class TemperatureConvertor
    {
        public static double CelsiusToFahrenheit(string celsius)
        {
            double celsiusValue = double.Parse(celsius);
            return (celsiusValue * 9 / 5) + 32;
        }
        public static double FahrenheitToCelsius(string fahrenheit)
        {
            double fahrenheitValue = double.Parse(fahrenheit);
            return (fahrenheitValue - 32) * 5 / 9;
        }
    }
    class TestTemperatureConvertor{
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in Celsius: ");
            string celsius = Console.ReadLine();
            Console.WriteLine("Temperature in Fahrenheit: " + TemperatureConvertor.CelsiusToFahrenheit(celsius));
            Console.WriteLine("Enter the temperature in Fahrenheit: ");
            string fahrenheit = Console.ReadLine();
            Console.WriteLine("Temperature in Celsius: " + TemperatureConvertor.FahrenheitToCelsius(fahrenheit));
        }
    }
}