﻿using System.Windows;
using System.Windows.Controls;

namespace LoopstationEditor.Views.Property
{
    /// <summary>
    /// Interaction logic for PropertyEnumCombo.xaml
    /// </summary>
    public partial class PropertyEnumCombo : UserControl
    {
        public static DependencyPropertyKey ValuePropertyKey = DependencyProperty.RegisterReadOnly("Value", typeof(string), typeof(PropertyEnumCombo), new PropertyMetadata(string.Empty));

        public string Value
        {
            get => (string)GetValue(ValuePropertyKey.DependencyProperty);
            private set => SetValue(ValuePropertyKey, value);
        }

        public PropertyEnumCombo()
        {
            InitializeComponent();
            DataContextChanged += (sender, e) => UpdateValue();
        }

        private void EnumBox_SelectionChanged(object sender, SelectionChangedEventArgs e) => UpdateValue();

        private void UpdateValue() => Value = (string)EnumBox.SelectedValue;
    }
}
