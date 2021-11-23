using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie.UserInterfaceCommunication.Messages
{
    public class PressArrowsMsg :IDisplayMsg
    {

        /// <summary>
        /// String with information about pressing any key 
        /// </summary>
        string msg = "Użyj klawiszy kursora <- Lewo, Prawo -> aby zmieniać strony";

        /// <summary>
        /// Displays Press arrows to navigate
        /// </summary>
        public void DisplayMsg()
        {

            Console.WriteLine(msg);
        }
    }
}

