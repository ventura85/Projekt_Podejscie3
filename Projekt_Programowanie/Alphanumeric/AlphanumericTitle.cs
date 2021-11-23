using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
