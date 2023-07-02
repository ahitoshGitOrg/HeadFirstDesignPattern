using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.DecoratorPattern
{
    public class SoyCondiment : CondimentDecorator
    {
        public SoyCondiment(Beverage beverage)
        {
            this.Beverage = beverage;
        }
        public override double Cost()
        {
            return Beverage.Cost() + 0.15;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Soy";
        }
    }
}
