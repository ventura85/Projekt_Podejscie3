using Projekt_Programowanie.Extensions;
using System.Threading.Tasks;

namespace Projekt_Programowanie.SortingAlghoritms
{
    public class BubbleSortV4 : ISortAlghoritm
    {
        /// <summary>
        /// Fourth (GOOD) Optimaized Version Of BubbleSort Alghoritm
        /// </summary>
        /// <param name="repository"></param>
        public void SortAlghoritm(int[] repository)
        {
            TaskSort(repository);
        }
        private async Task TaskSort(int[] repository)
        {
            int pmin = 0; int pmax = repository.Length - 1; int p;
            do
            {
                p = -1;
                await Task.Run(() =>
                {
                    for (int i = pmin; i < pmax; i++)
                        if (repository[i] > repository[i + 1])
                        {
                            repository.Swap(i, 1);
                            if (p < 0) pmin = i;
                            p = i;
                        }
                });
                if (pmin > 0) pmin--;
                pmax = p;
            } while (p >= 0);
        }
    }
}
