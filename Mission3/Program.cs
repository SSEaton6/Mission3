using System;

namespace Mission3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //initializes the array to keep track of the board
            string[] boardArray = {"0","1","2", "3", "4", "5", "6", "7", "8"};
            //this keeps track of whose turn it is
            int playerNum = 1;
           //keeps track of the turns. once it hits 9, if there is no winner, it is a tie
            int turn = 0;
            string message = ""; // while winner = 0, the game will continue to play. 1 means there's a winner. -1 is a draw.

            Console.WriteLine("Hello! Welcome to our Tic-Tac-Toe Game!");

            Support newSupport = new Support();
            newSupport.PrintBoard(boardArray);

            // do while loop to play the game while there isn't a winner
            do
            {
                while (playerNum == 1) 
                {
                    Console.WriteLine("Player 1, Enter a number between 0 and 8");
                    int playerchoice = Convert.ToInt32(Console.ReadLine());
                    // if else loop to check if player's choice is open or not
                    
                    if (boardArray[playerchoice] == Convert.ToString(playerchoice))
                    {
                        //player 1 is X
                        boardArray[playerchoice] = "X";
                        //changes the turn to player 2
                        playerNum = 2;
                        // increments the turn counter
                        turn++;
                        // passes the board and checks for a win
                        message = newSupport.DetermineWinner(boardArray, turn);
                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another number");
                    }
                    // clears the console so that it just shows one board at a time
                    
                }
                Console.Clear();
                newSupport.PrintBoard(boardArray);
                // checks the message variable passed from support class. If there is a winner, it breaks out of the loop.
                if (message == "X's are the winner!" || message == "It was a Tie!")
                {
                    break;
                }
                while (playerNum == 2)
                {
                    Console.WriteLine("Player 2, Enter a number between 0 and 8");
                    int playerchoice = Convert.ToInt32(Console.ReadLine());
                    if (boardArray[playerchoice] == Convert.ToString(playerchoice))
                    
                    {
                        // player 2 is O
                        boardArray[playerchoice] = "O";
                        // changes the turn back to player 1
                        playerNum = 1;
                        //increments the turn counter
                        turn++;
                        // passes the board and checks for a win
                        message = newSupport.DetermineWinner(boardArray, turn);

                    }
                    else
                    {
                        Console.WriteLine("That spot is already taken. Please choose another number");
                    }
                    
                }
                Console.Clear();
                newSupport.PrintBoard(boardArray);

            }
            while (message == "") ;
            // prints the final board and announces winner
            Console.WriteLine(message);
            newSupport.PrintBoard(boardArray);
        }
    }
}
