using System.Collections.Generic;
using Test1.Inventory;

namespace Test1.Characters
{
    public interface ICharacter
    {
        IInventory Inventory { get; }

        CharacterEntity CharacterEntity { get; }
    }
}