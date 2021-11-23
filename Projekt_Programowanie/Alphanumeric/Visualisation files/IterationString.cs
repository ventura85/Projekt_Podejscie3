using System;


namespace Projekt_Programowanie.Alphanumeric.Visualisation_files
{
    public class IterationString
    {

        private string msg;
        public string iterationMsg(int i)
        {
            msg = String.Format("{0,2}. Iteracja ", i);
            return msg;
        }
    }
}
