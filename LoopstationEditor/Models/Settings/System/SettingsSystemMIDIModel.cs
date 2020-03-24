using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.System
{
    public enum MIDITxChannel { RX = 16 }
    public enum MIDISync { AUTO = 0, INTERNAL = 1 }
    public enum MIDISyncSource { USB = 0, MIDI = 1 }

    public class SettingsSystemMIDIModel : SettingsModel
    {
        [XmlElement("RxCh", typeof(int))]
        [Property(0, 0, 15)]
        public ValueInt RxChannel { get; set; }

        [XmlElement("Omni", typeof(int))]
        [Property(true, 0, 1)]
        public ValueBool Omni { get; set; }

        [XmlElement("TxCh", typeof(int))]
        [PropertyMixed(MIDITxChannel.RX, 0, 16, 0, 15)]
        public ValueInt TxChannel { get; set; }

        [XmlElement("Sync", typeof(int))]
        [Property(MIDISync.AUTO, 0, 1)]
        public ValueEnum<MIDISync> Sync { get; set; }

        [XmlElement("InSel", typeof(int))]
        [Property(MIDISyncSource.USB, 0, 1)]
        public ValueEnum<MIDISyncSource> SyncSource { get; set; }

        [XmlElement("PcOut", typeof(int))]
        [Property(true, 0, 1)]
        public ValueBool PCOut { get; set; }

        public SettingsSystemMIDIModel() : base() { }
    }
}
