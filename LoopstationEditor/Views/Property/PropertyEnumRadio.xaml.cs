using LoopstationEditor.ViewModels.PropertyEngine;
using System;
using System.Windows;
using System.Windows.Controls;

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
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Value = (string)DataContext.GetType().GetProperty(nameof(PropertyEnumRadioViewModel<Enum>.Value)).GetValue(DataContext);
        }
    }
}
