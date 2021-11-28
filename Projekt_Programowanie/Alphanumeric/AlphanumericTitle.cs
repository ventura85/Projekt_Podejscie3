using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;


namespace Projekt_Programowanie.Alphanumeric
{
    public class AlphanumericTitle : IDisplayMsg
    {

        string msg = "*********** PREZENTACJA ALFANUMERYCZNA **********";
        public void DisplayMsg()
        {
            Console.WriteLine(msg);
        }
    }
}
