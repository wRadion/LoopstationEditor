using Loopstation.Xml.Memory;

namespace Loopstation.Model.Memory
{
    public enum MasterPhonesOut { MAIN, MONITOR }
    public enum MasterPhonesOutTracks { }

    public class ModelMasterSettings
    {
        // TODO Level (0...100) *2
        private int _lvl;
        public int Level { get; set; }

        // TODO Tempo (400...2500) /10
        private int _tmp;
        public int Tempo { get; set; }

        // TODO Eq/Comp (0...40) -20
        private int _cs;
        public int Compressor { get; set; }

        public int Reverb { get; set; }
        public MasterPhonesOut PhonesOut { get; set; }
        // TODO Bitwse Master>PhonesOutTracks
        public MasterPhonesOutTracks PhonesOutTracks { get; set; }

        public ModelMasterSettings(XmlMasterSettings xmlMaster)
        {
            Level = xmlMaster.Level;
            Tempo = xmlMaster.Tempo;
            Compressor = xmlMaster.Compressor;
            Reverb = xmlMaster.Reverb;
            PhonesOut = (MasterPhonesOut)xmlMaster.PhonesOut;
            PhonesOutTracks = (MasterPhonesOutTracks)xmlMaster.PhonesOutTracks;
        }
    }
}
