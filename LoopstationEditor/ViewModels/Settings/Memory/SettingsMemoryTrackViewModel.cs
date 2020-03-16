using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryTrackViewModel : SettingsViewModel
    {
        public PropertyBoolViewModel Reverse { get; }
        public PropertyIntViewModel PlayLevel { get; }
        public PropertyIntViewModel Pan { get; }
        public PropertyBoolViewModel OneShot { get; }
        public PropertyBoolViewModel TrackFX { get; }
        public PropertyEnumViewModel<TrackPlayMode> PlayMode { get; }
        public PropertyEnumViewModel<TrackStartMode> StartMode { get; }
        public PropertyEnumViewModel<TrackStopMode> StopMode { get; }
        public PropertyEnumViewModel<TrackMeasureMode> MeasureMode { get; }
        public PropertyIntViewModel MeasureLength { get; }
        public PropertyEnumViewModel<TrackMeasureBeat> MeasureBeat { get; }
        public PropertyBoolViewModel LoopSync { get; }
        public PropertyBoolViewModel TempoSync { get; }
        public PropertyIntViewModel RecordedTempo { get; }
        public PropertyBoolViewModel WavStatus { get; }
        public PropertyIntViewModel WavLength { get; }

        public SettingsMemoryTrackViewModel(SettingsMemoryTrackModel model)
            : base(model)
        {
            Reverse = new PropertyBoolViewModel(TrackProperty.Reverse, _properties);
            PlayLevel = new PropertyIntViewModel(TrackProperty.PlayLevel, _properties);
            Pan = new PropertyIntViewModel(TrackProperty.Pan, _properties);
            OneShot = new PropertyBoolViewModel(TrackProperty.OneShot, _properties);
            TrackFX = new PropertyBoolViewModel(TrackProperty.TrackFX, _properties);
            PlayMode = new PropertyEnumViewModel<TrackPlayMode>(TrackProperty.PlayMode, _properties);
            StartMode = new PropertyEnumViewModel<TrackStartMode>(TrackProperty.StartMode, _properties);
            StopMode = new PropertyEnumViewModel<TrackStopMode>(TrackProperty.StopMode, _properties);
            MeasureMode = new PropertyEnumViewModel<TrackMeasureMode>(TrackProperty.MeasureMode, _properties);
            MeasureLength = new PropertyIntViewModel(TrackProperty.MeasureLength, _properties);
            MeasureBeat = new PropertyEnumViewModel<TrackMeasureBeat>(TrackProperty.MeasureBeat, _properties);
            LoopSync = new PropertyBoolViewModel(TrackProperty.LoopSync, _properties);
            TempoSync = new PropertyBoolViewModel(TrackProperty.TempoSync, _properties);
            RecordedTempo = new PropertyIntViewModel(TrackProperty.RecordedTempo, _properties);
            WavStatus = new PropertyBoolViewModel(TrackProperty.WavStatus, _properties);
            WavLength = new PropertyIntViewModel(TrackProperty.WavLength, _properties);
        }
    }
}
