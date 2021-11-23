using Projekt_Programowanie.Extensions;
using System.Threading.Tasks;

namespace Projekt_Programowanie.SortingAlghoritms
{
    public class BubbleSortV5 : ISortAlghoritm
    {
        public void SortAlghoritm(int[] repository)
        {
            TaskSort(repository);
        }
        private async Task TaskSort(int[] repository)
        {
            int pmin = 0; int pmax = repository.Length - 2; int p;
            do
            {
                p = -1;
                await Task.Run(() =>
                {
                    for (int i = pmin; i <= pmax; i++)
                        if (repository[i] > repository[i + 1])
                        {
                            repository.Swap(i, 1);
                            p = i;
                        }
                });
                if (p < 0) break;
                pmax = p - 1;
                p = -1;
                await Task.Run(() =>
                {
                    for (int i = pmax; i >= pmin; i--)
                        if (repository[i] > repository[i + 1])
                        {
                            repository.Swap(i, 1);
                            p = i;
                        }
                });
                pmin = p + 1;
            } while (p >= 0);
        }
    }
}
