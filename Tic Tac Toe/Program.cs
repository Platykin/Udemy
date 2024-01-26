using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {

        static string[,] board = new string[,]
        {
                { "1", "2", "3"},
                { "4", "5", "6"},
                { "7", "8", "9"}
        };

        static string[,] initialBoard = new string[,]
        {
                { "1", "2", "3"},
                { "4", "5", "6"},
                { "7", "8", "9"}
        };

        static void drawBoard(string[,] boardToBeDrawn)
        {
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
        }
            static int turn = 0;
        static void Main(string[] args)
        {
            int player = 1;

            void winer()
            {
                Console.WriteLine("Congratz! Player {0} won!", player);
            }

            bool gameOver(string[,] Array)
            {
                Console.Clear();
                drawBoard(board);
                for (int k = 0; k < Array.GetLength(0); k++)
                {
                    if (Array[k, 0] == Array[k, 1] && Array[k, 0] == Array[k, 2])
                    {
                        winer();
                        return true;
                    }
                    if (Array[0, k] == Array[1, k] && Array[0, k] == Array[2, k])
                    {
                        winer();
                        return true;
                    }
                }
                if (Array[0, 0] == Array[1, 1] && Array[0,0] == Array[2, 2])
                {
                    winer();
                    return true;
                }
                if (Array[0, 2] == Array[1, 1] && Array[0, 2] == Array[2, 0])
                {
                    winer();
                    return true;
                }
                if (turn == 10)
                {
                    Console.WriteLine("It's a tie!");
                    return true;
                }
                return false;
            }
            bool end = false;



            while (!end)
            {
                Console.Clear();
                string playerMove = "0";
                int integerPlayerMove = 0;
                if (player == 1)
                {
                    Console.WriteLine("It's your turn, player 1. In which place do you want to play?");
                    try
                    {
                        if (turn == 0)
                        {
                            drawBoard(initialBoard);
                        }
                        else { drawBoard(board); }
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
                            if (turn == 0)
                            {
                                drawBoard(initialBoard);
                            }
                            else { drawBoard(board); }
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
                        }
                        else if(counter == integerPlayerMove && player == 2)
                        {
                            board[k, l] = "O";
                        }
                        counter++;
                    }
                }
                turn++;
                end = gameOver(board);
                if(player == 1)
                {
                    player = 2;
                }
                else
                {
                    player = 1;
                }
            }


        }
    }
}