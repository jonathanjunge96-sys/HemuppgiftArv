using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HemuppgiftArv.Game
{
    public class Board
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
            if (pinsTaken > noPins)
            {
                Console.WriteLine("Det finns inte så många stickor kvar!"); 
                return;
            }

            noPins -= pinsTaken; //Tar bort pins från räknare

        }

        public int GetNoPins() //returnerar antal kvarvarande pins
        {  
            return noPins; 
        }  
    }
}

           

            
            
        
        


