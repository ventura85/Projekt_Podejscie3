using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;

namespace Projekt_Programowanie.Timing
{
    class TimingTitle : IDisplayMsg
    {
        string msg = "*********** Porównanie czasów wykonywania algorytmu **********";
        public void DisplayMsg()
        {
            Console.WriteLine(msg);
        }
    }
}
