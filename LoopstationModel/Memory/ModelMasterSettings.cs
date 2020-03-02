using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory
{
    public enum MasterPhonesOut       { MAIN, MONITOR }
    public enum MasterPhonesOutTracks { }

    public class ModelMasterSettings
    {
        public int Level // TODO Level (0...100) *2
        {
            get => _levelProperty.Value;
            set => _levelProperty.Value = value;
        }
        public int Tempo // TODO Tempo (400...2500) /10
        {
            get => _tempoProperty.Value;
            set => _tempoProperty.Value = value;
        }
        public int Compressor // TODO Eq/Comp (0...40) -20
        {
            get => _compressorProperty.Value;
            set => _compressorProperty.Value = value;
        }
        public int Reverb
        {
            get => _reverbProperty.Value;
            set => _reverbProperty.Value = value;
        }
        public MasterPhonesOut PhonesOut
        {
            get => _phonesOutProperty.Value;
            set => _phonesOutProperty.Value = value;
        }
        public MasterPhonesOutTracks PhonesOutTracks // TODO Bitwise Master>PhonesOutTracks
        {
            get => _phonesOutTracksProperty.Value;
            set => _phonesOutTracksProperty.Value = value;
        }

        #region private Fields
        private readonly IntProperty _levelProperty;
        private readonly IntProperty _tempoProperty;
        private readonly IntProperty _compressorProperty;
        private readonly IntProperty _reverbProperty;
        private readonly EnumProperty<MasterPhonesOut> _phonesOutProperty;
        private readonly EnumProperty<MasterPhonesOutTracks> _phonesOutTracksProperty;

        private readonly XmlMasterSettings _xml;
        #endregion private Fields

        public ModelMasterSettings(XmlMasterSettings xmlMaster)
        {
            #region private Fields initialization
            _xml = xmlMaster;
            
            _levelProperty           = _xml.Level;
            _tempoProperty           = _xml.Tempo;
            _compressorProperty      = _xml.Compressor;
            _reverbProperty          = _xml.Reverb;
            _phonesOutProperty       = _xml.PhonesOut;
            _phonesOutTracksProperty = _xml.PhonesOutTracks;

            _levelProperty.PropertyChanged           += (_, e) => _xml.Level = e.Value;
            _tempoProperty.PropertyChanged           += (_, e) => _xml.Tempo = e.Value;
            _compressorProperty.PropertyChanged      += (_, e) => _xml.Compressor = e.Value;
            _reverbProperty.PropertyChanged          += (_, e) => _xml.Reverb = e.Value;
            _phonesOutProperty.PropertyChanged       += (_, e) => _xml.PhonesOut = e.Value;
            _phonesOutTracksProperty.PropertyChanged += (_, e) => _xml.PhonesOutTracks = e.Value;
            #endregion private Fields initialization
        }
    }
}
