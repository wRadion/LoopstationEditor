using Loopstation.Model.Memory.Base;
using Loopstation.Xml.Memory;

namespace Loopstation.Model.Memory
{
    public enum InputFxMode { MULTI, SINGLE }
    public enum InputSingleFx
    {
        FILTER, PHASER, FLANGER, SYNTH, LO_FI, RING_MODULATOR, GUITAR_TO_BASS, SLOW_GEAR, TRANSPOSE,
        PITCH_BEND, ROBOT, VOCAL_DIST, VOCODER, DYNAMICS, EQ, ISOLATOR, OCTAVE, PAN, TREMOLO, SLICER,
        DELAY, PANNING_DELAY, TAPE_ECHO, GRANULAR_DELAY, ROLL, CHORUS, REVERB
    }
    public enum InputFxMulti { }
    public enum InputMultiFxA
    {
        FILTER, PHASER, LO_FI, RING_MODULATOR, VOCAL_DIST, EQ, ISOLATOR, PAN, TREMOLO, SLICER,
        SYNTH, GUITAR_TO_BASS, SLOW_GEAR, TRANSPOSE, PITCH_BEND, ROBOT, VOCODER, DYNAMICS, OCTAVE
    }
    public enum InputMultiFxB
    {
        FILTER, PHASER, LO_FI, RING_MODULATOR, VOCAL_DIST, EQ, ISOLATOR, PAN, TREMOLO, SLICER,
        FLANGER, DELAY, PANNING_DELAY, ROLL, CHORUS
    }
    public enum InputMultiFxC
    {
        FILTER, PHASER, LO_FI, RING_MODULATOR, VOCAL_DIST, EQ, ISOLATOR, PAN, TREMOLO, SLICER,
        FLANGER, DELAY, PANNING_DELAY, ROLL, CHORUS,
        TAPE_ECHO, GRANULAR_DELAY, REVERB
    }

    public class ModelInputFxSettings
    {
        public InputFxMode Mode { get; set; } = InputFxMode.SINGLE;
        public FxSlotWithNone SingleEnabledSlot { get; set; } = FxSlotWithNone.NONE;
        public FxSlot SelectedSlot { get; set; } = FxSlot.A;
        public InputSingleFx SelectedSingleFxA { get; set; } = InputSingleFx.FILTER;
        public InputSingleFx SelectedSingleFxB { get; set; } = InputSingleFx.LO_FI;
        public InputSingleFx SelectedSingleFxC { get; set; } = InputSingleFx.PAN;
        // TODO: Bitwise InputFx>MultiSwitch
        // TODO: Bitwise Default Value 0 NONE
        public InputFxMulti MultiEnabledSlots { get; set; }
        public InputMultiFxA SelectedMultiFxA { get; set; } = InputMultiFxA.FILTER;
        public InputMultiFxB SelectedMultiFxB { get; set; } = InputMultiFxB.RING_MODULATOR;
        public InputMultiFxC SelectedMultiFxC { get; set; } = InputMultiFxC.TREMOLO;

        public ModelInputFxSettings() : this(null) { }
        public ModelInputFxSettings(XmlInputFxSettings xmlInputFx)
        {
            if (xmlInputFx == null) return;
            
            Mode = (InputFxMode)xmlInputFx.Mode;
            SingleEnabledSlot = (FxSlotWithNone)xmlInputFx.Switch;
            SelectedSlot = (FxSlot)xmlInputFx.Selected;
            SelectedSingleFxA = (InputSingleFx)xmlInputFx.SelectedSingleFxA;
            SelectedSingleFxB = (InputSingleFx)xmlInputFx.SelectedSingleFxB;
            SelectedSingleFxC = (InputSingleFx)xmlInputFx.SelectedSingleFxC;
            MultiEnabledSlots = (InputFxMulti)xmlInputFx.MultiSwitch;
            SelectedMultiFxA = (InputMultiFxA)xmlInputFx.SelectedMultiFxA;
            SelectedMultiFxB = (InputMultiFxB)xmlInputFx.SelectedMultiFxB;
            SelectedMultiFxC = (InputMultiFxC)xmlInputFx.SelectedMultiFxC;
        }
    }
}
