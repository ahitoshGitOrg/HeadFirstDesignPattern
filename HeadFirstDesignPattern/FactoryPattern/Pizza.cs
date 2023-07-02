﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.FactoryPattern
{
    public abstract class Pizza
    {
        public void Prepare() { }
        public void Bake() { }
        public void Cut() { }
        public void Box() { }
    }
}
