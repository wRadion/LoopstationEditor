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

    public static class TrackProperty
    {
        public const string Reverse = "Rev";
        public const string PlayLevel = "PlyLvl";
        public const string Pan = "Pan";
        public const string OneShot = "One";
        public const string TrackFx = "TrkFx";
        public const string PlayMode = "PlyMod";
        public const string StartMode = "StrtMod";
        public const string StopMode = "StpMod";
        public const string MeasureMode = "MeasMod";
        public const string MeasureLength = "MeasLen";
        public const string MeasureBeat = "MeasBtLp";
        public const string LoopSync = "LpSync";
        public const string TempoSync = "TmpSync";
        public const string RecordedTempo = "RecTmp";
        public const string WavStatus = "WavStat";
        public const string WavLength = "WavLen";
    }

    public class SettingsMemoryTrackModel : SettingsModel
    {
        [XmlElement(TrackProperty.Reverse, typeof(int))]
        [Property(false, 0, 1)]
        public ValueBool Reverse { get; set; }

        [XmlElement(TrackProperty.PlayLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt PlayLevel { get; set; }

        [XmlElement(TrackProperty.Pan, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt Pan { get; set; }

        [XmlElement(TrackProperty.OneShot, typeof(int))]
        [Property(false, 0, 1)]
        public ValueBool OneShot { get; set; }

        [XmlElement(TrackProperty.TrackFx, typeof(int))]
        [Property(true, 0, 1)]
        public ValueBool TrackFx { get; set; }

        [XmlElement(TrackProperty.PlayMode, typeof(int))]
        [Property(TrackPlayMode.MULTI, 0, 1)]
        public ValueEnum<TrackPlayMode> PlayMode { get; set; }

        [XmlElement(TrackProperty.StartMode, typeof(int))]
        [Property(TrackStartMode.IMMEDIATE, 0, 1)]
        public ValueEnum<TrackStartMode> StartMode { get; set; }

        [XmlElement(TrackProperty.StopMode, typeof(int))]
        [Property(TrackStopMode.IMMEDIATE, 0, 2)]
        public ValueEnum<TrackStopMode> StopMode { get; set; }

        [XmlElement(TrackProperty.MeasureMode, typeof(int))]
        [Property(TrackMeasureMode.AUTO, 0, 2)]
        public ValueEnum<TrackMeasureMode> MeasureMode { get; set; }

        [XmlElement(TrackProperty.MeasureLength, typeof(int))]
        [Property(0, 0, 1000)]
        public ValueInt MeasureLength { get; set; }

        [XmlElement(TrackProperty.MeasureBeat, typeof(int))]
        [Property(TrackMeasureBeat.OFF, 0, 5)]
        public ValueEnum<TrackMeasureBeat> MeasureBeat { get; set; }

        [XmlElement(TrackProperty.LoopSync, typeof(int))]
        [Property(true, 0, 1)]
        public ValueBool LoopSync { get; set; }

        [XmlElement(TrackProperty.TempoSync, typeof(int))]
        [Property(true, 0, 1)]
        public ValueBool TempoSync { get; set; }

        [XmlElement(TrackProperty.RecordedTempo, typeof(int))]
        [Property(1200, 400, 2500)]
        public ValueInt RecordedTempo { get; set; }

        [XmlElement(TrackProperty.WavStatus, typeof(int))]
        [Property(false, 0, 1)]
        public ValueBool WavStatus { get; set; }

        [XmlElement(TrackProperty.WavLength, typeof(int))]
        [Property(0, 0, 1_000_000_000)]
        public ValueInt WavLength { get; set; }

        public SettingsMemoryTrackModel() : base() { }
    }
}
