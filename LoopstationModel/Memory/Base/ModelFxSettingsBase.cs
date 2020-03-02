using Loopstation.Xml.Memory;

using Loopstation.Model.Memory.Fx;

namespace Loopstation.Model.Memory.Base
{
    public enum FxType         { INPUT, TRACK }
    public enum FxSlotWithNone { NONE, A, B, C }
    public enum FxSlot         { A, B, C }

    public abstract class ModelFxSettingsBase
    {
        public FxType Type { get; }
        public FxSlot Slot { get; }

        public        FilterFx Filter        { get; }
        public        PhaserFx Phaser        { get; }
        public       FlangerFx Flanger       { get; }
        public         SynthFx Synth         { get; }
        public          LoFiFx LoFi          { get; }
        public RingModulatorFx RingModulator { get; }
        public  GuitarToBassFx GuitarToBass  { get; }
        public      SlowGearFx SlowGear      { get; }
        public     TransposeFx Transpose     { get; }
        public     PitchBendFx PitchBend     { get; }
        public         RobotFx Robot         { get; }
        public     VocalDistFx VocalDist     { get; }
        public       VocoderFx Vocoder       { get; }
        public      DynamicsFx Dynamics      { get; }
        public            EqFx Eq            { get; }
        public      IsolatorFx Isolator      { get; }
        public        OctaveFx Octave        { get; }
        public           PanFx Pan           { get; }
        public       TremoloFx Tremolo       { get; }
        public        SlicerFx Slicer        { get; }
        public         DelayFx Delay         { get; }
        public  PanningDelayFx PanningDelay  { get; }
        public      TapeEchoFx TapeEcho      { get; }
        public GranularDelayFx GranularDelay { get; }
        public          RollFx Roll          { get; }
        public        ChorusFx Chorus        { get; }
        public        ReverbFx Reverb        { get; }

