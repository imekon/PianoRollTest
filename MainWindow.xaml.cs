using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace PianoRollTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<PianoRollItem> items;

        public MainWindow()
        {
            InitializeComponent();

            items = new ObservableCollection<PianoRollItem>();

            var darkLine = Color.FromRgb(200, 200, 200);
            var darkerLine = Color.FromRgb(150, 150, 150);

            for (int x = 0; x <= 32; x++)
            {
                PianoRollLine line;
                if (x % 4 == 0)
                    line = new PianoRollLine(darkerLine);
                else
                    line = new PianoRollLine(darkLine);

                line.SetVertLine(10 + x * 24, 10, 1000);
                items.Add(line);
            }

            for (int y = 0; y <= 35; y++)
            {
                PianoRollLine line;
                if (y % 7 == 0)
                    line = new PianoRollLine(darkerLine);
                else
                    line = new PianoRollLine(darkLine);

                line.SetHorzLine(10, 1000, 10 + y * 12);
                items.Add(line);
            }

            items.Add(new PianoRollCell(14, 0, 24, 96, false));
            items.Add(new PianoRollCell(16, 48, 24, 96, false));
            items.Add(new PianoRollCell(18, 48 * 2, 48, 96, false));
            items.Add(new PianoRollCell(20, 48 * 3, 24, 96, false));

            DataContext = this;
        }

        public ObservableCollection<PianoRollItem> Items => items;
    }
}
