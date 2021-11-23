using Projekt_Programowanie.Infrastructure;
using System;

namespace Projekt_Programowanie.MainMenuFiles
{
    public class MainMenu : ICategoryContent
    {

        public bool CategoryContent(Func<ICategoryInfo> contentFactory, Func<INavigationSender> navigateFactory)
        {

            var menu = contentFactory();
            var navigate = navigateFactory();
            Console.Clear();

            menu.ShowMenuContent(
            25,
            () => new MenuTitle(),
            () => new MenuIntroduction(),
            () => new MenuOptions());

            return navigate.NavigateTo(Console.ReadKey(true).Key);
        }   
    }
}
