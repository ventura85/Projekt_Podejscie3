using Projekt_Programowanie.Infrastructure;
using Projekt_Programowanie.MainMenuFiles;
using System;

namespace Projekt_Programowanie.Alphanumeric
{
    public class AlphanumericPresentation : ICategoryContent
    {

        int xPos = 25;
        public bool CategoryContent(Func<ICategoryInfo> contentFactory, Func<INavigationSender> navigateFactory)
        {

            var menu = contentFactory();
            var navigate = navigateFactory();
            Console.Clear();

            menu.ShowMenuContent(
            xPos,
            () => new AlphanumericTitle(),
            () => new AlphanumericIntroduction(),
            () => new AlphanumericOptions());

            //Create default repository so we can display default numbers stored in array
            int[] defaultRepository = new DefaultArray().Repository;
          
            //Display array using colors
            for (int i = 0; i < defaultRepository.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(defaultRepository[i] + " ");
                Console.ForegroundColor = ConsoleColor.White;
            }

            //Ask user if he want to chenge repository numbers
            Console.SetCursorPosition(xPos, 15 );
            Console.Write("Czy chcesz zmienić liczby? T/N");         
            Console.SetCursorPosition(xPos, 16);
            
            //Takie user to specific localisation, in this case it switch to New Array Creator or to StartVisualisation
            return navigate.NavigateTo(Console.ReadKey(true).Key);
        }
    }
}
