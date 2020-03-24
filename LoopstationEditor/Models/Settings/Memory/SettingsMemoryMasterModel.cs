using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory
{
    public enum MasterPhonesOut { MAIN = 0, MONITOR = 1 }

    public class SettingsMemoryMasterModel : SettingsModel
    {
        [XmlElement("Lvl", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt Level { get; set; }

        [XmlElement("Tmp", typeof(int))]
        [Property(1200, 400, 2500)]
        public ValueInt Tempo { get; set; }

        [XmlElement("Cs", typeof(int))]
        [Property(0, 0, 40)]
        public ValueInt Compressor { get; set; }

        [XmlElement("Rv", typeof(int))]
        [Property(0, 0, 100)]
        public ValueInt Reverb { get; set; }

        [XmlElement("PhOut", typeof(int))]
        [Property(MasterPhonesOut.MAIN, 0, 1)]
        public ValueEnum<MasterPhonesOut> PhonesOut { get; set; }

        [XmlElement("PhOutTr", typeof(int))]
        [Property(TrackBitwise.ALL, 0, 31)]
        public ValueEnum<TrackBitwise> PhonesOutTracks { get; set; }

        public SettingsMemoryMasterModel() : base() { }
    }
}
