

namespace Projekt_Programowanie.UserInterfaceCommunication
{
    public interface IStringToInt
    {

        /// <summary>
        /// Used To Convert Strings to Int when need to input something from keyboard
        /// </summary>
        /// <param name="text"></param>
        /// <param name="xPos"></param>
        /// <param name="yPos"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int ConvertStringToInt(string text,int xPos,int yPos, int min, int max);
    }
}
