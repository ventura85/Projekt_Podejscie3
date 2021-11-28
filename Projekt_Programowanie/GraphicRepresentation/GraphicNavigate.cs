using Projekt_Programowanie.MainMenuFiles;
using Projekt_Programowanie.UserInterfaceCommunication;
using System;


namespace Projekt_Programowanie.GraphicRepresentation
{
    public class GraphicNavigate : INavigationSender
    {
        public bool NavigateTo(ConsoleKey userChoice)
        {

            int xPos, yPos;
            (xPos, yPos) = Console.GetCursorPosition();
            yPos++;

            switch (userChoice)
            {
                case ConsoleKey.T:

                    Console.SetCursorPosition(xPos, yPos);
                    Console.Write("Podaj ilość liczb od 2 do 40: ");

                    (xPos, yPos) = Console.GetCursorPosition();
                    new GraphicVisualizer().show(
                        new StringToIntConverter().ConvertStringToInt(
                            Console.ReadLine(),
                            xPos, yPos,
                            2, 40
                            ),
                       () => new graphBar());

                    Console.ReadKey();
                    return false;

                case ConsoleKey.N:
                   
                    new GraphicVisualizer().show(
                        40,
                       () => new graphBar());
                    return false;
            }

            return true;
        }
    }
}
