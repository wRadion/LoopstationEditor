using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryMasterViewModel : SettingsViewModel
    {
        public PropertyIntViewModel Level { get; }
        public PropertyIntViewModel Tempo { get; }
        public PropertyIntViewModel Compressor { get; }
        public PropertyIntViewModel Reverb { get; }
        public PropertyEnumViewModel<MasterPhonesOut> PhonesOut { get; }
        public PropertyEnumViewModel<TrackBitwise> PhonesOutTracks { get; }

        public SettingsMemoryMasterViewModel(SettingsMemoryMasterModel model)
            : base(model)
        {
            Level = new PropertyIntViewModel(MasterProperty.Level, _properties);
            Tempo = new PropertyIntViewModel(MasterProperty.Tempo, _properties);
            Compressor = new PropertyIntViewModel(MasterProperty.Compressor, _properties);
            Reverb = new PropertyIntViewModel(MasterProperty.Reverb, _properties);
            PhonesOut = new PropertyEnumViewModel<MasterPhonesOut>(MasterProperty.PhonesOut, _properties);
            PhonesOutTracks = new PropertyEnumViewModel<TrackBitwise>(MasterProperty.PhonesOutTracks, _properties);
        }
    }
}
