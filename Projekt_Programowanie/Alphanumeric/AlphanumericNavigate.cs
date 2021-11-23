
using Projekt_Programowanie.MainMenuFiles;
using System;

namespace Projekt_Programowanie.Alphanumeric
{
    public class AlphanumericNavigate : INavigationSender
    {
        public bool NavigateTo(ConsoleKey userChoice)
        {

            switch (userChoice)
            {

                case ConsoleKey.T:
                    return true;
                   
                case ConsoleKey.N:
                    return false;                  
            }
            return true;
        }
    }
}
