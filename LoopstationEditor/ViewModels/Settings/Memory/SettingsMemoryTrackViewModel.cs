using LoopstationEditor.Converters.Int;
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
            Reverse = new PropertyBoolViewModel(nameof(Reverse), _properties);
            PlayLevel = new PropertyIntViewModel(nameof(PlayLevel), _properties, new IntLevelConverter());
            Pan = new PropertyIntViewModel(nameof(Pan), _properties, new IntPanConverter());
            OneShot = new PropertyBoolViewModel(nameof(OneShot), _properties);
            TrackFX = new PropertyBoolViewModel(nameof(TrackFX), _properties);
            PlayMode = new PropertyEnumViewModel<TrackPlayMode>(nameof(PlayMode), _properties);
            StartMode = new PropertyEnumViewModel<TrackStartMode>(nameof(StartMode), _properties);
            StopMode = new PropertyEnumViewModel<TrackStopMode>(nameof(StopMode), _properties);
            MeasureMode = new PropertyEnumViewModel<TrackMeasureMode>(nameof(MeasureMode), _properties);
            MeasureLength = new PropertyIntViewModel(nameof(MeasureLength), _properties);
            MeasureBeat = new PropertyEnumViewModel<TrackMeasureBeat>(nameof(MeasureBeat), _properties);
            LoopSync = new PropertyBoolViewModel(nameof(LoopSync), _properties);
            TempoSync = new PropertyBoolViewModel(nameof(TempoSync), _properties);
            RecordedTempo = new PropertyIntViewModel(nameof(RecordedTempo), _properties, new IntTempoConverter());
            WavStatus = new PropertyBoolViewModel(nameof(WavStatus), _properties);
            WavLength = new PropertyIntViewModel(nameof(WavLength), _properties);
        }
    }
}
