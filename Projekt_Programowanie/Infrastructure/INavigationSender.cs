using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie.MainMenuFiles
{
    public interface INavigationSender
    {
        public bool NavigateTo(ConsoleKey userChoice);
    }
}
