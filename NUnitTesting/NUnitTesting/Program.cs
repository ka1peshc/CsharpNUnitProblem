using System;

namespace NUnitTesting
{
    class Program
    {
        void VendingMachineChanges()
        {
            Console.WriteLine("Enter amount to get change from vending machine");
            int amount = Convert.ToInt32(Console.ReadLine());
            MinimumChangesNotes mcn = new MinimumChangesNotes();
            mcn.FindChanges(amount);
        }
        void DayOfWeek()
        {
            Console.WriteLine("Enter month then day and then year respectivily");
            int m = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered values: Month is" + m + " Day is " + d + " year is" + y);
            DayOfWeek dow = new DayOfWeek();
            dow.checkForDayOfWeek(m, d, y);
        }
        void TempratureConvertor()
        {
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
        void MonthlyPayment()
        {
            MontlyPayment mp = new MontlyPayment();
            Console.WriteLine("Enter folling values Principle amount, no. of years and Rate");
            int Principleamount = int.Parse(Console.ReadLine());
            int NoOfYear = int.Parse(Console.ReadLine());
            int Rate = int.Parse(Console.ReadLine());
            mp.calculateMontlyPayment(Principleamount, NoOfYear, Rate);
        }
        void SquareRoot()
        {
            FindingSquareRoot fsr = new FindingSquareRoot();
            Console.WriteLine("Enter number to find square root");
            int numsqrt = int.Parse(Console.ReadLine());
            fsr.getSquareRoot(numsqrt);
        }
        void ChangeNumberToBinary()
        {
            ToBinaryNumber tb = new ToBinaryNumber();
            Console.WriteLine("Enter number to convert into Binary");
            int numB = int.Parse(Console.ReadLine());
            tb.convertIntoBinary(numB);
        }
        void BinaryInterchange()
        {
            BinaryOperations bo = new BinaryOperations();
            Console.WriteLine("Enter number ");
            int numBinary = int.Parse(Console.ReadLine());
            bo.PerformingBinaryOperation(numBinary);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter option to perform");
            Console.WriteLine("1. Vending machine get minimum notes/changes");
            Console.WriteLine("2. Get day of particular date");
            Console.WriteLine("3. Temprature metric convertor ");
            Console.WriteLine("4. Get montly payment");
            Console.WriteLine("5. Get square root of given number");
            Console.WriteLine("6. Change number into binary format");
            Console.WriteLine("7. Swap to nibble and get new number");
            Program p = new Program();
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    p.VendingMachineChanges();
                    break;
                case 2:
                    p.DayOfWeek();
                    break;
                case 3:
                    p.TempratureConvertor();
                    break;
                case 4:
                    p.MonthlyPayment();
                    break;
                case 5:
                    p.SquareRoot();
                    break;
                case 6:
                    p.ChangeNumberToBinary();
                    break;
                case 7:
                    p.BinaryInterchange();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
