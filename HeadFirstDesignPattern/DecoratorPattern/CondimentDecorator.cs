﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.DecoratorPattern
{
    public abstract class CondimentDecorator: Beverage
    {
        protected Beverage Beverage;
        public override abstract string GetDescription();
    }
}
