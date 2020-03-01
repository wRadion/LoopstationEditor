using Loopstation.Xml.Memory;
using Loopstation.Model.Memory.Base;

namespace Loopstation.Model.Memory
{
    public enum TrackFxMode { MULTI, SINGLE }
    public enum TrackSingleFx
    {
        FILTER, PHASER, FLANGER, SYNTH, LO_FI, RING_MODULATOR, GUITAR_TO_BASS, SLOW_GEAR, TRANSPOSE,
        PITCH_BEND, ROBOT, VOCAL_DIST, VOCODER, DYNAMICS, EQ, ISOLATOR, OCTAVE, PAN, TREMOLO, SLICER,
        DELAY, PANNING_DELAY, TAPE_ECHO, GRANULAR_DELAY, ROLL, CHORUS, REVERB,
        BEAT_REPEAT, BEAT_SHIFT, BEAT_SCATTER, VINYL_FLICK
    }
    public enum TrackFxMulti { }
    public enum TrackMultiFxA
    {
        FILTER, PHASER, LO_FI, RING_MODULATOR, VOCAL_DIST, EQ, ISOLATOR, PAN, TREMOLO, SLICER,
        SYNTH, GUITAR_TO_BASS, SLOW_GEAR, TRANSPOSE, PITCH_BEND, ROBOT, VOCODER, DYNAMICS, OCTAVE,
        BEAT_REPEAT, BEAT_SHIFT, BEAT_SCATTER, VINYL_FLICK
    }
    public enum TrackMultiFxB
    {
        FILTER, PHASER, LO_FI, RING_MODULATOR, VOCAL_DIST, EQ, ISOLATOR, PAN, TREMOLO, SLICER,
        FLANGER, DELAY, PANNING_DELAY, ROLL, CHORUS
    }
    public enum TrackMultiFxC
    {
        FILTER, PHASER, LO_FI, RING_MODULATOR, VOCAL_DIST, EQ, ISOLATOR, PAN, TREMOLO, SLICER,
        FLANGER, DELAY, PANNING_DELAY, ROLL, CHORUS,
        TAPE_ECHO, GRANULAR_DELAY, REVERB
    }

    public class ModelTrackFxSettings
    {
        public TrackFxMode Mode { get; set; } = TrackFxMode.SINGLE;
        public FxSlotWithNone SingleEnabledSlot { get; set; } = FxSlotWithNone.NONE;
        public FxSlot SelectedSlot { get; set; } = FxSlot.A;
        public TrackSingleFx SelectedSingleFxA { get; set; } = TrackSingleFx.FILTER;
        public TrackSingleFx SelectedSingleFxB { get; set; } = TrackSingleFx.DELAY;
        public TrackSingleFx SelectedSingleFxC { get; set; } = TrackSingleFx.BEAT_REPEAT;
        // TODO: Bitwise TrackFx>MultiSwitch
        // TODO: Bitwise Default Value 0 NONE
        public TrackFxMulti MultiEnabledSlots { get; set; }
        public TrackMultiFxA SelectedMultiFxA { get; set; } = TrackMultiFxA.BEAT_REPEAT;
        public TrackMultiFxB SelectedMultiFxB { get; set; } = TrackMultiFxB.LO_FI;
        public TrackMultiFxC SelectedMultiFxC { get; set; } = TrackMultiFxC.DELAY;

        public ModelTrackFxSettings() : this(null) { }
        public ModelTrackFxSettings(XmlTrackFxSettings xmlTrackFx)
        {
            if (xmlTrackFx == null) return;

            Mode = (TrackFxMode)xmlTrackFx.Mode;
            SingleEnabledSlot = (FxSlotWithNone)xmlTrackFx.Switch;
            SelectedSlot = (FxSlot)xmlTrackFx.Selected;
            SelectedSingleFxA = (TrackSingleFx)xmlTrackFx.SelectedSingleFxA;
            SelectedSingleFxB = (TrackSingleFx)xmlTrackFx.SelectedSingleFxB;
            SelectedSingleFxC = (TrackSingleFx)xmlTrackFx.SelectedSingleFxC;
            MultiEnabledSlots = (TrackFxMulti)xmlTrackFx.MultiSwitch;
            SelectedMultiFxA = (TrackMultiFxA)xmlTrackFx.SelectedMultiFxA;
            SelectedMultiFxB = (TrackMultiFxB)xmlTrackFx.SelectedMultiFxB;
            SelectedMultiFxC = (TrackMultiFxC)xmlTrackFx.SelectedMultiFxC;
        }
    }
}
