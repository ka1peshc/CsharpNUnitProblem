using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    class BinaryOperations
    {
        internal void PerformingBinaryOperation(int num)
        {
            int[] binaryArr = new int[8];
            int[] reverseArr = new int[8];
            int[] nibble1 = new int[4];
            int[] nibble2 = new int[4];
            for (int i = 0; num > 0; i++)
            {
                binaryArr[i] = num % 2;
                num = num / 2;
            }
            for(int i = 0; i < binaryArr.Length; i++)
            {
                Console.Write(binaryArr[i]);
                if (i < 4)
                {
                    nibble1[i] = binaryArr[i];
                }
                else
                {
                    nibble2[i-4] = binaryArr[i];
                }
            }
            var myList = new List<int>();
            myList.AddRange(nibble1);
            myList.AddRange(nibble2);
            reverseArr = myList.ToArray();
            for (int i = 0; i < reverseArr.Length; i++)
            {
                Console.Write(reverseArr[i]);
            }
    }
}
