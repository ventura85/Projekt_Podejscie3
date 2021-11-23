using Projekt_Programowanie.Intro;
using Projekt_Programowanie.MainMenuFiles;

namespace Projekt_Programowanie.RunApplication
{
    public  class Application
    {
        public static void Run()
        {
            //Generate new settings
            ConsoleWindowSettings.SetConsoleProperties();
            
            //Shows Intro Page
            new MyIntro();
         
            //Starts application until MainMenu Returns False
            while (new MainMenu().CategoryContent(
                     () => new DisplayCategoryInfoPage(),
                     () => new MenuNavigate()
                     )) ;                        
        }
    }
}
