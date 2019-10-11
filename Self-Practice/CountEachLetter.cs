using System;
using System.Collections.Generic;
using System.Text;

namespace Self_Practice
{
    public class CountEachLetter
    {
        public static string HowManyLetters(string x)


        {
            var charArray = x.ToLower().ToCharArray();
            char[] alphabets = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            int[] counter = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for(int index = 0; index < alphabets.Length; index++)
            {
                foreach(var character in charArray)
                {
                    if(character == alphabets[index])
                    {
                        counter[index]++;
                    }

                   
                }

                if (counter[index] > 0)
                {
                    Console.WriteLine($"The number of {alphabets[index]} in {x} is - {counter[index]}");
                }
            }

        
            /*

            var splitString = x.Trim(' ').ToCharArray();
            var list = new List<int>(splitString.Length);
            var listString = new List<string>(splitString.Length);

            for(int y = 0; y < splitString.Length; y++)
            {
                list.Add(splitString[y].ToString().Length);
                listString.Add(splitString[y].ToString());

                for(int index = 0; index < listString.Count; index++)
                {
                    if(listString[index] == splitString[y].ToString() && list[y] == 1)
                        {
                        listString.Add(listString[index]);
                    
                }


            }

            */
            


            

            return x;




            /*
            var sentence = Console.ReadLine();
            var x = sentence.Trim(' ').ToCharArray();
            string str = string.Empty;

           

            for(int index = 0; index < x.Length; index++)
            {
                var list = new List<int>(x.Length);

                list.Add(x[index].ToString().Length);
                
                for(int a = 0; a < list.Count; a++)
                {
                    str += list[index];
                }
                    
            }
            Console.WriteLine(str);

    */
            





        }
    }
}
