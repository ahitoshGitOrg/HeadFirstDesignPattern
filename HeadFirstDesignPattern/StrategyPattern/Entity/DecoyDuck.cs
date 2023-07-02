using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.Entity
{
    internal class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I look like a decoy duck");
        }
    }
}
