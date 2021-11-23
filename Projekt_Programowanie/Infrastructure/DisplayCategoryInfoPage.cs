using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;

namespace Projekt_Programowanie.MainMenuFiles
{
    public class DisplayCategoryInfoPage : ICategoryInfo
    {

        int yPos = 0;
        public DisplayCategoryInfoPage ShowMenuContent(int xPos, Func<IDisplayMsg> titleFactory, Func<IDisplayMsg> introFactory, Func<IDisplayMsg> optionsFactory)
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
           
            return new DisplayCategoryInfoPage();
        }
    }
}
