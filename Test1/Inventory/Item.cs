namespace Test1.Inventory
{
    public class Item
    {
        public ItemID ItemId { get; }
        public int Amount { get; set; }

        public Item(ItemID itemId, int amount)
        {
            ItemId = itemId;
            Amount = amount;
        }
    }
}