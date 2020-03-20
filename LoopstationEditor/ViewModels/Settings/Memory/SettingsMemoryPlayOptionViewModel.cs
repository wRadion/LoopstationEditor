using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryPlayOptionViewModel : SettingsViewModel
    {
        public PropertyEnumRadioViewModel<PlayOptionSinglePlayChange> SinglePlayChange { get; }
        public PropertyEnumRadioViewModel<PlayOptionLoopQuantize> LoopQuantize { get; }
        public PropertyEnumRadioViewModel<PlayOptionLoopMode> LoopMode { get; }
        public PropertyIntViewModel LoopLength { get; }
        public PropertyBitwiseViewModel<TrackBitwise> AllStart { get; }
        public PropertyBitwiseViewModel<TrackBitwise> AllStop { get; }
        public PropertyIntViewModel FadeTime { get; }
        public PropertyEnumComboViewModel<Track> TargetTrack { get; }

        public SettingsMemoryPlayOptionViewModel(SettingsMemoryPlayOptionModel model)
            : base(model)
        {
            SinglePlayChange = new PropertyEnumRadioViewModel<PlayOptionSinglePlayChange>(nameof(SinglePlayChange), _properties);
            LoopQuantize = new PropertyEnumRadioViewModel<PlayOptionLoopQuantize>(nameof(LoopQuantize), _properties);
            LoopMode = new PropertyEnumRadioViewModel<PlayOptionLoopMode>(nameof(LoopMode), _properties);
            LoopLength = new PropertyIntViewModel(nameof(LoopLength), _properties);
            AllStart = new PropertyBitwiseViewModel<TrackBitwise>(nameof(AllStart), _properties, new TrackBitwiseToNumberConverter());
            AllStop = new PropertyBitwiseViewModel<TrackBitwise>(nameof(AllStop), _properties, new TrackBitwiseToNumberConverter());
            FadeTime = new PropertyIntViewModel(nameof(FadeTime), _properties);
            TargetTrack = new PropertyEnumComboViewModel<Track>(nameof(TargetTrack), _properties);
        }
    }
}
