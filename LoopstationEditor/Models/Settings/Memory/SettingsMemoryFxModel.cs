using System;

using LoopstationEditor.Models.Settings.Memory.Fx;

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

    public abstract class SettingsMemoryFxModel : SettingsContainerModel
    {
        public FxType Type { get; }
        public FxSlot Slot { get; }

        public FxFilterModel Filter { get; set; }
        public FxPhaserModel Phaser { get; set; }
        public FxFlangerModel Flanger { get; set; }
        public FxSynthModel Synth { get; set; }
        public FxLoFiModel LoFi { get; set; }
        public FxRingModulatorModel RingModulator { get; set; }
        public FxGuitarToBassModel GuitarToBass { get; set; }
        public FxSlowGearModel SlowGear { get; set; }
        public FxTransposeModel Transpose { get; set; }
        public FxPitchBendModel PitchBend { get; set; }
        public FxRobotModel Robot { get; set; }
        public FxVocalDistModel VocalDist { get; set; }
        public FxVocoderModel Vocoder { get; set; }
        public FxDynamicsModel Dynamics { get; set; }
        public FxEqModel Eq { get; set; }
        public FxIsolatorModel Isolator { get; set; }
        public FxOctaveModel Octave { get; set; }
        public FxPanModel Pan { get; set; }
        public FxTremoloModel Tremolo { get; set; }
        public FxSlicerModel Slicer { get; set; }
        public FxDelayModel Delay { get; set; }
        public FxPanningDelayModel PanningDelay { get; set; }
        public FxTapeEchoModel TapeEcho { get; set; }
        public FxGranularDelayModel GranularDelay { get; set; }
        public FxRollModel Roll { get; set; }
        public FxChorusModel Chorus { get; set; }
        public FxReverbModel Reverb { get; set; }

        public SettingsMemoryFxModel(FxType type, FxSlot slot) : base()
        {
            Type = type;
            Slot = slot;
        }
    }
}
