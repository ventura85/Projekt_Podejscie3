

namespace Projekt_Programowanie.Alphanumeric.Visualisation_files.Frames
{
    public interface ITableFrame
    {

        public void TableFrameTop(int length, int x, ref int y);
        public void TableFrameMid();
        public void TableFrameBottom(int length, int x, ref int y);

    }
}
