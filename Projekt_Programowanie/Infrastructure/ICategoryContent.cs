using Projekt_Programowanie.MainMenuFiles;
using System;


namespace Projekt_Programowanie.Infrastructure
{
    public interface ICategoryContent
    {

        /// <summary>
        /// Used to show Presentation Page of category. 
        /// </summary>
        /// <param name="contentFactory"></param>
        /// <param name="navigateFactory"></param>
        /// <returns></returns>
        public bool CategoryContent(Func<ICategoryInfo> contentFactory, Func<INavigationSender> navigateFactory);
    }
}
