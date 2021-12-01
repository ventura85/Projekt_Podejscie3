using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;


namespace Projekt_Programowanie.Timing
{
    class TimingIntro : IDisplayMsg
    {

        string[] msg = {
            "\tPrezentacja czasu potrzebnego do posortowania",
                        "\ttablicy 5000 elementów nie powtarzających się."
        };

        public void DisplayMsg()
        {

            int xPos, yPos;
            (xPos, yPos) = Console.GetCursorPosition();

            foreach (var item in msg)
            {

                Console.SetCursorPosition(xPos, yPos);
                Console.WriteLine(item);
                yPos++;
            }
            
        }
    }
}
