using LoopstationEditor.Converters.Enum;
using LoopstationEditor.Converters.Float;
using LoopstationEditor.Converters.Int;
using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.PropertyEngine;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public class SettingsMemoryTrackViewModel : SettingsViewModel
    {
        public readonly int TrackNumber;

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

        public SettingsMemoryTrackViewModel(int trackNumber, SettingsMemoryTrackModel model)
            : base(model)
        {
            TrackNumber = trackNumber;

            Reverse = new PropertyBoolViewModel(nameof(model.Reverse), PropertySet);
            PlayLevel = new PropertyIntViewModel(nameof(model.PlayLevel), PropertySet, new IntLevelConverter());
            Pan = new PropertyIntViewModel(nameof(model.Pan), PropertySet, new IntPanConverter());
            OneShot = new PropertyBoolViewModel(nameof(model.OneShot), PropertySet);
            TrackFx = new PropertyBoolViewModel(nameof(model.TrackFx), PropertySet);
            PlayMode = new PropertyEnumRadioViewModel<TrackPlayMode>(nameof(model.PlayMode), PropertySet);
            StartMode = new PropertyEnumRadioViewModel<TrackStartMode>(nameof(model.StartMode), PropertySet);
            StopMode = new PropertyEnumRadioViewModel<TrackStopMode>(nameof(model.StopMode), PropertySet);
            MeasureMode = new PropertyEnumRadioViewModel<TrackMeasureMode>(nameof(model.MeasureMode), PropertySet);
            MeasureLength = new PropertyIntViewModel(nameof(model.MeasureLength), PropertySet);
            MeasureBeat = new PropertyEnumComboViewModel<TrackMeasureBeat>(nameof(model.MeasureBeat), PropertySet, new EnumNoteConverter<TrackMeasureBeat>());
            LoopSync = new PropertyBoolViewModel(nameof(model.LoopSync), PropertySet);
            TempoSync = new PropertyBoolViewModel(nameof(model.TempoSync), PropertySet);
            RecordedTempo = new PropertyFloatViewModel(nameof(model.RecordedTempo), PropertySet, new FloatTempoConverter());
            WavStatus = new PropertyBoolViewModel(nameof(model.WavStatus), PropertySet);
            WavLength = new PropertyIntViewModel(nameof(model.WavLength), PropertySet);
        }
    }
}
