using System;

namespace Projekt_Programowanie.GraphicRepresentation
{
    public  class GraphBar
    {

        /// <summary>
        /// Draw vertical bars with specific Heigh and position on screen
        /// </summary>
        /// <param name="height"></param>
        /// <param name="xPos"></param>
        /// <param name="yPos"></param>
        public void GraphBarDisplay(int height, int xPos, int yPos)
        {

            bool isEven = (height % 2 == 0) ? isEven = true : isEven = false;


            Console.SetCursorPosition(xPos, yPos);
            //Char describes 0 as not blank space
            Console.WriteLine("_");

            //Check if Height is equal 1 to draw only one spot
            if (height / 2 == 0 && isEven == false)
            {
                Console.SetCursorPosition(xPos, yPos);
                Console.Write("\u2584");
            }
            while (height / 2 != 0)
            {

                Console.SetCursorPosition(xPos, yPos);
                Console.Write("\u2588");

                if (height / 2 > 1) height--;
                height--;
                //At the end of loop check if is even to draw additional spot
                if (height / 2 == 0 && isEven == false)
                {
                    Console.SetCursorPosition(xPos, yPos);
                    Console.Write("\u2584");
                }
                yPos = yPos - 1;


            }
           
        }
    }
}
