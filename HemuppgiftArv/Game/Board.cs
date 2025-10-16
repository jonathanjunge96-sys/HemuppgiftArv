using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemuppgiftArv.Game
{
    internal class Board
    {
        private int noPins; //räknare

        public void SetUp() //sätter antal stickor mellan 1-30
        {
            Random rnd = new Random();
            noPins = rnd.Next(1, 30);
        }

            

        public void TakePins(int pinsTaken) 
        {
            if (pinsTaken < 1 || pinsTaken > 2) //felhantering
            {
                Console.WriteLine("Du måste ta en eller två stickor!");
                return;
            }
            if (pinsTaken < noPins)

        }
            
            
        
        


    }
}
