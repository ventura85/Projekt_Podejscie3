using Projekt_Programowanie.Alphanumeric.Visualisation_files.Frames;
using Projekt_Programowanie.Extensions;
using System;


namespace Projekt_Programowanie.Alphanumeric.Visualisation_files
{
    public class AlghoritmVersionNr4 : AlghoritmVersion
    {
        private int[] _repo;

        public AlghoritmVersionNr4(int[] repo) : base(repo)
        {

            _repo = repo;
        }

        int xPos, yPos;
        int startX, StartY;
        int iterationCounter = 1;
        bool wasSwap;
        public override void DisplayAlghoritmPresentation()
        {

            int pmin = 0; int pmax = _repo.Length - 1; int p;

            int iterationStringLength = new IterationString().iterationMsg(10).Length;
            int frameLength = (iterationStringLength - 1 + _repo.Length) + (2 * _repo.Length);
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

            do
            {

                //Used to split screen 
                if (iterationCounter == 5)
                {

                    xPos = frameLength + 4;
                    yPos = StartY + 3;
                }

                //Display Top Frame, mid frame and show iteration info
                table.TableFrameTop(frameLength, xPos, ref yPos);


                int j = 0;
                p = -1;
                for (int i = pmin; i < pmax; i++)
                {

                    table.TableFrameMid();
                    if (j == 0) Console.Write(new IterationString().iterationMsg(iterationCounter));
                    else Console.SetCursorPosition(xPos + new IterationString().iterationMsg(10).Length + 1, yPos);

                    j++;
                    wasSwap = false;

                    if (_repo[i] > _repo[i + 1])
                    {

                        _repo.Swap(i, 1);
                        if (p < 0) pmin = i;
                        p = i;

                        new ColoredRepo().DisplayColoredRepo(_repo, i, ref yPos);
                        wasSwap = true;
                    }

                    if (wasSwap == false)
                    {

                        new ColoredRepo().DisplayColoredRepo(_repo, i, ref yPos, ConsoleColor.Blue, ConsoleColor.Blue);
                    }

                    table.TableFrameMid();
                    Console.SetCursorPosition(xPos, yPos);
                }

                if (pmax == 0)
                {

                    int i = 0;
                    table.TableFrameMid();
                    if (i == 0) Console.Write(new IterationString().iterationMsg(iterationCounter));
                    else Console.SetCursorPosition(xPos + new IterationString().iterationMsg(10).Length + 1, yPos);
                    new ColoredRepo().DisplayColoredRepo(_repo, i, ref yPos, ConsoleColor.Blue, ConsoleColor.Blue);
                    table.TableFrameMid();
                    Console.SetCursorPosition(xPos, yPos);
                }

                table.TableFrameBottom(frameLength, xPos, ref yPos);

                iterationCounter++;

                if (pmin > 0) pmin--;
                pmax = p;
            } while (p >= 0);

            //-------------------------------------------------------

            //Display repository after sorting
            Console.SetCursorPosition(0, 48);
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Tablica po sortowaniu : ");
            foreach (var item in _repo)
            {

                Console.Write(item + " ");
            }
        }
    }
}
