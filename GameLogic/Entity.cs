using System;

namespace GameLogic
{
    public abstract class Entity
    {
        public enum entity_type
        {
            Player,
            Monster,
            Object
        }

        private string name;

        private entity_type type;

        public Entity(string entity_name, entity_type type_of_entity)
        {
            name = entity_name;
            type = type_of_entity;
        }

        public string GetName()
        {
            return name;
        }

        public new entity_type GetType()
        {
            return type;
        }

        public void SetName(string newName)
        {
            name = newName;
        }

        public void SetType(entity_type newEntityType)
        {
            type = newEntityType;
        }
    }
}
