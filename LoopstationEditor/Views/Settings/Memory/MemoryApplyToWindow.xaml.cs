using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using LoopstationEditor.Utils;
using LoopstationEditor.ViewModels.Settings.Memory;

namespace LoopstationEditor.Views.Settings.Memory
{
    public class MemoryApplyToWindowState
    {
        public int ComboBox_SelectedIndex;
        public bool? All_Except_IsChecked;
        public string All_ExceptTextBox_Text;
        public string Only_TextBox_Text;
        public int Range_Minimum_Value;
        public int Range_Maximum_Value;
        public int Previous_X_Value;
        public int Next_X_Value;
    }

    /// <summary>
    /// Interaction logic for MemoryApplyToWindow.xaml
    /// </summary>
    public partial class MemoryApplyToWindow : XenionDark.Windows.Window
    {
        private readonly MemoryApplyToWindowViewModel _viewModel;

        public MemoryApplyToWindow(MemoryApplyToWindowViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;

            LoadState();
        }

        private bool ApplyToAll()
        {
            int[] excepts = new int[0];

            if ((bool)All_Except.IsChecked)
            {
                string input = Regex.Replace(All_ExceptTextBox.Text, "\\s", "");

                if (Regex.IsMatch(input, "(\\d+,)*\\d+"))
                    excepts = input.Split(',').Select((s) => int.Parse(s)).ToArray();
                else
                {
                    MessageBox.Show("The input is not in expected format.", "Error Except Numbers", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }

                if (excepts.Any((i) => 1 > i || i > 99))
                {
                    MessageBox.Show("The memory numbers must be between 1 and 99.", "Error Except Numbers", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }

            _viewModel.ApplyToAllMemories.Execute(excepts);
            return true;
        }

        private bool ApplyToOnly()
        {
            int[] only = new int[0];

            string input = Regex.Replace(Only_TextBox.Text, "\\s", "");

            if (Regex.IsMatch(input, "(\\d+,)*\\d+"))
                only = input.Split(',').Select((s) => int.Parse(s)).ToArray();
            else
            {
                MessageBox.Show("The input is not in expected format.", "Error Specifics Numbers", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            if (only.Any((i) => 1 > i || i > 99))
            {
                MessageBox.Show("The memory numbers must be between 1 and 99.", "Error Specifics Numbers", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            _viewModel.ApplyToOnlyMemories.Execute(only);
            return true;
        }

        private bool ApplyToRange()
        {
            int min = Range_Minimum.Value;
            int max = Range_Maximum.Value;

            _viewModel.ApplyToRangeMemories.Execute(new object[] { min, max });
            return true;
        }

        private bool ApplyToPrevious()
        {
            _viewModel.ApplyToPreviousMemories.Execute(Previous_X.Value);
            return true;
        }

        private bool ApplyToNext()
        {
            _viewModel.ApplyToNextMemories.Execute(Next_X.Value);
            return true;
        }

        private void LoadState()
        {
            MemoryApplyToWindowState state = Global.Instance.MemoryApplyToWindowState;

            if (state == null) return;

            ComboBox.SelectedIndex = state.ComboBox_SelectedIndex;
            All_Except.IsChecked = state.All_Except_IsChecked;
            All_ExceptTextBox.Text = state.All_ExceptTextBox_Text;
            Only_TextBox.Text = state.Only_TextBox_Text;
            Range_Minimum.Value = state.Range_Minimum_Value;
            Range_Minimum.Text = state.Range_Minimum_Value.ToString();
            Range_Maximum.Value = state.Range_Maximum_Value;
            Range_Maximum.Text = state.Range_Maximum_Value.ToString();
            Previous_X.Value = state.Previous_X_Value;
            Previous_X.Text = state.Previous_X_Value.ToString();
            Next_X.Value = state.Next_X_Value;
            Next_X.Text = state.Next_X_Value.ToString();
        }

        private void CopyState()
        {
            Global.Instance.MemoryApplyToWindowState = new MemoryApplyToWindowState()
            {
                ComboBox_SelectedIndex = ComboBox.SelectedIndex,
                All_Except_IsChecked = All_Except.IsChecked,
                All_ExceptTextBox_Text = All_ExceptTextBox.Text,
                Only_TextBox_Text = Only_TextBox.Text,
                Range_Minimum_Value = Range_Minimum.Value,
                Range_Maximum_Value = Range_Maximum.Value,
                Previous_X_Value = Previous_X.Value,
                Next_X_Value = Next_X.Value
            };
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            bool result;

            switch (((ComboBoxItem)ComboBox.SelectedItem).Name)
            {
                case "All": result = ApplyToAll(); break;
                case "Only": result = ApplyToOnly(); break;
                case "Range": result = ApplyToRange(); break;
                case "Previous": result = ApplyToPrevious(); break;
                case "Next": result = ApplyToNext(); break;
                default: throw new NotImplementedException();
            }

            if (result)
            {
                CopyState();
                Close();
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e) => Close();
    }
}
