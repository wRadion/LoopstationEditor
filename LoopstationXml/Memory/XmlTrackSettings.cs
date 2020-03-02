using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;
using Loopstation.Xml.Utils;

namespace Loopstation.Xml.Memory
{
    public class XmlTrackSettings : ICloneable<XmlTrackSettings>
    {
        private int _reverse;
        private int _playLevel;
        private int _pan;
        private int _oneShot;
        private int _trackFx;
        private int _playMode;
        private int _startMode;
        private int _stopMode;
        private int _measureMode;
        private int _measureLength;
        private int _measureBeatLoop;
        private int _loopSync;
        private int _tempoSync;
        private int _recordedTempo;
        private int _wavStatus;
        private int _wavLength;

        [XmlElement("Rev")]
        public int Reverse
        {
            get => _reverse;
            set => _reverse = Range.Guard(value, max: 1);
        }

        [XmlElement("PlyLvl")]
        public int PlayLevel
        {
            get => _playLevel;
            set => _playLevel = Range.Guard(value);
        }

        [XmlElement("Pan")]
        public int Pan
        {
            get => _pan;
            set => _pan = Range.Guard(value);
        }

        [XmlElement("One")]
        public int OneShot
        {
            get => _oneShot;
            set => _oneShot = Range.Guard(value, max: 1);
        }

        [XmlElement("TrkFx")]
        public int TrackFx
        {
            get => _trackFx;
            set => _trackFx = Range.Guard(value, max: 1);
        }

        [XmlElement("PlyMod")]
        public int PlayMode
        {
            get => _playMode;
            set => _playMode = Range.Guard(value, max: 1);
        }

        [XmlElement("StrtMod")]
        public int StartMode
        {
            get => _startMode;
            set => _startMode = Range.Guard(value, max: 1);
        }

        [XmlElement("StpMod")]
        public int StopMode
        {
            get => _stopMode;
            set => _stopMode = Range.Guard(value, max: 2);
        }

        [XmlElement("MeasMod")]
        public int MeasureMode
        {
            get => _measureMode;
            set => _measureMode = Range.Guard(value, max: 2);
        }

        [XmlElement("MeasLen")]
        public int MeasureLength
        {
            get => _measureLength;
            set => _measureLength = Range.Guard(value, max: 1000);
        }

        [XmlElement("MeasBtLp")]
        public int MeasureBeatLoop
        {
            get => _measureBeatLoop;
            set => _measureBeatLoop = Range.Guard(value, max: 5);
        }

        [XmlElement("LpSync")]
        public int LoopSync
        {
            get => _loopSync;
            set => _loopSync = Range.Guard(value, max: 1);
        }

        [XmlElement("TmpSync")]
        public int TempoSync
        {
            get => _tempoSync;
            set => _tempoSync = Range.Guard(value, max: 1);
        }

        [XmlElement("RecTmp")]
        public int RecordedTempo
        {
            get => _recordedTempo;
            set => _recordedTempo = Range.Guard(value, min: 400, max: 2500);
        }

        [XmlElement("WavStat")]
        public int WavStatus
        {
            get => _wavStatus;
            set => _wavStatus = Range.Guard(value, max: 1);
        }

        [XmlElement("WavLen")]
        public int WavLength
        {
            get => _wavLength;
            set => _wavLength = Range.Guard(value, max: 1_000_000_000);
        }

        public XmlTrackSettings() : this(null) { }
        public XmlTrackSettings(XmlTrackSettings other)
        {
            Reverse = other?.Reverse ?? 0;
            PlayLevel = other?.PlayLevel ?? 50;
            Pan = other?.Pan ?? 50;
            OneShot = other?.OneShot ?? 0;
            TrackFx = other?.TrackFx ?? 1;
            PlayMode = other?.PlayMode ?? 0;
            StartMode = other?.StartMode ?? 0;
            StopMode = other?.StopMode ?? 0;
            MeasureMode = other?.MeasureMode ?? 0;
            MeasureLength = other?.MeasureLength ?? 0;
            MeasureBeatLoop = other?.MeasureBeatLoop ?? 0;
            LoopSync = other?.LoopSync ?? 1;
            TempoSync = other?.TempoSync ?? 1;
            RecordedTempo = other?.RecordedTempo ?? 1200;
            WavStatus = other?.WavStatus ?? 0;
            WavLength = other?.WavLength ?? 0;
        }

        public XmlTrackSettings Clone() => new XmlTrackSettings(this);
    }
}
