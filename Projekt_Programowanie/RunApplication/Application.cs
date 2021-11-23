using Projekt_Programowanie.Intro;
using Projekt_Programowanie.MainMenuFiles;

namespace Projekt_Programowanie.RunApplication
{
    public  class Application
    {
        public static void Run()
        {
            
            ConsoleWindowSettings.SetConsoleProperties();
            
            new MyIntro();
         
            while (new MainMenu().CategoryContent(
                     () => new DisplayCategoryInfoPage(),
                     () => new MenuNavigate()
                     )) ;                        
        }
    }
}
