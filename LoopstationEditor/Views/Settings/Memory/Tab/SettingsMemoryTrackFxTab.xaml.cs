using System.Windows;
using System.Windows.Controls;

namespace LoopstationEditor.Views.Settings.Memory.Tab
{
    /// <summary>
    /// Interaction logic for SettingsMemoryTrackFxTab.xaml
    /// </summary>
    public partial class SettingsMemoryTrackFxTab : UserControl
    {
        public static DependencyProperty SelectedTabIndexProperty = DependencyProperty.Register("SelectedTabIndex", typeof(int), typeof(SettingsMemoryTrackFxTab));

        public int SelectedTabIndex
        {
            get => (int)GetValue(SelectedTabIndexProperty);
            set => SetValue(SelectedTabIndexProperty, value);
        }

        public SettingsMemoryTrackFxTab()
        {
            InitializeComponent();
        }
    }
}
