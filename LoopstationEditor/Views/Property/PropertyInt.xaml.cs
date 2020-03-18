using System.Windows;
using System.Windows.Controls;

namespace LoopstationEditor.Views.Property
{
    /// <summary>
    /// Interaction logic for PropertyInt.xaml
    /// </summary>
    public partial class PropertyInt : UserControl
    {
        public static DependencyProperty SmallChangeProperty = DependencyProperty.Register("SmallChange", typeof(int), typeof(PropertyInt), new PropertyMetadata(1));
        public static DependencyProperty LargeChangeProperty = DependencyProperty.Register("LargeChange", typeof(int), typeof(PropertyInt), new PropertyMetadata(10));
        public static DependencyProperty TickFrequencyProperty = DependencyProperty.Register("TickFrequency", typeof(int), typeof(PropertyInt), new PropertyMetadata(1));

        public int SmallChange
        {
            get => (int)GetValue(SmallChangeProperty);
            set => SetValue(SmallChangeProperty, value);
        }

        public int LargeChange
        {
            get => (int)GetValue(LargeChangeProperty);
            set => SetValue(LargeChangeProperty, value);
        }

        public int TickFrequency
        {
            get => (int)GetValue(TickFrequencyProperty);
            set => SetValue(TickFrequencyProperty, value);
        }

        public PropertyInt()
        {
            InitializeComponent();
        }
    }
}
