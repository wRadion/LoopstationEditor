using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;

namespace Loopstation.Xml.Memory
{
    [XmlRoot("INPUT_FX")]
    public class XmlInputFxSettings : ICloneable<XmlInputFxSettings>
    {
        [XmlElement("Mod")]
        public int Mode { get; set; } = 1;

        [XmlElement("MltMod")]
        public int MultiMode { get; set; } = 0;

        [XmlElement("Sw")]
        public int Switch { get; set; } = 0;

        [XmlElement("Sel")]
        public int Selected { get; set; } = 0;

        [XmlElement("Typ1")]
        public int SelectedSingleFxA { get; set; } = 0;

        [XmlElement("Typ2")]
        public int SelectedSingleFxB { get; set; } = 4;

        [XmlElement("Typ3")]
        public int SelectedSingleFxC { get; set; } = 17;

        [XmlElement("MltSw")]
        public int MultiSwitch { get; set; } = 0;

        [XmlElement("MltTyp1")]
        public int SelectedMultiFxA { get; set; } = 0;

        [XmlElement("MltTyp2")]
        public int SelectedMultiFxB { get; set; } = 3;

        [XmlElement("MltTyp3")]
        public int SelectedMultiFxC { get; set; } = 8;

        public XmlInputFxSettings() { }
        public XmlInputFxSettings(XmlInputFxSettings other)
        {
            if (other == null) return;

            Mode = other.Mode;
            MultiMode = other.MultiMode;
            Switch = other.Switch;
            Selected = other.Selected;
            SelectedSingleFxA = other.SelectedSingleFxA;
            SelectedSingleFxB = other.SelectedSingleFxB;
            SelectedSingleFxC = other.SelectedSingleFxC;
            MultiSwitch = other.MultiSwitch;
            SelectedMultiFxA = other.SelectedMultiFxA;
            SelectedMultiFxB = other.SelectedMultiFxB;
            SelectedMultiFxC = other.SelectedMultiFxC;
        }

        public XmlInputFxSettings Clone() => new XmlInputFxSettings(this);
    }
}
