using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;

namespace Loopstation.Xml.Memory
{
    public class XmlTrackSettings : ICloneable<XmlTrackSettings>
    {
        [XmlElement("Rev")]
        public int Reverse { get; set; } = 0;

        [XmlElement("PlyLvl")]
        public int PlayLevel { get; set; } = 50;

        [XmlElement("Pan")]
        public int Pan { get; set; } = 50;

        [XmlElement("One")]
        public int OneShot { get; set; } = 0;

        [XmlElement("TrkFx")]
        public int TrackFx { get; set; } = 1;

        [XmlElement("PlyMod")]
        public int PlayMode { get; set; } = 0;

        [XmlElement("StrtMod")]
        public int StartMode { get; set; } = 0;

        [XmlElement("StpMod")]
        public int StopMode { get; set; } = 0;

        [XmlElement("MeasMod")]
        public int MeasureMode { get; set; } = 0;

        [XmlElement("MeasLen")]
        public int MeasureLength { get; set; } = 0;

        [XmlElement("MeasBtLp")]
        public int MeasureBeatLoop { get; set; } = 0;

        [XmlElement("LpSync")]
        public int LoopSync { get; set; } = 1;

        [XmlElement("TmpSync")]
        public int TempoSync { get; set; } = 1;

        [XmlElement("RecTmp")]
        public int RecordedTempo { get; set; } = 1200;

        [XmlElement("WavStat")]
        public int WavStatus { get; set; } = 0;

        [XmlElement("WavLen")]
        public int WavLength { get; set; } = 0;

        public XmlTrackSettings() { }
        public XmlTrackSettings(XmlTrackSettings other)
        {
            if (other == null) return;

            Reverse = other.Reverse;
            PlayLevel = other.PlayLevel;
            Pan = other.Pan;
            OneShot = other.OneShot;
            TrackFx = other.TrackFx;
            PlayMode = other.PlayMode;
            StartMode = other.StartMode;
            StopMode = other.StopMode;
            MeasureMode = other.MeasureMode;
            MeasureLength = other.MeasureLength;
            MeasureBeatLoop = other.MeasureBeatLoop;
            LoopSync = other.LoopSync;
            TempoSync = other.TempoSync;
            RecordedTempo = other.RecordedTempo;
            WavStatus = other.WavStatus;
            WavLength = other.WavLength;
        }

        public XmlTrackSettings Clone() => new XmlTrackSettings(this);
    }
}
