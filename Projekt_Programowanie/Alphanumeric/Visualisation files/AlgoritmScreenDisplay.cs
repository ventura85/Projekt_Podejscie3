using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie.Alphanumeric.Visualisation_files
{
    public class AlgoritmScreenDisplay : IScreenDisplay
    {

        int xPos = 25, yPos = 0; 
        public void Show(Func<IDisplayMsg> factoryTitle, string text, AlghoritmVersion alghoritmVersion )
        {

            var title = factoryTitle();

            Console.SetCursorPosition(xPos, yPos);
            title.DisplayMsg();
           
            Console.SetCursorPosition(xPos, yPos+1);
            Console.Write(text);
           
            Console.SetCursorPosition(0, yPos+2);

          
            alghoritmVersion.DisplayAlghoritmPresentation();
        }
    }
}
