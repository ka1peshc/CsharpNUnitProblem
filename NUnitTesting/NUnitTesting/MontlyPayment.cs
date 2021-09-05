using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    class MontlyPayment
    {
        internal void calculateMontlyPayment(int Principleamount,int NoOfYear,float Rate)
        {
            float r = Rate / (12 * 100);
            int n = 12 * NoOfYear;
            double payment = (Principleamount * r) / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine("Montly payment will be {0}", payment);
        }
    }
}
