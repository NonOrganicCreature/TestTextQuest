using System;
using System.Collections.Generic;
using Test1.Dialog;
using Test1.DialogActions;
using Test1.Inventory;
using Test1.Characters;
using Test1.Resources;
using Test1.Room;

namespace Test1
{
    public class GameState
    {
        private List<IRoom> _rooms = new List<IRoom>();
        private IRoom _currentRoom = null;
        private ICharacter _player;
        
        public void Initialize()
        {
            _player = new BaseCharacter(
                new CharacterInventory(),
                CharacterEntity.Player
            );
            
            var vagabondInventory = new CharacterInventory();
            vagabondInventory.AddItem(new Item(ItemID.Money, Constants.VAGABOND_MONEYS_ROAD));
            vagabondInventory.AddItem(new Item(ItemID.Accessory, Constants.VAGABOND_ACCESSORY_ROAD));
            
            var npcs = new List<ICharacter>();

            var vagabond = new BaseCharacter(
                vagabondInventory,
                CharacterEntity.Vagabond
            );
            
            npcs.Add(vagabond);
            
            var dialogs = new List<RoomDialog>();
            
            var firstDialog = new RoomDialog(
                Constants.DIALOG_TEXT_ROAD_VAGABOND,
                DialogActionsLogic.VAGABOND_ROAD_TALK(vagabond, _player)
            );
            
            var secondDialog = new RoomDialog(
                Constants.DIALOG_TEXT_ROAD_ENVIRONMENT,
                DialogActionsLogic.ENVIRONMENT_ROAD_LOOKUP()
            );
            
            dialogs.Add(firstDialog);
            dialogs.Add(secondDialog);
            
            _rooms.Add(new BaseRoom(
                RoomType.Road,
                npcs,
                dialogs
            ));
        }

        public void LaunchGameLoop()
        {
            while (true)
            {
               
                if (_currentRoom == null)
                {
                    var roomIndex = 0;
                    Console.WriteLine("Комнаты, куда можно переместиться: ");
                    
                    foreach (var room in _rooms)
                    {
                        Console.WriteLine("{0}. {1}.\n", roomIndex + 1, room.RoomType.ToString());
                        roomIndex += 1;
                    }
                    
                    Console.WriteLine("Введите номер комнаты: ");
                    
                    var roomNumber = int.Parse(Console.ReadLine());
                    _currentRoom = _rooms[roomNumber - 1];
                    Console.Clear();
                }
                else
                {
                    var roomDialogs = _currentRoom.Dialogs;
                    var dialogIndex = 0;
                    foreach (var dialog in roomDialogs)
                    {
                        Console.WriteLine("{0}. {1}", dialogIndex + 1, dialog.DialogText);
                        dialogIndex += 1;
                    }
                    
                    Console.WriteLine("Введите номер действия: ");
                    var dialogNumber = int.Parse(Console.ReadLine());
                    
                    Console.Clear();
                    _currentRoom.Dialogs[dialogNumber - 1].Action();
                    Console.WriteLine();
                }
            }
        }
    }
}