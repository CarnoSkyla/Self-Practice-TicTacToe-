using System;
using System.Collections.Generic;
using System.Text;

namespace Self_Practice
{
    public class BiggestNumber
    {
        public static int GetBiggest(int[] listOfNumbers)
        {
            int x = 0;
           // Console.WriteLine(listOfNumbers);

            for(var index = 0; index < listOfNumbers.Length; index++)
            {
                  if(listOfNumbers[index] > x)
                  {
                    x = listOfNumbers[index];
                  } 
            }
            Console.WriteLine(x);
            return x;




        }
    }
}
