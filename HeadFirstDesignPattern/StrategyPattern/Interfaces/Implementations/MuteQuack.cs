using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadFirstDesignPattern.Interfaces;

namespace HeadFirstDesignPattern.Interfaces.Implementations
{
    internal class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Silence");
        }
    }
}
