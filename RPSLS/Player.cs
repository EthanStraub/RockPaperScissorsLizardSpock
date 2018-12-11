using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {

        public int score;
        public string gesture;
        public int playerId;
        
        public Player()
        {
            score = 0;
            gesture = "";
            playerId = 0;
        }

        public abstract void ChooseGesture();
    }        
}
