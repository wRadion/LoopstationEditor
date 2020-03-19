using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoopstationEditor.Views.Settings.Memory
{
    /// <summary>
    /// Interaction logic for SettingsMemoryNameView.xaml
    /// </summary>
    public partial class SettingsMemoryNameView : UserControl
    {
        public SettingsMemoryNameView()
        {
            InitializeComponent();
        }

        private void UpdateText()
        {
            if (NameBox.Text.Length > 12)
            {
                NameBox.Text = NameBox.Text.Substring(0, 12);
                NameBox.CaretIndex = NameBox.Text.Length;
            }
        }

        private void NameBox_TextChanged(object sender, TextChangedEventArgs e) => UpdateText();
        private void NameBox_TextInput(object sender, TextCompositionEventArgs e) => UpdateText();
    }
}
