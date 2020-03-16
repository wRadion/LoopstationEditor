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
            SinglePlayChange = new PropertyEnumViewModel<PlayOptionSinglePlayChange>(PlayOptionProperty.SinglePlayChange, _properties);
            LoopQuantize = new PropertyEnumViewModel<PlayOptionLoopQuantize>(PlayOptionProperty.LoopQuantize, _properties);
            LoopMode = new PropertyEnumViewModel<PlayOptionLoopMode>(PlayOptionProperty.LoopMode, _properties);
            LoopLength = new PropertyIntViewModel(PlayOptionProperty.LoopLength, _properties);
            AllStart = new PropertyEnumViewModel<TrackBitwise>(PlayOptionProperty.AllStart, _properties);
            AllStop = new PropertyEnumViewModel<TrackBitwise>(PlayOptionProperty.AllStop, _properties);
            FadeTime = new PropertyIntViewModel(PlayOptionProperty.FadeTime, _properties);
            TargetTrack = new PropertyEnumViewModel<Track>(PlayOptionProperty.TargetTrack, _properties);
        }
    }
}
