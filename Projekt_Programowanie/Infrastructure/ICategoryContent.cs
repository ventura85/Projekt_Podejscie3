using Projekt_Programowanie.MainMenuFiles;
using System;


namespace Projekt_Programowanie.Infrastructure
{
    public interface ICategoryContent
    {

        public bool CategoryContent(Func<ICategoryInfo> contentFactory, Func<INavigationSender> navigateFactory);
    }
}
