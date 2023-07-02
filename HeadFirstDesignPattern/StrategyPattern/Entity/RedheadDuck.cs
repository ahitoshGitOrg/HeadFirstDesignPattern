using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.Entity
{
    public class RedheadDuck : Duck //,IFlyable,IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("I look like a Readhead Duck");
        }

        //public void Fly()
        //{
        //    Console.WriteLine("I am a flying readhead duck");
        //}

        //public void Quack()
        //{
        //    Console.WriteLine("I am a quacking readhead duck");
        //}
    }
}
