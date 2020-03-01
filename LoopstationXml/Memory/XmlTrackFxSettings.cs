using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;

namespace Loopstation.Xml.Memory
{
    [XmlRoot("TRACK_FX")]
    public class XmlTrackFxSettings : ICloneable<XmlTrackFxSettings>
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
        public int SelectedSingleFxA { get; set; } = 2;

        [XmlElement("Typ2")]
        public int SelectedSingleFxB { get; set; } = 20;

        [XmlElement("Typ3")]
        public int SelectedSingleFxC { get; set; } = 27;

        [XmlElement("MltSw")]
        public int MultiSwitch { get; set; } = 0;

        [XmlElement("MltTyp1")]
        public int SelectedMultiFxA { get; set; } = 19;

        [XmlElement("MltTyp2")]
        public int SelectedMultiFxB { get; set; } = 2;

        [XmlElement("MltTyp3")]
        public int SelectedMultiFxC { get; set; } = 11;

        public XmlTrackFxSettings() { }
        public XmlTrackFxSettings(XmlTrackFxSettings other)
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

        public XmlTrackFxSettings Clone() => new XmlTrackFxSettings(this);
    }
}
