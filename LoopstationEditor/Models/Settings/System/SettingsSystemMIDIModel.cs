using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.System
{
    public enum MIDITxChannel { RX = 16 }
    public enum MIDISync { AUTO = 0, INTERNAL = 1 }
    public enum MIDISyncSource { USB = 0, MIDI = 1 }

    public static class MIDIProperty
    {
        public const string RxChannel = "RxCh";
        public const string Omni = "Omni";
        public const string TxChannel = "TxCh";
        public const string Sync = "Sync";
        public const string SyncSource = "InSel";
        public const string PCOut = "PcOut";
    }

    public class SettingsSystemMIDIModel : SettingsModel
    {
        [XmlElement(MIDIProperty.RxChannel, typeof(int))]
        [Property(0, 0, 15)]
        public ValueInt RxChannel { get; set; }

        [XmlElement(MIDIProperty.Omni, typeof(int))]
        [Property(true, 0, 1)]
        public ValueBool Omni { get; set; }

        [XmlElement(MIDIProperty.TxChannel, typeof(int))]
        [PropertyMixed(MIDITxChannel.RX, 0, 16, 0, 15)]
        public ValueInt TxChannel { get; set; }

        [XmlElement(MIDIProperty.Sync, typeof(int))]
        [Property(MIDISync.AUTO, 0, 1)]
        public ValueEnum<MIDISync> Sync { get; set; }

        [XmlElement(MIDIProperty.SyncSource, typeof(int))]
        [Property(MIDISyncSource.USB, 0, 1)]
        public ValueEnum<MIDISyncSource> SyncSource { get; set; }

        [XmlElement(MIDIProperty.PCOut, typeof(int))]
        [Property(true, 0, 1)]
        public ValueBool PCOut { get; set; }

        public SettingsSystemMIDIModel() : base() { }
    }
}
