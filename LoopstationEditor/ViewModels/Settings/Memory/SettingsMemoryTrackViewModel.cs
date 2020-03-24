using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Converters.Float;
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
            Reverse = new PropertyBoolViewModel(nameof(model.Reverse), _properties);
            PlayLevel = new PropertyIntViewModel(nameof(model.PlayLevel), _properties, new IntLevelConverter());
            Pan = new PropertyIntViewModel(nameof(model.Pan), _properties, new IntPanConverter());
            OneShot = new PropertyBoolViewModel(nameof(model.OneShot), _properties);
            TrackFx = new PropertyBoolViewModel(nameof(model.TrackFx), _properties);
            PlayMode = new PropertyEnumRadioViewModel<TrackPlayMode>(nameof(model.PlayMode), _properties);
            StartMode = new PropertyEnumRadioViewModel<TrackStartMode>(nameof(model.StartMode), _properties);
            StopMode = new PropertyEnumRadioViewModel<TrackStopMode>(nameof(model.StopMode), _properties);
            MeasureMode = new PropertyEnumRadioViewModel<TrackMeasureMode>(nameof(model.MeasureMode), _properties);
            MeasureLength = new PropertyIntViewModel(nameof(model.MeasureLength), _properties);
            MeasureBeat = new PropertyEnumComboViewModel<TrackMeasureBeat>(nameof(model.MeasureBeat), _properties, new EnumNoteConverter<TrackMeasureBeat>());
            LoopSync = new PropertyBoolViewModel(nameof(model.LoopSync), _properties);
            TempoSync = new PropertyBoolViewModel(nameof(model.TempoSync), _properties);
            RecordedTempo = new PropertyFloatViewModel(nameof(model.RecordedTempo), _properties, new FloatTempoConverter());
            WavStatus = new PropertyBoolViewModel(nameof(model.WavStatus), _properties);
            WavLength = new PropertyIntViewModel(nameof(model.WavLength), _properties);
        }
    }
}
