using HeadFirstDesignPattern.Interfaces.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.Entity
{
    public class MallardDuck : Duck //,IFlyable,IQuackable
    {
        public MallardDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new QuackSound();
        }
        public override void Display()
        {
            Console.WriteLine("I am a real Mallard Duck");
        }

        //public void Fly()
        //{
        //    Console.WriteLine("I am a flying Mallard duck");
        //}

        //public void Quack()
        //{
        //    Console.WriteLine("I am a quacking mallard duck");
        //}
    }
}
