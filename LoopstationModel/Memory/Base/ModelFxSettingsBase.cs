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

        public ModelFxSettingsBase(FxType type, FxSlot slot, XmlFxSettings xmlFx)
        {
            Type = type;
            Slot = slot;

            Filter        = new FilterFx(xmlFx);
            Phaser        = new PhaserFx(xmlFx);
            Flanger       = new FlangerFx(xmlFx);
            Synth         = new SynthFx(xmlFx);
            LoFi          = new LoFiFx(xmlFx);
            RingModulator = new RingModulatorFx(xmlFx);
            GuitarToBass  = new GuitarToBassFx(xmlFx);
            SlowGear      = new SlowGearFx(xmlFx);
            Transpose     = new TransposeFx(xmlFx);
            PitchBend     = new PitchBendFx(xmlFx);
            Robot         = new RobotFx(xmlFx);
            VocalDist     = new VocalDistFx(xmlFx);
            Vocoder       = new VocoderFx(xmlFx);
            Dynamics      = new DynamicsFx(xmlFx);
            Eq            = new EqFx(xmlFx);
            Isolator      = new IsolatorFx(xmlFx);
            Octave        = new OctaveFx(xmlFx);
            Pan           = new PanFx(xmlFx);
            Tremolo       = new TremoloFx(xmlFx);
            Slicer        = new SlicerFx(xmlFx);
            Delay         = new DelayFx(xmlFx);
            PanningDelay  = new PanningDelayFx(xmlFx);
            TapeEcho      = new TapeEchoFx(xmlFx);
            GranularDelay = new GranularDelayFx(xmlFx);
            Roll          = new RollFx(xmlFx);
            Chorus        = new ChorusFx(xmlFx);
            Reverb        = new ReverbFx(xmlFx);
        }
    }
}
