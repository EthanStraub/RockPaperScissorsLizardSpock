using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(bool versusAI) : base(versusAI)
        {
            //null
        }

        public void PlayerChoice()
        {
            Console.WriteLine("Player 1's turn.");
            user1Choice = Console.ReadLine();
            Console.WriteLine("Player 2's turn.");
            user2Choice = Console.ReadLine();
            Console.WriteLine(user1Choice + " " + user2Choice);
        }
    }
}
