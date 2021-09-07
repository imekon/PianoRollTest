using System.Windows;
using System.Windows.Controls;

namespace PianoRollTest
{
    public class PianoRollDataTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var element = container as FrameworkElement;
            if (element == null)
                return null;

            switch(item)
            {
                case PianoRollCell cell:
                    return element.FindResource("NoteTemplate") as DataTemplate;

                case PianoRollLine line:
                    return element.FindResource("LineTemplate") as DataTemplate;
            }

            return null;
        }
    }
}
