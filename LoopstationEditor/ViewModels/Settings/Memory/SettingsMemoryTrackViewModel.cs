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
        public PropertyBoolViewModel TrackFx { get; }
        public PropertyEnumRadioViewModel<TrackPlayMode> PlayMode { get; }
        public PropertyEnumRadioViewModel<TrackStartMode> StartMode { get; }
        public PropertyEnumRadioViewModel<TrackStopMode> StopMode { get; }
        public PropertyEnumRadioViewModel<TrackMeasureMode> MeasureMode { get; }
        public PropertyIntViewModel MeasureLength { get; }
        public PropertyEnumComboViewModel<TrackMeasureBeat> MeasureBeat { get; }
        public PropertyBoolViewModel LoopSync { get; }
        public PropertyBoolViewModel TempoSync { get; }
        public PropertyFloatViewModel RecordedTempo { get; }
        public PropertyBoolViewModel WavStatus { get; }
        public PropertyIntViewModel WavLength { get; }

        public SettingsMemoryTrackViewModel(SettingsMemoryTrackModel model)
            : base(model)
        {
            Reverse = new PropertyBoolViewModel(nameof(Reverse), _properties);
            PlayLevel = new PropertyIntViewModel(nameof(PlayLevel), _properties, new IntLevelConverter());
            Pan = new PropertyIntViewModel(nameof(Pan), _properties, new IntPanConverter());
            OneShot = new PropertyBoolViewModel(nameof(OneShot), _properties);
            TrackFx = new PropertyBoolViewModel(nameof(TrackFx), _properties);
            PlayMode = new PropertyEnumRadioViewModel<TrackPlayMode>(nameof(PlayMode), _properties);
            StartMode = new PropertyEnumRadioViewModel<TrackStartMode>(nameof(StartMode), _properties);
            StopMode = new PropertyEnumRadioViewModel<TrackStopMode>(nameof(StopMode), _properties);
            MeasureMode = new PropertyEnumRadioViewModel<TrackMeasureMode>(nameof(MeasureMode), _properties);
            MeasureLength = new PropertyIntViewModel(nameof(MeasureLength), _properties);
            MeasureBeat = new PropertyEnumComboViewModel<TrackMeasureBeat>(nameof(MeasureBeat), _properties);
            LoopSync = new PropertyBoolViewModel(nameof(LoopSync), _properties);
            TempoSync = new PropertyBoolViewModel(nameof(TempoSync), _properties);
            RecordedTempo = new PropertyFloatViewModel(nameof(RecordedTempo), _properties, new FloatTempoConverter());
            WavStatus = new PropertyBoolViewModel(nameof(WavStatus), _properties);
            WavLength = new PropertyIntViewModel(nameof(WavLength), _properties);
        }
    }
}
