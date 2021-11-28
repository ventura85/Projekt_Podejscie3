using Projekt_Programowanie.Extensions;


namespace Projekt_Programowanie.SortingAlghoritms
{
    public class BubbleSortV3 : ISortAlghoritm
    {
        /// <summary>
        /// Third better Version Of BubbleSort Alghoritm
        /// </summary>
        /// <param name="repository"></param>
        public void SortAlghoritm(int[] repository)
        {

            int p = 0;
            for (int j = repository.Length - 1; j > 0; j--)
            {
                p = 1;
                for (int i = 0; i < j; i++)
                {
                    if (repository[i] > repository[i + 1])
                    {
                        repository.Swap(i, 1);
                        p = 0;
                    }
                }

                if (p == 1) break;
            }
        }
    }
}
