using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.DecoratorPattern
{
    public class MilkCondiment : CondimentDecorator
    {
        public MilkCondiment(Beverage beverage)
        {
            this.Beverage = beverage;
        }
        public override double Cost()
        {
            return Beverage.Cost() + 0.10;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + "Milk";
        }
    }
}
