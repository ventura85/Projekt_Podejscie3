using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;

namespace Projekt_Programowanie.MainMenuFiles
{
    public  class MenuTitle : IDisplayMsg
    {

        string title = "************** SORTOWANIE BĄBELKOWE **************";

        /// <summary>
        /// Dispplay Menu Title 
        /// </summary>
        public void DisplayMsg()
        {
            Console.WriteLine(title);
        }
    }
}
