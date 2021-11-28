using System;


namespace Projekt_Programowanie.Infrastructure
{
    public class DrawRandomNumbers
    {

        /// <summary>
        /// Fills array with random numbers
        /// </summary>
        /// <param name="array"></param>
        public void DrawNumbers(int[] array)
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
    }
}
