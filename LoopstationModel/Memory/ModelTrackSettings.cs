using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory
{
    public enum Track { TRACK1, TRACK2, TRACK3, TRACK4, TRACK5 }
    public enum TrackPlayMode { MULTI, SINGLE }
    public enum TrackStartMode { IMMEDIATE, FADE_IN }
    public enum TrackStopMode { IMMEDIATE, FADE_OUT, LOOP_END }
    public enum TrackMeasureMode { AUTO, FREE, LENGTH }
    public enum TrackMeasureBeat { OFF, SIXTEENTH_NOTE, EIGHTH_NOTE, QUARTER_NOTE, HALF_NOTE, WHOLE_NOTE }

    public class ModelTrackSettings
    {
        public int TrackNumber { get; }
        public Track Track => (Track)(TrackNumber - 1);

        public bool Reverse
        {
            get => _reverseProperty.Value;
            set => _reverseProperty.Value = value;
        }
        public int PlayLevel // TODO Level (0...100) *2
        {
            get => _playLevelProperty.Value;
            set => _playLevelProperty.Value = value;
        }
        public int Pan // TODO Pan (0...100) -50
        {
            get => _panProperty.Value;
            set => _panProperty.Value = value;
        }
        public bool OneShot
        {
            get => _oneShotProperty.Value;
            set => _oneShotProperty.Value = value;
        }
        public bool TrackFx
        {
            get => _trackFxProperty.Value;
            set => _trackFxProperty.Value = value;
        }
        public TrackPlayMode PlayMode
        {
            get => _playModeProperty.Value;
            set => _playModeProperty.Value = value;
        }
        public TrackStartMode StartMode
        {
            get => _startModeProperty.Value;
            set => _startModeProperty.Value = value;
        }
        public TrackStopMode StopMode
        {
            get => _stopModeProperty.Value;
            set => _stopModeProperty.Value = value;
        }
        public TrackMeasureMode MeasureMode
        {
            get => _measureModeProperty.Value;
            set => _measureModeProperty.Value = value;
        }
        public int MeasureLength
        {
            get => _measureLengthProperty.Value;
            set => _measureLengthProperty.Value = value;
        }
        public TrackMeasureBeat MeasureBeat
        {
            get => _measureBeatProperty.Value;
            set => _measureBeatProperty.Value = value;
        }
        public bool LoopSync
        {
            get => _loopSyncProperty.Value;
            set => _loopSyncProperty.Value = value;
        }
        public bool TempoSync
        {
            get => _tempoSyncProperty.Value;
            set => _tempoSyncProperty.Value = value;
        }
        public int RecordedTempo // TODO Tempo (400...2500) /10
        {
            get => _recordedTempoProperty.Value;
            set => _recordedTempoProperty.Value = value;
        }
        public bool WavStatus
        {
            get => _wavStatusProperty.Value;
            set => _wavStatusProperty.Value = value;
        }
        public int WavLength
        {
            get => _wavLengthProperty.Value;
            set => _wavLengthProperty.Value = value;
        }

        #region private Fields
        private readonly BoolProperty _reverseProperty;
        private readonly IntProperty _playLevelProperty;
        private readonly IntProperty _panProperty;
        private readonly BoolProperty _oneShotProperty;
        private readonly BoolProperty _trackFxProperty;
        private readonly EnumProperty<TrackPlayMode> _playModeProperty;
        private readonly EnumProperty<TrackStartMode> _startModeProperty;
        private readonly EnumProperty<TrackStopMode> _stopModeProperty;
        private readonly EnumProperty<TrackMeasureMode> _measureModeProperty;
        private readonly IntProperty _measureLengthProperty;
        private readonly EnumProperty<TrackMeasureBeat> _measureBeatProperty;
        private readonly BoolProperty _loopSyncProperty;
        private readonly BoolProperty _tempoSyncProperty;
        private readonly IntProperty _recordedTempoProperty;
        private readonly BoolProperty _wavStatusProperty;
        private readonly IntProperty _wavLengthProperty;

        private readonly XmlTrackSettings _xml;
        #endregion private Fields

        public ModelTrackSettings(Track track, XmlTrackSettings xmlTrack) : this((int)track + 1, xmlTrack) { }
        public ModelTrackSettings(int num, XmlTrackSettings xmlTrack)
        {
            #region private Fields initialization
            _xml = xmlTrack;

            _reverseProperty       = _xml.Reverse;
            _playLevelProperty     = _xml.PlayLevel;
            _panProperty           = _xml.Pan;
            _oneShotProperty       = _xml.OneShot;
            _trackFxProperty       = _xml.TrackFx;
            _playModeProperty      = _xml.PlayMode;
            _startModeProperty     = _xml.StartMode;
            _stopModeProperty      = _xml.StopMode;
            _measureModeProperty   = _xml.MeasureMode;
            _measureLengthProperty = _xml.MeasureLength;
            _measureBeatProperty   = _xml.MeasureBeatLoop;
            _loopSyncProperty      = _xml.LoopSync;
            _tempoSyncProperty     = _xml.TempoSync;
            _recordedTempoProperty = _xml.RecordedTempo;
            _wavStatusProperty     = _xml.WavStatus;
            _wavLengthProperty     = _xml.WavLength;

            _reverseProperty.PropertyChanged       += (_, e) => _xml.Reverse = e.Value;
            _playLevelProperty.PropertyChanged     += (_, e) => _xml.PlayLevel = e.Value;
            _panProperty.PropertyChanged           += (_, e) => _xml.Pan = e.Value;
            _oneShotProperty.PropertyChanged       += (_, e) => _xml.OneShot = e.Value;
            _trackFxProperty.PropertyChanged       += (_, e) => _xml.TrackFx = e.Value;
            _playModeProperty.PropertyChanged      += (_, e) => _xml.PlayMode = e.Value;
            _startModeProperty.PropertyChanged     += (_, e) => _xml.StartMode = e.Value;
            _stopModeProperty.PropertyChanged      += (_, e) => _xml.StopMode = e.Value;
            _measureModeProperty.PropertyChanged   += (_, e) => _xml.MeasureMode = e.Value;
            _measureLengthProperty.PropertyChanged += (_, e) => _xml.MeasureLength = e.Value;
            _measureBeatProperty.PropertyChanged   += (_, e) => _xml.MeasureBeatLoop = e.Value;
            _loopSyncProperty.PropertyChanged      += (_, e) => _xml.LoopSync = e.Value;
            _tempoSyncProperty.PropertyChanged     += (_, e) => _xml.TempoSync = e.Value;
            _recordedTempoProperty.PropertyChanged += (_, e) => _xml.RecordedTempo = e.Value;
            _wavStatusProperty.PropertyChanged     += (_, e) => _xml.WavStatus = e.Value;
            _wavLengthProperty.PropertyChanged     += (_, e) => _xml.WavLength = e.Value;
            #endregion private Fields initialization

            TrackNumber = num;
        }
    }
}
