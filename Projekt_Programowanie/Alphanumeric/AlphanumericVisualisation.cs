using Projekt_Programowanie.Alphanumeric.Visualisation_files;
using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;

namespace Projekt_Programowanie.Alphanumeric
{
    public class AlphanumericVisualisation
    {

        ConsoleKey userChoice;
        int version = 1;
        public void StartPresentation(int[] repository, Func<IScreenDisplay> alghoritmPresentation)
        {

            var presentation = alghoritmPresentation();
            do
            {
                
                Console.Clear();

                new DisplayPressAnyKeyMsgFormatted(25, 53, () => new PressArrowsMsg());

                presentation.Show(
                     () => new AlphanumericTitle(),
                     $"\tSortowanie Bąbelkowe Wersja {version}",
                     new AlghoritmVersionFactory().Factory(version, repository)
                     );

                userChoice = Console.ReadKey().Key;
                switch (userChoice)
                {

                    case ConsoleKey.RightArrow:
                        version++;
                        break;

                    case ConsoleKey.LeftArrow:
                        if (version == 1) version = 1;
                        else version--;
                        break;
                }

                
            } while (version != 6);

        }
    }
}
