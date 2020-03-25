using System;
using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory
{
    [Flags]
    public enum FxSlotBitwise
    {
        NONE = 0, A = 1, B = 2, C = 4,
        ALL = A | B | C
    }

    public enum FxMode { MULTI = 0, SINGLE = 1 }
    public enum FxType { INPUT = 0, TRACK = 1 }
    public enum FxSlot { A = 0, B = 1, C = 2 }
    public enum FxSlotOrNone { NONE = 0, A = 1, B = 2, C = 3 }

    public enum FxRate { FOUR_MEASURES = 101, TWO_MEASURES = 102, ONE_MEASURE = 103, HALF_NOTE = 104, DOTTED_QUARTER_NOTE = 105, HALF_NOTE_TRIPLET = 106, QUARTER_NOTE = 107, DOTTED_EIGHTH_NOTE = 108, QUARTER_NOTE_TRIPLET = 109, EIGHTH_NOTE = 110, DOTTED_SIXTEENTH_NOTE = 111, EIGHTH_NOTE_TRIPLET = 112, SIXTEENTH_NOTE = 113, THIRTYSECOND_NOTE = 114 }
    public enum FxStepRate { OFF = 0, FOUR_MEASURES = 102, TWO_MEASURES = 103, ONE_MEASURE = 104, HALF_NOTE = 105, DOTTED_QUARTER_NOTE = 106, HALF_NOTE_TRIPLET = 107, QUARTER_NOTE = 108, DOTTED_EIGHTH_NOTE = 109, QUARTER_NOTE_TRIPLET = 110, EIGHTH_NOTE = 111, DOTTED_SIXTEENTH_NOTE = 112, EIGHTH_NOTE_TRIPLET = 113, SIXTEENTH_NOTE = 114, THIRTYSECOND_NOTE = 115 }
    public enum FxDelayTime { THIRTYSECOND_NOTE = 1001, SIXTEENTH_NOTE = 1002, EIGHTH_NOTE_TRIPLET = 1003, DOTTED_SIXTEENTH_NOTE = 1004, EIGHTH_NOTE = 1005, QUARTER_NOTE_TRIPLET = 1006, DOTTED_EIGHTH_NOTE = 1007, QUARTER_NOTE = 1008, HALF_NOTE_TRIPLET = 1009, DOTTED_QUARTER_NOTE = 1010, HALF_NOTE = 1011 }

    public enum FxFilterType { LPF = 0, BPF = 1, HPF = 2 }
    public enum FxRobotNote { C = 0, Db = 1, D = 2, Eb = 3, E = 4, F = 5, Gb = 6, G = 7, Ab = 8, A = 9, Bb = 10, B = 11 }
    public enum FxDynamicsType { NATURAL_COMP = 0, MIXER_COMP = 1, LIVE_COMP = 2, NATURAL_LIM = 3, HARD_LIM = 4, JINGL_COMP = 5, HARD_COMP = 6, SOFT_COMP = 7, CLEAN_COMP = 8, DANCE_COMP = 9, ORCH_COMP = 10, VOCAL_COMP = 11, ACOUSTIC = 12, ROCK_BAND = 13, ORCHESTRA = 14, LOW_BOOST = 15, BRIGHTEN = 16, DJs_VOICE = 17, PHONE_VOX = 18 }
    public enum FxIsolatorBand { LOW = 0, MID = 1, HIGH = 2 }
    public enum FxOctaveMode { MINUS_1OCT = 0, MINUS_2OCT = 1, BOTH = 2}
    public enum FxPanType { AUTO1 = 0, AUTO2 = 1, MANUAL = 2 }
    public enum FxSlicerPattern { P01 = 0, P02 = 1, P03 = 2, P04 = 3, P05 = 4, P06 = 5, P07 = 6, P08 = 7, P09 = 8, P10 = 9, P11 = 10, P12 = 11, P13 = 12, P14 = 13, P15 = 14, P16 = 15, P17 = 16, P18 = 17, P19 = 18, P20 = 19 }
    public enum FxRollMode { OFF = 0, _1_2 = 1, _1_4 = 2, _1_8 = 3, _1_16 = 4 }

    public class SettingsMemoryFxModel : SettingsModel
    {
        // FILTER
        [XmlElement("FilTyp", typeof(int))]
        [Property(FxFilterType.LPF, 0, 2)]
        public ValueEnum<FxFilterType> FilterType { get; set; }
        [XmlElement("FilRat", typeof(int))]
        [PropertyMixed(50, 0, 114, 0, 100, FxRate.FOUR_MEASURES, FxRate.THIRTYSECOND_NOTE)]
        public ValueInt FilterRate { get; set; }
        [XmlElement("FilDep", typeof(int))]
        [Property(55, 0, 100)]
        public ValueInt FilterDepth { get; set; }
        [XmlElement("FilReso", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt FilterResonance { get; set; }
        [XmlElement("FilCut", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt FilterCutoff { get; set; }
        [XmlElement("FilStpRat", typeof(int))]
        [PropertyMixed(FxStepRate.OFF, 0, 115, 1, 101, FxStepRate.FOUR_MEASURES, FxStepRate.THIRTYSECOND_NOTE, FxStepRate.OFF)]
        public ValueInt FilterStepRate { get; set; }

        // PHASER
        [XmlElement("PhRat", typeof(int))]
        [PropertyMixed(70, 0, 114, 0, 100, FxRate.FOUR_MEASURES, FxRate.THIRTYSECOND_NOTE)]
        public ValueInt PhaserRate { get; set; }
        [XmlElement("PhDep", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt PhaserDepth { get; set; }
        [XmlElement("PhReso", typeof(int))]
        [Property(0, 0, 100)]
        public ValueInt PhaserResonance { get; set; }
        [XmlElement("PhStpRat", typeof(int))]
        [PropertyMixed(FxStepRate.OFF, 0, 115, 1, 101, FxStepRate.FOUR_MEASURES, FxStepRate.THIRTYSECOND_NOTE, FxStepRate.OFF)]
        public ValueInt PhaserStepRate { get; set; }
        [XmlElement("PhLvl", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt PhaserLevel { get; set; }

        // FLANGER
        [XmlElement("FlRat", typeof(int))]
        [PropertyMixed(25, 0, 114, 0, 100, FxRate.FOUR_MEASURES, FxRate.THIRTYSECOND_NOTE)]
        public ValueInt FlangerRate { get; set; }
        [XmlElement("FlDep", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt FlangerDepth { get; set; }
        [XmlElement("FlReso", typeof(int))]
        [Property(70, 0, 100)]
        public ValueInt FlangerResonance { get; set; }
        [XmlElement("FlStpRat", typeof(int))]
        [PropertyMixed(FxStepRate.OFF, 0, 115, 1, 101, FxStepRate.FOUR_MEASURES, FxStepRate.THIRTYSECOND_NOTE, FxStepRate.OFF)]
        public ValueInt FlangerStepRate { get; set; }
        [XmlElement("FlLvl", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt FlangerLevel { get; set; }

        // SYNTH
        [XmlElement("SynFreq", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt SynthFrequency { get; set; }
        [XmlElement("SynReso", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt SynthResonance { get; set; }
        [XmlElement("SynDecay", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt SynthDecay { get; set; }
        [XmlElement("SynBal", typeof(int))]
        [Property(90, 0, 100)]
        public ValueInt SynthBalance { get; set; }

        // LO-FI
        [XmlElement("LoFiDep", typeof(int))]
        [Property(8, 0, 15)]
        public ValueInt LoFiDepth { get; set; }
        [XmlElement("LoFiSmpl", typeof(int))]
        [Property(15, 0, 31)]
        public ValueInt LoFiSampleRate { get; set; }
        [XmlElement("LoFiBal", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt LoFiBalance { get; set; }

        // RING MODULATOR
        [XmlElement("RmFreq", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt RingModulatorFrequency { get; set; }
        [XmlElement("RmBal", typeof(int))]
        [Property(100, 0, 100)]
        public ValueInt RingModulatorBalance { get; set; }

        // GUITAR TO BASS
        [XmlElement("GToB", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt GuitarToBassBalance { get; set; }

        // SLOW GEAR
        [XmlElement("SgSens", typeof(int))]
        [Property(40, 0, 100)]
        public ValueInt SlowGearSensitivity { get; set; }
        [XmlElement("SgRisTim", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt SlowGearRiseTime { get; set; }
        [XmlElement("SgLvl", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt SlowGearLevel { get; set; }

        // TRANSPOSE
        [XmlElement("Trans", typeof(int))]
        [Property(12, 0, 24)]
        public ValueInt TransposeSemitones { get; set; }

        // PITCH BEND
        [XmlElement("PbPit", typeof(int))]
        [Property(2, 0, 7)]
        public ValueInt PitchBendOctave { get; set; }
        [XmlElement("PbBnd", typeof(int))]
        [Property(100, 0, 100)]
        public ValueInt PitchBendBend { get; set; }

        // ROBOT
        [XmlElement("RoboNote", typeof(int))]
        [Property(FxRobotNote.C, 0, 11)]
        public ValueEnum<FxRobotNote> RobotNote { get; set; }
        [XmlElement("RoboGen", typeof(int))]
        [Property(10, 0, 20)]
        public ValueInt RobotGender { get; set; }

        // VOCAL DIST
        [XmlElement("DistDist", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VocalDistDistortion { get; set; }
        [XmlElement("DistTon", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VocalDistTone { get; set; }
        [XmlElement("DistLvl", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VocalDistLevel { get; set; }

        // VOCODER
        [XmlElement("VocoCar", typeof(int))]
        [Property(Track.TRACK1, 0, 4)]
        public ValueEnum<Track> VocoderCarrier { get; set; }
        [XmlElement("VocoSens", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VocoderModSens { get; set; }
        [XmlElement("VocoAtck", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VocoderAttack { get; set; }
        [XmlElement("VocoBal", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VocoderBalance { get; set; }

        // DYNAMICS
        [XmlElement("DynmTyp", typeof(int))]
        [Property(FxDynamicsType.NATURAL_COMP, 0, 18)]
        public ValueEnum<FxDynamicsType> DynamicsType { get; set; }
        [XmlElement("DynmDynm", typeof(int))]
        [Property(20, 0, 40)]
        public ValueInt DynamicsDynamics { get; set; }

        // EQ
        [XmlElement("EqLo", typeof(int))]
        [Property(20, 0, 40)]
        public ValueInt EqLow { get; set; }
        [XmlElement("EqLoMd", typeof(int))]
        [Property(20, 0, 40)]
        public ValueInt EqLowMid { get; set; }
        [XmlElement("EqHiMd", typeof(int))]
        [Property(20, 0, 40)]
        public ValueInt EqHighMid { get; set; }
        [XmlElement("EqHi", typeof(int))]
        [Property(20, 0, 40)]
        public ValueInt EqHigh { get; set; }
        [XmlElement("EqLvl", typeof(int))]
        [Property(20, 0, 40)]
        public ValueInt EqLevel { get; set; }

        // ISOLATOR
        [XmlElement("IsoBnd", typeof(int))]
        [Property(FxIsolatorBand.LOW, 0, 2)]
        public ValueEnum<FxIsolatorBand> IsolatorBand { get; set; }
        [XmlElement("IsoRat", typeof(int))]
        [PropertyMixed(FxRate.ONE_MEASURE, 0, 114, 0, 100, FxRate.FOUR_MEASURES, FxRate.THIRTYSECOND_NOTE)]
        public ValueInt IsolatorRate { get; set; }
        [XmlElement("IsoDep", typeof(int))]
        [Property(100, 0, 100)]
        public ValueInt IsolatorDepth { get; set; }
        [XmlElement("IsoStpRat", typeof(int))]
        [PropertyMixed(FxStepRate.OFF, 0, 115, 1, 101, FxStepRate.FOUR_MEASURES, FxStepRate.THIRTYSECOND_NOTE, FxStepRate.OFF)]
        public ValueInt IsolatorStepRate { get; set; }
        [XmlElement("IsoLvl", typeof(int))]
        [Property(100, 0, 100)]
        public ValueInt IsolatorLevel { get; set; }

        // OCTAVE
        [XmlElement("OctMod", typeof(int))]
        [Property(FxOctaveMode.MINUS_1OCT, 0, 2)]
        public ValueEnum<FxOctaveMode> OctaveMode { get; set; }
        [XmlElement("OctLvl", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt OctaveLevel { get; set; }

        // PAN
        [XmlElement("PanTyp", typeof(int))]
        [Property(FxPanType.AUTO1, 0, 2)]
        public ValueEnum<FxPanType> PanType { get; set; }
        [XmlElement("PanRat", typeof(int))]
        [PropertyMixed(50, 0, 114, 0, 100, FxRate.FOUR_MEASURES, FxRate.THIRTYSECOND_NOTE)]
        public ValueInt PanRate { get; set; }
        [XmlElement("PanDep", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt PanDepth { get; set; }
        [XmlElement("PanStpRat", typeof(int))]
        [PropertyMixed(FxStepRate.OFF, 0, 115, 1, 101, FxStepRate.FOUR_MEASURES, FxStepRate.THIRTYSECOND_NOTE, FxStepRate.OFF)]
        public ValueInt PanStepRate { get; set; }
        [XmlElement("PanPos", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt PanPosition { get; set; }

        // TREMOLO
        [XmlElement("TrRat", typeof(int))]
        [PropertyMixed(85, 0, 114, 0, 100, FxRate.FOUR_MEASURES, FxRate.THIRTYSECOND_NOTE)]
        public ValueInt TremoloRate { get; set; }
        [XmlElement("TrDep", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt TremoloDepth { get; set; }
        [XmlElement("TrLvl", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt TremoloLevel { get; set; }

        // SLICER
        [XmlElement("SlPat", typeof(int))]
        [Property(FxSlicerPattern.P01, 0, 19)]
        public ValueEnum<FxSlicerPattern> SlicerPattern { get; set; }
        [XmlElement("SlRat", typeof(int))]
        [PropertyMixed(FxRate.EIGHTH_NOTE, 0, 114, 0, 100, FxRate.FOUR_MEASURES, FxRate.THIRTYSECOND_NOTE)]
        public ValueInt SlicerRate { get; set; }
        [XmlElement("SlDep", typeof(int))]
        [Property(100, 0, 120)]
        public ValueInt SlicerDepth { get; set; }

        // DELAY
        [XmlElement("DlyTim", typeof(int))]
        [PropertyMixed(200, 0, 1011, 0, 1000, 1001, 1011)]
        public ValueInt DelayTime { get; set; }
        [XmlElement("DlyFb", typeof(int))]
        [Property(20, 0, 100)]
        public ValueInt DelayFeedback { get; set; }
        [XmlElement("DlyLvl", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt DelayLevel { get; set; }

        // PANNING DELAY
        [XmlElement("PanDlyTim", typeof(int))]
        [PropertyMixed(200, 0, 1011, 0, 1000, 1001, 1011)]
        public ValueInt PanningDelayTime { get; set; }
        [XmlElement("PanDlyFb", typeof(int))]
        [Property(20, 0, 100)]
        public ValueInt PanningDelayFeedback { get; set; }
        [XmlElement("PanDlyLvl", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt PanningDelayLevel { get; set; }

        // TAPE ECHO
        [XmlElement("EchRat", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt TapeEchoRate { get; set; }
        [XmlElement("EchInt", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt TapeEchoIntensity { get; set; }
        [XmlElement("EchLvl", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt TapeEchoLevel { get; set; }

        // GRANULAR DELAY
        [XmlElement("GraTim", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt GranularDelayTime { get; set; }
        [XmlElement("GraFb", typeof(int))]
        [Property(70, 0, 100)]
        public ValueInt GranularDelayFeedback { get; set; }
        [XmlElement("GraLvl", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt GranularDelayLevel { get; set; }

        // ROLL
        [XmlElement("RllTim", typeof(int))]
        [PropertyMixed(FxDelayTime.QUARTER_NOTE, 0, 1011, 0, 1000, 1001, 1011)]
        public ValueInt RollTime { get; set; }

        [XmlElement("RllMod", typeof(int))]
        [Property(FxRollMode._1_4, 0, 4)]
        public ValueEnum<FxRollMode> RollMode { get; set; }

        [XmlElement("RllFb", typeof(int))]
        [Property(20, 0, 100)]
        public ValueInt RollFeedback { get; set; }

        [XmlElement("RllLvl", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt RollLevel { get; set; }

        // CHORUS
        [XmlElement("ChoRat", typeof(int))]
        [PropertyMixed(50, 0, 114, 0, 100, FxRate.FOUR_MEASURES, FxRate.THIRTYSECOND_NOTE)]
        public ValueInt ChorusRate { get; set; }
        [XmlElement("ChoDep", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt ChorusDepth { get; set; }
        [XmlElement("ChoLvl", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt ChorusLevel { get; set; }

        // REVERB
        [XmlElement("RevTim", typeof(int))]
        [Property(27, 1, 100)]
        public ValueInt ReverbTime { get; set; }
        [XmlElement("RevLvl", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt ReverbLevel { get; set; }
        [XmlElement("RevDLvl", typeof(int))]
        [Property(100, 0, 100)]
        public ValueInt ReverbDryLevel { get; set; }

        public SettingsMemoryFxModel() : base() { }
    }
}
