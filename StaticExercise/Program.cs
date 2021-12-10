using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(0);

            Console.WriteLine($"After conversion: \r\nCelcius is {celsius}\r\nFahrenheit is {fahrenheit}");


        }
    }
}
