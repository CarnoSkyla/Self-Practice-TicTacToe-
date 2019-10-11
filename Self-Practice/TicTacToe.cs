using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Renderer;
using TicTacToeRendererLib.Enums;


namespace Self_Practice
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10, 2);
            _boardRenderer.Render();
        }

        public int getCoords(int x, int y)
        {
            var result = x * 3 + y;

            return result;

        }

        char[] spaces = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };

        //CHECK FOR X WHEN X WINS
        public void CheckXWin()
        {
            if (spaces[0] == 'X' && spaces[1] == 'X' && spaces[2] == 'X' ||
                spaces[3] == 'X' && spaces[4] == 'X' && spaces[5] == 'X' ||
                spaces[6] == 'X' && spaces[7] == 'X' && spaces[8] == 'X')
            {
                Console.WriteLine(" X has won,");
                Console.WriteLine("Thank you for playing");
                return;
            }

            if (spaces[0] == 'X' && spaces[3] == 'X' && spaces[6] == 'X' ||
               spaces[1] == 'X' && spaces[4] == 'X' && spaces[7] == 'X' ||
               spaces[2] == 'X' && spaces[5] == 'X' && spaces[8] == 'X')
            {
                Console.WriteLine(" X has won");
                Console.WriteLine("Thank you for playing");
                return;
            }

            if (spaces[0] == 'X' && spaces[4] == 'X' && spaces[8] == 'X' ||
               spaces[2] == 'X' && spaces[4] == 'X' && spaces[6] == 'X'
               )
            {
                Console.WriteLine(" X has won");
                Console.WriteLine("Thank you for playing");
                return;
            }
        }

        //CHECK FOR O WHEN O WINS
        public void CheckOWin()
        {
            if (spaces[0] == 'O' && spaces[1] == 'O' && spaces[2] == 'O' ||
                spaces[3] == 'O' && spaces[4] == 'O' && spaces[5] == 'O' ||
                spaces[6] == 'O' && spaces[7] == 'O' && spaces[8] == 'O')
            {
                Console.WriteLine(" O has won");
                Console.WriteLine("Thank you for playing");
                return;
            }

            if (spaces[0] == 'O' && spaces[3] == 'O' && spaces[6] == 'O' ||
                spaces[1] == 'O' && spaces[4] == 'O' && spaces[7] == 'O' ||
                spaces[2] == 'O' && spaces[5] == 'O' && spaces[8] == 'O')
            {
                Console.WriteLine(" O has won");
                Console.WriteLine("Thank you for playing");
                return;
            }

            if (spaces[0] == 'O' && spaces[4] == 'O' && spaces[8] == 'O' ||
                spaces[2] == 'O' && spaces[4] == 'O' && spaces[6] == 'O'
               )
            {
                Console.WriteLine(" O has won");
                Console.WriteLine("Thank you for playing");
                return;
            }
        }

        //The TIC TAC TOE GAME LOGIC METHOD
        public void TicTacToeGame()
        {
            for (int index = 0; index < spaces.Length; index++)
            {
                if(index >= spaces.Length)
                {
                    Console.WriteLine("Its a tie");
                }


                Console.SetCursorPosition(10, 12);
                Console.WriteLine("Enter a value for the row");
                var getUserInputX = Int32.Parse(Console.ReadLine()) - 1;


                Console.SetCursorPosition(10, 14);
                Console.WriteLine("Enter a value for the column");
                var getUserInputY = Int32.Parse(Console.ReadLine()) - 1;
                var getUserInput = getCoords(getUserInputX, getUserInputY);
                var playerCharacter = ' ';

                //CONDITION FOR CHECKING IF A SPACE IN THE BOARD HAS BEEN FILLED
                if (spaces[getUserInput] != ' ')
                {
                    Console.WriteLine("Spot already taken, O Fouled.. Its X's turn");
                }
                else
                {
                    //ALLOW X TO PLAY FIRST
                    if (index % 2 == 0)
                    {
                        playerCharacter = 'X';
                    }
                    else
                    {
                        playerCharacter = 'O';
                    }

                    //DISPLAY X || O ON THE CONSOLE!!
                    if (playerCharacter == 'X')
                    {
                        
                        _boardRenderer.AddMove(getUserInputX, getUserInputY, PlayerEnum.X, true);
                    }
                    else
                    {
                        _boardRenderer.AddMove(getUserInputX, getUserInputY, PlayerEnum.O, true);
                    }

                    spaces[getUserInput] = playerCharacter;

                    CheckXWin();
                    CheckOWin();

                }

            }
        }
    }  
   }


















