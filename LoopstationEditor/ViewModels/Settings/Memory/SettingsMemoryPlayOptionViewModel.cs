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
            SinglePlayChange = new PropertyEnumRadioViewModel<PlayOptionSinglePlayChange>(nameof(model.SinglePlayChange), PropertySet);
            LoopQuantize = new PropertyEnumRadioViewModel<PlayOptionLoopQuantize>(nameof(model.LoopQuantize), PropertySet);
            LoopMode = new PropertyEnumRadioViewModel<PlayOptionLoopMode>(nameof(model.LoopMode), PropertySet);
            LoopLength = new PropertyIntViewModel(nameof(model.LoopLength), PropertySet);
            AllStart = new PropertyBitwiseViewModel<TrackBitwise>(nameof(model.AllStart), PropertySet, new TrackBitwiseToNumberConverter());
            AllStop = new PropertyBitwiseViewModel<TrackBitwise>(nameof(model.AllStop), PropertySet, new TrackBitwiseToNumberConverter());
            FadeTime = new PropertyIntViewModel(nameof(model.FadeTime), PropertySet);
            TargetTrack = new PropertyEnumComboViewModel<Track>(nameof(model.TargetTrack), PropertySet);
        }
    }
}
