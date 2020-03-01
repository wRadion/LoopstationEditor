using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;

namespace Loopstation.Xml.System
{
    [XmlRoot("MIDI")]
    public class XmlMIDISettings : ICloneable<XmlMIDISettings>
    {
        [XmlElement("RxCh")]
        public int RxChannel { get; set; } = 0;

        [XmlElement("Omni")]
        public int Omni { get; set; } = 1;

        [XmlElement("TxCh")]
        public int TxChannel { get; set; } = 16;

        [XmlElement("Sync")]
        public int Sync { get; set; } = 0;

        [XmlElement("InSel")]
        public int SyncSource { get; set; } = 0;

        [XmlElement("PcOut")]
        public int PcOut { get; set; } = 1;

        public XmlMIDISettings() { }
        public XmlMIDISettings(XmlMIDISettings other)
        {
            if (other == null) return;

            RxChannel = other.RxChannel;
            Omni = other.Omni;
            TxChannel = other.TxChannel;
            Sync = other.Sync;
            SyncSource = other.SyncSource;
            PcOut = other.PcOut;
        }

        public XmlMIDISettings Clone() => new XmlMIDISettings(this);
    }
}
