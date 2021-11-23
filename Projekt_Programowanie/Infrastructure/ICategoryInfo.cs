using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;

namespace Projekt_Programowanie.MainMenuFiles
{
    public interface ICategoryInfo
    {

        /// <summary>
        /// Display String used to build page info content
        /// </summary>
        /// <param name="xPos"></param>
        /// <param name="titleFactory"></param>
        /// <param name="introFactory"></param>
        /// <param name="optionsFactory"></param>
        /// <returns></returns>
        public DisplayCategoryInfoPage ShowMenuContent(
            int xPos, 
            Func<IDisplayMsg> titleFactory, 
            Func<IDisplayMsg> introFactory, 
            Func<IDisplayMsg> optionsFactory 
            );
    }
}
