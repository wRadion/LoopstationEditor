using Loopstation.Xml.Memory;

namespace Loopstation.Model.Memory
{
    public enum InputFxMode { MULTI, SINGLE }
    public enum InputFx { A, B, C }
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
        public InputFxMode Mode { get; set; }
        public InputFx SingleSwitch { get; set; }
        public InputFx Selected { get; set; }
        public InputSingleFx SelectedSingleFxA { get; set; }
        public InputSingleFx SelectedSingleFxB { get; set; }
        public InputSingleFx SelectedSingleFxC { get; set; }
        // TODO: Bitwise InputFx>MultiSwitch
        public InputFxMulti MultiSwitch { get; set; }
        public InputMultiFxA SelectedMultiFxA { get; set; }
        public InputMultiFxB SelectedMultiFxB { get; set; }
        public InputMultiFxC SelectedMultiFxC { get; set; }

        public ModelInputFxSettings(XmlInputFxSettings xmlInputFx)
        {
            Mode = (InputFxMode)xmlInputFx.Mode;
            SingleSwitch = (InputFx)xmlInputFx.Switch;
            Selected = (InputFx)xmlInputFx.Selected;
            SelectedSingleFxA = (InputSingleFx)xmlInputFx.SelectedSingleFxA;
            SelectedSingleFxB = (InputSingleFx)xmlInputFx.SelectedSingleFxB;
            SelectedSingleFxC = (InputSingleFx)xmlInputFx.SelectedSingleFxC;
            MultiSwitch = (InputFxMulti)xmlInputFx.MultiSwitch;
            SelectedMultiFxA = (InputMultiFxA)xmlInputFx.SelectedMultiFxA;
            SelectedMultiFxB = (InputMultiFxB)xmlInputFx.SelectedMultiFxB;
            SelectedMultiFxC = (InputMultiFxC)xmlInputFx.SelectedMultiFxC;
        }
    }
}
