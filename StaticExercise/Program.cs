using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put in a temp fr celcius or fahrenheit and I will convert it");
            Console.WriteLine();
            Console.WriteLine("put in c for celcius and f for fahrenheit");
            var tempType = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (tempType == "f")
            {
                Console.WriteLine("enter the temp here");
                var temp = double.Parse(Console.ReadLine());
                Console.WriteLine($"the temp converted from fahrenheit to celcius is {TempConverter.FahrenheitToCelsius(temp)}");

            }
            else
            {
                Console.WriteLine("enter celcius temp here");
                var temp = double.Parse(Console.ReadLine());
                Console.WriteLine($"the temp converted from celcius to fahrenheit is {TempConverter.CelsiusToFahrenheit(temp)}");
            }
            
        }
    }
}
