using HeadFirstDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstDesignPattern.Entity
{
    public abstract class Character
    {
        protected IWeaponBehaviour weaponBehaviour;
        public Character()
        {

        }
        public abstract void fight();
        public void SetWeapon(IWeaponBehaviour weapon)
        {
            this.weaponBehaviour = weapon;
        }
        public void UseWeapon()
        {
            weaponBehaviour.UseWeapon();
        }
    }
}
