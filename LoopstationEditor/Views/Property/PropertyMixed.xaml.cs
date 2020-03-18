using System.Windows;
using System.Windows.Controls;

namespace LoopstationEditor.Views.Property
{
    /// <summary>
    /// Interaction logic for PropertyMixed.xaml
    /// </summary>
    public partial class PropertyMixed : UserControl
    {
        public static DependencyProperty SmallChangeProperty = DependencyProperty.Register("SmallChange", typeof(int), typeof(PropertyMixed), new PropertyMetadata(1));
        public static DependencyProperty LargeChangeProperty = DependencyProperty.Register("LargeChange", typeof(int), typeof(PropertyMixed), new PropertyMetadata(10));
        public static DependencyProperty TickFrequencyProperty = DependencyProperty.Register("TickFrequency", typeof(int), typeof(PropertyMixed), new PropertyMetadata(1));
        public static DependencyProperty GroupNameProperty = DependencyProperty.Register("GroupName", typeof(string), typeof(PropertyMixed));

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

        public string GroupName
        {
            get => (string)GetValue(GroupNameProperty);
            set => SetValue(GroupNameProperty, value);
        }

        public PropertyMixed()
        {
            InitializeComponent();
        }
    }
}
