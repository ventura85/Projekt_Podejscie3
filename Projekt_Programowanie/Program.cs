using Projekt_Programowanie.RunApplication;
using System;
using System.Diagnostics;
using System.Threading;

namespace Projekt_Programowanie
{
    class Program
    {
        #region Helpfull Functions
        public static void Position(int x, int y) => Console.SetCursorPosition(x, y);

        static void DrawNumbers(int[] array)
        {
            int n = array.Length;
            int k = array.Length;
            Random rand = new Random();
            // fill array with numbers 1,2...n
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
                numbers[i] = i + 1;
            // draw k numbers

            for (int i = 0; i < k; i++)
            {
                // create random indeks between 0 and n - 1
                int r = rand.Next(n);

                array[i] = numbers[r];
                numbers[r] = numbers[n - 1];
                n--;
            }
        }

        #endregion

        #region Plain Code Of Bubble Sort Alghoritm

        /// <summary>
        /// First Version Of BubbleSort Alghoritm
        /// </summary>
        /// <param name="array"></param>
        public static void BubbleSortV1(int[] array)
        {
            for (int j = 0; j < array.Length - 1; j++)
                for (int i = 0; i < array.Length - 1; i++)
                    if (array[i] > array[i + 1]) (array[i], array[i + 1]) = (array[i + 1], array[i]);
        }

        /// <summary>
        /// Second and little better Version Of BubbleSort Alghoritm
        /// </summary>
        /// <param name="array"></param>
        public static void BubbleSortV2(int[] array)
        {
            for (int j = array.Length - 1; j > 0; j--)
                for (int i = 0; i < j; i++)
                    if (array[i] > array[i + 1]) (array[i], array[i + 1]) = (array[i + 1], array[i]);
        }

        /// <summary>
        /// Third better Version Of BubbleSort Alghoritm
        /// </summary>
        /// <param name="array"></param>
        public static void BubbleSortV3(int[] array)
        {
            int p = 0;
            for (int j = array.Length - 1; j > 0; j--)
            {
                p = 1;
                for (int i = 0; i < j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                        p = 0;
                    }
                }

                if (p == 1) break;
            }
        }

