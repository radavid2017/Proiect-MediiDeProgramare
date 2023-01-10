using System;
using System.Collections.Generic;
using System.Text;

namespace GameLogic
{
    public abstract class Item
    {
        public enum item_type
        {
            Weapon,
            Shield
        }

        private string name;

        private item_type type;

        public Item(string item_name, item_type type_of_item)
        {
            name = item_name;
            type = type_of_item;
        }

        public virtual string getName()
        {
            return name;
        }

        public string GetName()
        {
            return name;
        }

        public new item_type GetType()
        {
            return type;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public void SetType(item_type newType)
        {
            type = newType;
        }
    }
}
