using System.Collections.Generic;
using Test1.Inventory;

namespace Test1.Characters
{
    public class BaseCharacter : ICharacter
    {
        public IInventory Inventory { get; }
        public CharacterEntity CharacterEntity { get; }

        public BaseCharacter(
            IInventory inventory,
            CharacterEntity characterEntity
        )
        {
            this.Inventory = inventory;
            this.CharacterEntity = characterEntity;
        }
        
    }
}