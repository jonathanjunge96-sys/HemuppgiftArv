using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemuppgiftArv.Game
{
    internal class ComputerPlayer : Player
    {
        private Random rnd = new Random();  //deklarerar randomgenerator
        public ComputerPlayer (string userId) //ärver från basklass player
            : base (userId) { }
        public override int TakePins(Board board) //skriver över resultat i board
        {
            int pins = rnd.Next(1, 3); //generatorn sätts i arbete(bara 1 och 2 gilitiga)
            Console.WriteLine($"{UserId} tar {pins} stickor.");
            return pins; //returnerar värde till pins
        }

    }
}
