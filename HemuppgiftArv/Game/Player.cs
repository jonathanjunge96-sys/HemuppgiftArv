using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemuppgiftArv.Game
{
    public abstract class Player //skapa föräldraklass
    {
        public string UserId { get; set; }  //kräver namn från användare

        public Player(string userId) //konstruktor
        { 
            UserId = userId;    
        }
        public abstract int TakePins(Board board);//metod att overrida i subklasser
    }




}
