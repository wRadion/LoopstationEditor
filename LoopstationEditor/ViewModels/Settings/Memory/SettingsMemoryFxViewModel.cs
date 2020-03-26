using System;
using System.Collections.Generic;

using LoopstationEditor.Models.Settings.Memory;
using LoopstationEditor.ViewModels.Settings.Memory.Fx;
using LoopstationEditor.Views.Settings.Memory.Fx;

namespace LoopstationEditor.ViewModels.Settings.Memory
{
    public struct FxItem
    {
        public string Name { get; }
        public FxViewModel ViewModel { get; }
        public Type ViewType { get; }

        public FxItem(string name, FxViewModel viewModel, Type viewType)
        {
            Name = name;
            ViewModel = viewModel;
            ViewType = viewType;
        }
    }

    public abstract class SettingsMemoryFxViewModel : SettingsContainerViewModel
    {
        public readonly FxType Type;
        public readonly FxSlot Slot;

        public override SettingsViewModel CurrentViewModel => FxList[SelectedIndex].ViewModel;

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

        public List<FxItem> FxList { get; private set; }

        public SettingsMemoryFxViewModel(FxType type, FxSlot slot, SettingsMemoryFxModel model)
            : base(model)
        {
            Type = type;
            Slot = slot;

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

        public virtual void SetFxList()
        {
            FxList = new List<FxItem>
            {
                new FxItem(Filter.DisplayName, Filter, typeof(FxFilterView)),
                new FxItem(Phaser.DisplayName, Phaser, typeof(FxPhaserView)),
                new FxItem(Flanger.DisplayName, Flanger, typeof(FxFlangerView)),
                new FxItem(Synth.DisplayName, Synth, typeof(FxSynthView)),
                new FxItem(LoFi.DisplayName, LoFi, typeof(FxLoFiView)),
                new FxItem(RingModulator.DisplayName, RingModulator, typeof(FxRingModulatorView)),
                new FxItem(GuitarToBass.DisplayName, GuitarToBass, typeof(FxGuitarToBassView)),
                new FxItem(SlowGear.DisplayName, SlowGear, typeof(FxSlowGearView)),
                new FxItem(Transpose.DisplayName, Transpose, typeof(FxTransposeView)),
                new FxItem(PitchBend.DisplayName, PitchBend, typeof(FxPitchBendView)),
                new FxItem(Robot.DisplayName, Robot, typeof(FxRobotView)),
                new FxItem(VocalDist.DisplayName, VocalDist, typeof(FxVocalDistView)),
                new FxItem(Dynamics.DisplayName, Dynamics, typeof(FxDynamicsView)),
                new FxItem(Eq.DisplayName, Eq, typeof(FxEqView)),
                new FxItem(Isolator.DisplayName, Isolator, typeof(FxIsolatorView)),
                new FxItem(Octave.DisplayName, Octave, typeof(FxOctaveView)),
                new FxItem(Pan.DisplayName, Pan, typeof(FxPanView)),
                new FxItem(Tremolo.DisplayName, Tremolo, typeof(FxTremoloView)),
                new FxItem(Slicer.DisplayName, Slicer, typeof(FxSlicerView)),
                new FxItem(Delay.DisplayName, Delay, typeof(FxDelayView)),
                new FxItem(PanningDelay.DisplayName, PanningDelay, typeof(FxPanningDelayView)),
                new FxItem(TapeEcho.DisplayName, TapeEcho, typeof(FxTapeEchoView)),
                new FxItem(GranularDelay.DisplayName, GranularDelay, typeof(FxGranularDelayView)),
                new FxItem(Roll.DisplayName, Roll, typeof(FxRollView)),
                new FxItem(Chorus.DisplayName, Chorus, typeof(FxChorusView)),
                new FxItem(Reverb.DisplayName, Reverb, typeof(FxReverbView))
            };
        }

        public override void ApplyChanges<T>(T model)
        {
            if (model is SettingsMemoryFxModel memoryFx)
            {
                Filter.ApplyChanges(memoryFx);
                Phaser.ApplyChanges(memoryFx);
                Flanger.ApplyChanges(memoryFx);
                Synth.ApplyChanges(memoryFx);
                LoFi.ApplyChanges(memoryFx);
                RingModulator.ApplyChanges(memoryFx);
                GuitarToBass.ApplyChanges(memoryFx);
                SlowGear.ApplyChanges(memoryFx);
                Transpose.ApplyChanges(memoryFx);
                PitchBend.ApplyChanges(memoryFx);
                Robot.ApplyChanges(memoryFx);
                VocalDist.ApplyChanges(memoryFx);
                Dynamics.ApplyChanges(memoryFx);
                Eq.ApplyChanges(memoryFx);
                Isolator.ApplyChanges(memoryFx);
                Octave.ApplyChanges(memoryFx);
                Pan.ApplyChanges(memoryFx);
                Tremolo.ApplyChanges(memoryFx);
                Slicer.ApplyChanges(memoryFx);
                Delay.ApplyChanges(memoryFx);
                PanningDelay.ApplyChanges(memoryFx);
                TapeEcho.ApplyChanges(memoryFx);
                GranularDelay.ApplyChanges(memoryFx);
                Roll.ApplyChanges(memoryFx);
                Chorus.ApplyChanges(memoryFx);
                Reverb.ApplyChanges(memoryFx);
            }
            else
                throw new ArgumentException("Model must be of type SettingsMemoryFxModel.");
        }

        public override void RevertChanges()
        {
            Filter.RevertChanges();
            Phaser.RevertChanges();
            Flanger.RevertChanges();
            Synth.RevertChanges();
            LoFi.RevertChanges();
            RingModulator.RevertChanges();
            GuitarToBass.RevertChanges();
            SlowGear.RevertChanges();
            Transpose.RevertChanges();
            PitchBend.RevertChanges();
            Robot.RevertChanges();
            VocalDist.RevertChanges();
            Dynamics.RevertChanges();
            Eq.RevertChanges();
            Isolator.RevertChanges();
            Octave.RevertChanges();
            Pan.RevertChanges();
            Tremolo.RevertChanges();
            Slicer.RevertChanges();
            Delay.RevertChanges();
            PanningDelay.RevertChanges();
            TapeEcho.RevertChanges();
            GranularDelay.RevertChanges();
            Roll.RevertChanges();
            Chorus.RevertChanges();
            Reverb.RevertChanges();
        }
    }
}
