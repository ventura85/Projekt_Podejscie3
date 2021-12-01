using Projekt_Programowanie.Infrastructure;
using Projekt_Programowanie.MainMenuFiles;
using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;

namespace Projekt_Programowanie.Timing
{
    public class TimingPresentation : ICategoryContent
    {
        public bool CategoryContent(Func<ICategoryInfo> contentFactory, Func<INavigationSender> navigateFactory)
        {
            var menu = contentFactory();
            var navigate = navigateFactory();
            Console.Clear();

            menu.ShowMenuContent(           //Show Content
            25,                             // when x is on position 25
            () => new TimingTitle(),
            () => new TimingIntro(),
            () => new TimingOptions());

            new DisplayPressAnyKeyMsgFormatted(25, 40, () => new PressAnyKeyMsg());
            //Takes user to another navigation menu and shows specific content
            return navigate.NavigateTo(Console.ReadKey(true).Key);
        }
    }
}
