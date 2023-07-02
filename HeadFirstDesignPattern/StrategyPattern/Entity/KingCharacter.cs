using HeadFirstDesignPattern.Interfaces.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.Entity
{
    internal class KingCharacter : Character
    {
        public KingCharacter()
        {
            weaponBehaviour = new SwordBehaviour();
        }
        public override void fight()
        {
            Console.WriteLine("I am the King");
        }
    }
}
