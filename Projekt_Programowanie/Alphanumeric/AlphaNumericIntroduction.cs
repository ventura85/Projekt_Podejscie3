using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie.Alphanumeric
{
    class AlphanumericIntroduction : IDisplayMsg
    {
        string msg = "Program prezentuje przebieg sortowania bąbelkowego w wersjach od 1 do 5";
        public void DisplayMsg()
        {
            Console.WriteLine(msg);
        }
    }
}
