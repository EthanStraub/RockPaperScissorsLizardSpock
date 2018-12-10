using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {

        public int p1WinCount = 0;
        public int p2WinCount = 0;
        public string user1Choice;
        public string user2Choice;
        public bool versusAI;
        public string aiCheck;
        public string[] choices = { "rock", "paper", "scissors", "lizard", "spock"};

        public Game()
        {
            //null
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

        public void GameLoop()
        {
            {
                Console.WriteLine("Type 'pvp' for a 2-player game, or 'ai' for a player vs. computer game");
                aiCheck = Console.ReadLine();

                switch (aiCheck)
                {
                    case "pvp":
                        versusAI = false;
                        break;
                    case "ai":
                        versusAI = true;
                        break;
                    default:
                        Console.WriteLine("Please try again.");
                        GameLoop();
                        break;
                }
            }

            Player PlayerSet = new Player(versusAI);
            
            PlayerSet.Play();
            
            Console.ReadLine();
        }
        

    }
}
