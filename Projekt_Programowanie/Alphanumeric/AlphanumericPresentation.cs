using Projekt_Programowanie.Infrastructure;
using Projekt_Programowanie.MainMenuFiles;
using Projekt_Programowanie.UserInterfaceCommunication;
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

            int[] defaultRepository = new DefaultArray().Repository;
          
            for (int i = 0; i < defaultRepository.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(defaultRepository[i] + " ");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.SetCursorPosition(xPos, 15 );
            Console.Write("Czy chcesz zmienić liczby? T/N");
            ConsoleKey userChoice = Console.ReadKey(true).Key;
            Console.SetCursorPosition(xPos, 16);

            if (userChoice == ConsoleKey.T)
            {
                Console.Write("Podaj Liczbę: ");
                defaultRepository = new CreateCustomArray().CustomArray(
                    defaultRepository.Length, 
                    () => new StringToIntConverter(),
                    0, 99
                    );

                for (int i = 0; i < defaultRepository.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(defaultRepository[i] + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.ReadKey();
            }
            else if (userChoice == ConsoleKey.N)
            {
                Console.WriteLine("nie");
                Console.ReadKey();
            }
            else return true;
            return false;
        }
    }
}
