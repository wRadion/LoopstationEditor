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

        public SettingsMemoryFxViewModel(SettingsMemoryFxModel model) :
            base(model)
        {
            Filter = new FxFilterViewModel(model.Filter);
            Phaser = new FxPhaserViewModel(model.Phaser);
            Flanger = new FxFlangerViewModel(model.Flanger);
            Synth = new FxSynthViewModel(model.Synth);
            LoFi = new FxLoFiViewModel(model.LoFi);
            RingModulator = new FxRingModulatorViewModel(model.RingModulator);
            GuitarToBass = new FxGuitarToBassViewModel(model.GuitarToBass);
            SlowGear = new FxSlowGearViewModel(model.SlowGear);
            Transpose = new FxTransposeViewModel(model.Transpose);
            PitchBend = new FxPitchBendViewModel(model.PitchBend);
            Robot = new FxRobotViewModel(model.Robot);
            VocalDist = new FxVocalDistViewModel(model.VocalDist);
            Dynamics = new FxDynamicsViewModel(model.Dynamics);
            Eq = new FxEqViewModel(model.Eq);
            Isolator = new FxIsolatorViewModel(model.Isolator);
            Octave = new FxOctaveViewModel(model.Octave);
            Pan = new FxPanViewModel(model.Pan);
            Tremolo = new FxTremoloViewModel(model.Tremolo);
            Slicer = new FxSlicerViewModel(model.Slicer);
            Delay = new FxDelayViewModel(model.Delay);
            PanningDelay = new FxPanningDelayViewModel(model.PanningDelay);
            TapeEcho = new FxTapeEchoViewModel(model.TapeEcho);
            GranularDelay = new FxGranularDelayViewModel(model.GranularDelay);
            Roll = new FxRollViewModel(model.Roll);
            Chorus = new FxChorusViewModel(model.Chorus);
            Reverb = new FxReverbViewModel(model.Reverb);
        }
    }
}
