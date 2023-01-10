using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic
{
    class Player : Entity
    {
        private Weapon weapon;
        private Shield shield;
        private string attack_value;
        private string defense_value;

        public Player(string player_name, Weapon player_weapon,
            Shield player_shield)
            : base(player_name, entity_type.Player)
        {
            weapon = player_weapon;
            shield = player_shield;
        }

        public Weapon GetWeapon()
        {
            return weapon;
        }

        public Shield GetShield()
        {
            return shield;
        }

        public string GetAttackValue()
        {
            return attack_value;
        }

        public string GetDefenseValue()
        {
            return defense_value;
        }

        public void SetWeapon(Weapon newWeapon)
        {
            weapon = newWeapon;
        }

        public void SetShield(Shield newShield)
        {
            shield = newShield;
        }
    }
}
