using Projekt_Programowanie.SortingAlghoritms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Programowanie.Timing.TimingClasses
{
    public class AlghoritmFactory
    {

        public SortAlghoritmVersion AlghoritmFactoryResult(int i)
        {

            switch (i)
            {

                case 1:
                    return new BubbleSortV1();

                case 2:
                    return new BubbleSortV2();

                case 3:
                    return new BubbleSortV3();

                case 4:
                    return new BubbleSortV4();

                case 5:
                    return new BubbleSortV5();

            }
            return null;
        }
    }
}
