using System;
using System.Collections.Generic;
using System.Text;

namespace Self_Practice
{
    public class SortNumbers
    {
        public static string SortList(int[] list)
        {
            int[] numArray = list;
            var newList = new List<int>();

            for (int index = 0; index < numArray.Length; index++)
            {
               if(numArray[0] > numArray[1])
                {
                    
                    numArray[0] = numArray[1];
                    

                    

                    if(numArray[0] == numArray[1])
                    {
                       
                    }

                } 

               if(numArray[1] > numArray[2])
                {
                    numArray[1] = numArray[2];
                    newList.Add(numArray[1]);
                }
                
                   


            }

            return string.Empty;
        }
    }
}