using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;

namespace Projekt_Programowanie.Alphanumeric
{
    public class AlphanumericOptions : IDisplayMsg
    {

        string[] messeges = {
                "* Sortowanie bąbelkowe - wersja 1",
                "* Sortowanie bąbelkowe - wersja 2",
                "* Sortowanie bąbelkowe - wersja 3",
                "* Sortowanie bąbelkowe - wersja 4 - wersja zoptymalizowana",
                "* Sortowanie bąbelkowe - wersja 5 - dwukierunkowa",
                " ",
                "Każde sortowanie zostało przeprowadzone na podstawie tych samych",
                "dziewięciu przykładowych liczb: "
        };
        public void DisplayMsg()
        {
            int x, y;
            (x, y) = Console.GetCursorPosition();
            for (int i = 0; i < messeges.Length; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write(messeges[i]);
            }
        }
    }
}
