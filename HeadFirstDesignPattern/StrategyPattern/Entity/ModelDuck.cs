using HeadFirstDesignPattern.Interfaces.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.Entity
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackBehaviour=new QuackSound();
        }
        public override void Display()
        {
            Console.WriteLine("I am a model duck");
        }
    }
}
