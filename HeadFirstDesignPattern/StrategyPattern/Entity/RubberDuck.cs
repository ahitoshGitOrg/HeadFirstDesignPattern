using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.Entity
{
    public class RubberDuck : Duck//,IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("I am a Rubber Duck");
        }

        //public void Quack()
        //{
        //    Console.WriteLine("I am a Rubber Duck that can Sqeak");
        //}
    }
}
