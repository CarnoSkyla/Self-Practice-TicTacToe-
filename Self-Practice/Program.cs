using System;
using TicTacToeRendererLib;

namespace Self_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] listOfNumbers = { 1, 3, 5, 7, 8 };
            int[] listOfNums = { 1, 3, 8, 85};

            BiggestNumber.GetBiggest(listOfNumbers);

            SecondBiggestNum.GetSecBiggest(listOfNums);

            CapitalizeFirstLetter.Capitalize();
            CountEachLetter.HowManyLetters(Console.ReadLine());

            int[] list = { 8, 3, 5, 16, 1 };
            SortNumbers.SortList(list);
            */




            var ticTacToe = new TicTacToe();
            ticTacToe.TicTacToeGame();
        }
    }
}
