using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Converters.Float;
using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryMasterViewModel : SettingsViewModel
    {
        public PropertyIntViewModel Level { get; }
        public PropertyFloatViewModel Tempo { get; }
        public PropertyIntViewModel Compressor { get; }
        public PropertyIntViewModel Reverb { get; }
        public PropertyEnumRadioViewModel<MasterPhonesOut> PhonesOut { get; }
        public PropertyBitwiseViewModel<TrackBitwise> PhonesOutTracks { get; }

        public SettingsMemoryMasterViewModel(SettingsMemoryMasterModel model)
            : base(model)
        {
            Level = new PropertyIntViewModel(nameof(model.Level), _properties, new IntLevelConverter());
            Tempo = new PropertyFloatViewModel(nameof(model.Tempo), _properties, new FloatTempoConverter());
            Compressor = new PropertyIntViewModel(nameof(model.Compressor), _properties, new IntDbConverter());
            Reverb = new PropertyIntViewModel(nameof(model.Reverb), _properties);
            PhonesOut = new PropertyEnumRadioViewModel<MasterPhonesOut>(nameof(model.PhonesOut), _properties);
            PhonesOutTracks = new PropertyBitwiseViewModel<TrackBitwise>(nameof(model.PhonesOutTracks), _properties, new TrackBitwiseToNumberConverter());
        }
    }
}
