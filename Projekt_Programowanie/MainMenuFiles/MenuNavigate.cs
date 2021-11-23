using Projekt_Programowanie.Alphanumeric;
using System;

namespace Projekt_Programowanie.MainMenuFiles
{
    public class MenuNavigate : INavigationSender
    {
        public bool NavigateTo(ConsoleKey userChoice)
        {
             
            switch (userChoice)
            {
             
                case ConsoleKey.D1:
                    while(
                        new AlphanumericPresentation().CategoryContent(
                     () => new DisplayCategoryInfoPage(),
                     () => new AlphanumericNavigate()
                     ));
                    break;
                case ConsoleKey.D2:

                    break;
                case ConsoleKey.D3:

                    break;
                case ConsoleKey.D0:

                    return false;
            }

            return true;
        }
    }
}
