using System;
using System.Collections.Generic;
using System.Text;

namespace Self_Practice
{
    public class SecondBiggestNum
    {
        public static int GetSecBiggest(int[] listOfNums)
        {
            Array.Sort(listOfNums);
            Array.Reverse(listOfNums);
            Console.WriteLine(listOfNums[1]);

            return listOfNums[1];
            
        }
    }
}
