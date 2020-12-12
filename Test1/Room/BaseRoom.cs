using System.Collections.Generic;
using Test1.Dialog;
using Test1.Characters;

namespace Test1.Room
{
    public class BaseRoom : IRoom
    {
        public RoomType RoomType { get; }
        public List<ICharacter> ListCharacters { get; }
        public List<RoomDialog> Dialogs { get; }

        public BaseRoom(
            RoomType roomType, 
            List<ICharacter> listNpc, 
            List<RoomDialog> dialogs
        )
        {
            RoomType = roomType;
            ListCharacters = listNpc;
            Dialogs = dialogs;
        }
    }
}