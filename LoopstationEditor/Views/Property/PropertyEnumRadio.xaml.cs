using System;
using System.Windows;
using System.Windows.Controls;

using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.Views.Property
{
    /// <summary>
    /// Interaction logic for PropertyEnumRadio.xaml
    /// </summary>
    public partial class PropertyEnumRadio : UserControl
    {
        public static DependencyPropertyKey ValuePropertyKey = DependencyProperty.RegisterReadOnly("Value", typeof(string), typeof(PropertyEnumRadio), new PropertyMetadata(string.Empty));

        public string Value
        {
            get => (string)GetValue(ValuePropertyKey.DependencyProperty);
            private set => SetValue(ValuePropertyKey, value);
        }

        public PropertyEnumRadio()
        {
            InitializeComponent();
            DataContextChanged += (sender, e) => UpdateValue();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e) => UpdateValue();

        private void UpdateValue()
        {
            Value = (string)DataContext.GetType().GetProperty(nameof(PropertyEnumRadioViewModel<Enum>.Value)).GetValue(DataContext);
        }
    }
}
