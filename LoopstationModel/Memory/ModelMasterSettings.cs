using Loopstation.Xml.Memory;

namespace Loopstation.Model.Memory
{
    public enum MasterPhonesOut { MAIN, MONITOR }
    public enum MasterPhonesOutTracks { }

    public class ModelMasterSettings
    {
        // TODO Level (0...100) *2
        private int _lvl;
        public int Level { get; set; } = 50;

        // TODO Tempo (400...2500) /10
        private int _tmp;
        public int Tempo { get; set; } = 1200;

        // TODO Eq/Comp (0...40) -20
        private int _cs;
        public int Compressor { get; set; } = 0;

        public int Reverb { get; set; } = 0;
        public MasterPhonesOut PhonesOut { get; set; } = MasterPhonesOut.MAIN;
        // TODO Bitwise Master>PhonesOutTracks
        // TODO Bitwise Default Value 31 (ALL)
        public MasterPhonesOutTracks PhonesOutTracks { get; set; }

        public ModelMasterSettings() : this(null) { }
        public ModelMasterSettings(XmlMasterSettings xmlMaster)
        {
            if (xmlMaster == null) return;

            Level = xmlMaster.Level;
            Tempo = xmlMaster.Tempo;
            Compressor = xmlMaster.Compressor;
            Reverb = xmlMaster.Reverb;
            PhonesOut = (MasterPhonesOut)xmlMaster.PhonesOut;
            PhonesOutTracks = (MasterPhonesOutTracks)xmlMaster.PhonesOutTracks;
        }
    }
}
