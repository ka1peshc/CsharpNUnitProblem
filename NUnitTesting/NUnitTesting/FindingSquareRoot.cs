using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    class FindingSquareRoot
    {
        internal void getSquareRoot(double c)
        {
            double t = c;
            const double Epsilon = 1E-15;
            double squareRoot;
            while (true)
            {
                squareRoot = 0.5 * (t + (c / t));
                if (Math.Abs(squareRoot - t) < Epsilon)
                    break;
                 t = squareRoot;
            }
            Console.WriteLine("{0} square root is {1}", c, squareRoot);
        }
    }
}
