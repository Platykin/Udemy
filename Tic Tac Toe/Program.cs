using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] board = new string[,]
            {
                { "1", "2", "3"},
                { "4", "5", "6"},
                { "7", "8", "9"}
            };
            int player = 1;

            bool gameOver(string[,] Array)
            {
                for (int k = 0; k < Array.GetLength(0); k++)
                {
                    if (Array[k, 0] == Array[k, 1] && Array[k, 0] == Array[k, 2])
                    {              
                        return true;
                    }
                    if (Array[0, k] == Array[1, k] && Array[0, k] == Array[2, k])
                    {
                        return true;
                    }
                }
                if (Array[0, 0] == Array[1, 1] && Array[0,0] == Array[2, 2])
                {
                    return true;
                }
                if (Array[0, 2] == Array[1, 1] && Array[0, 2] == Array[2, 0])
                {
                    return true;
                }
                return false;
            }
            bool end = false;
            while (!end)
            {
                string playerMove = "0";
                int integerPlayerMove = 0;
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    Console.WriteLine("\n");
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        if (j == (board.GetLength(1) - 1))
                        {
                            Console.Write(" | " + board[i, j] + " |");
                        }
                        else
                        {
                            Console.Write(" | " + board[i, j]);
                        }
                    }
                    Console.WriteLine("\n_______________");
                }            
                end = gameOver(board);
                if (player == 1)
                {
                    Console.WriteLine("It's your turn, player 1. In which place do you want to play?");
                    try
                    {
                        playerMove = Console.ReadLine();
                        integerPlayerMove = int.Parse(playerMove);
                    }
                    catch(ArgumentNullException)
                    {
                        Console.WriteLine("You should choose one of the available number as your move!");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("You should choose one of the available number as your move!");
                    }
                    
                }
                else if (player == 2)
                {
                        Console.WriteLine("It's your turn, player 2. Which place do you want to play? ");
                        try
                        {
                            playerMove = Console.ReadLine();
                            integerPlayerMove = int.Parse(playerMove);
                        }
                        catch (ArgumentNullException)
                        {
                            Console.WriteLine("You should choose one of the available number as your move!");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("You should choose one of the available number as your move!");
                        }
                      
                }



                int counter = 1;

                for(int k = 0; k<board.GetLength(0); k++)
                {
                    for(int l = 0; l < board.GetLength(1); l++)
                    {
                        if(counter == integerPlayerMove && player == 1)
                        {
                            board[k, l] = "X";
                            player += 1;
                        }
                        else if(counter == integerPlayerMove && player == 2)
                        {
                            board[k, l] = "O";
                            player -= 1;
                        }
                        counter++;
                    }
                }


            }

            if (end == true)
            {
                Console.WriteLine("Congratz! Player {0} won!", player);
            }

        }
    }
}