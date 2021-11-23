using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;


namespace Projekt_Programowanie.Alphanumeric.Visualisation_files
{
    public interface IScreenDisplay
    {

        public void Show(Func<IDisplayMsg> factoryTitle, string text, AlghoritmVersion alghoritmVersion);
    }
}
