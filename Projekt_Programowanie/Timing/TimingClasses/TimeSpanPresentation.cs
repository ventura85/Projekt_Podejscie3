using Projekt_Programowanie.Infrastructure;
using System;
using Projekt_Programowanie.Extensions;

namespace Projekt_Programowanie.Timing.TimingClasses
{

    public enum FontColors
    {
        DarkRed = 0,
        Red = 1,
        DarkYellow =2,
        Yellow = 3,
        Green = 4,
        Black = 10,
        white = 11
    }
    public class TimeSpanPresentation
    {

        int xPos= 25, yPos = 8;

       
        public void ShowResult()
        {

          

            CheckTime[] alghoritmRepo = new CheckTime[5];

            int[] repo = new int[5000];
            DrawRandomNumbers.DrawNumbers(repo);
          

            for (int i = 1; i <= 5; i++)
            {

                alghoritmRepo[i - 1] = new CheckTime(new AlghoritmFactory().
                                                            AlghoritmFactoryResult(i),
                                                            $"{i}",
                                                            repo);
            }

            for (int j = alghoritmRepo.Length - 1; j > 0; j--)
                for (int i = 0; i < j; i++)
                    if (alghoritmRepo[i].TimeSpanResult > alghoritmRepo[i + 1].TimeSpanResult) 
                        (alghoritmRepo[i], alghoritmRepo[i+1]) = (alghoritmRepo[i+1], alghoritmRepo[i]);

            Array.Reverse(alghoritmRepo);

            for (int i = 0; i < alghoritmRepo.Length; i++)
            {

                var currentColor = Enum.GetName(typeof(FontColors), i);
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), currentColor, true);
                Console.SetCursorPosition(xPos, yPos);
                Console.WriteLine(alghoritmRepo[i].Title + " " + alghoritmRepo[i].TimeSpanResult);
                Console.WriteLine();
                yPos++;
            }


            Console.ReadKey();
        }

        
    }
}
