
using Projekt_Programowanie.Alphanumeric.Visualisation_files;
using Projekt_Programowanie.Infrastructure;
using Projekt_Programowanie.MainMenuFiles;
using Projekt_Programowanie.UserInterfaceCommunication;
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
                    new AlphanumericVisualisation().StartPresentation(
                        new CreateCustomArray().CustomArray(
                            9,       //int[] size
                            () => new StringToIntConverter(),
                            0, 99    //range
                            ),
                        () => new AlgoritmScreenDisplay()
                        );

                    return false;
                   
                case ConsoleKey.N:
                    new AlphanumericVisualisation().StartPresentation(
                        new DefaultArray().Repository,
                           () => new AlgoritmScreenDisplay()
                           );

                    return false;                  
            }
            return true;
        }
    }
}