        public ModelFxSettingsBase(FxType type, FxSlot slot) : this(type, slot, new XmlFxSettings()) { }
        public ModelFxSettingsBase(FxType type, FxSlot slot, XmlFxSettings xmlFx)
        {
            Type = type;
            Slot = slot;

            Filter = new FilterFx()
            {
                Type      = (FilterType)xmlFx.FilterType,
                Rate      = (Rate)xmlFx.FilterRate,
                Depth     = xmlFx.FilterDepth,
                Resonance = xmlFx.FilterResonance,
                Cutoff    = xmlFx.FilterCutoff,
                StepRate  = (StepRate)xmlFx.FilterStepRate
            };

            Phaser = new PhaserFx()
            {
                Rate      = (Rate)xmlFx.PhaserRate,
                Depth     = xmlFx.PhaserDepth,
                Resonance = xmlFx.PhaserResonance,
                StepRate  = (StepRate)xmlFx.PhaserStepRate,
                Level     = xmlFx.PhaserLevel
            };

            Flanger = new FlangerFx()
            {
                Rate      = (Rate)xmlFx.FlangerRate,
                Depth     = xmlFx.FlangerDepth,
                Resonance = xmlFx.FlangerResonance,
                StepRate  = (StepRate)xmlFx.FlangerStepRate,
                Level     = xmlFx.FlangerLevel
            };

            Synth = new SynthFx()
            {
                Frequency = xmlFx.SynthFrequency,
                Resonance = xmlFx.SynthResonance,
                Decay     = xmlFx.SynthDecay,
                Balance   = xmlFx.SynthBalance
            };

            LoFi = new LoFiFx()
            {
                Depth      = xmlFx.LoFiDepth,
                SampleRate = xmlFx.LoFiSampleRate,
                Balance    = xmlFx.LoFiBalance
            };

            RingModulator = new RingModulatorFx()
            {
                Frequency = xmlFx.RingModulatorFrequency,
                Balance   = xmlFx.RingModulatorBalance
            };

            GuitarToBass = new GuitarToBassFx()
            {
                Balance = xmlFx.GuitarToBassBalance
            };

            SlowGear = new SlowGearFx()
            {
                Sensitivity = xmlFx.SlowGearSensitivity,
                RiseTime    = xmlFx.SlowGearRiseTime,
                Level       = xmlFx.SlowGearLevel
            };

            Transpose = new TransposeFx()
            {
                Semitones = xmlFx.Transpose
            };

            PitchBend = new PitchBendFx()
            {
                Octave = xmlFx.PitchBendOctave,
                Bend   = xmlFx.PitchBendBend
            };

            Robot = new RobotFx()
            {
                Note   = (RobotNote)xmlFx.RobotNote,
                Gender = xmlFx.RobotGender
            };

            VocalDist = new VocalDistFx()
            {
                Distortion = xmlFx.VocalDistDistortion,
                Tone       = xmlFx.VocalDistTone,
                Level      = xmlFx.VocalDistLevel
            };

            Vocoder = new VocoderFx()
            {
                Carrier = (Track)xmlFx.VocoderCarrier,
                ModSens = xmlFx.VocoderModSens,
                Attack  = xmlFx.VocoderAttack,
                Balance = xmlFx.VocoderBalance
            };

            Dynamics = new DynamicsFx()
            {
                Type     = (DynamicsType)xmlFx.DynamicsType,
                Dynamics = xmlFx.DynamicsDynamics
            };

            Eq = new EqFx()
            {
                Low     = xmlFx.EqLow,
                LowMid  = xmlFx.EqLowMid,
                HighMid = xmlFx.EqHighMid,
                High    = xmlFx.EqHigh,
                Level   = xmlFx.EqLevel
            };

            Isolator = new IsolatorFx()
            {
                Band     = (IsolatorBand)xmlFx.IsolatorBand,
                Rate     = (Rate)xmlFx.IsolatorRate,
                Depth    = xmlFx.IsolatorDepth,
                StepRate = (StepRate)xmlFx.IsolatorStepRate,
                Level    = xmlFx.IsolatorLevel
            };

            Octave = new OctaveFx()
            {
                Mode  = (OctaveMode)xmlFx.OctaveMode,
                Level = xmlFx.OctaveLevel
            };

            Pan = new PanFx()
            {
                Type     = (PanType)xmlFx.PanType,
                Rate     = (Rate)xmlFx.PanRate,
                Depth    = xmlFx.PanDepth,
                StepRate = (StepRate)xmlFx.PanStepRate,
                Position = xmlFx.PanPosition
            };

            Tremolo = new TremoloFx()
            {
                Rate  = (Rate)xmlFx.TremoloRate,
                Depth = xmlFx.TremoloDepth,
                Level = xmlFx.TremoloLevel
            };

            Slicer = new SlicerFx()
            {
                Pattern = (SlicerPattern)xmlFx.SlicerPattern,
                Rate    = (Rate)xmlFx.SlicerRate,
                Depth   = xmlFx.SlicerDepth
            };

            Delay = new DelayFx()
            {
                Time     = (DelayTime)xmlFx.DelayTime,
                Feedback = xmlFx.DelayFeedback,
                Level    = xmlFx.DelayLevel
            };

            PanningDelay = new PanningDelayFx()
            {
                Time     = (DelayTime)xmlFx.PanningDelayTime,
                Feedback = xmlFx.PanningDelayFeedback,
                Level    = xmlFx.PanningDelayLevel
            };

            TapeEcho = new TapeEchoFx()
            {
                Rate      = xmlFx.TapeEchoRate,
                Intensity = xmlFx.TapeEchoIntensity,
                Level     = xmlFx.TapeEchoLevel
            };

            GranularDelay = new GranularDelayFx()
            {
                Time     = xmlFx.GranularDelayTime,
                Feedback = xmlFx.GranularDelayFeedback,
                Level    = xmlFx.GranularDelayLevel
            };

            Roll = new RollFx()
            {
                Time     = (DelayTime)xmlFx.RollTime,
                Mode     = (RollMode)xmlFx.RollMode,
                Feedback = xmlFx.RollFeedback,
                Level    = xmlFx.RollLevel
            };

            Chorus = new ChorusFx()
            {
                Rate  = (Rate)xmlFx.ChorusRate,
                Depth = xmlFx.ChorusDepth,
                Level = xmlFx.ChorusLevel
            };

            Reverb = new ReverbFx()
            {
                Time     = xmlFx.ReverbTime,
                Level    = xmlFx.ReverbLevel,
                DryLevel = xmlFx.ReverbDryLevel
            };
        }
    }
}
