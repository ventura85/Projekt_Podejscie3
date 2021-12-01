using Projekt_Programowanie.MainMenuFiles;
using Projekt_Programowanie.Timing.TimingClasses;
using System;


namespace Projekt_Programowanie.Timing
{
    public class TimingNavigate : INavigationSender
    {
        public bool NavigateTo(ConsoleKey userChoice)
        {
            new TimeSpanPresentation().ShowResult();
            return false;
        }
    }
}
