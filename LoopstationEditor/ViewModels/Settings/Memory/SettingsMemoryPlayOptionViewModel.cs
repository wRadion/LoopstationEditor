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
            SinglePlayChange = new PropertyEnumRadioViewModel<PlayOptionSinglePlayChange>(nameof(model.SinglePlayChange), _properties);
            LoopQuantize = new PropertyEnumRadioViewModel<PlayOptionLoopQuantize>(nameof(model.LoopQuantize), _properties);
            LoopMode = new PropertyEnumRadioViewModel<PlayOptionLoopMode>(nameof(model.LoopMode), _properties);
            LoopLength = new PropertyIntViewModel(nameof(model.LoopLength), _properties);
            AllStart = new PropertyBitwiseViewModel<TrackBitwise>(nameof(model.AllStart), _properties, new TrackBitwiseToNumberConverter());
            AllStop = new PropertyBitwiseViewModel<TrackBitwise>(nameof(model.AllStop), _properties, new TrackBitwiseToNumberConverter());
            FadeTime = new PropertyIntViewModel(nameof(model.FadeTime), _properties);
            TargetTrack = new PropertyEnumComboViewModel<Track>(nameof(model.TargetTrack), _properties);
        }
    }
}
