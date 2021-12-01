using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie.Timing
{
    public class TimingOptions : IDisplayMsg
    {

        string msg = "Tworze tablicę i sprawdzam czasy. Może to zająć chwilę.";
        public void DisplayMsg()
        {
            Console.WriteLine(msg);
        }
    }
}
