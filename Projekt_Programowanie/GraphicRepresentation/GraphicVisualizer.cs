using Projekt_Programowanie.Extensions;
using Projekt_Programowanie.Infrastructure;
using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;
using System.Threading;

namespace Projekt_Programowanie.GraphicRepresentation
{
    public class GraphicVisualizer
    {

        public void show(int howMuchNumbers, Func<IGraphBar> graphBarFactory)
        {

            var graphBar = graphBarFactory();
            int[] repository = new int[howMuchNumbers];

            //fills repo with random numbers
            DrawRandomNumbers.DrawNumbers(repository);

            int startPositionX = 25;
            int startPositionY = 20;

            //Start Sorting Alghoritm
            for (int j = 0; j < repository.Length - 1; j++)
            {
                //Sort elements in array
                for (int i = 0; i < repository.Length - 1; i++)
                {
                   

                    //Value used to set x position of cursor on screen
                    int counter = startPositionX;
                    if (repository[i] > repository[i + 1])
                    {
                        //swap values beetwen arrays                       
                        repository.Swap(i, 1);

                        //change font color to White and show values smaller than int i
                        Console.ForegroundColor = ConsoleColor.White;
                        for (int k = 0; k < i; k++)
                        {
                            //Draw bar
                            graphBar.GraphBarDisplay(repository[k], counter, startPositionY);
                            counter++;
                        }

                        //change font color to Red and show values actually used in swap process
                        Console.ForegroundColor = ConsoleColor.Green;
                        graphBar.GraphBarDisplay(repository[i], counter, startPositionY);
                        counter++;
                        Console.ForegroundColor = ConsoleColor.Red;
                        graphBar.GraphBarDisplay(repository[i + 1], counter, startPositionY);
                        counter++;

                        //change font color to Gray and show values bigger than i+2
                        Console.ForegroundColor = ConsoleColor.White;
                        for (int k = i + 2; k < repository.Length; k++)
                        {
                            graphBar.GraphBarDisplay(repository[k], counter, startPositionY);
                            counter++;
                        }
                        Thread.Sleep(300);

                    }

                }

            }
            //Show full graph sorted
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < repository.Length; i++)
            {

                graphBar.GraphBarDisplay(repository[i], startPositionX + i, startPositionY);
               
            }

            new DisplayPressAnyKeyMsgFormatted(25, 53, () => new PressAnyKeyMsg());
            Console.ReadKey();
        }
    }
}
