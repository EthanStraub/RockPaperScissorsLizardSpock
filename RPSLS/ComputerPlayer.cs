using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(bool versusAI) : base(versusAI)
        {
            //null
        }

        public void PlayerChoice()
        {
            Console.WriteLine("Player 1's turn.");
            user1Choice = Console.ReadLine();
            Console.WriteLine("Computer's turn.");
            user2Choice = "TEST";
            Console.WriteLine(user1Choice + " " + user2Choice);
        }
    }
}
