using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class ComputerPlayer : Player
    {
        public int computerGesture;
        int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public override void ChooseGesture()
        {
            Console.WriteLine("Computer's turn.");
            Console.WriteLine("");
            computerGesture = RandomNumber(0, 5);
            gesture = Choices.choicesArray[computerGesture];
        }
    }
}
