using System;

namespace NUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Minimum changes given by vending machine
            "Enter amount to get change from vending machine");
            int amount = Convert.ToInt32(Console.ReadLine());
            MinimumChangesNotes mcn = new MinimumChangesNotes();
            mcn.FindChanges(amount);
            
            //day of the week
            Console.WriteLine("Enter month then day and then year respectivily");
            int m = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered values: Month is" + m + " Day is " + d + " year is" + y);
            DayOfWeek dow = new DayOfWeek();
            dow.checkForDayOfWeek(m, d, y);
            */

            //Temprature convertor
            TempratureConverter tc = new TempratureConverter();
            Console.WriteLine("Enter temprature in number");
            int tempNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Select convertion");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                tc.CelsiusToFahrenheit(tempNumber);
            }
            else if (option == 2)
            {
                tc.FahrenheitToCelsius(tempNumber);
            }
            else
            {
                Console.WriteLine("Enter valid input option");
            }


        }
    }
}
