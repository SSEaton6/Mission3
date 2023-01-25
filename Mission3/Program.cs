using System;

namespace Mission3
{
    class Driver
    {
        int[] boardArray = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        int playerNum = 1;
        int choice;
        int winner; // while winner = 0, the game will continue to play. 1 means there's a winner. -1 is a draw.

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            Support.PrintBoard(boardArray);

            do
            {
                while (playerNum == 1) 
                {
                    Console.WriteLine("Player 1, Enter a number between 1 and 9");
                    choice = Console.ReadLine();
                    if (boardArray[choice + 1] == choice + 1)
                    {
                        boardArray[choice + 1] = 'X';
                        playerNum = 2;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another number");
                    }
                    Support.PrintBoard(boardArray);
                }
                
                while (playerNum == 2)
                {
                    Console.WriteLine("Player 2, Enter a number between 1 and 9");
                    choice = Console.ReadLine();
                    if (boardArray[choice + 1] == choice + 1)
                    {
                        boardArray[choice + 1] = 'O';
                        playerNum = 1;
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another number");
                    }
                    Support.PrintBoard(boardArray);
                }
            }
            while (winner != 1 && winner != -1) ;
            Support.PrintBoard(boardArray);
            Support.DetermineWinner(boardArray);
        }
    }
}
