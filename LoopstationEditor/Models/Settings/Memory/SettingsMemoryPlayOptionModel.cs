using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory
{
    public enum PlayOptionSinglePlayChange { IMMEDIATE = 0, LOOP_END = 1 }
    public enum PlayOptionLoopQuantize { REC_END = 0, MEASURE = 1, BEAT = 2 }
    public enum PlayOptionLoopMode { AUTO = 0, LENGTH = 1 }

    public class SettingsMemoryPlayOptionModel : SettingsModel
    {
        [XmlElement("SinglePlyChg", typeof(int))]
        [Property(PlayOptionSinglePlayChange.IMMEDIATE, 0, 1)]
        public ValueEnum<PlayOptionSinglePlayChange> SinglePlayChange { get; set; }

        [XmlElement("LpQtz", typeof(int))]
        [Property(PlayOptionLoopQuantize.REC_END, 0, 2)]
        public ValueEnum<PlayOptionLoopQuantize> LoopQuantize { get; set; }

        [XmlElement("LpMod", typeof(int))]
        [Property(PlayOptionLoopMode.AUTO, 0, 1)]
        public ValueEnum<PlayOptionLoopMode> LoopMode { get; set; }

        [XmlElement("LpLen", typeof(int))]
        [Property(0, 0, 1000)]
        public ValueInt LoopLength { get; set; }

        [XmlElement("AllStrt", typeof(int))]
        [Property(TrackBitwise.ALL, 0, 31)]
        public ValueEnum<TrackBitwise> AllStart { get; set; }

        [XmlElement("AllStp", typeof(int))]
        [Property(TrackBitwise.ALL, 0, 31)]
        public ValueEnum<TrackBitwise> AllStop { get; set; }

        [XmlElement("FadeTim", typeof(int))]
        [Property(2, 1, 64)]
        public ValueInt FadeTime { get; set; }

        [XmlElement("TgtTr", typeof(int))]
        [Property(Track.TRACK1, 0, 4)]
        public ValueEnum<Track> TargetTrack { get; set; }

        public SettingsMemoryPlayOptionModel() : base() { }
    }
}
