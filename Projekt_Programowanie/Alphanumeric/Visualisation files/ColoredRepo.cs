

using System;

namespace Projekt_Programowanie.Alphanumeric.Visualisation_files
{
    public class ColoredRepo
    {

        public void DisplayColoredRepo(
            int[] repo, int i, ref int y, 
            ConsoleColor color1 = ConsoleColor.Blue, 
            ConsoleColor color2 = ConsoleColor.Red, 
            ConsoleColor color3 = ConsoleColor.Gray )
        {
           
            Console.ForegroundColor = color1;
        
            for (int k = 0; k < i; k++)
            {
                Console.Write(repo[k] + " ");
            }

            //change font color to Red when was swap, or blue when there was no swap
            Console.ForegroundColor = color2;
            Console.Write(repo[i] + " " + repo[i + 1] + " ");

            //change font color to Gray and show values bigger than i+2
            Console.ForegroundColor = color3;
            for (int k = i + 2; k < repo.Length; k++)
            {
                Console.Write(repo[k] + " ");
            }
            
            y++;
           
        }
    }
}
