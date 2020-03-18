using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryPlayOptionViewModel : SettingsViewModel
    {
        public PropertyEnumViewModel<PlayOptionSinglePlayChange> SinglePlayChange { get; }
        public PropertyEnumViewModel<PlayOptionLoopQuantize> LoopQuantize { get; }
        public PropertyEnumViewModel<PlayOptionLoopMode> LoopMode { get; }
        public PropertyIntViewModel LoopLength { get; }
        public PropertyEnumViewModel<TrackBitwise> AllStart { get; }
        public PropertyEnumViewModel<TrackBitwise> AllStop { get; }
        public PropertyIntViewModel FadeTime { get; }
        public PropertyEnumViewModel<Track> TargetTrack { get; }

        public SettingsMemoryPlayOptionViewModel(SettingsMemoryPlayOptionModel model)
            : base(model)
        {
            SinglePlayChange = new PropertyEnumViewModel<PlayOptionSinglePlayChange>(nameof(SinglePlayChange), _properties);
            LoopQuantize = new PropertyEnumViewModel<PlayOptionLoopQuantize>(nameof(LoopQuantize), _properties);
            LoopMode = new PropertyEnumViewModel<PlayOptionLoopMode>(nameof(LoopMode), _properties);
            LoopLength = new PropertyIntViewModel(nameof(LoopLength), _properties);
            AllStart = new PropertyEnumViewModel<TrackBitwise>(nameof(AllStart), _properties);
            AllStop = new PropertyEnumViewModel<TrackBitwise>(nameof(AllStop), _properties);
            FadeTime = new PropertyIntViewModel(nameof(FadeTime), _properties);
            TargetTrack = new PropertyEnumViewModel<Track>(nameof(TargetTrack), _properties);
        }
    }
}
