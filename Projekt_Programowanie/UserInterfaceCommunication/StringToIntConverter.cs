using System;

namespace Projekt_Programowanie.UserInterfaceCommunication
{
    public class StringToIntConverter : IStringToInt
    {

        bool isItNumber;
        int outputValue;

        /// <summary>
        /// Takes Text to convert, Actual position of cursor, and minum and maximum value that can be enter by user
        /// </summary>
        /// <param name="text"></param>
        /// <param name="xPos"></param>
        /// <param name="yPos"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int ConvertStringToInt(string text, int xPos, int yPos, int min, int max)
        {

            //Lets check it can be int
            isItNumber = int.TryParse(text, out outputValue);

            //If string was number lets check if its in min max range
            if (isItNumber == true &&
                outputValue >= min &&
                outputValue <= max)
            {

                //If was in range Save it in repository
                Console.SetCursorPosition(xPos, yPos);
                ClearLine(50);
                Console.SetCursorPosition(xPos, yPos + 1);                      
                Console.Write("Zapisano!                                     ");
                Console.SetCursorPosition(xPos, yPos);
                return outputValue;
            }
            else
            {

                do
                {

                    //Back to starting position
                    Console.SetCursorPosition(xPos, yPos);

                    //It wasn't number or was not in range 
                    if (isItNumber == false ||
                        outputValue < min ||
                        outputValue > max)
                    {

                        //Display error
                        Console.SetCursorPosition(xPos, yPos + 1);
                        Console.Write("Nie podano liczby, spróbuj ponownie!");
                        Console.SetCursorPosition(xPos, yPos);
                        ClearLine(50);

                    }
                    
                    //Lets try again make user give us a proper value!
                    Console.SetCursorPosition(xPos, yPos);
                    isItNumber = int.TryParse((Console.ReadLine()), out outputValue);

                    if (isItNumber == true &&
                        outputValue >= min &&
                        outputValue <= max)
                    {

                        Console.SetCursorPosition(xPos, yPos+1);                      
                        Console.Write("Zapisano!                                     ");
                        Console.SetCursorPosition(xPos, yPos);
                       
                    }

                } while (isItNumber != true ||
                        outputValue < min ||
                        outputValue > max);

            }

            //Lets Clear what user wrote and back to starting position
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
