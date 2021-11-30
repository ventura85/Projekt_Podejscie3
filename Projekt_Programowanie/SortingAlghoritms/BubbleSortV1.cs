using Projekt_Programowanie.Extensions;

namespace Projekt_Programowanie.SortingAlghoritms
{
    public class BubbleSortV1 : SortAlghoritmVersion
    {
        

        /// <summary>
        /// First Version Of BubbleSort Alghoritm
        /// </summary>
        /// <param name="repository"></param>
        public override void SortAlghoritm(int[] repository)
        {
            
            for (int j = 0; j < repository.Length - 1; j++)
                for (int i = 0; i < repository.Length - 1; i++)
                    if (repository[i] > repository[i + 1]) repository.Swap(i, 1);
        }
    }
}
