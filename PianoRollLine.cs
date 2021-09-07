using System.Windows.Media;

namespace PianoRollTest
{
    public class PianoRollLine : PianoRollItem
    {
        private int x1;
        private int x2;
        private int y1;
        private int y2;

        public PianoRollLine(Color colour) : base(colour)
        {
        }

        public void SetHorzLine(int x1, int x2, int y)
        {
            this.x1 = x1;
            this.x2 = x2;
            y1 = y;
            y2 = y;
        }

        public void SetVertLine(int x, int y1, int y2)
        {
            x1 = x;
            x2 = x;
            this.y1 = y1;
            this.y2 = y2;
        }

        public int X1 => x1;
        public int X2 => x2;
        public int Y1 => y1;
        public int Y2 => y2;
    }
}
