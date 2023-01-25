using System;
using System.Collections.Generic;
using System.Text;

namespace Mission3
{
    class Support
    {


        // print game board
        public void PrintBoard (string[] board)
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[0], board[1], board[2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[3], board[4], board[5]);
            Console.WriteLine("_____|_____|_____"); Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[6], board[7], board[8]);
            Console.WriteLine("     |     |     ");
        }

        public string DetermineWinner (string[] board, int turn)
        {
            bool win = false;
            int checker = 0;
            string winner = "";

            //horizontal
            if (board[0] == board[1] && board[0] == board[2])
            {
                checker = 0;
                win = true;
            }
            else if (board[3] == board[4] && board[3] == board[5])
            {
                checker = 3;
                win = true;
            }
            else if (board[6] == board[7] && board[6] == board[8])
            {
                checker = 6;
                win = true;
            }

            //vertical
            else if (board[0] == board[3] && board[3] == board[6])
            {
                checker = 0;
                win = true;
            }

            else if (board[1] == board[4] && board[4] == board[7])
            {
                checker = 1;
                win = true;
            }
            else if (board[2] == board[5] && board[5] == board[8])
            {
                checker = 2;
                win = true;
            }

            //diagonal 
            else if (board[0] == board[4] && board[4] == board[8])
            {
                checker = 0;
                win = true;
            }
            else if (board[2] == board[4] && board[4] == board[6])
            {
                checker = 2;
                win = true;
            }

            if (win == true)
            {
                if (board[checker] == "X" || board[checker] == "x")
                {
                    winner = "X's are the winner!";
                }
                else if (board[checker] == "O" || board[checker] == "o")
                {
                    winner = "O's are the winner!";
                } 
            }
            if (turn == 9)
            {
                winner = "It was a Tie!";
            }
            

            return winner;
        }
    }
}
