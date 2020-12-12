using System;
using Test1.Actions;
using Test1.Inventory;
using Test1.Characters;

namespace Test1.DialogActions
{
    public static class DialogActionsLogic
    {
        public static Action VAGABOND_ROAD_TALK(ICharacter vagabond, ICharacter player)
        {
            return () =>
            {
                if (vagabond.Inventory.GetItemByID(ItemID.Money).Amount < 50)
                {
                    Console.WriteLine("Бродяга молчит...");
                    return;
                }
                InventoryActions.TransferItem(vagabond, player, 50, ItemID.Money);
                InventoryActions.TransferItem(vagabond, player, 1, ItemID.Accessory);
                Console.WriteLine("Вы получили 50 монет и медальон...");
            };
        }

        public static Action ENVIRONMENT_ROAD_LOOKUP()
        {
            return () =>
            {
                EnvironmentActions.EnvironmentLookup();
                Console.WriteLine("Вы осматриваете окрестности...");
            };
        }
    }
}