using Projekt_Programowanie.Extensions;


namespace Projekt_Programowanie.SortingAlghoritms
{
    public class BubbleSortV5 : SortAlghoritmVersion
    {

        /// <summary>
        /// Fifth (Most Effective) Version OF Bubble Sort Alghoritm
        /// </summary>
        /// <param name="repository"></param>
        public override void SortAlghoritm(int[] repository)
        {

            int pmin = 0; int pmax = repository.Length - 2; int p;
            do
            {
                p = -1;
                for (int i = pmin; i <= pmax; i++)
                    if (repository[i] > repository[i + 1])
                    {
                        repository.Swap(i, 1);
                        p = i;
                    }
                if (p < 0) break;
                pmax = p - 1;
                p = -1;
                for (int i = pmax; i >= pmin; i--)
                    if (repository[i] > repository[i + 1])
                    {
                        repository.Swap(i, 1);
                        p = i;
                    }
                pmin = p + 1;
            } while (p >= 0);
        }
    }
}
