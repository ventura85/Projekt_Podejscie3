using Projekt_Programowanie.Extensions;


namespace Projekt_Programowanie.SortingAlghoritms
{
    public class BubbleSortV4 : SortAlghoritmVersion
    {
        /// <summary>
        /// Fourth (GOOD) Optimaized Version Of BubbleSort Alghoritm
        /// </summary>
        /// <param name="repository"></param>
        public override void SortAlghoritm(int[] repository)
        {

            int pmin = 0; int pmax = repository.Length - 1; int p;
            do
            {
                p = -1;
                for (int i = pmin; i < pmax; i++)
                    if (repository[i] > repository[i + 1])
                    {
                        repository.Swap(i, 1);
                        if (p < 0) pmin = i;
                        p = i;
                    }
                if (pmin > 0) pmin--;
                pmax = p;
            } while (p >= 0);
        }
    }
}
