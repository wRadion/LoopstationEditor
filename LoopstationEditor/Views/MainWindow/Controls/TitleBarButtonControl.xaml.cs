using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LoopstationEditor.Views.MainWindow.Controls
{
    /// <summary>
    /// Interaction logic for TitleBarButtonControl.xaml
    /// </summary>
    public partial class TitleBarButtonControl : UserControl
    {
        public static DependencyProperty CommandProperty =
            DependencyProperty.Register("Command", typeof(ICommand), typeof(TitleBarButtonControl));
        public static DependencyProperty IconPathProperty =
            DependencyProperty.Register("IconPath", typeof(string), typeof(TitleBarButtonControl));

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public string IconPath
        {
            get => (string)GetValue(IconPathProperty);
            set => SetValue(IconPathProperty, value);
        }

        public TitleBarButtonControl()
        {
            InitializeComponent();
        }
    }
}
