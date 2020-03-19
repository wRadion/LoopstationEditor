using System.Windows;
using System.Windows.Controls;

namespace LoopstationEditor.Views.Property
{
    /// <summary>
    /// Interaction logic for PropertyFloat.xaml
    /// </summary>
    public partial class PropertyFloat : UserControl
    {
        public static DependencyProperty SmallChangeProperty = DependencyProperty.Register("SmallChange", typeof(float), typeof(PropertyFloat), new PropertyMetadata(1f));
        public static DependencyProperty LargeChangeProperty = DependencyProperty.Register("LargeChange", typeof(float), typeof(PropertyFloat), new PropertyMetadata(10f));
        public static DependencyProperty TickFrequencyProperty = DependencyProperty.Register("TickFrequency", typeof(float), typeof(PropertyFloat), new PropertyMetadata(1f));

        public float SmallChange
        {
            get => (float)GetValue(SmallChangeProperty);
            set => SetValue(SmallChangeProperty, value);
        }

        public float LargeChange
        {
            get => (float)GetValue(LargeChangeProperty);
            set => SetValue(LargeChangeProperty, value);
        }

        public float TickFrequency
        {
            get => (float)GetValue(TickFrequencyProperty);
            set => SetValue(TickFrequencyProperty, value);
        }

        public PropertyFloat()
        {
            InitializeComponent();
        }
    }
}