        /// <summary>
        /// Fourth (GOOD) Optimaized Version Of BubbleSort Alghoritm
        /// </summary>
        /// <param name="array"></param>
        public static void BubbleSortV4(int[] array)
        {
            int pmin = 0; int pmax = array.Length - 1; int p;
            do
            {
                p = -1;
                for (int i = pmin; i < pmax; i++)
                    if (array[i] > array[i + 1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                        if (p < 0) pmin = i;
                        p = i;
                    }
                if (pmin > 0) pmin--;
                pmax = p;
            } while (p >= 0);
        }

        /// <summary>
        /// Fifth (Most Effective) Version OF Bubble Sort Alghoritm
        /// </summary>
        /// <param name="array"></param>
        public static void BubbleSortV5(int[] array)
        {
            int pmin = 0; int pmax = array.Length - 2; int p;
            do
            {
                p = -1;
                for (int i = pmin; i <= pmax; i++)
                    if (array[i] > array[i + 1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                        p = i;
                    }
                if (p < 0) break;
                pmax = p - 1;
                p = -1;
                for (int i = pmax; i >= pmin; i--)
                    if (array[i] > array[i + 1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                        p = i;
                    }
                pmin = p + 1;
            } while (p >= 0);
        }
        #endregion

        #region Bubble Sort Alphanumeric Presentation


        /// <summary>
        /// Bubble sort alghoritm with alphanumeric presentation.
        /// </summary>
        /// <param name="array"></param>
        static void SortV1(int[] array)
        {
            int yPos = 4;
            int xPos = 0;
            bool wasSwap;
            int endPosition = 0;

            for (int j = 0; j < array.Length - 1; j++)
            {
                if (j == (array.Length) / 2)
                {
                    endPosition = yPos - 2;
                    xPos = 50;
                    yPos = 4;
                }

                Position(xPos, yPos);
                //change font color to Yellow and draw top frame
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int z = 0; z < 49; z++)
                    if (z == 0) Console.Write("\u250c");
                    else if (z == 48) Console.Write("\u2510");
                    else Console.Write("\u2500");

                yPos++;
                Position(xPos, yPos);
                //Draw |
                Console.Write("\u2502");

                //change font color to Yellow and show text
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(String.Format("{0,2}. Iteracja ", j + 1));

                //change font color to Yellow and draw │
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(String.Format("{0,35}", '\u2502'));
                yPos++;

                //Sort elements in array
                for (int i = 0; i < array.Length - 1; i++)
                {
                    wasSwap = false;
                    if (array[i] > array[i + 1])
                    {
                        //swap values beetwen arrays                       
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Position(xPos, yPos);
                        Console.WriteLine(String.Format("\u2502 Zamiana:  {0,-2} i {1,2} \u2502", i + 1, i + 2));
                        //change font color to Blue and show values smaller than int i
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Position(xPos + 22, yPos);
                        for (int k = 0; k < i; k++)
                        {
                            Console.Write(array[k] + " ");
                        }

                        //change font color to Red and show values actually used in swap process
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(array[i] + " " + array[i + 1] + " ");

                        //change font color to Gray and show values bigger than i+2
                        Console.ForegroundColor = ConsoleColor.Gray;
                        for (int k = i + 2; k < array.Length; k++)
                        {
                            Console.Write(array[k] + " ");
                        }
                        //change font color to Yellow and show │
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\u2502");
                        yPos++;
                        wasSwap = true;
                    }
                    Position(xPos, yPos);
                    if (wasSwap == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\u2502 Zamiana:  Brak    \u2502");
                        Position(xPos + 22, yPos);
                        //change font color to Blue and show values smaller than int i
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Position(xPos + 22, yPos);
                        for (int k = 0; k < i; k++)
                        {
                            Console.Write(array[k] + " ");
                        }

                        //change font color to Red and show values actually used in swap process
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(array[i] + " " + array[i + 1] + " ");

                        //change font color to Gray and show values bigger than i+2
                        Console.ForegroundColor = ConsoleColor.Gray;
                        for (int k = i + 2; k < array.Length; k++)
                        {
                            Console.Write(array[k] + " ");
                        }
                        //change font color to Yellow and show │
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\u2502");
                        yPos++;
                    }
                }
                Position(xPos, yPos);

                for (int z = 0; z < 49; z++)
                {
                    if (z == 0) Console.Write("\u2514");
                    else if (z == 48) Console.Write("\u2518");
                    else if (z == 20) Console.Write("\u2534");
                    else Console.Write("\u2500");
                }
                yPos++;
            }
            Position(0, endPosition);
        }


        static void SortV2(int[] array)
        {
            int yPos = 4;
            int xPos = 0;
            bool wasSwap;
            int iteration = 1;
            int endPosition = 0;

            for (int j = array.Length - 1; j > 0; j--)
            {
                if (j == (array.Length) / 2)
                {
                    endPosition = yPos - 2;
                    xPos = 50;
                    yPos = 4;
                }

                Position(xPos, yPos);
                //change font color to Yellow and draw top frame
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int z = 0; z < 49; z++)
                    if (z == 0) Console.Write("\u250c");
                    else if (z == 48) Console.Write("\u2510");
                    else Console.Write("\u2500");

                yPos++;
                Position(xPos, yPos);
                //Draw |
                Console.Write("\u2502");

                //change font color to Yellow and show text
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(String.Format("{0,2}. Iteracja ", iteration));

                //change font color to Yellow and show │
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(String.Format("{0,35}", '\u2502'));
                yPos++;

                for (int i = 0; i < j; i++)
                {
                    wasSwap = false;
                    if (array[i] > array[i + 1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Position(xPos, yPos);
                        Console.WriteLine(String.Format("\u2502 Zamiana:  {0,-2} i {1,2} \u2502", i + 1, i + 2));
                        //change font color to Blue and show values smaller than int i
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Position(xPos + 22, yPos);
                        for (int k = 0; k < i; k++)
                        {
                            Console.Write(array[k] + " ");
                        }

                        //change font color to Red and show values actually used in swap process
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(array[i] + " " + array[i + 1] + " ");

                        //change font color to Gray and show values bigger than i+2
                        Console.ForegroundColor = ConsoleColor.Gray;
                        for (int k = i + 2; k < array.Length; k++)
                        {
                            Console.Write(array[k] + " ");
                        }
                        //change font color to Yellow and show │
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\u2502");
                        yPos++;
                        wasSwap = true;
                    }
                    Position(xPos, yPos);
                    if (wasSwap == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\u2502 Zamiana:  Brak    \u2502");
                        Position(xPos + 22, yPos);
                        //change font color to Blue and show values smaller than int i
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Position(xPos + 22, yPos);
                        for (int k = 0; k < i; k++)
                        {
                            Console.Write(array[k] + " ");
                        }

                        //change font color to Red and show values actually used in swap process
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(array[i] + " " + array[i + 1] + " ");

                        //change font color to Gray and show values bigger than i+2
                        Console.ForegroundColor = ConsoleColor.Gray;
                        for (int k = i + 2; k < array.Length; k++)
                        {
                            Console.Write(array[k] + " ");
                        }
                        //change font color to Yellow and show │
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\u2502");
                        yPos++;
                    }

                }
                Position(xPos, yPos);

                for (int z = 0; z < 49; z++)
                {
                    if (z == 0) Console.Write("\u2514");
                    else if (z == 48) Console.Write("\u2518");
                    else if (z == 20) Console.Write("\u2534");
                    else Console.Write("\u2500");
                }
                yPos++;
                iteration++;
            }
            Position(0, endPosition);
        }

        static void SortV3(int[] array)
        {
            int yPos = 4;
            int xPos = 0;
            bool wasSwap;
            bool breakPoint = false;
            int iteration = 1;
            int endPosition = 0;

            for (int j = array.Length - 1; j > 0; j--)
            {
                if (j == (array.Length) / 2)
                {
                    endPosition = yPos - 2;
                    xPos = 50;
                    yPos = 4;
                }
                if (breakPoint) break;
                // "TopFrame":
                Position(xPos, yPos);
                //change font color to Yellow and draw top frame
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int z = 0; z < 49; z++)
                    if (z == 0) Console.Write("\u250c");
                    else if (z == 48) Console.Write("\u2510");
                    else Console.Write("\u2500");

                yPos++;
                Position(xPos, yPos);
                //Draw |
                Console.Write("\u2502");

                //change font color to Yellow and show text
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(String.Format("{0,2}. Iteracja ", iteration));

                //change font color to Yellow and show │
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(String.Format("{0,35}", '\u2502'));
                yPos++;


                wasSwap = false;
                for (int i = 0; i < j; i++)
                {

                    if (array[i] > array[i + 1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                        wasSwap = true;

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Position(xPos, yPos);
                        Console.WriteLine(String.Format("\u2502 Zamiana:  {0,-2} i {1,2} \u2502", i + 1, i + 2));
                        //change font color to Blue and show values smaller than int i
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Position(xPos + 22, yPos);
                        for (int k = 0; k < i; k++)
                        {
                            Console.Write(array[k] + " ");
                        }

                        //change font color to Red and show values actually used in swap process
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(array[i] + " " + array[i + 1] + " ");

                        //change font color to Gray and show values bigger than i+2
                        Console.ForegroundColor = ConsoleColor.Gray;
                        for (int k = i + 2; k < array.Length; k++)
                        {
                            Console.Write(array[k] + " ");
                        }
                        //change font color to Yellow and show │
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\u2502");
                        yPos++;

                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Position(xPos, yPos);
                        Console.WriteLine(String.Format("\u2502 Zamiana:  Brak    \u2502"));
                        //change font color to Blue and show values smaller than int i
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Position(xPos + 22, yPos);
                        for (int k = 0; k < i; k++)
                        {
                            Console.Write(array[k] + " ");
                        }

                        //change font color to Red and show values actually used in swap process
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(array[i] + " " + array[i + 1] + " ");

                        //change font color to Gray and show values bigger than i+2
                        Console.ForegroundColor = ConsoleColor.Gray;
                        for (int k = i + 2; k < array.Length; k++)
                        {
                            Console.Write(array[k] + " ");
                        }
                        //change font color to Yellow and show │
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\u2502");
                        yPos++;

                    }
                }
                //"BottomFrame":
                Position(xPos, yPos);

                for (int z = 0; z < 49; z++)
                {
                    if (z == 0) Console.Write("\u2514");
                    else if (z == 48) Console.Write("\u2518");
                    else if (z == 20) Console.Write("\u2534");
                    else Console.Write("\u2500");
                }
                yPos++;
                iteration++;
                if (wasSwap == false) breakPoint = true;

            }
            Position(0, endPosition);
        }

        static void SortV4(int[] array)
        {
            int pmin = 0; int pmax = array.Length - 1; int p = 0;
            int yPos = 4;
            int xPos = 0;
            bool wasSwap;
            int iteration = 1;
            int endPosition = 0;

            do
            {
                if (iteration == 5)
                {
                    endPosition = yPos - 2;
                    xPos = 50;
                    yPos = 4;
                }

                // "TopFrame":
                Position(xPos, yPos);
                //change font color to Yellow and draw top frame
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int z = 0; z < 49; z++)
                    if (z == 0) Console.Write("\u250c");
                    else if (z == 48) Console.Write("\u2510");
                    else Console.Write("\u2500");

                yPos++;
                Position(xPos, yPos);
                //Draw |
                Console.Write("\u2502");

                //change font color to Yellow and show text
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(String.Format("{0,2}. Iteracja ", iteration));

                //change font color to Yellow and show │
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(String.Format("{0,35}", '\u2502'));
                yPos++;



                p = -1;
                for (int i = pmin; i < pmax; i++)
                {
                    wasSwap = false;
                    if (array[i] > array[i + 1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                        if (p < 0) pmin = i;
                        p = i;

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Position(xPos, yPos);
                        Console.WriteLine(String.Format("\u2502 Zamiana:  {0,-2} i {1,2} \u2502", i + 1, i + 2));

                        if (i == 0)
                        {
                            //change font color to Blue and show values smaller than int i
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Position(xPos + 22, yPos);
                            for (int k = 0; k < i; k++)
                            {
                                Console.Write(array[k] + " ");
                            }

                            //change font color to Red and show values actually used in swap process
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(array[i] + " " + array[i + 1] + " ");

                            //change font color to Gray and show values bigger than i+2
                            Console.ForegroundColor = ConsoleColor.Gray;
                            for (int k = i + 2; k < array.Length; k++)
                            {
                                Console.Write(array[k] + " ");
                            }
                            //change font color to Yellow and show │
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\u2502");
                            yPos++;
                            wasSwap = true;
                        }
                        else
                        {
                            //change font color to Blue and show values smaller than int i
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Position(xPos + 22, yPos);
                            for (int k = 0; k < i; k++)
                            {
                                Console.Write(array[k] + " ");
                            }

                            //change font color to Red and show values actually used in swap process
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(array[i] + " " + array[i + 1] + " ");

                            //change font color to Gray and show values bigger than i+2
                            Console.ForegroundColor = ConsoleColor.Gray;
                            for (int k = i + 2; k < array.Length; k++)
                            {
                                Console.Write(array[k] + " ");
                            }
                            //change font color to Yellow and show │
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("\u2502");
                            yPos++;
                            wasSwap = true;
                        }


                    }

                    Position(xPos, yPos);
                    if (wasSwap == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\u2502 Zamiana:  Brak    \u2502");
                        Position(xPos + 22, yPos);
                        //change font color to Blue and show values smaller than int i
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Position(xPos + 22, yPos);
                        for (int k = 0; k < i; k++)
                        {
                            Console.Write(array[k] + " ");
                        }

                        //change font color to Red and show values actually used in swap process
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(array[i] + " " + array[i + 1] + " ");

                        //change font color to Gray and show values bigger than i+2
                        Console.ForegroundColor = ConsoleColor.Gray;
                        for (int k = i + 2; k < array.Length; k++)
                        {
                            Console.Write(array[k] + " ");
                        }
                        //change font color to Yellow and show │
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\u2502");
                        yPos++;
                    }

                }
                if (pmax == 0)
                {
                    Position(xPos, yPos);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\u2502 Zamiana:  Brak    \u2502");
                    Position(xPos + 22, yPos);
                    //change font color to Blue and show values smaller than int i
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Position(xPos + 22, yPos);
                    int i = 0;
                    for (int k = 0; k < i; k++)
                    {
                        Console.Write(array[k] + " ");
                    }

                    //change font color to Red and show values actually used in swap process
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(array[i] + " " + array[i + 1] + " ");

                    //change font color to Gray and show values bigger than i+2
                    Console.ForegroundColor = ConsoleColor.Gray;
                    for (int k = i + 2; k < array.Length; k++)
                    {
                        Console.Write(array[k] + " ");
                    }
                    //change font color to Yellow and show │
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\u2502");
                    yPos++;
                }
                //"BottomFrame":
                Position(xPos, yPos);

                for (int z = 0; z < 49; z++)
                {
                    if (z == 0) Console.Write("\u2514");
                    else if (z == 48) Console.Write("\u2518");
                    else if (z == 20) Console.Write("\u2534");
                    else Console.Write("\u2500");
                }
                yPos++;
                iteration++;

                if (pmin > 0) pmin--;
                pmax = p;
            } while (p >= 0);
            Position(0, endPosition);
        }

        static void SortV5(int[] array)
        {
            int pmin = 0; int pmax = array.Length - 2; int p;
            int yPos = 4;
            int xPos = 0;
            int xPos2 = 50;
            int yPos2 = 4;
            bool wasSwap;
            int iteration = 1;
            int endPosition;
            do
            {
                Position(xPos, yPos);
                // "TopFrame":
                Position(xPos, yPos);
                //change font color to Yellow and draw top frame
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int z = 0; z < 49; z++)
                    if (z == 0) Console.Write("\u250c");
                    else if (z == 48) Console.Write("\u2510");
                    else Console.Write("\u2500");

                yPos++;
                Position(xPos, yPos);
                //Draw |
                Console.Write("\u2502");

                //change font color to Yellow and show text
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(String.Format("{0,2}. Iteracja ", iteration));

                //change font color to Yellow and show │
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(String.Format("{0,35}", '\u2502'));
                yPos++;

                p = -1;
                for (int i = pmin; i <= pmax; i++)
                {
                    wasSwap = false;
                    if (array[i] > array[i + 1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                        p = i;

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Position(xPos, yPos);
                        Console.WriteLine(String.Format("\u2502 Zamiana:  {0,-2} i {1,2} \u2502", i + 1, i + 2));

                        //change font color to Blue and show values smaller than int i
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Position(xPos + 22, yPos);
                        for (int k = 0; k < i; k++)
                        {
                            Console.Write(array[k] + " ");
                        }

                        //change font color to Red and show values actually used in swap process
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(array[i] + " " + array[i + 1] + " ");

                        //change font color to Gray and show values bigger than i+2
                        Console.ForegroundColor = ConsoleColor.Gray;
                        for (int k = i + 2; k < array.Length; k++)
                        {
                            Console.Write(array[k] + " ");
                        }
                        //change font color to Yellow and show │
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\u2502");
                        yPos++;
                        wasSwap = true;
                    }

                    Position(xPos, yPos);
                    if (wasSwap == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\u2502 Zamiana:  Brak    \u2502");
                        Position(xPos + 22, yPos);
                        //change font color to Blue and show values smaller than int i
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Position(xPos + 22, yPos);
                        for (int k = 0; k < i; k++)
                        {
                            Console.Write(array[k] + " ");
                        }

                        //change font color to Red and show values actually used in swap process
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(array[i] + " " + array[i + 1] + " ");

                        //change font color to Gray and show values bigger than i+2
                        Console.ForegroundColor = ConsoleColor.Gray;
                        for (int k = i + 2; k < array.Length; k++)
                        {
                            Console.Write(array[k] + " ");
                        }
                        //change font color to Yellow and show │
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\u2502");
                        yPos++;
                    }

                }
                Position(xPos, yPos);

                for (int z = 0; z < 49; z++)
                {
                    if (z == 0) Console.Write("\u2514");
                    else if (z == 48) Console.Write("\u2518");
                    else if (z == 20) Console.Write("\u2534");
                    else Console.Write("\u2500");
                }
                yPos++;
                endPosition = yPos - 2;
                if (p < 0) break;
                pmax = p - 1;

                //------------ 2  PĘTLA ------------------------------------------


                // "TopFrame":
                Position(xPos2, yPos2);
                //change font color to Yellow and draw top frame
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int z = 0; z < 49; z++)
                    if (z == 0) Console.Write("\u250c");
                    else if (z == 48) Console.Write("\u2510");
                    else Console.Write("\u2500");

                yPos2++;
                Position(xPos2, yPos2);
                //Draw |
                Console.Write("\u2502");

                //change font color to Yellow and show text
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(String.Format("{0,2}. Iteracja ", iteration));

                //change font color to Yellow and show │
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(String.Format("{0,35}", '\u2502'));
                yPos2++;

                p = -1;
                for (int i = pmax; i >= pmin; i--)
                {
                    wasSwap = false;
                    if (array[i] > array[i + 1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                        p = i;

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Position(xPos2, yPos2);
                        Console.WriteLine(String.Format("\u2502 Zamiana:  {0,-2} i {1,2} \u2502", i + 1, i + 2));
                        Position(xPos2 + 22, yPos2);
                        //change font color to Gray and show values bigger than i+2
                        Console.ForegroundColor = ConsoleColor.Gray;
                        for (int k = 0; k < i; k++)
                        {
                            Console.Write(array[k] + " ");
                        }

                        //change font color to Red and show values actually used in swap process
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(array[i] + " " + array[i + 1] + " ");

                        //change font color to Blue and show values smaller than int i
                        Console.ForegroundColor = ConsoleColor.Blue;
                        for (int k = i + 2; k < array.Length; k++)
                        {
                            Console.Write(array[k] + " ");
                        }


                        //change font color to Yellow and show │
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\u2502");
                        yPos2++;
                        wasSwap = true;
                    }
                    Position(xPos2, yPos2);
                    if (wasSwap == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\u2502 Zamiana:  Brak    \u2502");
                        Position(xPos + 22, yPos);
                        //--
                        Position(xPos2 + 22, yPos2);
                        //change font color to Gray and show values bigger than i+2
                        Console.ForegroundColor = ConsoleColor.Gray;
                        for (int k = 0; k < i; k++)
                        {
                            Console.Write(array[k] + " ");
                        }

                        //change font color to Red and show values actually used in swap process
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(array[i] + " " + array[i + 1] + " ");

                        //change font color to Blue and show values smaller than int i
                        Console.ForegroundColor = ConsoleColor.Blue;
                        for (int k = i + 2; k < array.Length; k++)
                        {
                            Console.Write(array[k] + " ");
                        }


                        //change font color to Yellow and show │
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\u2502");
                        yPos2++;
                    }
                }
                pmin = p + 1;

                //"BottomFrame":
                Position(xPos2, yPos2);

                for (int z = 0; z < 49; z++)
                {
                    if (z == 0) Console.Write("\u2514");
                    else if (z == 48) Console.Write("\u2518");
                    else if (z == 20) Console.Write("\u2534");
                    else Console.Write("\u2500");
                }
                yPos2++;
                iteration++;
            } while (p >= 0);
            Position(0, endPosition);
        }
        #endregion

        #region Graphical Representation
        /// <summary>
        /// Function to handle the Graphical Representation menu and functions
        /// </summary>
        public static void BubbleSortGraph()
        {
            Console.Clear();
            int[] array = new int[40];
            DrawNumbers(array);

            Console.WriteLine("\t\t\t*********** Program prezentujący w sposób graficzny  **********");
            Console.WriteLine("\t\t\t\t\tPrzebieg sortowania bąbelkowego");
            Console.WriteLine("\n\n\t\t\tProgram prezentuje za pomocą słupków proces sortowania");
            Console.WriteLine("\n\t\t\ttablicy zawierającej 40 elementów nie powtarzających się.");


            Position(28, 40);
            Console.WriteLine("Aby kontynuować, naciśnij dowolny klawisz . . .");
            Console.ReadKey(true);
            Position(28, 40);
            Console.WriteLine("Trwa Sortowanie... Może to zając dłuższą chwilę");
            // :::::::::::::::::::::::::
            //Start Sorting Alghoritm
            int yPos = 30;

            for (int j = 0; j < array.Length - 1; j++)
            {
                //Sort elements in array
                for (int i = 0; i < array.Length - 1; i++)
                {
                    //Value used to set cursor x position on screen
                    int xPos = 30;
                    Console.ForegroundColor = ConsoleColor.Black;
                    ClearBar(array.Length, xPos + i, yPos);

                    if (array[i] > array[i + 1])
                    {
                        //swap values beetwen arrays                       
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);

                        //change font color to White and show values smaller than int i
                        Console.ForegroundColor = ConsoleColor.White;
                        for (int k = 0; k < i; k++)
                        {
                            //Draw bar
                            GraphBar(array[k], xPos, yPos);
                            xPos++;
                        }

                        //change font color to Red and show values actually used in swap process
                        Console.ForegroundColor = ConsoleColor.Red;
                        GraphBar(array[i], xPos, yPos);
                        xPos++;
                        Console.ForegroundColor = ConsoleColor.Green;
                        GraphBar(array[i + 1], xPos, yPos);
                        xPos++;

                        //change font color to Gray and show values bigger than i+2
                        Console.ForegroundColor = ConsoleColor.White;
                        for (int k = i + 2; k < array.Length; k++)
                        {
                            GraphBar(array[k], xPos, yPos);
                            xPos++;
                        }
                        Thread.Sleep(200);

                    }
                    else
                    {
                        //change font color to White and show values smaller than int i
                        Console.ForegroundColor = ConsoleColor.White;
                        for (int k = 0; k < i; k++)
                        {
                            //Draw bar
                            GraphBar(array[k], xPos, yPos);
                            xPos++;
                        }

                        //change font color to Red and show values actually used in swap process
                        Console.ForegroundColor = ConsoleColor.Green;
                        GraphBar(array[i], xPos, yPos);
                        xPos++;
                        Console.ForegroundColor = ConsoleColor.Green;
                        GraphBar(array[i + 1], xPos, yPos);
                        xPos++;

                        //change font color to Gray and show values bigger than i+2
                        Console.ForegroundColor = ConsoleColor.White;
                        for (int k = i + 2; k < array.Length; k++)
                        {
                            GraphBar(array[k], xPos, yPos);
                            xPos++;
                        }
                        Thread.Sleep(200);
                    }

                }

            }
            //Show  graph sorted
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < array.Length; i++)
            {
                GraphBar(array[i], i + 30, yPos);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Position(28, 40);
            Console.WriteLine("Aby kontynuować, naciśnij dowolny klawisz . . .");
            Console.ReadKey(true);
        }

        /// <summary>
        /// Function to draw vertical bars with specific Heigh and position on screen 
        /// </summary>
        /// <param name="height"></param>
        /// <param name="xPos"></param>
        /// <param name="yPos"></param>
        public static void GraphBar(int height, int xPos, int yPos)
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
            Console.SetCursorPosition(xPos, 23);

        }
        public static void ClearBar(int height, int xPos, int yPos)
        {

            int newHeight = height / 2;
            int length = height;
            string blankSpace = String.Empty;

            /*  for (int i = 0; i < length; i++)
               {
                   blankSpace += " ";
               }
               for (int j = 0; j < newHeight; j++)
               {
                   Position(xPos, yPos);
                   Console.WriteLine(blankSpace);
                   yPos++;
               }*/

            for (int i = 0; i < newHeight; i++)
            {
                Position(xPos, yPos);
                Console.WriteLine(" ");
                yPos--;
            }


        }
        #endregion

