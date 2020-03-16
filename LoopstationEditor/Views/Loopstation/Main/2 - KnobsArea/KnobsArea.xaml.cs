using System.Windows;
using System.Windows.Controls;

namespace LoopstationEditor.Views.Loopstation.Main.KnobsArea
{
    /// <summary>
    /// Interaction logic for KnobsArea.xaml
    /// </summary>
    public partial class KnobsArea : UserControl
    {
        public static DependencyProperty TextLine1Property = DependencyProperty.Register("TextLine1", typeof(string), typeof(KnobsArea));
        public static DependencyProperty TextLine2Property = DependencyProperty.Register("TextLine2", typeof(string), typeof(KnobsArea));

        public string TextLine1
        {
            get => (string)GetValue(TextLine1Property);
            set => SetValue(TextLine1Property, value);
        }
        public string TextLine2
        {
            get => (string)GetValue(TextLine2Property);
            set => SetValue(TextLine2Property, value);
        }

        public KnobsArea()
        {
            InitializeComponent();
        }
    }
}
