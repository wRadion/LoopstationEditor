using System;
using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory
{
    [Flags]
    public enum TrackBitwise
    {
        NONE = 0, TRACK1 = 1, TRACK2 = 2, TRACK3 = 4, TRACK4 = 8, TRACK5 = 16,
        ALL = TRACK1 | TRACK2 | TRACK3 | TRACK4 | TRACK5
    }

    public enum Track { TRACK1 = 0, TRACK2 = 1, TRACK3 = 2, TRACK4 = 3, TRACK5 = 4 }
    public enum TrackPlayMode { MULTI = 0, SINGLE = 1 }
    public enum TrackStartMode { IMMEDIATE = 0, FADE_IN = 1 }
    public enum TrackStopMode {  IMMEDIATE = 0, FADE_OUT = 1, LOOP_END = 2 }
    public enum TrackMeasureMode { AUTO = 0, FREE = 1, LENGTH = 2 }
    public enum TrackMeasureBeat { OFF = 0, SIXTEENTH_NOTE = 1, EIGHTH_NOTE = 2, QUARTER_NOTE = 3, HALF_NOTE = 4, WHOLE_NOTE = 5 }

    public class SettingsMemoryTrackModel : SettingsModel
    {
        [XmlElement("Rev", typeof(int))]
        [Property(false, 0, 1)]
        public ValueBool Reverse { get; set; }

        [XmlElement("PlyLvl", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt PlayLevel { get; set; }

        [XmlElement("Pan", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt Pan { get; set; }

        [XmlElement("One", typeof(int))]
        [Property(false, 0, 1)]
        public ValueBool OneShot { get; set; }

        [XmlElement("TrkFx", typeof(int))]
        [Property(true, 0, 1)]
        public ValueBool TrackFx { get; set; }

        [XmlElement("PlyMod", typeof(int))]
        [Property(TrackPlayMode.MULTI, 0, 1)]
        public ValueEnum<TrackPlayMode> PlayMode { get; set; }

        [XmlElement("StrtMod", typeof(int))]
        [Property(TrackStartMode.IMMEDIATE, 0, 1)]
        public ValueEnum<TrackStartMode> StartMode { get; set; }

        [XmlElement("StpMod", typeof(int))]
        [Property(TrackStopMode.IMMEDIATE, 0, 2)]
        public ValueEnum<TrackStopMode> StopMode { get; set; }

        [XmlElement("MeasMod", typeof(int))]
        [Property(TrackMeasureMode.AUTO, 0, 2)]
        public ValueEnum<TrackMeasureMode> MeasureMode { get; set; }

        [XmlElement("MeasLen", typeof(int))]
        [Property(0, 0, 1000)]
        public ValueInt MeasureLength { get; set; }

        [XmlElement("MeasBtLp", typeof(int))]
        [Property(TrackMeasureBeat.OFF, 0, 5)]
        public ValueEnum<TrackMeasureBeat> MeasureBeat { get; set; }

        [XmlElement("LpSync", typeof(int))]
        [Property(true, 0, 1)]
        public ValueBool LoopSync { get; set; }

        [XmlElement("TmpSync", typeof(int))]
        [Property(true, 0, 1)]
        public ValueBool TempoSync { get; set; }

        [XmlElement("RecTmp", typeof(int))]
        [Property(1200, 400, 2500)]
        public ValueInt RecordedTempo { get; set; }

        [XmlElement("WavStat", typeof(int))]
        [Property(false, 0, 1)]
        public ValueBool WavStatus { get; set; }

        [XmlElement("WavLen", typeof(int))]
        [Property(0, 0, 1_000_000_000)]
        public ValueInt WavLength { get; set; }

        public SettingsMemoryTrackModel() : base() { }
    }
}
