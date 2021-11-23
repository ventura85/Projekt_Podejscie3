namespace Projekt_Programowanie.Extensions
{
    public static class ExtensionsMethods
    {

        /// <summary>
        /// Swaps elements in array
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="index"></param>
        /// <param name="element"></param>
        public static void Swap(this int[] repository, int index, int element)
        {

            (repository[index], repository[index + element]) = (repository[index + element], repository[index]);
        }
    }
}
