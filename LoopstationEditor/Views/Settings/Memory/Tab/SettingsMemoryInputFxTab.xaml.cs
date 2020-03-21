using System.Windows;
using System.Windows.Controls;

namespace LoopstationEditor.Views.Settings.Memory.Tab
{
    /// <summary>
    /// Interaction logic for SettingsMemoryInputFxTab.xaml
    /// </summary>
    public partial class SettingsMemoryInputFxTab : UserControl
    {
        public static DependencyProperty SelectedTabIndexProperty = DependencyProperty.Register("SelectedTabIndex", typeof(int), typeof(SettingsMemoryInputFxTab));

        public int SelectedTabIndex
        {
            get => (int)GetValue(SelectedTabIndexProperty);
            set => SetValue(SelectedTabIndexProperty, value);
        }

        public SettingsMemoryInputFxTab()
        {
            InitializeComponent();
        }
    }
}
