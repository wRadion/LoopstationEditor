using System;
using System.Xml.Serialization;

namespace Loopstation.Xml.System
{
    [XmlRoot("INPUT_OUTPUT")]
    public class XmlInputOutputSettings : ICloneable
    {
        [XmlElement("InNsThrs")]
        public int InputNSTreshold { get; set; } = 40;

        [XmlElement("LineOutLvl")]
        public int LineOutLevel { get; set; } = 50;

        [XmlElement("InSrc")]
        public int InputSource { get; set; } = 1;

        [XmlElement("InLineOut")]
        public int InputLineOut { get; set; } = 1;

        [XmlElement("OutLvlSel")]
        public int OutputLevelSelection { get; set; } = 0;

        public XmlInputOutputSettings() { }
        public XmlInputOutputSettings(XmlInputOutputSettings other)
        {
            if (other == null) return;

            InputNSTreshold = other.InputNSTreshold;
            LineOutLevel = other.LineOutLevel;
            InputSource = other.InputSource;
            InputLineOut = other.InputLineOut;
            OutputLevelSelection = other.OutputLevelSelection;
        }

        public object Clone() => new XmlInputOutputSettings(this);
    }
}
