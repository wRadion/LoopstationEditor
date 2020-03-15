namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public enum FxRate { FOUR_MEASURES = 101, TWO_MEASURES = 102, ONE_MEASURE = 103, HALF_NOTE = 104, DOTTED_QUARTER_NOTE = 105, HALF_NOTE_TRIPLET = 106, QUARTER_NOTE = 107, DOTTED_EIGHTH_NOTE = 108, QUARTER_NOTE_TRIPLET = 109, EIGHTH_NOTE = 110, DOTTED_SIXTEENTH_NOTE = 111, EIGHTH_NOTE_TRIPLET = 112, SIXTEENTH_NOTE = 113, THIRTYSECOND_NOTE = 114 }
    public enum FxStepRate { OFF = 0, FOUR_MEASURES = 102, TWO_MEASURES = 103, ONE_MEASURE = 104, HALF_NOTE = 105, DOTTED_QUARTER_NOTE = 106, HALF_NOTE_TRIPLET = 107, QUARTER_NOTE = 108, DOTTED_EIGHTH_NOTE = 109, QUARTER_NOTE_TRIPLET = 110, EIGHTH_NOTE = 111, DOTTED_SIXTEENTH_NOTE = 112, EIGHTH_NOTE_TRIPLET = 113, SIXTEENTH_NOTE = 114, THIRTYSECOND_NOTE = 115 }
    public enum FxDelayTime { THIRTYSECOND_NOTE = 1001, SIXTEENTH_NOTE = 1002, EIGHTH_NOTE_TRIPLET = 1003, DOTTED_SIXTEENTH_NOTE = 1004, EIGHTH_NOTE = 1005, QUARTER_NOTE_TRIPLET = 1006, DOTTED_EIGHTH_NOTE = 1007, QUARTER_NOTE = 1008, HALF_NOTE_TRIPLET = 1009, DOTTED_QUARTER_NOTE = 1010, HALF_NOTE = 1011 }

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

        public const string BeatRepeatType = "RepTyp";
        public const string BeatRepeatLength = "RepLen";

        public const string BeatShiftType = "ShftTyp";
        public const string BeatShiftShift = "ShftShft";

        public const string BeatScatterType = "ScatTyp";
        public const string BeatScatterLength = "ScatLen";

        public const string VinylFlick = "Flick";
    }
}
