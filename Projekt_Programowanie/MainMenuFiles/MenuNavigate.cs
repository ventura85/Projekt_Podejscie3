using Projekt_Programowanie.Alphanumeric;
using Projekt_Programowanie.GraphicRepresentation;
using System;

namespace Projekt_Programowanie.MainMenuFiles
{
    public class MenuNavigate : INavigationSender
    {
        /// <summary>
        /// Takes to the specific localisation from menu to content  
        /// </summary>
        /// <param name="userChoice"></param>
        /// <returns></returns>
        public bool NavigateTo(ConsoleKey userChoice)
        {
             
            switch (userChoice)
            {
             
                    // Go to Alphanumeric Presentation by choosing 1 key
                case ConsoleKey.D1:
                    while(
                        new AlphanumericPresentation().CategoryContent( 
                         () => new DisplayCategoryInfoPage(),
                          () => new AlphanumericNavigate()
                          ));
                    break;

                     // Go to Graphic Presentation by choosing 2 key
                case ConsoleKey.D2:
                    while (
                        new GraphicPresentation().CategoryContent(
                         () => new DisplayCategoryInfoPage(),
                          () => new GraphicNavigate()
                          )) ;
                    break;
                    break;

                    // Go to by Time Span by choosing 3 key
                case ConsoleKey.D3:
                   
                    break;

                    //Pressing key 0 Ends Aplication
                case ConsoleKey.D0:

                    return false;
            }

            return true;
        }
    }
}
