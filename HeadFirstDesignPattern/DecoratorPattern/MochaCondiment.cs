using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.DecoratorPattern
{
    public class MochaCondiment : CondimentDecorator
    {
        public MochaCondiment(Beverage beverage)
        {
            this.Beverage = beverage;
        }
        public override double Cost()
        {
            return Beverage.Cost() + 0.20;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Mocha";
        }
    }
}
