using Projekt_Programowanie.UserInterfaceCommunication;
using System;


namespace Projekt_Programowanie.Infrastructure
{
    public class CreateCustomArray
    {
        IStringToInt convert;
        int[] output;
        int xPos, yPos;

        public int[] CustomArray(int size, Func<IStringToInt> convertFactory, int min, int max)
        {

            convert = convertFactory();
            output = new int[size];

            (xPos, yPos) = Console.GetCursorPosition();
            for (int i = 0; i < output.Length; i++)
            {

                output[i] = convert.ConvertStringToInt(Console.ReadLine(), xPos, yPos,  min,  max);
            }
            return output;
        }
    }
}
