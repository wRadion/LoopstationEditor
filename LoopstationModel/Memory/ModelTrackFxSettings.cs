using Loopstation.Xml.Memory;

namespace Loopstation.Model.Memory
{
    public enum TrackFxMode { MULTI, SINGLE }
    public enum TrackFx { A, B, C }
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
        public TrackFxMode Mode { get; set; }
        public TrackFx SingleSwitch { get; set; }
        public TrackFx Selected { get; set; }
        public TrackSingleFx SelectedSingleFxA { get; set; }
        public TrackSingleFx SelectedSingleFxB { get; set; }
        public TrackSingleFx SelectedSingleFxC { get; set; }
        // TODO: Bitwise TrackFx>MultiSwitch
        public TrackFxMulti MultiSwitch { get; set; }
        public TrackMultiFxA SelectedMultiFxA { get; set; }
        public TrackMultiFxB SelectedMultiFxB { get; set; }
        public TrackMultiFxC SelectedMultiFxC { get; set; }

        public ModelTrackFxSettings(XmlTrackFxSettings xmlTrackFx)
        {
            Mode = (TrackFxMode)xmlTrackFx.Mode;
            SingleSwitch = (TrackFx)xmlTrackFx.Switch;
            Selected = (TrackFx)xmlTrackFx.Selected;
            SelectedSingleFxA = (TrackSingleFx)xmlTrackFx.SelectedSingleFxA;
            SelectedSingleFxB = (TrackSingleFx)xmlTrackFx.SelectedSingleFxB;
            SelectedSingleFxC = (TrackSingleFx)xmlTrackFx.SelectedSingleFxC;
            MultiSwitch = (TrackFxMulti)xmlTrackFx.MultiSwitch;
            SelectedMultiFxA = (TrackMultiFxA)xmlTrackFx.SelectedMultiFxA;
            SelectedMultiFxB = (TrackMultiFxB)xmlTrackFx.SelectedMultiFxB;
            SelectedMultiFxC = (TrackMultiFxC)xmlTrackFx.SelectedMultiFxC;
        }
    }
}
