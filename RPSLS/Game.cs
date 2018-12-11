using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    { 
        Player Player1;
        Player Player2;

        public void SetUpPlayers()
        {
            Player1 = new HumanPlayer();
            Player2 = SetPlayerAI();

            Player1.playerId = 1;
            Player2.playerId = 2;
        }

        public Player SetPlayerAI()
        {
            
            Player playerTwo = null;
            bool isInputValid = false;
        
            while (!isInputValid)
            {
                Console.WriteLine("Type 'pvp' for a 2-player game, or 'ai' for a player vs. computer game");
                string aiCheck = Console.ReadLine();
                switch (aiCheck)
                {
                    case "pvp":
                        playerTwo = new HumanPlayer();
                        isInputValid = true;
                        break;
                    case "ai":
                        playerTwo = new ComputerPlayer();
                        isInputValid = true;
                        break;
                    default:
                        Console.WriteLine("Please try again.");
                        playerTwo = null;
                        break;
                }
                Console.WriteLine("");
            }
            return playerTwo;
        }

        public void GameLoop()
        {

            while (Player1.score != 3 && Player2.score != 3)
            {
                Player1.ChooseGesture();
                Choices.ClearCurrentConsoleLine();
                Player2.ChooseGesture();
                Choices.ClearCurrentConsoleLine();
                ChoiceComparison();
                
            }
            WinCheck();
        }


        public void WinCheck()
        {
            if (Player1.score == 3)
            {
                Console.WriteLine("Player 1 wins the game! Type 'restart' to restart or 'quit' to exit the program.");
            }
            else if (Player2.score == 3)
            {
                Console.WriteLine("Player 2 wins the game! Type 'restart' to restart or 'quit' to exit the program."); 
            }
        }

        public void ChoiceComparison()
        {
            Console.WriteLine("");
            if (Player1.gesture == Player2.gesture)
            {
                Console.WriteLine("Both choices match! Try again!");
            }
            else if (Player1.gesture == Choices.choicesArray[0] && (Player2.gesture == Choices.choicesArray[2] || Player2.gesture == Choices.choicesArray[3]))
            {
                switch (Player2.gesture)
                {
                    case "scissors":
                        Console.WriteLine("Rock crushes Scissors!");
                        break;
                    case "lizard":
                        Console.WriteLine("Rock crushes Lizard!");
                        break;
                }
                Player1.score += 1;
            }
            else if (Player1.gesture == Choices.choicesArray[1] && (Player2.gesture == Choices.choicesArray[0] || Player2.gesture == Choices.choicesArray[4]))
            {
                switch (Player2.gesture)
                {
                    case "rock":
                        Console.WriteLine("Paper covers Rock!");
                        break;
                    case "spock":
                        Console.WriteLine("Paper disproves Spock!");
                        break;
                }
                Player1.score += 1;
            }
            else if (Player1.gesture == Choices.choicesArray[2] && (Player2.gesture == Choices.choicesArray[1] || Player2.gesture == Choices.choicesArray[3]))
            {
                switch (Player2.gesture)
                {
                    case "paper":
                        Console.WriteLine("Scissors cuts Paper!");
                        break;
                    case "lizard":
                        Console.WriteLine("Scissors decapitates Lizard!");
                        break;
                }
                Player1.score += 1;
            }
            else if (Player1.gesture == Choices.choicesArray[3] && (Player2.gesture == Choices.choicesArray[1] || Player2.gesture == Choices.choicesArray[4]))
            {
                switch (Player2.gesture)
                {
                    case "paper":
                        Console.WriteLine("Lizard eats Paper!");
                        break;
                    case "spock":
                        Console.WriteLine("Lizard poisons Spock!");
                        break;
                }
                Player1.score += 1;
            }
            else if (Player1.gesture == Choices.choicesArray[4] && (Player2.gesture == Choices.choicesArray[0] || Player2.gesture == Choices.choicesArray[2]))
            {
                switch (Player2.gesture)
                {
                    case "rock":
                        Console.WriteLine("Spock vaporizes Rock!");
                        break;
                    case "scissors":
                        Console.WriteLine("Spock smashes Scissors!");
                        break;
                }
                Player1.score += 1;
            } //end of user 1
            else if (Player2.gesture == Choices.choicesArray[0] && (Player1.gesture == Choices.choicesArray[2] || Player1.gesture == Choices.choicesArray[3]))
            {
                switch (Player1.gesture)
                {
                    case "scissors":
                        Console.WriteLine("Rock crushes Scissors!");
                        break;
                    case "lizard":
                        Console.WriteLine("Rock crushes Lizard!");
                        break;
                }
                Player2.score += 1;
            }
            else if (Player2.gesture == Choices.choicesArray[1] && (Player1.gesture == Choices.choicesArray[0] || Player1.gesture == Choices.choicesArray[4]))
            {
                switch (Player1.gesture)
                {
                    case "rock":
                        Console.WriteLine("Paper covers Rock!");
                        break;
                    case "spock":
                        Console.WriteLine("Paper disproves Spock!");
                        break;
                }
                Player2.score += 1;
            }
            else if (Player2.gesture == Choices.choicesArray[2] && (Player1.gesture == Choices.choicesArray[1] || Player1.gesture == Choices.choicesArray[3]))
            {
                switch (Player1.gesture)
                {
                    case "paper":
                        Console.WriteLine("Scissors cuts Paper!");
                        break;
                    case "lizard":
                        Console.WriteLine("Scissors decapitates Lizard!");
                        break;
                }
                Player2.score += 1;
            }
            else if (Player2.gesture == Choices.choicesArray[3] && (Player1.gesture == Choices.choicesArray[1] || Player1.gesture == Choices.choicesArray[4]))
            {
                switch (Player1.gesture)
                {
                    case "paper":
                        Console.WriteLine("Lizard eats Paper!");
                        break;
                    case "spock":
                        Console.WriteLine("Lizard poisons Spock!");
                        break;
                }
                Player2.score += 1;
            }
            else if (Player2.gesture == Choices.choicesArray[4] && (Player1.gesture == Choices.choicesArray[0] || Player1.gesture == Choices.choicesArray[2]))
            {
                switch (Player1.gesture)
                {
                    case "rock":
                        Console.WriteLine("Spock vaporizes Rock!");
                        break;
                    case "scissors":
                        Console.WriteLine("Spock smashes Scissors!");
                        break;
                }
                Player2.score += 1;
            }
            else
            {
                Console.WriteLine("One or more players have entered an invalid input. The match will count as a draw.");
            }

            Console.WriteLine("");
            Console.WriteLine("Player 1 has " + Player1.score + " win(s)!");
            Console.WriteLine("Player 2 has " + Player2.score + " win(s)!");
            Console.WriteLine("");
        }

    }
}
