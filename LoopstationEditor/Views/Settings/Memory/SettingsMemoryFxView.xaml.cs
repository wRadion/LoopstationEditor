using System;
using System.Windows.Controls;

using LoopstationEditor.ViewModels.Settings.Memory;

namespace LoopstationEditor.Views.Settings.Memory
{
    /// <summary>
    /// Interaction logic for SettingsMemoryFxView.xaml
    /// </summary>
    public partial class SettingsMemoryFxView : UserControl
    {
        public SettingsMemoryFxView()
        {
            InitializeComponent();
        }

        private void FxListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count == 0)
                MainContent.Child = null;
            else
            {
                FxItem selectedFx = (FxItem)e.AddedItems[0];
                MainContent.Child = (UserControl)Activator.CreateInstance(selectedFx.ViewType, selectedFx.ViewModel);
            }
        }
    }
}
