using Projekt_Programowanie.Infrastructure;
using System;

namespace Projekt_Programowanie.MainMenuFiles
{
    public class MainMenu : ICategoryContent
    {
        /// <summary>
        /// Creates Content Page for specific categories and returns true or false used to Exit from loop
        /// </summary>
        /// <param name="contentFactory"></param>
        /// <param name="navigateFactory"></param>
        /// <returns></returns>
        public bool CategoryContent(Func<ICategoryInfo> contentFactory, Func<INavigationSender> navigateFactory)
        {

            var menu = contentFactory();
            var navigate = navigateFactory();
            Console.Clear();

            menu.ShowMenuContent(           //Show Content
            25,                             // when x is on position 25
            () => new MenuTitle(),          // String Menu is MenuTitle
            () => new MenuIntroduction(),   // String Introducion is from MenuIntroduction
            () => new MenuOptions());       //and String Options is from MenuOption

            //Takes user to another navigation menu and shows specific content
            return navigate.NavigateTo(Console.ReadKey(true).Key);
        }   
    }
}
