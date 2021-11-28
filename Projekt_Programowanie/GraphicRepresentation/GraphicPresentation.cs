
using Projekt_Programowanie.Infrastructure;
using Projekt_Programowanie.MainMenuFiles;
using System;

namespace Projekt_Programowanie.GraphicRepresentation
{
    public class GraphicPresentation : ICategoryContent
    {
        public bool CategoryContent(Func<ICategoryInfo> contentFactory, Func<INavigationSender> navigateFactory)
        {

            var menu = contentFactory();
            var navigate = navigateFactory();
            Console.Clear();

            menu.ShowMenuContent(           //Show Content
            25,                             // when x is on position 25
            () => new GraphicTitle(),          
            () => new GraphicIntro(),   
            () => new GraphicOptions());         

            //Takes user to another navigation menu and shows specific content
            return navigate.NavigateTo(Console.ReadKey(true).Key);
        }
    }
}
