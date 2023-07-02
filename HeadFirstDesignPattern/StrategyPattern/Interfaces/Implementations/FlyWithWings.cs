using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.Interfaces.Implementations
{
    internal class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I Fly with wings");
        }
    }
}
