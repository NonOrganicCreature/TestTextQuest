namespace Test1.Inventory
{
    public interface IInventory
    {
        void AddItem(Item item);
        Item GetItemByID(ItemID id);
    }
}