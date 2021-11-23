using Projekt_Programowanie.Alphanumeric.Visualisation_files.Frames;
using Projekt_Programowanie.Extensions;
using System;


namespace Projekt_Programowanie.Alphanumeric.Visualisation_files
{
    public class AlghoritmVersionNr5 : AlghoritmVersion
    {
        private int[] _repo;

        public AlghoritmVersionNr5(int[] repo) : base(repo)
        {

            _repo = repo;
        }

        int xPos, yPos;
        int xPos2, yPos2;
        int iterationCounter = 1;
        bool wasSwap;
        public override void DisplayAlghoritmPresentation()
        {
            int iterationStringLength = new IterationString().iterationMsg(10).Length;
            int frameLength = (iterationStringLength - 1 + _repo.Length) + (2 * _repo.Length);
            var table = new TableFrames();

            //Getting and setting coords
            (xPos2, yPos2) = Console.GetCursorPosition();
            (xPos, yPos) = (xPos2, yPos2);
            xPos2 = frameLength + 4;
            yPos2 += 3;
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

            int pmin = 0; int pmax = _repo.Length - 2; int p;
            do
            {

                //Display Top Frame, mid frame and show iteration info
                table.TableFameTop(frameLength, xPos, ref yPos);

                int m = 0;
                p = -1;
                for (int i = pmin; i <= pmax; i++)
                {

                    table.TableFameMid();
                    if (m == 0) Console.Write(new IterationString().iterationMsg(iterationCounter));
                    else Console.SetCursorPosition(xPos + new IterationString().iterationMsg(10).Length + 1, yPos);
                    m++;

                    wasSwap = false;
                    if (_repo[i] > _repo[i + 1])
                    {

                        _repo.Swap(i, 1);
                        p = i;

                        new ColoredRepo().DisplayColoredRepo(_repo, i, ref yPos);
                        wasSwap = true;
                    }

                    if (wasSwap == false)
                    {

                        new ColoredRepo().DisplayColoredRepo(_repo, i, ref yPos, ConsoleColor.Blue, ConsoleColor.Blue);
                    }

                    table.TableFameMid();
                    Console.SetCursorPosition(xPos, yPos);
                }

                table.TableFameBottom(frameLength, xPos, ref yPos);

                if (p < 0) break;

                //------------ 2  loop ------------------------------------------

                pmax = p - 1;
                p = -1;

                Console.SetCursorPosition(xPos2, yPos2);
                //Display Top Frame, mid frame and show iteration info
                table.TableFameTop(frameLength, xPos2, ref yPos2);

                int j = 0;
                for (int i = pmax; i >= pmin; i--)
                {

                    table.TableFameMid();
                    if (j == 0) Console.Write(new IterationString().iterationMsg(iterationCounter));
                    else Console.SetCursorPosition(xPos2 + new IterationString().iterationMsg(10).Length + 1, yPos2);
                    j++;

                    wasSwap = false;
                    if (_repo[i] > _repo[i + 1])
                    {

                        _repo.Swap(i, 1);
                        p = i;

                        new ColoredRepo().DisplayColoredRepo(_repo, i, ref yPos2, ConsoleColor.Gray, ConsoleColor.Red, ConsoleColor.Blue );
                        wasSwap = true;
                    }

                    if (wasSwap == false)
                    {

                        new ColoredRepo().DisplayColoredRepo(_repo, i, ref yPos2, ConsoleColor.Gray, ConsoleColor.Blue , ConsoleColor.Blue);
                    }

                    table.TableFameMid();
                    Console.SetCursorPosition(xPos2, yPos2);
                }

                table.TableFameBottom(frameLength, xPos2, ref yPos2);
                iterationCounter++;
                pmin = p + 1;

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
