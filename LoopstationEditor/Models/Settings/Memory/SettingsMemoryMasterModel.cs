using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory
{
    public enum MasterPhonesOut { MAIN = 0, MONITOR = 1 }

    public static class MasterProperty
    {
        public const string Level = "Lvl";
        public const string Tempo = "Tmp";
        public const string Compressor = "Cs";
        public const string Reverb = "Rv";
        public const string PhonesOut = "PhOut";
        public const string PhonesOutTracks = "PhOutTr";
    }

    public class SettingsMemoryMasterModel : SettingsModel
    {
        [XmlElement(MasterProperty.Level, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt Level { get; set; }

        [XmlElement(MasterProperty.Tempo, typeof(int))]
        [Property(1200, 400, 2500)]
        public ValueInt Tempo { get; set; }

        [XmlElement(MasterProperty.Compressor, typeof(int))]
        [Property(0, 0, 40)]
        public ValueInt Compressor { get; set; }

        [XmlElement(MasterProperty.Reverb, typeof(int))]
        [Property(0, 0, 100)]
        public ValueInt Reverb { get; set; }

        [XmlElement(MasterProperty.PhonesOut, typeof(int))]
        [Property(MasterPhonesOut.MAIN, 0, 1)]
        public ValueEnum<MasterPhonesOut> PhonesOut { get; set; }

        [XmlElement(MasterProperty.PhonesOutTracks, typeof(int))]
        [Property(TrackBitwise.ALL, 0, 31)]
        public ValueEnum<TrackBitwise> PhonesOutTracks { get; set; }

        public SettingsMemoryMasterModel() : base() { }
    }
}
