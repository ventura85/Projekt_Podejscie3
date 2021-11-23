using Projekt_Programowanie.Extensions;
using System.Threading.Tasks;

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
            TaskSort(repository);
        }
        private async Task TaskSort(int[] repository)
        {

            int p = 0;
            for (int j = repository.Length - 1; j > 0; j--)
            {
                p = 1;
                await Task.Run(() =>
                {
                    for (int i = 0; i < j; i++)
                    {
                        if (repository[i] > repository[i + 1])
                        {
                            repository.Swap(i, 1);
                            p = 0;
                        }
                    }
                });
            }
        }
    }
}
