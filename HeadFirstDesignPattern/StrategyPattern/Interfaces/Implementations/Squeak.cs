using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.Interfaces.Implementations
{
    public class SqueakSound : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
