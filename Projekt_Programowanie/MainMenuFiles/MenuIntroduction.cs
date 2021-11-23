using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie.MainMenuFiles
{
    public class MenuIntroduction : IDisplayMsg
    {
        string msg = "PROGRAM PREZENTUJĄCY METODĘ SORTOWANIA BĄBELKOWEGO";
        public void DisplayMsg()
        {
            Console.WriteLine(msg);
        }
    }
}
