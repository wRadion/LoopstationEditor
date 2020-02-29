using System.Windows;
using System.Windows.Controls;

namespace LoopstationEditor.Views.Loopstation.Tracks.Controls
{
    /// <summary>
    /// Interaction logic for Track.xaml
    /// </summary>
    public partial class Track : UserControl
    {
        public static DependencyProperty TrackNumberProperty = DependencyProperty.Register("TrackNumber", typeof(int), typeof(Track));

        public int TrackNumber
        {
            get => (int)GetValue(TrackNumberProperty);
            set => SetValue(TrackNumberProperty, value);
        }

        public Track()
        {
            InitializeComponent();
        }
    }
}
