﻿using System;

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
            
            MontlyPayment mp = new MontlyPayment();
            Console.WriteLine("Enter folling values Principle amount, no. of years and Rate");
            int Principleamount = int.Parse(Console.ReadLine());
            int NoOfYear = int.Parse(Console.ReadLine());
            int Rate = int.Parse(Console.ReadLine());
            mp.calculateMontlyPayment(Principleamount,NoOfYear,Rate);

            FindingSquareRoot fsr = new FindingSquareRoot();
            Console.WriteLine("Enter number to find square root");
            int numsqrt = int.Parse(Console.ReadLine());
            fsr.getSquareRoot(numsqrt);
            
            ToBinaryNumber tb = new ToBinaryNumber();
            Console.WriteLine("Enter number to convert into Binary");
            int numB = int.Parse(Console.ReadLine());
            tb.convertIntoBinary(numB);
            */
            BinaryOperations bo = new BinaryOperations();
            Console.WriteLine("Enter number ");
            int numBinary = int.Parse(Console.ReadLine());
            bo.PerformingBinaryOperation(numBinary);

        }
    }
}
