using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory
{
    public enum PlayOptionSinglePlayChange { IMMEDIATE = 0, LOOP_END = 1 }
    public enum PlayOptionLoopQuantize { REC_END = 0, MEASURE = 1, BEAT = 2 }
    public enum PlayOptionLoopMode { AUTO = 0, LENGTH = 1 }

    public static class PlayOptionProperty
    {
        public const string SinglePlayChange = "SinglePlyChg";
        public const string LoopQuantize = "LpQtz";
        public const string LoopMode = "LpMod";
        public const string LoopLength = "LpLen";
        public const string AllStart = "AllStrt";
        public const string AllStop = "AllStp";
        public const string FadeTime = "FadeTim";
        public const string TargetTrack = "TgtTr";
    }

    public class SettingsMemoryPlayOptionModel : SettingsModel
    {
        [XmlElement(PlayOptionProperty.SinglePlayChange, typeof(int))]
        [Property(PlayOptionSinglePlayChange.IMMEDIATE, 0, 1)]
        public ValueEnum<PlayOptionSinglePlayChange> SinglePlayChange { get; set; }

        [XmlElement(PlayOptionProperty.LoopQuantize, typeof(int))]
        [Property(PlayOptionLoopQuantize.REC_END, 0, 2)]
        public ValueEnum<PlayOptionLoopQuantize> LoopQuantize { get; set; }

        [XmlElement(PlayOptionProperty.LoopMode, typeof(int))]
        [Property(PlayOptionLoopMode.AUTO, 0, 1)]
        public ValueEnum<PlayOptionLoopMode> LoopMode { get; set; }

        [XmlElement(PlayOptionProperty.LoopLength, typeof(int))]
        [Property(0, 0, 1000)]
        public ValueInt LoopLength { get; set; }

        [XmlElement(PlayOptionProperty.AllStart, typeof(int))]
        [Property(TrackBitwise.ALL, 0, 31)]
        public ValueEnum<TrackBitwise> AllStart { get; set; }

        [XmlElement(PlayOptionProperty.AllStop, typeof(int))]
        [Property(TrackBitwise.ALL, 0, 31)]
        public ValueEnum<TrackBitwise> AllStop { get; set; }

        [XmlElement(PlayOptionProperty.FadeTime, typeof(int))]
        [Property(2, 1, 64)]
        public ValueInt FadeTime { get; set; }

        [XmlElement(PlayOptionProperty.TargetTrack, typeof(int))]
        [Property(Track.TRACK1, 0, 4)]
        public ValueEnum<Track> TargetTrack { get; set; }

        public SettingsMemoryPlayOptionModel() : base() { }
    }
}
