using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;
using Loopstation.Xml.Utils;

namespace Loopstation.Xml.System
{
    [XmlRoot("SETUP")]
    public class XmlSetupSettings : ICloneable<XmlSetupSettings>
    {
        private int _memoryNumber;
        private int _lcdContrast;
        private int _phantomPower;
        private int _displayMode;
        private int _indicatorMode;
        private int _autoOff;
        private int _allClear;
        private int _quickClear;
        private int _knobMode;

        /// <summary>
        /// Integer from <c>0</c> to <c>98</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("MemNum")]
        public int MemoryNumber
        {
            get => _memoryNumber;
            set => _memoryNumber = Range.Guard(value, max: 98);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>15</c>.
        /// <para>Default value is <c>7</c>.</para>
        /// </summary>
        [XmlElement("LcdContrast")]
        public int LCDContrast
        {
            get => _lcdContrast;
            set => _lcdContrast = Range.Guard(value, max: 15);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("PhantomPwr")]
        public int PhantomPower
        {
            get => _phantomPower;
            set => _phantomPower = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>6</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// Values: <c>[0]...6</c>
        /// </summary>
        [XmlElement("DispMod")]
        public int DisplayMode
        {
            get => _displayMode;
            set => _displayMode = Range.Guard(value, max: 6);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>3</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("IndMod")]
        public int IndicatorMode
        {
            get => _indicatorMode;
            set => _indicatorMode = Range.Guard(value, max: 3);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>1</c>.</para>
        /// </summary>
        [XmlElement("AutoOff")]
        public int AutoOff
        {
            get => _autoOff;
            set => _autoOff = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("AllClr")]
        public int AllClear
        {
            get => _allClear;
            set => _allClear = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("QuickClr")]
        public int QuickClear
        {
            get => _quickClear;
            set => _quickClear = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("KnobMod")]
        public int KnobMode
        {
            get => _knobMode;
            set => _knobMode = Range.Guard(value, max: 1);
        }

        public XmlSetupSettings() : this(null) { }
        public XmlSetupSettings(XmlSetupSettings other)
        {
            MemoryNumber  = other?.MemoryNumber  ?? 0;
            LCDContrast   = other?.LCDContrast   ?? 7;
            PhantomPower  = other?.PhantomPower  ?? 0;
            DisplayMode   = other?.DisplayMode   ?? 0;
            IndicatorMode = other?.IndicatorMode ?? 0;
            AutoOff       = other?.AutoOff       ?? 1;
            AllClear      = other?.AllClear      ?? 0;
            QuickClear    = other?.QuickClear    ?? 0;
            KnobMode      = other?.KnobMode      ?? 0;
        }

        public XmlSetupSettings Clone() => new XmlSetupSettings(this);
    }
}
