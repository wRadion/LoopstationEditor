using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;

namespace Loopstation.Xml.Memory
{
    [XmlRoot("MASTER")]
    public class XmlMasterSettings : ICloneable<XmlMasterSettings>
    {
        [XmlElement("Lvl")]
        public int Level { get; set; } = 50;

        [XmlElement("Tmp")]
        public int Tempo { get; set; } = 1200;

        [XmlElement("Cs")]
        public int Compressor { get; set; } = 0;

        [XmlElement("Rv")]
        public int Reverb { get; set; } = 0;

        [XmlElement("PhOut")]
        public int PhonesOut { get; set; } = 0;

        [XmlElement("PhOutTr")]
        public int PhonesOutTracks { get; set; } = 31;

        public XmlMasterSettings() { }
        public XmlMasterSettings(XmlMasterSettings other)
        {
            if (other == null) return;

            Level = other.Level;
            Tempo = other.Tempo;
            Compressor = other.Compressor;
            Reverb = other.Reverb;
            PhonesOut = other.PhonesOut;
            PhonesOutTracks = other.PhonesOutTracks;
        }

        public XmlMasterSettings Clone() => new XmlMasterSettings(this);
    }
}
