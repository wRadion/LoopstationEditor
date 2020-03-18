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

    public static class FxProperty
    {
        public const string FilterType = "FilTyp";
        public const string FilterRate = "FilRat";
        public const string FilterDepth = "FilDep";
        public const string FilterResonance = "FilReso";
        public const string FilterCutoff = "FilCut";
        public const string FilterStepRate = "FilStpRat";

        public const string PhaserRate = "PhRat";
        public const string PhaserDepth = "PhDep";
        public const string PhaserResonance = "PhReso";
        public const string PhaserStepRate = "PhStpRat";
        public const string PhaserLevel = "PhLvl";

        public const string FlangerRate = "FlRat";
        public const string FlangerDepth = "FlDep";
        public const string FlangerResonance = "FlReso";
        public const string FlangerStepRate = "FlStpRat";
        public const string FlangerLevel = "FlLvl";

        public const string SynthFrequency = "SynFreq";
        public const string SynthResonance = "SynReso";
        public const string SynthDecay = "SynDecay";
        public const string SynthBalance = "SynBal";

        public const string LoFiDepth = "LoFiDep";
        public const string LoFiSampleRate = "LoFiSmpl";
        public const string LoFiBalance = "LoFiBal";

        public const string RingModulatorFrequency = "RmFreq";
        public const string RingModulatorBalance = "RmBal";

        public const string GuitarToBassBalance = "GToB";

        public const string SlowGearSensitivity = "SgSens";
        public const string SlowGearRiseTime = "SgRisTim";
        public const string SlowGearLevel = "SgLvl";

        public const string TransposeSemitones = "Trans";

        public const string PitchBendOctave = "PbPit";
        public const string PitchBendBend = "PbBnd";

        public const string RobotNote = "RoboNote";
        public const string RobotGender = "RoboGen";

        public const string VocalDistDistortion = "DistDist";
        public const string VocalDistTone = "DistTon";
        public const string VocalDistLevel = "DistLvl";

        public const string VocoderCarrier = "VocoCar";
        public const string VocoderModSens = "VocoSens";
        public const string VocoderAttack = "VocoAtck";
        public const string VocoderBalance = "VocoBal";

        public const string DynamicsType = "DynmTyp";
        public const string DynamicsDynamics = "DynmDynm";

        public const string EqLow = "EqLo";
        public const string EqLowMid = "EqLoMd";
        public const string EqHighMid = "EqHiMd";
        public const string EqHigh = "EqHi";
        public const string EqLevel = "EqLvl";

        public const string IsolatorBand = "IsoBnd";
        public const string IsolatorRate = "IsoRat";
        public const string IsolatorDepth = "IsoDep";
        public const string IsolatorStepRate = "IsoStpRat";
        public const string IsolatorLevel = "IsoLvl";

        public const string OctaveMod = "OctMod";
        public const string OctaveLevel = "OctLvl";

        public const string PanType = "PanTyp";
        public const string PanRate = "PanRat";
        public const string PanDepth = "PanDep";
        public const string PanStepRate = "PanStpRat";
        public const string PanPosition = "PanPos";

        public const string TremoloRate = "TrRat";
        public const string TremoloDepth = "TrDep";
        public const string TremoloLevel = "TrLvl";

        public const string SlicerPattern = "SlPat";
        public const string SlicerRate = "SlRat";
        public const string SlicerDepth = "SlDep";

        public const string DelayTime = "DlyTim";
        public const string DelayFeedback = "DlyFb";
        public const string DelayLevel = "DlyLvl";

        public const string PanningDelayTime = "PanDlyTim";
        public const string PanningDelayFeedback = "PanDlyFb";
        public const string PanningDelayLevel = "PanDlyLvl";

        public const string TapeEchoRate = "EchRat";
        public const string TapeEchoIntensity = "EchInt";
        public const string TapeEchoLevel = "EchLvl";

        public const string GranularDelayTime = "GraTim";
        public const string GranularDelayFeedback = "GraFb";
        public const string GranularDelayLevel = "GraLvl";

        public const string RollTime = "RllTim";
        public const string RollMode = "RllMod";
        public const string RollFeedback = "RllFb";
        public const string RollLevel = "RllLvl";

        public const string ChorusRate = "ChoRat";
        public const string ChorusDepth = "ChoDep";
        public const string ChorusLevel = "ChoLvl";

        public const string ReverbTime = "RevTim";
        public const string ReverbLevel = "RevLvl";
        public const string ReverbDryLevel = "RevDLvl";
    }

    public class SettingsMemoryFxModel : SettingsModel
    {
        // FILTER
        [XmlElement(FxProperty.FilterType, typeof(int))]
        [Property(FxFilterType.LPF, 0, 2)]
        public ValueEnum<FxFilterType> FilterType { get; set; }
        [XmlElement(FxProperty.FilterRate, typeof(int))]
        [PropertyMixed(50, 0, 114, 0, 100)]
        public ValueInt FilterRate { get; set; }
        [XmlElement(FxProperty.FilterDepth, typeof(int))]
        [Property(55, 0, 100)]
        public ValueInt FilterDepth { get; set; }
        [XmlElement(FxProperty.FilterResonance, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt FilterResonance { get; set; }
        [XmlElement(FxProperty.FilterCutoff, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt FilterCutoff { get; set; }
        [XmlElement(FxProperty.FilterStepRate, typeof(int))]
        [PropertyMixed(FxStepRate.OFF, 0, 115, 1, 101)]
        public ValueInt FilterStepRate { get; set; }

        // PHASER
        [XmlElement(FxProperty.PhaserRate, typeof(int))]
        [PropertyMixed(70, 0, 114, 0, 100)]
        public ValueInt PhaserRate { get; set; }
        [XmlElement(FxProperty.PhaserDepth, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt PhaserDepth { get; set; }
        [XmlElement(FxProperty.PhaserResonance, typeof(int))]
        [Property(0, 0, 100)]
        public ValueInt PhaserResonance { get; set; }
        [XmlElement(FxProperty.PhaserStepRate, typeof(int))]
        [PropertyMixed(FxStepRate.OFF, 0, 115, 1, 101)]
        public ValueInt PhaserStepRate { get; set; }
        [XmlElement(FxProperty.PhaserLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt PhaserLevel { get; set; }

        // FLANGER
        [XmlElement(FxProperty.FlangerRate, typeof(int))]
        [PropertyMixed(25, 0, 114, 0, 100)]
        public ValueInt FlangerRate { get; set; }
        [XmlElement(FxProperty.FlangerDepth, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt FlangerDepth { get; set; }
        [XmlElement(FxProperty.FlangerResonance, typeof(int))]
        [Property(70, 0, 100)]
        public ValueInt FlangerResonance { get; set; }
        [XmlElement(FxProperty.FlangerStepRate, typeof(int))]
        [PropertyMixed(FxStepRate.OFF, 0, 115, 1, 101)]
        public ValueInt FlangerStepRate { get; set; }
        [XmlElement(FxProperty.FlangerLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt FlangerLevel { get; set; }

        // SYNTH
        [XmlElement(FxProperty.SynthFrequency, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt SynthFrequency { get; set; }
        [XmlElement(FxProperty.SynthResonance, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt SynthResonance { get; set; }
        [XmlElement(FxProperty.SynthDecay, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt SynthDecay { get; set; }
        [XmlElement(FxProperty.SynthBalance, typeof(int))]
        [Property(90, 0, 100)]
        public ValueInt SynthBalance { get; set; }

        // LO-FI
        [XmlElement(FxProperty.LoFiDepth, typeof(int))]
        [Property(8, 0, 15)]
        public ValueInt LoFiDepth { get; set; }
        [XmlElement(FxProperty.LoFiSampleRate, typeof(int))]
        [Property(15, 0, 31)]
        public ValueInt LoFiSampleRate { get; set; }
        [XmlElement(FxProperty.LoFiBalance, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt LoFiBalance { get; set; }

        // RING MODULATOR
        [XmlElement(FxProperty.RingModulatorFrequency, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt RingModulatorFrequency { get; set; }
        [XmlElement(FxProperty.RingModulatorBalance, typeof(int))]
        [Property(100, 0, 100)]
        public ValueInt RingModulatorBalance { get; set; }

        // GUITAR TO BASS
        [XmlElement(FxProperty.GuitarToBassBalance, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt GuitarToBassBalance { get; set; }

        // SLOW GEAR
        [XmlElement(FxProperty.SlowGearSensitivity, typeof(int))]
        [Property(40, 0, 100)]
        public ValueInt SlowGearSensitivity { get; set; }
        [XmlElement(FxProperty.SlowGearRiseTime, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt SlowGearRiseTime { get; set; }
        [XmlElement(FxProperty.SlowGearLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt SlowGearLevel { get; set; }

        // TRANSPOSE
        [XmlElement(FxProperty.TransposeSemitones, typeof(int))]
        [Property(12, 0, 24)]
        public ValueInt TransposeSemitones { get; set; }

        // PITCH BEND
        [XmlElement(FxProperty.PitchBendOctave, typeof(int))]
        [Property(2, 0, 7)]
        public ValueInt PitchBendOctave { get; set; }
        [XmlElement(FxProperty.PitchBendBend, typeof(int))]
        [Property(100, 0, 100)]
        public ValueInt PitchBendBend { get; set; }

        // ROBOT
        [XmlElement(FxProperty.RobotNote, typeof(int))]
        [Property(FxRobotNote.C, 0, 11)]
        public ValueEnum<FxRobotNote> RobotNote { get; set; }
        [XmlElement(FxProperty.RobotGender, typeof(int))]
        [Property(10, 0, 20)]
        public ValueInt RobotGender { get; set; }

        // VOCAL DIST
        [XmlElement(FxProperty.VocalDistDistortion, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VocalDistDistortion { get; set; }
        [XmlElement(FxProperty.VocalDistTone, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VocalDistTone { get; set; }
        [XmlElement(FxProperty.VocalDistLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VocalDistLevel { get; set; }

        // VOCODER
        [XmlElement(FxProperty.VocoderCarrier, typeof(int))]
        [Property(Track.TRACK1, 0, 4)]
        public ValueEnum<Track> VocoderCarrier { get; set; }
        [XmlElement(FxProperty.VocoderModSens, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VocoderModSens { get; set; }
        [XmlElement(FxProperty.VocoderAttack, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VocoderAttack { get; set; }
        [XmlElement(FxProperty.VocoderBalance, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VocoderBalance { get; set; }

        // DYNAMICS
        [XmlElement(FxProperty.DynamicsType, typeof(int))]
        [Property(FxDynamicsType.NATURAL_COMP, 0, 18)]
        public ValueEnum<FxDynamicsType> DynamicsType { get; set; }
        [XmlElement(FxProperty.DynamicsDynamics, typeof(int))]
        [Property(20, 0, 40)]
        public ValueInt DynamicsDynamics { get; set; }

        // EQ
        [XmlElement(FxProperty.EqLow, typeof(int))]
        [Property(20, 0, 40)]
        public ValueInt EqLow { get; set; }
        [XmlElement(FxProperty.EqLowMid, typeof(int))]
        [Property(20, 0, 40)]
        public ValueInt EqLowMid { get; set; }
        [XmlElement(FxProperty.EqHighMid, typeof(int))]
        [Property(20, 0, 40)]
        public ValueInt EqHighMid { get; set; }
        [XmlElement(FxProperty.EqHigh, typeof(int))]
        [Property(20, 0, 40)]
        public ValueInt EqHigh { get; set; }
        [XmlElement(FxProperty.EqLevel, typeof(int))]
        [Property(20, 0, 40)]
        public ValueInt EqLevel { get; set; }

        // ISOLATOR
        [XmlElement(FxProperty.IsolatorBand, typeof(int))]
        [Property(FxIsolatorBand.LOW, 0, 2)]
        public ValueEnum<FxIsolatorBand> IsolatorBand { get; set; }
        [XmlElement(FxProperty.IsolatorRate, typeof(int))]
        [PropertyMixed(FxRate.ONE_MEASURE, 0, 114, 0, 100)]
        public ValueInt IsolatorRate { get; set; }
        [XmlElement(FxProperty.IsolatorDepth, typeof(int))]
        [Property(100, 0, 100)]
        public ValueInt IsolatorDepth { get; set; }
        [XmlElement(FxProperty.IsolatorStepRate, typeof(int))]
        [PropertyMixed(FxStepRate.OFF, 0, 115, 1, 101)]
        public ValueInt IsolatorStepRate { get; set; }
        [XmlElement(FxProperty.IsolatorLevel, typeof(int))]
        [Property(100, 0, 100)]
        public ValueInt IsolatorLevel { get; set; }

        // OCTAVE
        [XmlElement(FxProperty.OctaveMod, typeof(int))]
        [Property(FxOctaveMode.MINUS_1OCT, 0, 2)]
        public ValueEnum<FxOctaveMode> OctaveMod { get; set; }
        [XmlElement(FxProperty.OctaveLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt OctaveLevel { get; set; }

        // PAN
        [XmlElement(FxProperty.PanType, typeof(int))]
        [Property(FxPanType.AUTO1, 0, 2)]
        public ValueEnum<FxPanType> PanType { get; set; }
        [XmlElement(FxProperty.PanRate, typeof(int))]
        [PropertyMixed(50, 0, 114, 0, 100)]
        public ValueInt PanRate { get; set; }
        [XmlElement(FxProperty.PanDepth, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt PanDepth { get; set; }
        [XmlElement(FxProperty.PanStepRate, typeof(int))]
        [PropertyMixed(FxStepRate.OFF, 0, 115, 1, 101)]
        public ValueInt PanStepRate { get; set; }
        [XmlElement(FxProperty.PanPosition, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt PanPosition { get; set; }

        // TREMOLO
        [XmlElement(FxProperty.TremoloRate, typeof(int))]
        [PropertyMixed(85, 0, 114, 0, 100)]
        public ValueInt TremoloRate { get; set; }
        [XmlElement(FxProperty.TremoloDepth, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt TremoloDepth { get; set; }
        [XmlElement(FxProperty.TremoloLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt TremoloLevel { get; set; }

        // SLICER
        [XmlElement(FxProperty.SlicerPattern, typeof(int))]
        [Property(FxSlicerPattern.P01, 0, 19)]
        public ValueEnum<FxSlicerPattern> SlicerPattern { get; set; }
        [XmlElement(FxProperty.SlicerRate, typeof(int))]
        [PropertyMixed(FxRate.EIGHTH_NOTE, 0, 114, 0, 100)]
        public ValueInt SlicerRate { get; set; }
        [XmlElement(FxProperty.SlicerDepth, typeof(int))]
        [Property(100, 0, 120)]
        public ValueInt SlicerDepth { get; set; }

        // DELAY
        [XmlElement(FxProperty.DelayTime, typeof(int))]
        [PropertyMixed(200, 0, 1011, 0, 1000)]
        public ValueInt DelayTime { get; set; }
        [XmlElement(FxProperty.DelayFeedback, typeof(int))]
        [Property(20, 0, 100)]
        public ValueInt DelayFeedback { get; set; }
        [XmlElement(FxProperty.DelayLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt DelayLevel { get; set; }

        // PANNING DELAY
        [XmlElement(FxProperty.PanningDelayTime, typeof(int))]
        [PropertyMixed(200, 0, 1011, 0, 1000)]
        public ValueInt PanningDelayTime { get; set; }
        [XmlElement(FxProperty.PanningDelayFeedback, typeof(int))]
        [Property(20, 0, 100)]
        public ValueInt PanningDelayFeedback { get; set; }
        [XmlElement(FxProperty.PanningDelayLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt PanningDelayLevel { get; set; }

        // TAPE ECHO
        [XmlElement(FxProperty.TapeEchoRate, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt TapeEchoRate { get; set; }
        [XmlElement(FxProperty.TapeEchoIntensity, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt TapeEchoIntensity { get; set; }
        [XmlElement(FxProperty.TapeEchoLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt TapeEchoLevel { get; set; }

        // GRANULAR DELAY
        [XmlElement(FxProperty.GranularDelayTime, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt GranularDelayTime { get; set; }
        [XmlElement(FxProperty.GranularDelayFeedback, typeof(int))]
        [Property(70, 0, 100)]
        public ValueInt GranularDelayFeedback { get; set; }
        [XmlElement(FxProperty.GranularDelayLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt GranularDelayLevel { get; set; }

        // ROLL
        [XmlElement(FxProperty.RollTime, typeof(int))]
        [PropertyMixed(FxDelayTime.QUARTER_NOTE, 0, 1011, 0, 1000)]
        public ValueInt RollTime { get; set; }

        [XmlElement(FxProperty.RollMode, typeof(int))]
        [Property(FxRollMode._1_4, 0, 4)]
        public ValueEnum<FxRollMode> RollMode { get; set; }

        [XmlElement(FxProperty.RollFeedback, typeof(int))]
        [Property(20, 0, 100)]
        public ValueInt RollFeedback { get; set; }

        [XmlElement(FxProperty.RollLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt RollLevel { get; set; }

        // CHORUS
        [XmlElement(FxProperty.ChorusRate, typeof(int))]
        [PropertyMixed(50, 0, 114, 0, 100)]
        public ValueInt ChorusRate { get; set; }
        [XmlElement(FxProperty.ChorusDepth, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt ChorusDepth { get; set; }
        [XmlElement(FxProperty.ChorusLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt ChorusLevel { get; set; }

        // REVERB
        [XmlElement(FxProperty.ReverbTime, typeof(int))]
        [Property(27, 1, 100)]
        public ValueInt ReverbTime { get; set; }
        [XmlElement(FxProperty.ReverbLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt ReverbLevel { get; set; }
        [XmlElement(FxProperty.ReverbDryLevel, typeof(int))]
        [Property(100, 0, 100)]
        public ValueInt ReverbDryLevel { get; set; }
    }
}
