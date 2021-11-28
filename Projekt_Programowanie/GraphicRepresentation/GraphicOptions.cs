using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;


namespace Projekt_Programowanie.GraphicRepresentation
{
    public class GraphicOptions : IDisplayMsg
    {
        /// <summary>
        /// String To Show
        /// </summary>
        string[] messeges = {
            "\t\tCzy chcesz zmienić wielkość tablicy?",
            "T - Tak / N - Nie"          
        };

        /// <summary>
        /// Display Menu Options
        /// </summary>
        public void DisplayMsg()
        {
            int x, y;
            (x, y) = Console.GetCursorPosition();
            for (int i = 0; i < messeges.Length; i++)
            {

                y++;
                Console.SetCursorPosition(x, y);
                Console.WriteLine(messeges[i]);
            }
            Console.SetCursorPosition(x, y + 1);
        }
    }
}
