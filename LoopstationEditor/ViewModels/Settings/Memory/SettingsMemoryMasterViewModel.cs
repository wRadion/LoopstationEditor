using LoopstationEditor.Converters.Int;
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
            Level = new PropertyIntViewModel(nameof(Level), _properties, new IntLevelConverter());
            Tempo = new PropertyIntViewModel(nameof(Tempo), _properties, new IntTempoConverter());
            Compressor = new PropertyIntViewModel(nameof(Compressor), _properties, new IntDbConverter());
            Reverb = new PropertyIntViewModel(nameof(Reverb), _properties);
            PhonesOut = new PropertyEnumViewModel<MasterPhonesOut>(nameof(PhonesOut), _properties);
            PhonesOutTracks = new PropertyEnumViewModel<TrackBitwise>(nameof(PhonesOutTracks), _properties);
        }
    }
}
