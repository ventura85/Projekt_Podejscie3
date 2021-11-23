using System;
using System.Runtime.InteropServices;


namespace Projekt_Programowanie.RunApplication
{
    public static class ConsoleWindowSettings
    {
        public static void SetConsoleProperties()
        {

            #region System Properties
            Console.Title = "..::: SORTOWANIE BĄBELKOWE :::..";
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.SetWindowSize(100, 55);
                Console.SetBufferSize(100, 100);

                Console.CursorVisible = false;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Aplikacja Tylko na system Windows");
                Console.WriteLine("Aby kontynuować, naciśnij dowolny klawisz . . .");
                Console.ReadKey();
                Environment.Exit(0);
            }
            #endregion
        }
    }
}
