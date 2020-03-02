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

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("Rev")]
        public int Reverse
        {
            get => _reverse;
            set => _reverse = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("PlyLvl")]
        public int PlayLevel
        {
            get => _playLevel;
            set => _playLevel = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>100</c>.
        /// <para>Default value is <c>50</c>.</para>
        /// </summary>
        [XmlElement("Pan")]
        public int Pan
        {
            get => _pan;
            set => _pan = Range.Guard(value);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("One")]
        public int OneShot
        {
            get => _oneShot;
            set => _oneShot = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>1</c>.</para>
        /// </summary>
        [XmlElement("TrkFx")]
        public int TrackFx
        {
            get => _trackFx;
            set => _trackFx = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("PlyMod")]
        public int PlayMode
        {
            get => _playMode;
            set => _playMode = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("StrtMod")]
        public int StartMode
        {
            get => _startMode;
            set => _startMode = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>2</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("StpMod")]
        public int StopMode
        {
            get => _stopMode;
            set => _stopMode = Range.Guard(value, max: 2);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>2</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("MeasMod")]
        public int MeasureMode
        {
            get => _measureMode;
            set => _measureMode = Range.Guard(value, max: 2);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1000</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("MeasLen")]
        public int MeasureLength
        {
            get => _measureLength;
            set => _measureLength = Range.Guard(value, max: 1000);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>5</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("MeasBtLp")]
        public int MeasureBeatLoop
        {
            get => _measureBeatLoop;
            set => _measureBeatLoop = Range.Guard(value, max: 5);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>1</c>.</para>
        /// </summary>
        [XmlElement("LpSync")]
        public int LoopSync
        {
            get => _loopSync;
            set => _loopSync = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>1</c>.</para>
        /// </summary>
        [XmlElement("TmpSync")]
        public int TempoSync
        {
            get => _tempoSync;
            set => _tempoSync = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>400</c> to <c>2500</c>.
        /// <para>Default value is <c>1200</c>.</para>
        /// </summary>
        [XmlElement("RecTmp")]
        public int RecordedTempo
        {
            get => _recordedTempo;
            set => _recordedTempo = Range.Guard(value, min: 400, max: 2500);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("WavStat")]
        public int WavStatus
        {
            get => _wavStatus;
            set => _wavStatus = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1_000_000_000</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("WavLen")]
        public int WavLength
        {
            get => _wavLength;
            set => _wavLength = Range.Guard(value, max: 1_000_000_000);
        }

        public XmlTrackSettings() : this(null) { }
        public XmlTrackSettings(XmlTrackSettings other)
        {
            Reverse         = other?.Reverse         ?? 0;
            PlayLevel       = other?.PlayLevel       ?? 50;
            Pan             = other?.Pan             ?? 50;
            OneShot         = other?.OneShot         ?? 0;
            TrackFx         = other?.TrackFx         ?? 1;
            PlayMode        = other?.PlayMode        ?? 0;
            StartMode       = other?.StartMode       ?? 0;
            StopMode        = other?.StopMode        ?? 0;
            MeasureMode     = other?.MeasureMode     ?? 0;
            MeasureLength   = other?.MeasureLength   ?? 0;
            MeasureBeatLoop = other?.MeasureBeatLoop ?? 0;
            LoopSync        = other?.LoopSync        ?? 1;
            TempoSync       = other?.TempoSync       ?? 1;
            RecordedTempo   = other?.RecordedTempo   ?? 1200;
            WavStatus       = other?.WavStatus       ?? 0;
            WavLength       = other?.WavLength       ?? 0;
        }

        public XmlTrackSettings Clone() => new XmlTrackSettings(this);
    }
}
