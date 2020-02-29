using System.Windows;
using System.Windows.Controls;

namespace LoopstationEditor.Views.Loopstation.Controls
{
    /// <summary>
    /// Interaction logic for ButtonNormal.xaml
    /// </summary>
    public partial class ButtonNormal : UserControl
    {
        public static DependencyProperty LineHeightProperty = DependencyProperty.Register("LineHeight", typeof(double), typeof(ButtonNormal));

        public double LineHeight
        {
            get => (double)GetValue(LineHeightProperty);
            set => SetValue(LineHeightProperty, (double)value);
        }

        public ButtonNormal()
        {
            InitializeComponent();
        }
    }
}
