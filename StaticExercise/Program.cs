using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(68);
            var Fahrenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine("conversation");
                Console.WriteLine($"celsius{celcius}");
                Console.WriteLine($"Fahrenheit{Fahrenheit}");
        }
    }
}
