using System;


namespace Projekt_Programowanie.UserInterfaceCommunication.Messages
{
    public class PressAnyKeyMsg : IDisplayMsg
    {

        /// <summary>
        /// String with information about pressing any key 
        /// </summary>
        string msg = "Aby kontynuować, naciśnij dowolny klawisz . . .";

        /// <summary>
        /// Displays Press Any Key To Continue....
        /// </summary>
        public void DisplayMsg()
        {

            Console.WriteLine(msg);
        }
    }
}
