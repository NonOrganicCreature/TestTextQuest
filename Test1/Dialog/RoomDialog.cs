using System;

namespace Test1.Dialog
{
    public class RoomDialog
    {
        public string DialogText { get; }
        public Action Action { get; }
        
        public RoomDialog(string dialogText, Action action)
        {
            this.DialogText = dialogText;
            this.Action = action;
        }
    }
}