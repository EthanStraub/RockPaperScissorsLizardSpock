using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        public string user1Choice;
        public string user2Choice;
        public bool versusAI;
        public string aiCheck;


        public Game()
        {
            //null
        }

        public void GameLoop()
        {
            {
                Console.WriteLine("Type 'PVP' for a 2-player game, or 'AI' for a player vs. computer game");
                aiCheck = Console.ReadLine();

                switch (aiCheck)
                {
                    case "PVP":
                        versusAI = false;
                        break;
                    case "AI":
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
