using Projekt_Programowanie.SortingAlghoritms;
using System;
using System.Diagnostics;

namespace Projekt_Programowanie.Timing.TimingClasses
{
    public class CheckTime
    {

        public TimeSpan TimeSpanResult { get; set; }
        public String Title { get; set; }

        public CheckTime(SortAlghoritmVersion factoryAlghoritm, string title, int[] repo)
        {

            int[] _repo = repo;
            Title = "Algorytm wersja: " + title;

            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            factoryAlghoritm.SortAlghoritm(_repo);
            stopWatch.Stop();

            // Get the elapsed time as a TimeSpan value.
            TimeSpanResult = stopWatch.Elapsed;
        }
    }
}
