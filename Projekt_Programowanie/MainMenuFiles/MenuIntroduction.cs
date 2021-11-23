using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;


namespace Projekt_Programowanie.MainMenuFiles
{
    public class MenuIntroduction : IDisplayMsg
    {

        /// <summary>
        /// string to show
        /// </summary>
        string msg = "PROGRAM PREZENTUJĄCY METODĘ SORTOWANIA BĄBELKOWEGO";

        /// <summary>
        /// Displays Menu Itroduction string 
        /// </summary>
        public void DisplayMsg()
        {
            Console.WriteLine(msg);
        }
    }
}
