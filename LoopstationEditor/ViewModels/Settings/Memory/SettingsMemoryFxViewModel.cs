using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.Settings.Memory.Fx;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public abstract class SettingsMemoryFxViewModel : SettingsContainerViewModel
    {
        public FxFilterViewModel Filter { get; }
        public FxPhaserViewModel Phaser { get; }
        public FxFlangerViewModel Flanger { get; }
        public FxSynthViewModel Synth { get; }
        public FxLoFiViewModel LoFi { get; }
        public FxRingModulatorViewModel RingModulator { get; }
        public FxGuitarToBassViewModel GuitarToBass { get; }
        public FxSlowGearViewModel SlowGear { get; }
        public FxTransposeViewModel Transpose { get; }
        public FxPitchBendViewModel PitchBend { get; }
        public FxRobotViewModel Robot { get; }
        public FxVocalDistViewModel VocalDist { get; }
        public FxVocoderViewModel Vocoder { get; }
        public FxDynamicsViewModel Dynamics { get; }
        public FxEqViewModel Eq { get; }
        public FxIsolatorViewModel Isolator { get; }
        public FxOctaveViewModel Octave { get; }
        public FxPanViewModel Pan { get; }
        public FxTremoloViewModel Tremolo { get; }
        public FxSlicerViewModel Slicer { get; }
        public FxDelayViewModel Delay { get; }
        public FxPanningDelayViewModel PanningDelay { get; }
        public FxTapeEchoViewModel TapeEcho { get; }
        public FxGranularDelayViewModel GranularDelay { get; }
        public FxRollViewModel Roll { get; }
        public FxChorusViewModel Chorus { get; }
        public FxReverbViewModel Reverb { get; }

        public SettingsMemoryFxViewModel(SettingsMemoryFxModel model)
            : base(model)
        {
            Filter = new FxFilterViewModel(model);
            Phaser = new FxPhaserViewModel(model);
            Flanger = new FxFlangerViewModel(model);
            Synth = new FxSynthViewModel(model);
            LoFi = new FxLoFiViewModel(model);
            RingModulator = new FxRingModulatorViewModel(model);
            GuitarToBass = new FxGuitarToBassViewModel(model);
            SlowGear = new FxSlowGearViewModel(model);
            Transpose = new FxTransposeViewModel(model);
            PitchBend = new FxPitchBendViewModel(model);
            Robot = new FxRobotViewModel(model);
            VocalDist = new FxVocalDistViewModel(model);
            Dynamics = new FxDynamicsViewModel(model);
            Eq = new FxEqViewModel(model);
            Isolator = new FxIsolatorViewModel(model);
            Octave = new FxOctaveViewModel(model);
            Pan = new FxPanViewModel(model);
            Tremolo = new FxTremoloViewModel(model);
            Slicer = new FxSlicerViewModel(model);
            Delay = new FxDelayViewModel(model);
            PanningDelay = new FxPanningDelayViewModel(model);
            TapeEcho = new FxTapeEchoViewModel(model);
            GranularDelay = new FxGranularDelayViewModel(model);
            Roll = new FxRollViewModel(model);
            Chorus = new FxChorusViewModel(model);
            Reverb = new FxReverbViewModel(model);
        }
    }
}
