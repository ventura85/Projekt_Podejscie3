using System;

namespace Projekt_Programowanie.UserInterfaceCommunication.Messages
{
    public class DisplayPressAnyKeyMsgFormatted
    {

        IDisplayMsg msg;
        public DisplayPressAnyKeyMsgFormatted(int xPos, int yPos, Func<IDisplayMsg> factoryFunc)
        {

            msg = factoryFunc();
            Console.SetCursorPosition(xPos, yPos);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            msg.DisplayMsg();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
