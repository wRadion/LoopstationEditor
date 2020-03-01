using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;

namespace Loopstation.Xml.System
{
    [XmlRoot("SETUP")]
    public class XmlSetupSettings : ICloneable<XmlSetupSettings>
    {
        [XmlElement("MemNum")]
        public int MemoryNumber { get; set; } = 0;

        [XmlElement("LcdContrast")]
        public int LCDContrast { get; set; } = 7;

        [XmlElement("PhantomPwr")]
        public int PhantomPower { get; set; } = 0;

        [XmlElement("DispMod")]
        public int DisplayMode { get; set; } = 0;

        [XmlElement("IndMod")]
        public int IndicatorMode { get; set; } = 0;

        [XmlElement("AutoOff")]
        public int AutoOff { get; set; } = 1;

        [XmlElement("AllClr")]
        public int AllClear { get; set; } = 0;

        [XmlElement("QuickClr")]
        public int QuickClear { get; set; } = 0;

        [XmlElement("KnobMod")]
        public int KnobMode { get; set; } = 0;

        public XmlSetupSettings() { }
        public XmlSetupSettings(XmlSetupSettings other)
        {
            if (other == null) return;

            MemoryNumber = other.MemoryNumber;
            LCDContrast = other.LCDContrast;
            PhantomPower = other.PhantomPower;
            DisplayMode = other.DisplayMode;
            IndicatorMode = other.IndicatorMode;
            AutoOff = other.AutoOff;
            AllClear = other.AllClear;
            QuickClear = other.QuickClear;
            KnobMode = other.KnobMode;
        }

        public XmlSetupSettings Clone() => new XmlSetupSettings(this);
    }
}
