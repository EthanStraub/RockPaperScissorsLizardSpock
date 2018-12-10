using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class ComputerPlayer : Player
    {
        public int computerChoice;
        int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public ComputerPlayer(bool versusAI) : base(versusAI)
        {
            //null
        }

        public void winCalc()
        {
            winOption = Console.ReadLine();
            switch (winOption)
            {
                case "restart":
                    p1WinCount = 0;
                    p2WinCount = 0;
                    GameLoop();
                    break;
                case "quit":
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("Please try again.");
                    ChoiceCalcLoop();
                    break;
            }
        }

        public void ChoiceCalcLoop()
        {
            Console.WriteLine("");

            if (p1WinCount == 3)
            {
                Console.WriteLine("Player 1 wins the game! Type 'restart' to restart or 'quit' to exit the program.");
                winCalc();

            }
            else if (p2WinCount == 3)
            {
                Console.WriteLine("Computer wins the game! Type 'restart' to restart or 'quit' to exit the program.");
                winCalc();
            }

            Console.WriteLine("Player 1's turn.");
            user1Choice = Console.ReadLine();

            Console.SetCursorPosition(0, Console.CursorTop - 1);
            ClearCurrentConsoleLine();

            Console.WriteLine("Computer's turn.");
            computerChoice = RandomNumber(0, 4);
            Console.WriteLine(computerChoice);
            user2Choice = choices[computerChoice];

            ChoiceComparison();
        }

        public void ChoiceComparison()
        {
            Console.WriteLine("");
            if (user1Choice == user2Choice)
            {
                Console.WriteLine("Both choices match! Try again!");
            }
            else if (user1Choice == choices[0] && (user2Choice == choices[2] || user2Choice == choices[3]))
            {
                Console.WriteLine(user1Choice + " beats " + user2Choice + "!");
                p1WinCount += 1;
            }
            else if (user1Choice == choices[1] && (user2Choice == choices[0] || user2Choice == choices[4]))
            {
                Console.WriteLine(user1Choice + " beats " + user2Choice + "!");
                p1WinCount += 1;
            }
            else if (user1Choice == choices[2] && (user2Choice == choices[1] || user2Choice == choices[3]))
            {
                Console.WriteLine(user1Choice + " beats " + user2Choice + "!");
                p1WinCount += 1;
            }
            else if (user1Choice == choices[3] && (user2Choice == choices[1] || user2Choice == choices[4]))
            {
                Console.WriteLine(user1Choice + " beats " + user2Choice + "!");
                p1WinCount += 1;
            }
            else if (user1Choice == choices[4] && (user2Choice == choices[0] || user2Choice == choices[2]))
            {
                Console.WriteLine(user1Choice + " beats " + user2Choice + "!");
                p1WinCount += 1;
            } //end of user 1
            else if (user2Choice == choices[0] && (user1Choice == choices[2] || user1Choice == choices[3]))
            {
                Console.WriteLine(user2Choice + " beats " + user1Choice + "!");
                p2WinCount += 1;
            }
            else if (user2Choice == choices[1] && (user1Choice == choices[0] || user1Choice == choices[4]))
            {
                Console.WriteLine(user2Choice + " beats " + user1Choice + "!");
                p2WinCount += 1;
            }
            else if (user2Choice == choices[2] && (user1Choice == choices[1] || user1Choice == choices[3]))
            {
                Console.WriteLine(user2Choice + " beats " + user1Choice + "!");
                p2WinCount += 1;
            }
            else if (user2Choice == choices[3] && (user1Choice == choices[1] || user1Choice == choices[4]))
            {
                Console.WriteLine(user2Choice + " beats " + user1Choice + "!");
                p2WinCount += 1;
            }
            else if (user2Choice == choices[4] && (user1Choice == choices[0] || user1Choice == choices[2]))
            {
                Console.WriteLine(user2Choice + " beats " + user1Choice + "!");
                p2WinCount += 1;
            }
            Console.WriteLine("");

            Console.WriteLine("Player 1 has " + p1WinCount + " win(s)!");
            Console.WriteLine("Computer has " + p2WinCount + " win(s)!");

            ChoiceCalcLoop();
        }
    }
}
