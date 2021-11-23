using System.Threading.Tasks;
using Projekt_Programowanie.Extensions;

namespace Projekt_Programowanie.SortingAlghoritms
{
    public class BubbleSortV1 : ISortAlghoritm
    {
        /// <summary>
        /// First Version Of BubbleSort Alghoritm
        /// </summary>
        /// <param name="repository"></param>
        public void SortAlghoritm(int[] repository)
        {
            {
                TaskSort(repository);
            }
        }
        private async Task TaskSort(int[] repository)
        {
            for (int j = 0; j < repository.Length - 1; j++)
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i < repository.Length - 1; i++)
                        if (repository[i] > repository[i + 1])
                            repository.Swap(i, 1);
                });
            }
        }
    }
}
