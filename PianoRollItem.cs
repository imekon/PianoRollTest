using System.Windows.Media;

namespace PianoRollTest
{
    public abstract class PianoRollItem
    {
        private Color colour;

        public PianoRollItem(Color colour)
        {
            this.colour = colour;
        }

        public SolidColorBrush Brush => new SolidColorBrush(colour);
    }
}
