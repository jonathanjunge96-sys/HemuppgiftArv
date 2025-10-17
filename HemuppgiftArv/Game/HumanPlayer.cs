using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemuppgiftArv.Game
{
    public class HumanPlayer : Player //ärver från basklass
    {
        public HumanPlayer(string userId)
            : base(userId) { }

        public override int TakePins(Board board)
        {
            int pins;

            while (true)
            {
                Console.WriteLine($"{UserId}, hur många stickor vill du ta? (1 eller 2)");
                string input = Console.ReadLine();

                try
                {
                    if (int.TryParse(input, out pins) && (pins == 1 || pins == 2)) //omvandlar och returnerar om inga fel i input
                    {
                        return pins;
                    }

                    Console.WriteLine("Ogiltigt värde. Endast siffrorna 1 och 2 är giltiga.");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Fel vid inmatning: {e.Message}"); //implementerat try catch för att undvika krasch
                }

                
            }
        }
    }


}
