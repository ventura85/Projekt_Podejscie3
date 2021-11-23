using Projekt_Programowanie.UserInterfaceCommunication.Messages;
using System;

namespace Projekt_Programowanie.Intro
{
    public class MyIntro
    {
        public MyIntro()
        {

            Console.Clear();

            Console.WriteLine("\n\t.oOOOo. ");
            Console.WriteLine("\to     o                                                  o       ");
            Console.WriteLine("\tO.                      O     ");
            Console.WriteLine("\t `OOoo.                oOo                                        ");
            Console.WriteLine("\t      `O .oOo. `OoOo.   o   .oOo. 'o     O .oOoO' 'OoOo. O  .oOo. ");
            Console.WriteLine("\t       o O   o  o       O   O   o  O  o  o O   o   o   O o  OooO' ");
            Console.WriteLine("\tO.    .O o   O  O       o   o   O  o  O  O o   O   O   o O  O ");
            Console.WriteLine("\t `oooO'  `OoO'  o       `oO `OoO'  `Oo'oO' `OoO'o  o   O o' `OoO' ");

            Console.WriteLine("\n\to.oOOOo.          o           o o                            ");
            Console.WriteLine("\t o     o         O           O  O      ");
            Console.WriteLine("\t O     O         O           o  o    ");
            Console.WriteLine("\t oOooOO.         o           O  o        ");
            Console.WriteLine("\t o     `O .oOoO' OoOo. .oOo. o  O  o  .oOo. 'o     O .oOo.     ");
            Console.WriteLine("\t O      o O   o  O   o OooO' O  OoO   O   o  O  o  o OooO'    ");
            Console.WriteLine("\t o     .O o   O  o   O O     o  o  O  o   O  o  O  O O         ");
            Console.WriteLine("\t `OooOO'  `OoO'o `OoO' `OoO' Oo O   o `OoO'  `Oo'oO' `OoO'     ");
            Console.WriteLine("\t               Oo\n\t\t\t\t\tParadygmaty Programowania. Semestr III");
            Console.WriteLine("\n\n\n\n\tAutor:\n\tKamil Lewandowski\n\n\tNr. Albumu:\n\t56223");         

            new DisplayPressAnyKeyMsgFormatted(25, 40, () => new PressAnyKeyMsg());
            Console.ReadKey(true);
        }
    }
}
