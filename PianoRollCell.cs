using System.Windows.Media;

namespace PianoRollTest
{
    public class PianoRollCell : PianoRollItem
    {
        private int note;
        private int start;

        public PianoRollCell(int note, int start, int length, int velocity, bool locked) : base(Colors.Yellow)
        {
            this.note = note;
            this.start = start;
            Length = length;
            Velocity = velocity;
            Locked = locked;
        }

        public int Note { get => note; 
            set
            {
                note = value; 
            } 
        }

        public int X
        {
            get
            {
                return start + 10;
            }
        }
        
        public int Y
        {
            get
            {
                return (35 - note - 1) * 12 + 10;
            }
        }
        public int Start
        {
            get => start;
            set
            {
                start = value;
            }
        }

        public int Length { get; set; }
        public int Velocity { get; set; }
        public bool Locked { get; set; }
    }
}
