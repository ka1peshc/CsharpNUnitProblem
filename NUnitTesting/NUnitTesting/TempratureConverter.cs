using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    class TempratureConverter
    {
        internal void CelsiusToFahrenheit(int temp)
        {
            //(°C × 9/5) + 32 = °F
            int tempInF = temp * (9 / 5) + 32;
            Console.WriteLine("{0} celsius into {1} fahrenheit", temp, tempInF);
        }
        internal void FahrenheitToCelsius(int temp)
        {
            //(°F − 32) x 5/9 = °C
            int tempInF = (temp -32) * (5/9);
            Console.WriteLine("{0} fahrenheit into {1} celsius", temp, tempInF);
        }

    }
}
