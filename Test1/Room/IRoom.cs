using System.Collections.Generic;
using Test1.Dialog;
using Test1.Characters;

namespace Test1.Room
{
    public interface IRoom
    {
        RoomType RoomType { get; }
        List<ICharacter> ListCharacters { get; }
        
        List<RoomDialog> Dialogs { get; }
    }
}