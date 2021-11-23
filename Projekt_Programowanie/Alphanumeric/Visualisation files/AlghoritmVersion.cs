

namespace Projekt_Programowanie.Alphanumeric.Visualisation_files
{
    public abstract class AlghoritmVersion
    {
        private int[] _repo;
        protected AlghoritmVersion(int[] repo)
        {
            _repo = repo;
        }
        public abstract void DisplayAlghoritmPresentation();
    }
}
