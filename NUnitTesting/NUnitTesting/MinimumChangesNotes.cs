using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    class MinimumChangesNotes
    {
        internal void FindChanges(int amount)
        {
            int note=0;
            int amt = amount;
            while ( amount != 0 )
            {
                if(amount >= 1000)
                {
                    amount -= 1000;
                    note++;
                }
                else if(amount >= 500)
                {
                    amount -= 500;
                    note++;
                }
                else if (amount >= 100)
                {
                    amount -= 100;
                    note++;
                }
                else if (amount >= 50)
                {
                    amount -= 50;
                    note++;
                }
                else if (amount >= 10)
                {
                    amount -= 10;
                    note++;
                }
                else if (amount >= 5)
                {
                    amount -= 5;
                    note++;
                }else if (amount >= 2)
                {
                    amount -= 2;
                    note++;
                }else if (amount >= 1)
                {
                    amount -= 1;
                    note++;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            Console.WriteLine("Number of notes required to give {0} is {1}", amt, note);
        }
    }
}
