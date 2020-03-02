using System.Xml.Serialization;

using Loopstation.Common;

namespace Loopstation.Xml.Memory
{
    [XmlRoot("INPUT_FX")]
    public class XmlInputFxSettings : ICloneable<XmlInputFxSettings>
    {
        private int _mode;
        private int _multiMode;
        private int _switch;
        private int _selected;
        private int _selectedSingleFxA;
        private int _selectedSingleFxB;
        private int _selectedSingleFxC;
        private int _multiSwitch;
        private int _selectedMultiFxA;
        private int _selectedMultiFxB;
        private int _selectedMultiFxC;

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>1</c>.</para>
        /// </summary>
        [XmlElement("Mod")]
        public int Mode
        {
            get => _mode;
            set => _mode = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("MltMod")]
        public int MultiMode
        {
            get => _multiMode;
            set => _multiMode = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>3</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("Sw")]
        public int Switch
        {
            get => _switch;
            set => _switch = Range.Guard(value, max: 3);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>2</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("Sel")]
        public int Selected
        {
            get => _selected;
            set => _selected = Range.Guard(value, max: 2);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>26</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("Typ1")]
        public int SelectedSingleFxA
        {
            get => _selectedSingleFxA;
            set => _selectedSingleFxA = Range.Guard(value, max: 26);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>26</c>.
        /// <para>Default value is <c>4</c>.</para>
        /// </summary>
        [XmlElement("Typ2")]
        public int SelectedSingleFxB
        {
            get => _selectedSingleFxB;
            set => _selectedSingleFxB = Range.Guard(value, max: 26);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>26</c>.
        /// <para>Default value is <c>17</c>.</para>
        /// </summary>
        [XmlElement("Typ3")]
        public int SelectedSingleFxC
        {
            get => _selectedSingleFxC;
            set => _selectedSingleFxC = Range.Guard(value, max: 26);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>7</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("MltSw")]
        public int MultiSwitch
        {
            get => _multiSwitch;
            set => _multiSwitch = Range.Guard(value, max: 7);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>18</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("MltTyp1")]
        public int SelectedMultiFxA
        {
            get => _selectedMultiFxA;
            set => _selectedMultiFxA = Range.Guard(value, max: 18);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>14</c>.
        /// <para>Default value is <c>3</c>.</para>
        /// </summary>
        [XmlElement("MltTyp2")]
        public int SelectedMultiFxB
        {
            get => _selectedMultiFxB;
            set => _selectedMultiFxB = Range.Guard(value, max: 14);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>17</c>.
        /// <para>Default value is <c>8</c>.</para>
        /// </summary>
        [XmlElement("MltTyp3")]
        public int SelectedMultiFxC
        {
            get => _selectedMultiFxC;
            set => _selectedMultiFxC = Range.Guard(value, max: 17);
        }

        public XmlInputFxSettings() : this(null) { }
        public XmlInputFxSettings(XmlInputFxSettings other)
        {
            Mode              = other?.Mode              ?? 1;
            MultiMode         = other?.MultiMode         ?? 0;
            Switch            = other?.Switch            ?? 0;
            Selected          = other?.Selected          ?? 0;
            SelectedSingleFxA = other?.SelectedSingleFxA ?? 0;
            SelectedSingleFxB = other?.SelectedSingleFxB ?? 4;
            SelectedSingleFxC = other?.SelectedSingleFxC ?? 17;
            MultiSwitch       = other?.MultiSwitch       ?? 0;
            SelectedMultiFxA  = other?.SelectedMultiFxA  ?? 0;
            SelectedMultiFxB  = other?.SelectedMultiFxB  ?? 3;
            SelectedMultiFxC  = other?.SelectedMultiFxC  ?? 8;
        }

        public XmlInputFxSettings Clone() => new XmlInputFxSettings(this);
    }
}
