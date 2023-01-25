using System;

namespace Mission3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] boardArray = {"0","1","2", "3", "4", "5", "6", "7", "8", "9"};
            int playerNum = 1;
           
            int turn = 0;
            string message = ""; // while winner = 0, the game will continue to play. 1 means there's a winner. -1 is a draw.

            Console.WriteLine("Hello! Welcome to our Tic-Tac-Toe Game!");

            Support newSupport = new Support();
            newSupport.PrintBoard(boardArray);

            do
            {
                while (playerNum == 1) 
                {
                    Console.WriteLine("Player 1, Enter a number between 0 and 8");
                    int playerchoice = Convert.ToInt32(Console.ReadLine());

                    if (Convert.ToInt32(boardArray[playerchoice]) == playerchoice)
                    {
                        boardArray[playerchoice] = "X";
                        playerNum = 2;
                        turn++;
                        message = newSupport.DetermineWinner(boardArray, turn);
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another number");
                    }
                    Console.Clear();
                    newSupport.PrintBoard(boardArray);
                }
                
                if (message == "X's are the winner!" || message == "It was a Tie!")
                {
                    break;
                }
                while (playerNum == 2)
                {
                    Console.WriteLine("Player 2, Enter a number between 0 and 8");
                    int playerchoice = Convert.ToInt32(Console.ReadLine());
                    if (Convert.ToInt32(boardArray[playerchoice]) == playerchoice)
                    {
                        boardArray[playerchoice] = "O";
                        playerNum = 1;
                        turn++;
                        message = newSupport.DetermineWinner(boardArray, turn);

                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another number");
                    }
                    Console.Clear();
                    newSupport.PrintBoard(boardArray);
                }
                
            }
            while (message == "") ;
            Console.WriteLine(message);
            newSupport.PrintBoard(boardArray);
        }
    }
}
