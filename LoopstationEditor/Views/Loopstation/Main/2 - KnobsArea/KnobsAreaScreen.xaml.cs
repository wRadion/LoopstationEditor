using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LoopstationEditor.Views.Loopstation.Main.KnobsArea
{
    /// <summary>
    /// Interaction logic for KnobsAreaScreen.xaml
    /// </summary>
    public partial class KnobsAreaScreen : UserControl
    {
        public static DependencyProperty TextLine1Property = DependencyProperty.Register("TextLine1", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty TextLine2Property = DependencyProperty.Register("TextLine2", typeof(string), typeof(KnobsAreaScreen));

        #region CharsProperty
        public static DependencyProperty Char1Property = DependencyProperty.Register("Char1", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char2Property = DependencyProperty.Register("Char2", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char3Property = DependencyProperty.Register("Char3", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char4Property = DependencyProperty.Register("Char4", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char5Property = DependencyProperty.Register("Char5", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char6Property = DependencyProperty.Register("Char6", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char7Property = DependencyProperty.Register("Char7", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char8Property = DependencyProperty.Register("Char8", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char9Property = DependencyProperty.Register("Char9", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char10Property = DependencyProperty.Register("Char10", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char11Property = DependencyProperty.Register("Char11", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char12Property = DependencyProperty.Register("Char12", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char13Property = DependencyProperty.Register("Char13", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char14Property = DependencyProperty.Register("Char14", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char15Property = DependencyProperty.Register("Char15", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char16Property = DependencyProperty.Register("Char16", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char17Property = DependencyProperty.Register("Char17", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char18Property = DependencyProperty.Register("Char18", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char19Property = DependencyProperty.Register("Char19", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char20Property = DependencyProperty.Register("Char20", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char21Property = DependencyProperty.Register("Char21", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char22Property = DependencyProperty.Register("Char22", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char23Property = DependencyProperty.Register("Char23", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char24Property = DependencyProperty.Register("Char24", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char25Property = DependencyProperty.Register("Char25", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char26Property = DependencyProperty.Register("Char26", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char27Property = DependencyProperty.Register("Char27", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char28Property = DependencyProperty.Register("Char28", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char29Property = DependencyProperty.Register("Char29", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char30Property = DependencyProperty.Register("Char30", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char31Property = DependencyProperty.Register("Char31", typeof(string), typeof(KnobsAreaScreen));
        public static DependencyProperty Char32Property = DependencyProperty.Register("Char32", typeof(string), typeof(KnobsAreaScreen));
        #endregion CharsProperty

        public string TextLine1
        {
            get => (string)GetValue(TextLine1Property);
            set => SetValue(TextLine1Property, value);
        }
        public string TextLine2
        {
            get => (string)GetValue(TextLine2Property);
            set => SetValue(TextLine2Property, value);
        }

        #region Chars
        public string Char1
        {
            get => (string)GetValue(Char1Property);
            set => SetValue(Char1Property, value);
        }
        public string Char2
        {
            get => (string)GetValue(Char2Property);
            set => SetValue(Char2Property, value);
        }
        public string Char3
        {
            get => (string)GetValue(Char3Property);
            set => SetValue(Char3Property, value);
        }
        public string Char4
        {
            get => (string)GetValue(Char4Property);
            set => SetValue(Char4Property, value);
        }
        public string Char5
        {
            get => (string)GetValue(Char5Property);
            set => SetValue(Char5Property, value);
        }
        public string Char6
        {
            get => (string)GetValue(Char6Property);
            set => SetValue(Char6Property, value);
        }
        public string Char7
        {
            get => (string)GetValue(Char7Property);
            set => SetValue(Char7Property, value);
        }
        public string Char8
        {
            get => (string)GetValue(Char8Property);
            set => SetValue(Char8Property, value);
        }
        public string Char9
        {
            get => (string)GetValue(Char9Property);
            set => SetValue(Char9Property, value);
        }
        public string Char10
        {
            get => (string)GetValue(Char10Property);
            set => SetValue(Char10Property, value);
        }
        public string Char11
        {
            get => (string)GetValue(Char11Property);
            set => SetValue(Char11Property, value);
        }
        public string Char12
        {
            get => (string)GetValue(Char12Property);
            set => SetValue(Char12Property, value);
        }
        public string Char13
        {
            get => (string)GetValue(Char13Property);
            set => SetValue(Char13Property, value);
        }
        public string Char14
        {
            get => (string)GetValue(Char14Property);
            set => SetValue(Char14Property, value);
        }
        public string Char15
        {
            get => (string)GetValue(Char15Property);
            set => SetValue(Char15Property, value);
        }
        public string Char16
        {
            get => (string)GetValue(Char16Property);
            set => SetValue(Char16Property, value);
        }
        public string Char17
        {
            get => (string)GetValue(Char17Property);
            set => SetValue(Char17Property, value);
        }
        public string Char18
        {
            get => (string)GetValue(Char18Property);
            set => SetValue(Char18Property, value);
        }
        public string Char19
        {
            get => (string)GetValue(Char19Property);
            set => SetValue(Char19Property, value);
        }
        public string Char20
        {
            get => (string)GetValue(Char20Property);
            set => SetValue(Char20Property, value);
        }
        public string Char21
        {
            get => (string)GetValue(Char21Property);
            set => SetValue(Char21Property, value);
        }
        public string Char22
        {
            get => (string)GetValue(Char22Property);
            set => SetValue(Char22Property, value);
        }
        public string Char23
        {
            get => (string)GetValue(Char23Property);
            set => SetValue(Char23Property, value);
        }
        public string Char24
        {
            get => (string)GetValue(Char24Property);
            set => SetValue(Char24Property, value);
        }
        public string Char25
        {
            get => (string)GetValue(Char25Property);
            set => SetValue(Char25Property, value);
        }
        public string Char26
        {
            get => (string)GetValue(Char26Property);
            set => SetValue(Char26Property, value);
        }
        public string Char27
        {
            get => (string)GetValue(Char27Property);
            set => SetValue(Char27Property, value);
        }
        public string Char28
        {
            get => (string)GetValue(Char28Property);
            set => SetValue(Char28Property, value);
        }
        public string Char29
        {
            get => (string)GetValue(Char29Property);
            set => SetValue(Char29Property, value);
        }
        public string Char30
        {
            get => (string)GetValue(Char30Property);
            set => SetValue(Char30Property, value);
        }
        public string Char31
        {
            get => (string)GetValue(Char31Property);
            set => SetValue(Char31Property, value);
        }
        public string Char32
        {
            get => (string)GetValue(Char32Property);
            set => SetValue(Char32Property, value);
        }
        #endregion Chars

        public KnobsAreaScreen()
        {
            InitializeComponent();
        }

        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
            if (e.Property.Name != TextLine1Property.Name && e.Property.Name != TextLine2Property.Name) return;

            string line = (string)e.NewValue;

            if (e.Property.Name == TextLine1Property.Name)
            {
                Char1 = line.Length > 0 ? line[0].ToString() : " ";
                Char2 = line.Length > 1 ? line[1].ToString() : " ";
                Char3 = line.Length > 2 ? line[2].ToString() : " ";
                Char4 = line.Length > 3 ? line[3].ToString() : " ";
                Char5 = line.Length > 4 ? line[4].ToString() : " ";
                Char6 = line.Length > 5 ? line[5].ToString() : " ";
                Char7 = line.Length > 6 ? line[6].ToString() : " ";
                Char8 = line.Length > 7 ? line[7].ToString() : " ";
                Char9 = line.Length > 8 ? line[8].ToString() : " ";
                Char10 = line.Length > 9 ? line[9].ToString() : " ";
                Char11 = line.Length > 10 ? line[10].ToString() : " ";
                Char12 = line.Length > 11 ? line[11].ToString() : " ";
                Char13 = line.Length > 12 ? line[12].ToString() : " ";
                Char14 = line.Length > 13 ? line[13].ToString() : " ";
                Char15 = line.Length > 14 ? line[14].ToString() : " ";
                Char16 = line.Length > 15 ? line[15].ToString() : " ";
            }
            else if (e.Property.Name == TextLine2Property.Name)
            {
                Char17 = line.Length > 0 ? line[0].ToString() : " ";
                Char18 = line.Length > 1 ? line[1].ToString() : " ";
                Char19 = line.Length > 2 ? line[2].ToString() : " ";
                Char20 = line.Length > 3 ? line[3].ToString() : " ";
                Char21 = line.Length > 4 ? line[4].ToString() : " ";
                Char22 = line.Length > 5 ? line[5].ToString() : " ";
                Char23 = line.Length > 6 ? line[6].ToString() : " ";
                Char24 = line.Length > 7 ? line[7].ToString() : " ";
                Char25 = line.Length > 8 ? line[8].ToString() : " ";
                Char26 = line.Length > 9 ? line[9].ToString() : " ";
                Char27 = line.Length > 10 ? line[10].ToString() : " ";
                Char28 = line.Length > 11 ? line[11].ToString() : " ";
                Char29 = line.Length > 12 ? line[12].ToString() : " ";
                Char30 = line.Length > 13 ? line[13].ToString() : " ";
                Char31 = line.Length > 14 ? line[14].ToString() : " ";
                Char32 = line.Length > 15 ? line[15].ToString() : " ";
            }
        }
    }
}
