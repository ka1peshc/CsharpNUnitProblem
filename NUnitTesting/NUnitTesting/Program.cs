using System;

namespace NUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter amount to get change from vending machine");
            int amount = Convert.ToInt32(Console.ReadLine());
            MinimumChangesNotes mcn = new MinimumChangesNotes();
            mcn.FindChanges(amount);
        }
    }
}
