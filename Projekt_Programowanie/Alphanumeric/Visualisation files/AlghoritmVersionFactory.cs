

namespace Projekt_Programowanie.Alphanumeric.Visualisation_files
{
    public class AlghoritmVersionFactory
    {
        
        public  AlghoritmVersion Factory(int ver, int[] repo)
        {

            int[] tempRepo = new int[repo.Length];
            repo.CopyTo(tempRepo, 0);

            switch (ver)
            {
                
                case 1:
                    return new AlghoritmVersionNr1(tempRepo);

                case 2:
                    return new AlghoritmVersionNr2(tempRepo);

                case 3:
                    return new AlghoritmVersionNr3(tempRepo);

                case 4:
                    return new AlghoritmVersionNr4(tempRepo);

                case 5:
                    return new AlghoritmVersionNr5(tempRepo);
              
            }

            return new AlghoritmVersionNr1(tempRepo);
        }
       
    }
}
