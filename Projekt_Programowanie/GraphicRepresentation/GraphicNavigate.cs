using Projekt_Programowanie.MainMenuFiles;
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
                    Console.WriteLine("Podaj ilość liczb od 2 do 40");
                    Console.ReadKey();
                    return false;

                case ConsoleKey.N:

                    return false;
            }

            return true;
        }
    }
}
