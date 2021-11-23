using System;

namespace Projekt_Programowanie.UserInterfaceCommunication.Messages
{
    public class DisplayPressAnyKeyMsgFormatted
    {

        IDisplayMsg msg;

        /// <summary>
        /// Display On Screen Formatted String using localisation and Colors
        /// </summary>
        /// <param name="xPos"></param>
        /// <param name="yPos"></param>
        /// <param name="factoryFunc"></param>
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
