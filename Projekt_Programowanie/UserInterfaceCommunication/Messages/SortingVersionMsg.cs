

using System;

namespace Projekt_Programowanie.UserInterfaceCommunication.Messages
{
    public class SortingVersionMsg : IDisplayMsg
    {

        string msg = "\t Sortowanie Bąbelkowe Wersja";
        public void DisplayMsg()
        {
            Console.Write(msg);
        }
    }
}
