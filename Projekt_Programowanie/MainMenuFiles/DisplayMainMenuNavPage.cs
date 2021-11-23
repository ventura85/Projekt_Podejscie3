using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;

namespace Projekt_Programowanie.MainMenuFiles
{
    public class DisplayMainMenuNavPage : IMenu
    {
        int yPos = 0;
        public DisplayMainMenuNavPage ShowMenuContent(int xPos, Func<MenuTitle> titleFactory, Func<MenuIntroduction> introFactory, Func<MenuOptions> optionsFactory)
        {

            var title = titleFactory();
            var intro = introFactory();
            var options = optionsFactory();
           
            //Title Position
            Console.SetCursorPosition(xPos, yPos);
            title.DisplayMsg();
            yPos++;

            //Introduction Position
            Console.SetCursorPosition(xPos, yPos);
            intro.DisplayMsg();
            yPos += 5;

            //Introduction Options
            Console.SetCursorPosition(xPos, yPos);
            options.DisplayMsg();

            new DisplayPressAnyKeyMsgFormatted(25, 40, () => new PressAnyKeyMsg());
            Console.ReadKey(true);
            return new DisplayMainMenuNavPage();
        }
    }
}
