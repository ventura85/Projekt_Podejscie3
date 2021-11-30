using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;


namespace Projekt_Programowanie.GraphicRepresentation
{
    public class GraphicTitle : IDisplayMsg
    {
        string msg = "************ GRAFICZNY PRZEBIEG SORTOWANIA BĄBELKOWEGO ************";
        public void DisplayMsg()
        {
            Console.WriteLine(msg);
        }
    }
}
