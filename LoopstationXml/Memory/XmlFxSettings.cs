using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;

namespace Loopstation.Xml.Memory
{
    public class XmlFxSettings : ICloneable<XmlFxSettings>
    {
        [XmlElement("FilTyp")]
        public int FilterType { get; set; } = 0;

        [XmlElement("FilRat")]
        public int FilterRate { get; set; } = 50;

        [XmlElement("FilDep")]
        public int FilterDepth { get; set; } = 55;

        [XmlElement("FilReso")]
        public int FilterResonance { get; set; } = 50;

        [XmlElement("FilCut")]
        public int FilterCutoff { get; set; } = 50;

        [XmlElement("FilStpRat")]
        public int FilterStepRate { get; set; } = 0;

        [XmlElement("PhRat")]
        public int PhaserRate { get; set; } = 70;

        [XmlElement("PhDep")]
        public int PhaserDepth { get; set; } = 50;

        [XmlElement("PhReso")]
        public int PhaserResonance { get; set; } = 0;

        [XmlElement("PhStpRat")]
        public int PhaserStepRate { get; set; } = 0;

        [XmlElement("PhLvl")]
        public int PhaserLevel { get; set; } = 50;

        [XmlElement("FlRat")]
        public int FlangerRate { get; set; } = 25;

        [XmlElement("FlDep")]
        public int FlangerDepth { get; set; } = 50;

        [XmlElement("FlReso")]
        public int FlangerResonance { get; set; } = 70;

        [XmlElement("FlStpRat")]
        public int FlangerStepRate { get; set; } = 0;

        [XmlElement("FlLvl")]
        public int FlangerLevel { get; set; } = 50;

        [XmlElement("SynFreq")]
        public int SynthFrequency { get; set; } = 50;

        [XmlElement("SynReso")]
        public int SynthResonance { get; set; } = 50;

        [XmlElement("SynDecay")]
        public int SynthDecay { get; set; } = 50;

        [XmlElement("SynBal")]
        public int SynthBalance { get; set; } = 90;

        [XmlElement("LoFiDep")]
        public int LoFiDepth { get; set; } = 8;

        [XmlElement("LoFiSmpl")]
        public int LoFiSampleRate { get; set; } = 15;

        [XmlElement("LoFiBal")]
        public int LoFiBalance { get; set; } = 50;

        [XmlElement("RmFreq")]
        public int RingModulatorFrequency { get; set; } = 50;

        [XmlElement("RmBal")]
        public int RingModulatorBalance { get; set; } = 100;

        [XmlElement("GToB")]
        public int GuitarToBassBalance { get; set; } = 50;

        [XmlElement("SgSens")]
        public int SlowGearSensitivity { get; set; } = 40;

        [XmlElement("SgRisTim")]
        public int SlowGearRiseTime { get; set; } = 50;

        [XmlElement("SgLvl")]
        public int SlowGearLevel { get; set; } = 50;

        [XmlElement("Trans")]
        public int Transpose { get; set; } = 12;

        [XmlElement("PbPit")]
        public int PitchBendOctave { get; set; } = 2;

        [XmlElement("PbBnd")]
        public int PitchBendBend { get; set; } = 100;

        [XmlElement("RoboNote")]
        public int RobotNote { get; set; } = 0;

        [XmlElement("RoboGen")]
        public int RobotGender { get; set; } = 10;

        [XmlElement("DistDist")]
        public int VocalDistDistortion { get; set; } = 50;

        [XmlElement("DistTon")]
        public int VocalDistTone { get; set; } = 50;

        [XmlElement("DistLvl")]
        public int VocalDistLevel { get; set; } = 50;

        [XmlElement("VocoCar")]
        public int VocoderCarrier { get; set; } = 0;

        [XmlElement("VocoSens")]
        public int VocoderModSens { get; set; } = 50;

        [XmlElement("VocoAtck")]
        public int VocoderAttack { get; set; } = 50;

        [XmlElement("VocoBal")]
        public int VocoderBalance { get; set; } = 50;

        [XmlElement("DynmTyp")]
        public int DynamicsType { get; set; } = 0;

        [XmlElement("DynmDynm")]
        public int DynamicsDynamics { get; set; } = 20;

        [XmlElement("EqLo")]
        public int EqLow { get; set; } = 20;

        [XmlElement("EqLoMd")]
        public int EqLowMid { get; set; } = 20;

        [XmlElement("EqHiMd")]
        public int EqHighMid { get; set; } = 20;

        [XmlElement("EqHi")]
        public int EqHigh { get; set; } = 20;

        [XmlElement("EqLvl")]
        public int EqLevel { get; set; } = 20;

        [XmlElement("IsoBnd")]
        public int IsolatorBand { get; set; } = 0;

        [XmlElement("IsoRat")]
        public int IsolatorRate { get; set; } = 103;

        [XmlElement("IsoDep")]
        public int IsolatorDepth { get; set; } = 100;

        [XmlElement("IsoStpRat")]
        public int IsolatorStepRate { get; set; } = 0;

        [XmlElement("IsoLvl")]
        public int IsolatorLevel { get; set; } = 100;

        [XmlElement("OctMod")]
        public int OctaveMode { get; set; } = 0;

        [XmlElement("OctLvl")]
        public int OctaveLevel { get; set; } = 50;

        [XmlElement("PanTyp")]
        public int PanType { get; set; } = 0;

        [XmlElement("PanRat")]
        public int PanRate { get; set; } = 50;

        [XmlElement("PanDep")]
        public int PanDepth { get; set; } = 50;

        [XmlElement("PanStpRat")]
        public int PanStepRate { get; set; } = 0;

        [XmlElement("PanPos")]
        public int PanPosition { get; set; } = 50;

