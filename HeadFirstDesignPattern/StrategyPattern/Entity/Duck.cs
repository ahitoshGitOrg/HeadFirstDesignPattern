using HeadFirstDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.Entity
{
    public abstract class Duck
    {
        protected IFlyBehaviour flyBehaviour;
        protected IQuackBehaviour quackBehaviour;
        public Duck()
        {

        }
        public abstract void Display();
        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
        public void PerfomFly()
        {
            flyBehaviour.Fly();
        }
        public void PerformQuack()
        {
            quackBehaviour.Quack();
        }
        public void SetDuckBehaviour(IFlyBehaviour fb)
        {
            flyBehaviour = fb;
        }
        public void SetQuackBehaviour(IQuackBehaviour qb)
        {
            quackBehaviour = qb;
        }
    }
}
