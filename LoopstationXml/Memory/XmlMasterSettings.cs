using System;
using System.Xml.Serialization;

namespace Loopstation.Xml.Memory
{
    [XmlRoot("MASTER")]
    public class XmlMasterSettings : ICloneable
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

        public object Clone() => new XmlMasterSettings(this);
    }
}
