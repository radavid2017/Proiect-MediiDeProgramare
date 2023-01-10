using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic
{
    public class Shield : Item
    {
        private int defense;

        public Shield(string shield_name, int shield_defense) : base(shield_name, item_type.Weapon)
        {
            defense = shield_defense;
        }

        public int GetDefense()
        {
            return defense;
        }

        public void SetDefense(int newDefense)
        {
            defense = newDefense;
        }
    }
}
