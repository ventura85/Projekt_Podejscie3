using System;

namespace Projekt_Programowanie.UserInterfaceCommunication
{
    public class StringToIntConverter : IStringToInt
    {

        bool isItNumber;
        int outputValue;

        public int ConvertStringToInt(string text, int xPos, int yPos, int min, int max)
        {

            isItNumber = int.TryParse(text, out outputValue);

            if (isItNumber == true &&
                outputValue >= min &&
                outputValue <= max)
            {
                Console.SetCursorPosition(xPos, yPos);
                ClearLine(50);
                Console.SetCursorPosition(xPos, yPos + 1);
                Console.Write("Zapisano w tablicy !                          ");
                Console.SetCursorPosition(xPos, yPos);
                return outputValue;
            }
            else
            {

                do
                {
                    Console.SetCursorPosition(xPos, yPos);

                    if (isItNumber == false ||
                        outputValue < min ||
                        outputValue > max)
                    {

                        Console.SetCursorPosition(xPos, yPos + 1);
                        Console.Write("Nie podano liczby, spróbuj ponownie!");

                    }
                                     
                    Console.SetCursorPosition(xPos, yPos);
                    isItNumber = int.TryParse((Console.ReadLine()), out outputValue);

                    if (isItNumber == true &&
                        outputValue >= min &&
                        outputValue <= max)
                    {

                        Console.SetCursorPosition(xPos, yPos+1);
                        Console.Write("Zapisano w tablicy !                          ");
                        Console.SetCursorPosition(xPos, yPos);
                       
                    }

                } while (isItNumber != true ||
                        outputValue < min ||
                        outputValue > max);

            }

            Console.SetCursorPosition(xPos, yPos);
            ClearLine(50);          
            Console.SetCursorPosition(xPos, yPos);

            return outputValue;
        }
        private void ClearLine(int l)
        {

            for (int i = 0; i < l; i++)
            {

                Console.Write(" ");
            }
        }
    }
}