        [XmlElement("TrRat")]
        public int TremoloRate { get; set; } = 85;

        [XmlElement("TrDep")]
        public int TremoloDepth { get; set; } = 50;

        [XmlElement("TrLvl")]
        public int TremoloLevel { get; set; } = 50;

        [XmlElement("SlPat")]
        public int SlicerPattern { get; set; } = 0;

        [XmlElement("SlRat")]
        public int SlicerRate { get; set; } = 110;

        [XmlElement("SlDep")]
        public int SlicerDepth { get; set; } = 100;

        [XmlElement("DlyTim")]
        public int DelayTime { get; set; } = 200;

        [XmlElement("DlyFb")]
        public int DelayFeedback { get; set; } = 20;

        [XmlElement("DlyLvl")]
        public int DelayLevel { get; set; } = 50;

        [XmlElement("PanDlyTim")]
        public int PanningDelayTime { get; set; } = 200;

        [XmlElement("PanDlyFb")]
        public int PanningDelayFeedback { get; set; } = 20;

        [XmlElement("PanDlyLvl")]
        public int PanningDelayLevel { get; set; } = 50;

        [XmlElement("EchRat")]
        public int TapeEchoRate { get; set; } = 50;

        [XmlElement("EchInt")]
        public int TapeEchoIntensity { get; set; } = 50;

        [XmlElement("EchLvl")]
        public int TapeEchoLevel { get; set; } = 50;

        [XmlElement("GraTim")]
        public int GranularDelayTime { get; set; } = 50;

        [XmlElement("GraFb")]
        public int GranularDelayFeedback { get; set; } = 70;

        [XmlElement("GraLvl")]
        public int GranularDelayLevel { get; set; } = 50;

        [XmlElement("RllTim")]
        public int RollTime { get; set; } = 1008;

        [XmlElement("RllMod")]
        public int RollMode { get; set; } = 2;

        [XmlElement("RllFb")]
        public int RollFeedback { get; set; } = 20;

        [XmlElement("RllLvl")]
        public int RollLevel { get; set; } = 50;

        [XmlElement("ChoRat")]
        public int ChorusRate { get; set; } = 50;

        [XmlElement("ChoDep")]
        public int ChorusDepth { get; set; } = 50;

        [XmlElement("ChoLvl")]
        public int ChorusLevel { get; set; } = 50;

        [XmlElement("RevTim")]
        public int ReverbTime { get; set; } = 27;

        [XmlElement("RevLvl")]
        public int ReverbLevel { get; set; } = 50;

        [XmlElement("RevDLvl")]
        public int ReverbDryLevel { get; set; } = 100;

        public XmlFxSettings() { }
        public XmlFxSettings(XmlFxSettings other)
        {
            if (other == null) return;

            FilterType = other.FilterType;
            FilterRate = other.FilterRate;
            FilterDepth = other.FilterDepth;
            FilterResonance = other.FilterResonance;
            FilterCutoff = other.FilterCutoff;
            FilterStepRate = other.FilterStepRate;
            PhaserRate = other.PhaserRate;
            PhaserDepth = other.PhaserDepth;
            PhaserResonance = other.PhaserResonance;
            PhaserStepRate = other.PhaserStepRate;
            PhaserLevel = other.PhaserLevel;
            FlangerRate = other.FlangerRate;
            FlangerDepth = other.FlangerDepth;
            FlangerResonance = other.FlangerResonance;
            FlangerStepRate = other.FlangerStepRate;
            FlangerLevel = other.FlangerLevel;
            SynthFrequency = other.SynthFrequency;
            SynthResonance = other.SynthResonance;
            SynthDecay = other.SynthDecay;
            SynthBalance = other.SynthBalance;
            LoFiDepth = other.LoFiDepth;
            LoFiSampleRate = other.LoFiSampleRate;
            LoFiBalance = other.LoFiBalance;
            RingModulatorFrequency = other.RingModulatorFrequency;
            RingModulatorBalance = other.RingModulatorBalance;
            GuitarToBassBalance = other.GuitarToBassBalance;
            SlowGearSensitivity = other.SlowGearSensitivity;
            SlowGearRiseTime = other.SlowGearRiseTime;
            SlowGearLevel = other.SlowGearLevel;
            Transpose = other.Transpose;
            PitchBendOctave = other.PitchBendOctave;
            PitchBendBend = other.PitchBendBend;
            RobotNote = other.RobotNote;
            RobotGender = other.RobotGender;
            VocalDistDistortion = other.VocalDistDistortion;
            VocalDistTone = other.VocalDistTone;
            VocalDistLevel = other.VocalDistLevel;
            VocoderCarrier = other.VocoderCarrier;
            VocoderModSens = other.VocoderModSens;
            VocoderAttack = other.VocoderAttack;
            VocoderBalance = other.VocoderBalance;
            DynamicsType = other.DynamicsType;
            DynamicsDynamics = other.DynamicsDynamics;
            EqLow = other.EqLow;
            EqLowMid = other.EqLowMid;
            EqHighMid = other.EqHighMid;
            EqHigh = other.EqHigh;
            EqLevel = other.EqLevel;
            IsolatorBand = other.IsolatorBand;
            IsolatorRate = other.IsolatorRate;
            IsolatorDepth = other.IsolatorDepth;
            IsolatorStepRate = other.IsolatorStepRate;
            IsolatorLevel = other.IsolatorLevel;
            OctaveMode = other.OctaveMode;
            OctaveLevel = other.OctaveLevel;
            PanType = other.PanType;
            PanRate = other.PanRate;
            PanDepth = other.PanDepth;
            PanStepRate = other.PanStepRate;
        }

        public XmlFxSettings Clone() => new XmlFxSettings(this);
    }
}
