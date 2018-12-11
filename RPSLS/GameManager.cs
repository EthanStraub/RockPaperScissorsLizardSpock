using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GameManager
    {
        Game game1;
        bool isRunning = true;
        
        public Game MakeGame()
        {
            return new Game();
        }

        public void StartGame()
        {
            game1 = MakeGame();
            game1.SetUpPlayers();
            game1.GameLoop();
        }
        
        public void RestartGame()
        {
            
            bool isInputValid = false;
            while (!isInputValid)
            {
                string winOption = Console.ReadLine();
                switch (winOption)
                {       
                    case "restart":
                        isInputValid = true;
                        break;
                    case "quit":
                        isInputValid = true;
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Please try again.");
                        break;
                }
                Console.WriteLine("");
            }
        }

        public void StartManager()
        {
            while(isRunning)
            {
                StartGame();
                RestartGame();
            }
        }
    }
}
