using System.Collections.Generic;

namespace Test1.Inventory
{
    public class CharacterInventory : IInventory
    {
        private List<Item> _items;

        public CharacterInventory()
        {
            _items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public Item GetItemByID(ItemID id)
        {
            return _items.Find(item => item.ItemId == id);
        }
    }
}