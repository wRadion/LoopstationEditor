using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

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
        public bool Enabled
        {
            get => _enabledProperty.Value;
            set => _enabledProperty.Value = value;
        }
        public int Level // TODO Level (0...100) *2
        {
            get => _levelProperty.Value;
            set => _levelProperty.Value = value;
        }
        public RhythmPattern Pattern
        {
            get => _patternProperty.Value;
            set => _patternProperty.Value = value;
        }
        public RhythmBeat Beat
        {
            get => _beatProperty.Value;
            set => _beatProperty.Value = value;
        }
        public bool LineOut
        {
            get => _lineOutProperty.Value;
            set => _lineOutProperty.Value = value;
        }
        public bool RecCount
        {
            get => _recCountProperty.Value;
            set => _recCountProperty.Value = value;
        }
        public bool PlayCount
        {
            get => _playCountProperty.Value;
            set => _playCountProperty.Value = value;
        }
        public RhythmStopMode StopMode
        {
            get => _stopModeProperty.Value;
            set => _stopModeProperty.Value = value;
        }

        #region private Fields
        private readonly BoolProperty _enabledProperty;
        private readonly IntProperty _levelProperty;
        private readonly EnumProperty<RhythmPattern> _patternProperty;
        private readonly EnumProperty<RhythmBeat> _beatProperty;
        private readonly BoolProperty _lineOutProperty;
        private readonly BoolProperty _recCountProperty;
        private readonly BoolProperty _playCountProperty;
        private readonly EnumProperty<RhythmStopMode> _stopModeProperty;

        private readonly XmlRhythmSettings _xml;
        #endregion private Fields

        public ModelRhythmSettings(XmlRhythmSettings xmlRhythm)
        {
            #region private Fields initialization
            _xml = xmlRhythm;

            _enabledProperty   = _xml.Switch;
            _levelProperty     = _xml.Level;
            _patternProperty   = _xml.Pattern;
            _beatProperty      = _xml.Beat;
            _lineOutProperty   = _xml.LineOut;
            _recCountProperty  = _xml.RecCount;
            _playCountProperty = _xml.PlayCount;
            _stopModeProperty  = _xml.StopMode;

            _enabledProperty.PropertyChanged   += (_, e) => _xml.Switch = e.Value;
            _levelProperty.PropertyChanged     += (_, e) => _xml.Level = e.Value;
            _patternProperty.PropertyChanged   += (_, e) => _xml.Pattern = e.Value;
            _beatProperty.PropertyChanged      += (_, e) => _xml.Beat = e.Value;
            _lineOutProperty.PropertyChanged   += (_, e) => _xml.LineOut = e.Value;
            _recCountProperty.PropertyChanged  += (_, e) => _xml.RecCount = e.Value;
            _playCountProperty.PropertyChanged += (_, e) => _xml.PlayCount = e.Value;
            _stopModeProperty.PropertyChanged  += (_, e) => _xml.StopMode = e.Value;
            #endregion private Fields initialization
        }
    }
}
