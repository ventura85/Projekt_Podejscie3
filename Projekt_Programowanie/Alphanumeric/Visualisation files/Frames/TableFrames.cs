using System;

namespace Projekt_Programowanie.Alphanumeric.Visualisation_files.Frames
{
    public class TableFrames : ITableFrame
    {

        public void TableFameBottom(int length, int x, ref int y)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\u2514");

            for (int i = 0; i < length; i++)
            {

                Console.Write("\u2500");
            }

            Console.Write("\u2518");
            y++;
            Console.SetCursorPosition(x, y);
        }

        public void TableFameMid()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\u2502");
        }

        public void TableFameTop(int length, int x, ref int y)
        {

            Console.SetCursorPosition(x, y);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\u250c");

            for (int i = 0; i < length; i++)
            {

                Console.Write("\u2500");
            }

            Console.Write("\u2510");
            y++;
            Console.SetCursorPosition(x, y);
        }
    }
}
