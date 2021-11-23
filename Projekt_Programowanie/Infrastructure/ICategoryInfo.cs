using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;

namespace Projekt_Programowanie.MainMenuFiles
{
    public interface ICategoryInfo
    {
        public DisplayCategoryInfoPage ShowMenuContent(
            int xPos, 
            Func<IDisplayMsg> titleFactory, 
            Func<IDisplayMsg> introFactory, 
            Func<IDisplayMsg> optionsFactory 
            );
    }
}
