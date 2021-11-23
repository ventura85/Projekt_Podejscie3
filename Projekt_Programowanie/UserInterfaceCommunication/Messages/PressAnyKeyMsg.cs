using System;


namespace Projekt_Programowanie.UserInterfaceCommunication.Messages
{
    public class PressAnyKeyMsg : IDisplayMsg
    {

        string msg = "Aby kontynuować, naciśnij dowolny klawisz . . .";
        public void DisplayMsg()
        {

            Console.WriteLine(msg);
        }
    }
}
