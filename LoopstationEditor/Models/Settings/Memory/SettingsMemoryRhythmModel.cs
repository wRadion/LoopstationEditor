using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory
{
    public enum RhythmPattern { SIMPLE_BEAT_1 = 0, SIMPLE_BEAT_2 = 1, SIMPLE_BEAT_3 = 2, SIMPLE_BEAT_4 = 3, SIMPLE_BEAT_5 = 4, DOWNBEAT_SNARE = 5, ROCK_1 = 6, ROCK_2 = 7, ROCK_3 = 8, ROCK_4 = 9, ROCK_5 = 10, LATIN_ROCK_1 = 11, LATIN_ROCK_2 = 12, GROOVE_BEAT_1 = 13, GROOVE_BEAT_2 = 14, GROOVE_BEAT_3 = 15, GROOVE_BEAT_4 = 16, GROOVE_BEAT_5 = 17, SHUFFLE_1 = 18, SHUFFLE_2 = 19, SHUFFLE_3 = 20, SHUFFLE_4 = 21, SHUFFLE_5 = 22, SHUFFLE_6 = 23, _1_2_SHUFFLE_1 = 24, _1_2_SHUFFLE_2 = 25, _16TH_SHUFFLE_1 = 26, _16TH_SHUFFLE_2 = 27, SHUFFLE_REGGAE = 28, POP_1 = 29, POP_2 = 30, POP_3 = 31, FUNK_1 = 32, FUNK_2 = 33, FUNK_3 = 34, FUSION_1 = 35, FUSION_2 = 36, FUSION_3 = 37, SWING = 38, BOSSA_1 = 39, BOSSA_2 = 40, BOSSA_3 = 41, SAMBA_1 = 42, SAMBA_2 = 43, SAMBA_3 = 44, CLAVE_1 = 45, CLAVE_2 = 46, _909_BEAT = 47, _909_CLAP = 48, R_AND_B_1 = 49, R_AND_B_2 = 50, HI_HAT = 51, KICK_AND_HI_HAT_1 = 52, KICK_AND_HI_HAT_2 = 53, CONGA_AND_HI_HAT = 54, CONGA_AND_MARACAS = 55, METRONOME_1 = 56, METRONOME_2 = 57 }
    public enum RhythmBeat { _2_4 = 0, _3_4 = 1, _4_4 = 2, _5_4 = 3, _6_4 = 4, _7_4 = 5, _5_8 = 6, _6_8 = 7, _7_8 = 8, _8_8 = 9, _9_8 = 10, _10_8 = 11, _11_8 = 12, _12_8 = 13, _13_8 = 14, _14_8 = 15, _15_8 = 16 }
    public enum RhythmRecCount { OFF = 0, ONE_MEASURE = 1 }
    public enum RhythmPlayCount { OFF = 0, ONE_MEASURE = 1 }
    public enum RhythmStopMode { OFF = 0, LOOPER_STOP = 1, REC_END = 2 }

    public static class RhythmProperty
    {
        public const string Enabled = "Sw";
        public const string Level = "Lvl";
        public const string Pattern = "Ptn";
        public const string Beat = "Bt";
        public const string LineOut = "LineOut";
        public const string RecCount = "RecCnt";
        public const string PlayCount = "PlyCnt";
        public const string StopMode = "Stp";
    }
    public class SettingsMemoryRhythmModel : SettingsModel
    {
        [XmlElement(RhythmProperty.Enabled, typeof(int))]
        [Property(false, 0, 1)]
        public ValueBool Enabled { get; set; }

        [XmlElement(RhythmProperty.Level, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt Level { get; set; }

        [XmlElement(RhythmProperty.Pattern, typeof(int))]
        [Property(RhythmPattern.SIMPLE_BEAT_1, 0, 57)]
        public ValueEnum<RhythmPattern> Pattern { get; set; }

        [XmlElement(RhythmProperty.Beat, typeof(int))]
        [Property(RhythmBeat._4_4, 0, 16)]
        public ValueEnum<RhythmBeat> Beat { get; set; }

        [XmlElement(RhythmProperty.LineOut, typeof(int))]
        [Property(true, 0, 1)]
        public ValueBool LineOut { get; set; }

        [XmlElement(RhythmProperty.RecCount, typeof(int))]
        [Property(RhythmRecCount.OFF, 0, 1)]
        public ValueEnum<RhythmRecCount> RecCount { get; set; }

        [XmlElement(RhythmProperty.PlayCount, typeof(int))]
        [Property(RhythmPlayCount.OFF, 0, 1)]
        public ValueEnum<RhythmPlayCount> PlayCount { get; set; }

        [XmlElement(RhythmProperty.StopMode, typeof(int))]
        [Property(RhythmStopMode.LOOPER_STOP, 0, 2)]
        public ValueEnum<RhythmStopMode> StopMode { get; set; }

        public SettingsMemoryRhythmModel() : base() { }
    }
}
