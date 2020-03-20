using System.Windows;
using System.Windows.Controls;

namespace LoopstationEditor.Views.Settings.Memory.Tab
{
    /// <summary>
    /// Interaction logic for SettingsMemoryAssignsTab.xaml
    /// </summary>
    public partial class SettingsMemoryAssignsTab : UserControl
    {
        public static DependencyProperty SelectedTabIndexProperty = DependencyProperty.Register("SelectedTabIndex", typeof(int), typeof(SettingsMemoryAssignsTab));

        public int SelectedTabIndex
        {
            get => (int)GetValue(SelectedTabIndexProperty);
            set => SetValue(SelectedTabIndexProperty, value);
        }

        public SettingsMemoryAssignsTab()
        {
            InitializeComponent();
        }
    }
}
