using Loopstation.Xml.Memory;

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

        public bool IsReverse { get; set; } = false;

        // TODO Level (0...100) *2
        private int _plyLvl;
        public int PlayLevel { get; set; } = 50;

        // TODO Pan (0...100) -50
        private int _pan;
        public int Pan { get; set; } = 50;

        public bool IsOneShot { get; set; } = false;
        public bool TrackFxEnabled { get; set; } = true;
        public TrackPlayMode PlayMode { get; set; } = TrackPlayMode.MULTI;
        public TrackStartMode StartMode { get; set; } = TrackStartMode.IMMEDIATE;
        public TrackStopMode StopMode { get; set; } = TrackStopMode.IMMEDIATE;
        public TrackMeasureMode MeasureMode { get; set; } = TrackMeasureMode.AUTO;
        public int MeasureLength { get; set; } = 0;
        public TrackMeasureBeat MeasureBeat { get; set; } = TrackMeasureBeat.OFF;
        public bool IsLoopSync { get; set; } = true;
        public bool IsTempoSync { get; set; } = true;

        // TODO Tempo (400...2500) /10
        private int _recTmp;
        public int RecordedTempo { get; set; } = 1200;
        public bool HasWav { get; set; } = false;
        public int WavLength { get; set; } = 0;

        public ModelTrackSettings(Track track) : this(track, null) { }
        public ModelTrackSettings(Track track, XmlTrackSettings xmlTrack) : this((int)track + 1, xmlTrack) { }
        public ModelTrackSettings(int num) : this(num, null) { }
        public ModelTrackSettings(int num, XmlTrackSettings xmlTrack)
        {
            TrackNumber = num;

            if (xmlTrack == null) return;

            IsReverse = xmlTrack.Reverse == 1;
            PlayLevel = xmlTrack.PlayLevel;
            Pan = xmlTrack.Pan;
            IsOneShot = xmlTrack.OneShot == 1;
            TrackFxEnabled = xmlTrack.TrackFx == 1;
            PlayMode = (TrackPlayMode)xmlTrack.PlayMode;
            StartMode = (TrackStartMode)xmlTrack.StartMode;
            StopMode = (TrackStopMode)xmlTrack.StopMode;
            MeasureMode = (TrackMeasureMode)xmlTrack.MeasureMode;
            MeasureLength = xmlTrack.MeasureLength;
            MeasureBeat = (TrackMeasureBeat)xmlTrack.MeasureBeatLoop;
            IsLoopSync = xmlTrack.LoopSync == 1;
            IsTempoSync = xmlTrack.TempoSync == 1;
            RecordedTempo = xmlTrack.RecordedTempo;
            HasWav = xmlTrack.WavStatus == 1;
            WavLength = xmlTrack.WavLength;
        }
    }
}
