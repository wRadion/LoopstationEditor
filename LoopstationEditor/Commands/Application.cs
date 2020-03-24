using System.Windows.Input;

namespace LoopstationEditor.Commands
{
    public static class Application
    {
        public static readonly RoutedUICommand NewSettings = new RoutedUICommand(
            "New Settings",
            "NewSettings",
            typeof(Application),
            new InputGestureCollection()
            {
                new KeyGesture(Key.N, ModifierKeys.Control)
            });

        public static readonly RoutedUICommand OpenSettings = new RoutedUICommand(
            "Open Settings",
            "OpenSettings",
            typeof(Application),
            new InputGestureCollection()
            {
                new KeyGesture(Key.O, ModifierKeys.Control)
            });

        public static readonly RoutedUICommand SaveSettings = new RoutedUICommand(
            "Save Settings",
            "SaveSettings",
            typeof(Application),
            new InputGestureCollection()
            {
                new KeyGesture(Key.S, ModifierKeys.Control)
            });

        public static readonly RoutedUICommand SaveSettingsAs = new RoutedUICommand(
            "Save SettingsAs",
            "SaveSettingsAs",
            typeof(Application),
            new InputGestureCollection()
            {
                new KeyGesture(Key.S, ModifierKeys.Control | ModifierKeys.Alt)
            });
    }
}
