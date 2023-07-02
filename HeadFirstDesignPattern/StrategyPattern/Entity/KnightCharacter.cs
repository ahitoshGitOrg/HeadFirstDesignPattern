using HeadFirstDesignPattern.Interfaces.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.Entity
{
    internal class KnightCharacter : Character
    {
        public KnightCharacter()
        {
            weaponBehaviour = new AxeBehaviour();
        }
        public override void fight()
        {
            Console.WriteLine("I am a Knight");
        }
    }
}
