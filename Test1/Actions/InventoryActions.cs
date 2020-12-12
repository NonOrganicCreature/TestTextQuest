using Test1.Inventory;
using Test1.Characters;
using Test1.Room;

namespace Test1.Actions
{
    public class InventoryActions
    {
       
        public static void TransferItem(ICharacter from, ICharacter to, int amount, ItemID id)
        {
            from.Inventory.GetItemByID(id).Amount -= amount;
            
            if (to.Inventory.GetItemByID(id) != null)
            {
                to.Inventory.GetItemByID(id).Amount += amount;
            }
            else
            {
                to.Inventory.AddItem(new Item(id, amount));
            }
        }
    }
}