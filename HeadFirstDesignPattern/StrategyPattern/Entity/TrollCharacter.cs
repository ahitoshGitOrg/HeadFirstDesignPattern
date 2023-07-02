using HeadFirstDesignPattern.Interfaces.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.Entity
{
    internal class TrollCharacter : Character
    {
        public TrollCharacter()
        {
            weaponBehaviour = new BowAndArrowBehaviour();
        }
        public override void fight()
        {
            Console.WriteLine("I am a Troll");
        }
    }
}
