

namespace Projekt_Programowanie.Alphanumeric
{
    public class DefaultArray : IRepository
    {

        private int[] defaultNumbers;
        public int[] Repository { get => defaultNumbers; set { } }

        public DefaultArray()
        {

           defaultNumbers = new int[]{ 43, 93, 81, 42, 67, 59, 72, 1, 95 };
        }

        /// <summary>
        /// Creates custom default Array
        /// </summary>
        /// <param name="CustomArray"></param>
        public DefaultArray(int[] CustomArray)
        {

            CustomArray.CopyTo(defaultNumbers, 0);
        }
    }
}
