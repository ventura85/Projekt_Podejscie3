

using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;

namespace Projekt_Programowanie.GraphicRepresentation
{
    public class GraphicIntro : IDisplayMsg
    {
        /// <summary>
        /// string to show
        /// </summary>
        string msg = "PROGRAM PREZENTUJĄCY SORTOWANIE 40 ELEMENTÓW NIE POWTARZAJĄCYCH SIĘ";

        /// <summary>
        /// Displays Menu Itroduction string 
        /// </summary>
        public void DisplayMsg()
        {
            Console.WriteLine(msg);
        }
    }
}
