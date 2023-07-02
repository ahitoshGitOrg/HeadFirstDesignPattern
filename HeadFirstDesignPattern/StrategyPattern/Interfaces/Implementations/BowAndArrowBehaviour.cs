﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.Interfaces.Implementations
{
    internal class BowAndArrowBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("I am using Bow and arrow");
        }
    }
}
