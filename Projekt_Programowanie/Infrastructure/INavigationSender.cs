using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie.MainMenuFiles
{
    public interface INavigationSender
    {
        /// <summary>
        /// Used to switch between categories. Takes user to specific content
        /// </summary>
        /// <param name="userChoice"></param>
        /// <returns></returns>
        public bool NavigateTo(ConsoleKey userChoice);
    }
}
