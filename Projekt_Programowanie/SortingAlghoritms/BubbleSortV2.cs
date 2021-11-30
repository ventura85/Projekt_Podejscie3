using Projekt_Programowanie.Extensions;
using System.Threading.Tasks;

namespace Projekt_Programowanie.SortingAlghoritms
{
    public class BubbleSortV2 : ISortAlghoritm
    {
        /// <summary>
        /// Second and little better Version Of BubbleSort Alghoritm
        /// </summary>
        /// <param name="repository"></param>
        public void SortAlghoritm(int[] repository)
        {

            for (int j = repository.Length - 1; j > 0; j--)
                for (int i = 0; i < j; i++)
                    if (repository[i] > repository[i + 1]) repository.Swap(i,1);
        }
    }
}
