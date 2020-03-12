using System.Windows.Controls;

namespace LoopstationEditor.Views.Settings
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : XenionDark.Windows.Window
    {
        public SettingsWindow(string title, UserControl control)
        {
            InitializeComponent();
            Title = title;
            Content = control;
        }
    }
}
