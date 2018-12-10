using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player : Game
    {
        public Player(bool versusAI)
        {
            this.versusAI = versusAI;
        }

        public void Play()
        {
            if (!versusAI)
            {
                HumanPlayer Humans = new HumanPlayer(versusAI);
                Humans.PlayerChoice();
            }
            else if (versusAI)
            {
                ComputerPlayer HumanAndComp = new ComputerPlayer(versusAI);
                HumanAndComp.PlayerChoice();
            }
        }
    }
        
}
