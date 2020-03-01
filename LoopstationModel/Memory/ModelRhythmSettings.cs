using Loopstation.Xml.Memory;

namespace Loopstation.Model.Memory
{
    public enum RhythmPattern
    {
        SIMPLE_BEAT_1, SIMPLE_BEAT_2, SIMPLE_BEAT_3, SIMPLE_BEAT_4, SIMPLE_BEAT_5,
        DOWNBEAT_SNARE, ROCK_1, ROCK_2, ROCK_3, ROCK_4, ROCK_5, LATIN_ROCK_1, LATIN_ROCK_2,
        GROOVE_BEAT_1, GROOVE_BEAT_2, GROOVE_BEAT_3, GROOVE_BEAT_4, GROOVE_BEAT_5,
        SHUFFLE_1, SHUFFLE_2, SHUFFLE_3, SHUFFLE_4, SHUFFLE_5, SHUFFLE_6,
        HALF_SHUFFLE_1, HALF_SHUFFLE_2, SIXTEENTH_SHUFFLE_1, SIXTEENTH_SHUFFLE_2, SHUFFLE_REGGAE,
        POP_1, POP_2, POP_3, FUNK_1, FUNK_2, FUNK_3, FUSION_1, FUSION_2, FUSION_3, SWING,
        BOSSA_1, BOSSA_2, BOSSA_3, SAMBA_1, SAMBA_2, SAMBA_3, CLAVE_1, CLAVE_2,
        X909_BEAT, X909_CLAP, RNB_1, RNB_2,
        HI_HAT, KICK_AND_HI_HAT_1, KICK_AND_HI_HAT_2, CONGA_AND_HI_HAT, CONGA_AND_MARACAS,
        METRONOME_1, METRONOME_2
    }
    // TODO RhythmBeat => A struct with 2 ints?
    public enum RhythmBeat
    {
        B2_4, B3_4, B4_4, B5_4, B6_4, B7_4,
        B5_8, B6_8, B7_8, B8_8, B9_8, B10_8, B11_8, B12_8, B13_8, B14_8, B15_8
    }
    public enum RhythmStopMode { OFF, LOOPER_STOP, REC_END }

    public class ModelRhythmSettings
    {
        public bool Enabled { get; set; } = false;

        // TODO Level (0...100) *2
        private int _lvl;
        public int Level { get; set; } = 50;

        public RhythmPattern Pattern { get; set; } = RhythmPattern.SIMPLE_BEAT_1;
        public RhythmBeat Beat { get; set; } = RhythmBeat.B4_4;
        public bool IsLineOut { get; set; } = true;
        public bool HasRecOneMeasure { get; set; } = false;
        public bool HasPlayOneMeasure { get; set; } = false;
        public RhythmStopMode StopMode { get; set; } = RhythmStopMode.LOOPER_STOP;

        public ModelRhythmSettings() : this(null) { }
        public ModelRhythmSettings(XmlRhythmSettings xmlRhythm)
        {
            if (xmlRhythm == null) return;

            Enabled = xmlRhythm.Switch == 1;
            Level = xmlRhythm.Level;
            Pattern = (RhythmPattern)xmlRhythm.Pattern;
            Beat = (RhythmBeat)xmlRhythm.Beat;
            IsLineOut = xmlRhythm.LineOut == 1;
            HasRecOneMeasure = xmlRhythm.RecCount == 1;
            HasPlayOneMeasure = xmlRhythm.PlayCount == 1;
            StopMode = (RhythmStopMode)xmlRhythm.StopMode;
        }
    }
}
