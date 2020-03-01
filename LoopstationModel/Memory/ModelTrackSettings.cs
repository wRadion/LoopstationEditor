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

        public bool IsReverse { get; set; }

        // TODO Level (0...100) *2
        private int _plyLvl;
        public int PlayLevel { get; set; }

        // TODO Pan (0...100) -50
        private int _pan;
        public int Pan { get; set; }

        public bool IsOneShot { get; set; }
        public bool HasTrackFx { get; set; }
        public TrackPlayMode PlayMode { get; set; }
        public TrackStartMode StartMode { get; set; }
        public TrackStopMode StopMode { get; set; }
        public TrackMeasureMode MeasureMode { get; set; }
        public int MeasureLength { get; set; }
        public TrackMeasureBeat MeasureBeat { get; set; }
        public bool IsLoopSync { get; set; }
        public bool IsTempoSync { get; set; }

        // TODO Tempo (400...2500) /10
        private int _recTmp;
        public int RecordedTempo { get; set; }
        public bool HasWav { get; set; }
        public int WavLength { get; set; }

        public ModelTrackSettings(int num, XmlTrackSettings xmlTrack)
        {
            TrackNumber = num;

            IsReverse = xmlTrack.Reverse == 1;
            PlayLevel = xmlTrack.PlayLevel;
            Pan = xmlTrack.Pan;
            IsOneShot = xmlTrack.OneShot == 1;
            HasTrackFx = xmlTrack.TrackFx == 1;
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
