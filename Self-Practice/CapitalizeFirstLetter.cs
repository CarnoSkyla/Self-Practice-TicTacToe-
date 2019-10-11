using System;
using System.Collections.Generic;
using System.Text;

namespace Self_Practice
{
    public class CapitalizeFirstLetter
    {
        public static void Capitalize()
        {

       
            
           
                  var sentence = Console.ReadLine();

            //var sentence = "i hope you had a good weekend";


            string[] splited = sentence.Split(' ');


           
            for(int index = 0; index < splited.Length; index++)
            {
                var splittedArray = splited[index].ToCharArray();
                splittedArray[0] = char.ToUpper(splittedArray[0]);
                splited[index] = new string(splittedArray);

            }
             
            string capString = string.Empty;

           foreach(var word in splited)
            {
                capString = capString + word + " ";

            }

            Console.WriteLine(capString);
            
    
        }

       
    }
}
