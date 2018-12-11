using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class HumanPlayer : Player
    {
        public override void ChooseGesture()
        {
            Console.WriteLine("Player "+playerId+"'s turn.");
            gesture = Console.ReadLine();
        }
    }
}
