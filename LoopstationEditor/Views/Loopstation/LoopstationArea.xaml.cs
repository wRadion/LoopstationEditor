using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace LoopstationEditor.Views.Loopstation
{
    /// <summary>
    /// Interaction logic for LoopstationArea.xaml
    /// </summary>
    public partial class LoopstationArea : UserControl
    {
        public static DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(LoopstationArea));
        public static DependencyProperty TextOffsetProperty = DependencyProperty.Register("TextOffset", typeof(Thickness), typeof(LoopstationArea));
        public static DependencyProperty PointsProperty = DependencyProperty.Register("Points", typeof(PointCollection), typeof(LoopstationArea));
        public static DependencyProperty CommandProperty = DependencyProperty.Register("Command", typeof(ICommand), typeof(LoopstationArea));
        public static DependencyProperty CommandParameterProperty = DependencyProperty.Register("CommandParameter", typeof(object), typeof(LoopstationArea), new PropertyMetadata(null));

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public Thickness TextOffset
        {
            get => (Thickness)GetValue(TextOffsetProperty);
            set => SetValue(TextOffsetProperty, value);
        }

        public PointCollection Points
        {
            get => (PointCollection)GetValue(PointsProperty);
            set => SetValue(PointsProperty, value);
        }

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public object CommandParameter
        {
            get => GetValue(CommandParameterProperty);
            set => SetValue(CommandParameterProperty, value);
        }

        private bool _hasClicked;

        public LoopstationArea()
        {
            InitializeComponent();

            SetValue(PointsProperty, new PointCollection());
            _hasClicked = false;
        }

        private void Polygon_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _hasClicked = true;
        }

        private void Polygon_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (_hasClicked && Command != null)
            {
                _hasClicked = false;
                Command.Execute(CommandParameter);
            }
        }
    }
}
