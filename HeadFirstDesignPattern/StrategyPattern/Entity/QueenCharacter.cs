using HeadFirstDesignPattern.Interfaces.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.Entity
{
    internal class QueenCharacter : Character
    {
        public QueenCharacter()
        {
            weaponBehaviour = new KnifeBehaviour();
        }
        public override void fight()
        {
            Console.WriteLine("I am the Queen");
        }
    }
}
