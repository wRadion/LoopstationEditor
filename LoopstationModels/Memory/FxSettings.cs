using LoopstationModels.Base;

namespace LoopstationModels.Memory
{
    public enum FxType
    {
        INPUT,
        TRACK
    }

    public enum FxPosition
    {
        A = 1,
        B = 2,
        C = 3
    }

    public class FxSettings : BaseSettings
    {
        public FxType FxType;
        public FxPosition FxPosition;

        public FxSettings(FxType type, FxPosition pos) : base($"{ type.ToString() }_FX{ (int)pos }")
        {
            FxType = type;
            FxPosition = pos;

            // Filter
            AddProperty("FilTyp", max: 2);
            AddProperty("FilRat", def: 50, max: 114);
            AddProperty("FilDep", def: 55);
            AddProperty("FilReso", def: 50);
            AddProperty("FilCut", def: 50);
            AddProperty("FilStpRat", max: 115);

            // Phaser
            AddProperty("PhRat", def: 70, max: 114);
            AddProperty("PhDep", def: 50);
            AddProperty("PhReso");
            AddProperty("PhStpRat", max: 115);
            AddProperty("PhLvl", def: 50);

            // Flanger
            AddProperty("FlRat", def: 25, max: 114);
            AddProperty("FlDep", def: 50);
            AddProperty("FlReso", def: 70);
            AddProperty("FlStpRat", max: 115);
            AddProperty("FlLvl", def: 50);

            // Synth
            AddProperty("SynFreq", def: 50);
            AddProperty("SynReso", def: 50);
            AddProperty("SynDecay", def: 50);
            AddProperty("SynBal", def: 90);

            // LoFi
            AddProperty("LoFiDep", def: 8, max: 15);
            AddProperty("LoFiSmpl", def: 15, max: 31);
            AddProperty("LoFiBal", def: 50);

            // Ring Modulator
            AddProperty("RmFreq", def: 50);
            AddProperty("RmBal", def: 100);

            // Guitar To Bass
            AddProperty("GToB", def: 50);

            // Slow Gear
            AddProperty("SgSens", def: 40);
            AddProperty("SgRisTim", def: 50);
            AddProperty("SgLvl", def: 50);

            // Transpose
            AddProperty("Trans", def: 12, max: 24);

            // Pitch Bend
            AddProperty("PbPit", def: 2, max: 7);
            AddProperty("PbBnd", def: 100);

            // Robot
            AddProperty("RoboNote", max: 11);
            AddProperty("RoboGen", def: 10, max: 20);

            // Vocal Dist
            AddProperty("DistDist", def: 50);
            AddProperty("DistTon", def: 50);
            AddProperty("DistLvl", def: 50);

            // Vocoder
            AddProperty("VocoCar", max: 4);
            AddProperty("VocoSens", def: 50);
            AddProperty("VocoAtck", def: 50);
            AddProperty("VocoBal", def: 50);

            // Dynamics
            AddProperty("DynmTyp", max: 18);
            AddProperty("DynmDynm", def: 20, max: 40);

            // EQ
            AddProperty("EqLo", def: 20, max: 40);
            AddProperty("EqLoMd", def: 20, max: 40);
            AddProperty("EqHiMd", def: 20, max: 40);
            AddProperty("EqHi", def: 20, max: 40);
            AddProperty("EqLvl", def: 20, max: 40);

            // Isolator
            AddProperty("IsoBnd", max: 2);
            AddProperty("IsoRat", def: 103, max: 114);
            AddProperty("IsoDep", def: 100);
            AddProperty("IsoStpRat", max: 115);
            AddProperty("IsoLvl", def: 100);

            // Octave
            AddProperty("OctMod", max: 2);
            AddProperty("OctLvl", def: 50);

            // Pan
            AddProperty("PanTyp", max: 2);
            AddProperty("PanRat", def: 50, max: 114);
            AddProperty("PanDep", def: 50);
            AddProperty("PanStpRat", max: 115);
            AddProperty("PanPos", def: 50);

            // Tremolo
            AddProperty("TrRat", def: 85, max: 114);
            AddProperty("TrDep", def: 50);
            AddProperty("TrLvl", def: 50);

            // Slicer
            AddProperty("SlPat", max: 19);
            AddProperty("SlRat", def: 110, max: 114);
            AddProperty("SlDep", def: 100);

            // Delay
            AddProperty("DlyTim", def: 200, max: 1011);
            AddProperty("DlyFb", def: 20);
            AddProperty("DlyLvl", def: 50);

            // Panning Delay
            AddProperty("PanDlyTim", def: 200, max: 1011);
            AddProperty("PanDlyFb", def: 20);
            AddProperty("PanDlyLvl", def: 50);

            // Tape Echo
            AddProperty("EchRat", def: 50);
            AddProperty("EchInt", def: 50);
            AddProperty("EchLvl", def: 50);

            // Granular Delay
            AddProperty("GraTim", def: 50);
            AddProperty("GraFb", def: 70);
            AddProperty("GraLvl", def: 50);

            // Roll
            AddProperty("RllTim", def: 1008, max: 1011);
            AddProperty("RllMod", def: 2, max: 4);
            AddProperty("RllFb", def: 20);
            AddProperty("RllLvl", def: 50);

            // Chorus
            AddProperty("ChoRat", def: 50, max: 114);
            AddProperty("ChoDep", def: 50);
            AddProperty("ChoLvl", def: 50);

            // Reverb
            AddProperty("RevTim", def: 27, min: 1);
            AddProperty("RevLvl", def: 50);
            AddProperty("RevDLvl", def: 100);
        }
    }
}
