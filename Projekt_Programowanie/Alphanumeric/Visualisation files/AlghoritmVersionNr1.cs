using Projekt_Programowanie.Alphanumeric.Visualisation_files.Frames;
using Projekt_Programowanie.Extensions;
using System;


namespace Projekt_Programowanie.Alphanumeric.Visualisation_files
{
    public class AlghoritmVersionNr1 : AlghoritmVersion
    {
        private int[] _repo;
        public AlghoritmVersionNr1(int[] repo) : base(repo)
        {

            _repo = repo;
        }
       
        int xPos, yPos;
        int startX, StartY;
        int iterationCounter = 1;
        bool wasSwap;
        public override void DisplayAlghoritmPresentation()
        {
            int iterationStringLength = new IterationString().iterationMsg(10).Length;
            int frameLength = (iterationStringLength - 1 + _repo.Length) + (2* _repo.Length);
            var table = new TableFrames();

            //Getting and setting coords
            (startX, StartY) = Console.GetCursorPosition();
            (xPos, yPos) = (startX, StartY);
            yPos += 2;

            Console.SetCursorPosition(xPos, yPos);

            //Display repository before sorting
            Console.Write("Tablica przed sortowaniem : ");
            foreach (var item in _repo)
            {

                Console.Write(item + " ");
            }
            yPos++;
            //-------------------------------------------------------

            for (int j = 0; j < _repo.Length - 1; j++)
            {

                //Used to split screen 
                if (j == (_repo.Length) / 2)
                {
                    
                    xPos = frameLength + 4;
                    yPos = StartY + 3;
                }

                //Display Top Frame, mid frame and show iteration info
                table.TableFameTop(frameLength, xPos, ref yPos);
                               

                for (int i = 0; i < _repo.Length - 1; i++)
                {

                    table.TableFameMid();
                    if (i == 0) Console.Write(new IterationString().iterationMsg(iterationCounter));
                    else Console.SetCursorPosition(xPos + new IterationString().iterationMsg(10).Length + 1, yPos);

                    wasSwap = false;
                    if (_repo[i] > _repo[i + 1])
                    {

                        _repo.Swap(i, 1);

                        new ColoredRepo().DisplayColoredRepo(_repo, i, ref yPos );
                        wasSwap = true;
                    }

                    if (wasSwap == false)
                    {

                        new ColoredRepo().DisplayColoredRepo(_repo, i, ref yPos, ConsoleColor.Blue, ConsoleColor.Blue);
                    }

                    table.TableFameMid();
                    Console.SetCursorPosition(xPos, yPos);
                }
                iterationCounter++;
                table.TableFameBottom(frameLength, xPos, ref yPos);
            }

            //-------------------------------------------------------

            //Display repository after sorting
            Console.SetCursorPosition(0,48);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Tablica po sortowaniu : ");
            foreach (var item in _repo)
            {

                Console.Write(item + " ");
            }
        }
    }
}
