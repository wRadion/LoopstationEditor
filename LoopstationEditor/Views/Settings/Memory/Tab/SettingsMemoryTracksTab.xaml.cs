using System.Windows;
using System.Windows.Controls;

namespace LoopstationEditor.Views.Settings.Memory.Tab
{
    /// <summary>
    /// Interaction logic for SettingsMemoryTracksTab.xaml
    /// </summary>
    public partial class SettingsMemoryTracksTab : UserControl
    {
        public static DependencyProperty SelectedTabIndexProperty = DependencyProperty.Register("SelectedTabIndex", typeof(int), typeof(SettingsMemoryTracksTab));

        public int SelectedTabIndex
        {
            get => (int)GetValue(SelectedTabIndexProperty);
            set => SetValue(SelectedTabIndexProperty, value);
        }

        public SettingsMemoryTracksTab()
        {
            InitializeComponent();
        }
    }
}