        #region Alghoritm Timing
        public static void TimingMenu()
        {
            Console.Clear();
            int[] array = new int[5000];
            DrawNumbers(array);

            Console.WriteLine("\t\t\t*********** Porównanie czasów wykonywania algorytmu **********");
            Console.WriteLine("\n\n\t\t\tProgram prezentuje ilość czasu potrzebnego do posortowania");
            Console.WriteLine("\n\t\t\ttablicy zawierającej  5000 elementów nie powtarzających się.");
            Console.WriteLine("\n\t\t\tTworze tablicę i sprawdzam czasy.\n\n");

            // V1
            Console.WriteLine("Algorytm Wersja 1");
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            BubbleSortV1(array);
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            Console.Write("Czas wykonania algorytmu to:  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(ts.Duration());
            Console.BackgroundColor = ConsoleColor.Black;

            // V2
            Console.WriteLine("\nAlgorytm Wersja 2");
            stopWatch.Reset();
            stopWatch.Start();
            BubbleSortV2(array);
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            Console.Write("Czas wykonania algorytmu to:  ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(ts.Duration());
            Console.BackgroundColor = ConsoleColor.Black;
            // V3

            Console.WriteLine("\nAlgorytm Wersja 3");
            stopWatch.Reset();
            stopWatch.Start();
            BubbleSortV3(array);
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            ts = stopWatch.Elapsed;
            var v3time = ts.Duration();
            // Format and display the TimeSpan value.
            Console.Write("Czas wykonania algorytmu to:  ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(ts.Duration());
            Console.BackgroundColor = ConsoleColor.Black;

            // V4
            //Console.WriteLine("\nAlgorytm Wersja 4");
            stopWatch.Reset();
            stopWatch.Start();
            BubbleSortV4(array);
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            ts = stopWatch.Elapsed;
            var v4time = ts.Duration();


            // V5
            //Console.WriteLine("\nAlgorytm Wersja 5");
            stopWatch.Reset();
            stopWatch.Start();
            BubbleSortV5(array);
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            ts = stopWatch.Elapsed;
            var v5time = ts.Duration();

            if (v4time.CompareTo(v5time) == 1)
            {
                Console.WriteLine("\nAlgorytm Wersja 4");
                Console.Write("Czas wykonania algorytmu to:  ");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(v4time.Duration());
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\nAlgorytm Wersja 5");
                Console.Write("Czas wykonania algorytmu to:  ");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(v5time.Duration());
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.WriteLine("\nAlgorytm Wersja 4");
                Console.Write("Czas wykonania algorytmu to:  ");
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine(v4time.Duration());
                Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine("\nAlgorytm Wersja 5");
                Console.Write("Czas wykonania algorytmu to:  ");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(v5time.Duration());
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("\n\n\t\t\tAby kontynuować, naciśnij dowolny klawisz . . .");
            Console.ReadKey();
        }
        #endregion

        #region Main Menu
        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t************** SORTOWANIE BĄBELKOWE **************");
            Console.WriteLine("\t\t\tPROGRAM PREZENTUJĄCY METODĘ SORTOWANIA BĄBELKOWEGO");
            Console.WriteLine("\n\n\t\t\t\t\t..::: MENU :::..\n\n\n");
            Console.WriteLine("\t\t\t1. Prezentacja Alfanumeryczna");
            Console.WriteLine("\t\t\t2. Prezentacja Graficzna");
            Console.WriteLine("\t\t\t3. Analiza Czasów Sortowania");
            Console.WriteLine("\n\t\t\t0. Zakończenie programu");

            ConsoleKey userChoice = Console.ReadKey(true).Key;

            switch (userChoice)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    //tablica do posortowania
                    int[] defaultArray = { 43, 93, 81, 42, 67, 59, 72, 1, 95 };

                    Console.WriteLine("\t\t\t*********** PREZENTACJA ALFANUMERYCZNA **********");
                    Console.WriteLine("\n\n\t\tProgram prezentuje przebieg sortowania bąbelkowego w wersjach od 1 do 5");
                    Console.WriteLine("\n\t\t* Sortowanie bąbelkowe - wersja 1");
                    Console.WriteLine("\t\t* Sortowanie bąbelkowe - wersja 2");
                    Console.WriteLine("\t\t* Sortowanie bąbelkowe - wersja 3");
                    Console.WriteLine("\t\t* Sortowanie bąbelkowe - wersja 4 - wersja zoptymalizowana");
                    Console.WriteLine("\t\t* Sortowanie bąbelkowe - wersja 5 - dwukierunkowa");

                    Console.Write("\n\t\tKażde sortowanie zostało przeprowadzone na podstawie tych samych \n" +
                        "\t\tdziewięciu przykładowych liczb: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    foreach (var val in defaultArray)
                        Console.Write(val + " ");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n\n\t\t\tAby kontynuować, naciśnij dowolny klawisz . . .");
                    Console.ReadKey();

                    int versionNumber = 1;
                    do
                    {
                        Console.Clear();

                        //Create copy of default array
                        int[] arr = new int[defaultArray.Length];
                        defaultArray.CopyTo(arr, 0);

                        Console.WriteLine("\t\t\t*********** PREZENTACJA ALFANUMERYCZNA **********");
                        Console.WriteLine("\t\t\t\t  Sortowanie Bąbelkowe Wersja {0}", versionNumber);

                        //wypisz zawartosc przed sortowaniem
                        Console.Write("\nPrzed sortowaniem :   ");
                        for (int z = 0; z < arr.Length; z++)
                        {
                            Console.Write(arr[z] + " ");
                        }
                        Console.WriteLine("\n");
                        switch (versionNumber)
                        {
                            case 1:
                                //sortuj babelkowo              
                                SortV1(arr);
                                break;
                            case 2:
                                //sortuj babelkowo              
                                SortV2(arr);
                                break;
                            case 3:
                                //sortuj babelkowo              
                                SortV3(arr);
                                break;
                            case 4:
                                //sortuj babelkowo              
                                SortV4(arr);
                                break;
                            case 5:
                                //sortuj babelkowo              
                                SortV5(arr);
                                break;
                        }


                        //wypisz zawartosc po sortowaniu
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\n\nPo sortowaniu :\t      ");
                        for (int z = 0; z < arr.Length; z++)
                        {
                            Console.Write(arr[z] + " ");
                        }
                        Console.WriteLine("\n\nUżyj klawiszy kursora <- Lewo, Prawo -> aby zmieniać strony");
                        userChoice = Console.ReadKey().Key;
                        if (userChoice == ConsoleKey.LeftArrow && versionNumber != 1) versionNumber--;
                        if (userChoice == ConsoleKey.RightArrow) versionNumber++;
                    } while (versionNumber <= 5);


                    break;
                case ConsoleKey.D2:
                    BubbleSortGraph();
                    break;
                case ConsoleKey.D3:
                    TimingMenu();
                    break;
                case ConsoleKey.D0:
                    return true;
            }

            return false;
        }
        #endregion

        #region Intro
        public static void Intro()
        {
            Console.Clear();
            Console.WriteLine("\n\t.oOOOo. ");
            Console.WriteLine("\to     o                                                  o       ");
            Console.WriteLine("\tO.                      O     ");
            Console.WriteLine("\t `OOoo.                oOo                                        ");
            Console.WriteLine("\t      `O .oOo. `OoOo.   o   .oOo. 'o     O .oOoO' 'OoOo. O  .oOo. ");
            Console.WriteLine("\t       o O   o  o       O   O   o  O  o  o O   o   o   O o  OooO' ");
            Console.WriteLine("\tO.    .O o   O  O       o   o   O  o  O  O o   O   O   o O  O ");
            Console.WriteLine("\t `oooO'  `OoO'  o       `oO `OoO'  `Oo'oO' `OoO'o  o   O o' `OoO' ");

            Console.WriteLine("\n\to.oOOOo.          o           o o                            ");
            Console.WriteLine("\t o     o         O           O  O      ");
            Console.WriteLine("\t O     O         O           o  o    ");
            Console.WriteLine("\t oOooOO.         o           O  o        ");
            Console.WriteLine("\t o     `O .oOoO' OoOo. .oOo. o  O  o  .oOo. 'o     O .oOo.     ");
            Console.WriteLine("\t O      o O   o  O   o OooO' O  OoO   O   o  O  o  o OooO'    ");
            Console.WriteLine("\t o     .O o   O  o   O O     o  o  O  o   O  o  O  O O         ");
            Console.WriteLine("\t `OooOO'  `OoO'o `OoO' `OoO' Oo O   o `OoO'  `Oo'oO' `OoO'     ");
            Console.WriteLine("\t               Oo\n\t\t\t\t\t\tParadygmaty Programowania. Semestr III");
            Console.WriteLine("\n\n\n\n\tAutor:\n\tKamil Lewandowski\n\n\tNr. Albumu:\n\t56223");

            Console.WriteLine("\n\n\n\t\t\tAby kontynuować, naciśnij dowolny klawisz . . .");
            Console.ReadKey();
        }


        #endregion


   
        static void Main() => Application.Run();
        
    
    }
}
