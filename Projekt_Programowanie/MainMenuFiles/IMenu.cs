using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie.MainMenuFiles
{
    public interface IMenu
    {
        public DisplayMainMenuNavPage ShowMenuContent(int xPos, Func<MenuTitle> titleFactory, Func<MenuIntroduction> introFactory, Func<MenuOptions> optionsFactory );
    }
}
