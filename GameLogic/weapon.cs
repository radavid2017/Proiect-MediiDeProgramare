using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic
{
    public class Weapon : Item
    {

        private int damage;

        public Weapon(string weapon_name, int weapon_damage) : base(weapon_name, item_type.Weapon)
        {
            damage = weapon_damage;
        }

        public int GetDamage()
        {
            return damage; 
        }


        public void SetDamage(int newDamage)
        {
            damage = newDamage;
        }
    }
}
