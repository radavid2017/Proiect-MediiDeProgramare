using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic
{
    class Monster : Entity
    {
        private int attack_value;
        private int defense_value;
        private Item reward;

        public Monster(string monster_name, int att_val, int def_val, Item reward) : base(monster_name, entity_type.Monster)
        {
            attack_value = att_val;
            defense_value = def_val;
        }
    }
}
