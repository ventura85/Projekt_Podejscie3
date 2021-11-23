using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;

namespace Projekt_Programowanie.MainMenuFiles
{
    public class MenuOptions : IDisplayMsg
    {
        string[] messeges = {
            "\t\t..::: MENU:::..",
            "1. Prezentacja Alfanumeryczna",
            "2. Prezentacja Graficzna",
            "3. Analiza Czasów Sortowania",
            "0. Zakończenie programu"
        };
        public void DisplayMsg()
        {
            int x, y;
            (x,y) = Console.GetCursorPosition();
            for (int i = 0; i < messeges.Length; i++)
            {
                Console.SetCursorPosition(x, y+i);
                Console.WriteLine(messeges[i]);
            }
        }
    }
}
