using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(" -- Rock Paper Scissors Lizard Spock -- \r\n");
            Console.WriteLine("Proper syntax is as follows: 'rock','paper','scissors','lizard','spock','restart','quit'.\r\n");

            GameManager NewManager = new GameManager();
            NewManager.StartManager();
        }
    }

}
