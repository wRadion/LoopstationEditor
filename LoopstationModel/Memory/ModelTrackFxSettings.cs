using Loopstation.Xml.Memory;
using Loopstation.Common.Property;
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
        public TrackFxMode Mode
        {
            get => _modeProperty.Value;
            set => _modeProperty.Value = value;
        }
        public FxSlotWithNone SingleEnabledSlot
        {
            get => _singleEnabledSlotProperty.Value;
            set => _singleEnabledSlotProperty.Value = value;
        }
        public FxSlot SelectedSlot
        {
            get => _selectedSlotProperty.Value;
            set => _selectedSlotProperty.Value = value;
        }
        public TrackSingleFx SelectedSingleFxA
        {
            get => _selectedSingleFxAProperty.Value;
            set => _selectedSingleFxAProperty.Value = value;
        }
        public TrackSingleFx SelectedSingleFxB
        {
            get => _selectedSingleFxBProperty.Value;
            set => _selectedSingleFxBProperty.Value = value;
        }
        public TrackSingleFx SelectedSingleFxC
        {
            get => _selectedSingleFxCProperty.Value;
            set => _selectedSingleFxCProperty.Value = value;
        }
        public TrackFxMulti MultiEnabledSlots // TODO: Bitwise TrackFx>MultiSwitch
        {
            get => _multiEnabledSlotsProperty.Value;
            set => _multiEnabledSlotsProperty.Value = value;
        }
        public TrackMultiFxA SelectedMultiFxA
        {
            get => _selectedMultiFxAProperty.Value;
            set => _selectedMultiFxAProperty.Value = value;
        }
        public TrackMultiFxB SelectedMultiFxB
        {
            get => _selectedMultiFxBProperty.Value;
            set => _selectedMultiFxBProperty.Value = value;
        }
        public TrackMultiFxC SelectedMultiFxC
        {
            get => _selectedMultiFxCProperty.Value;
            set => _selectedMultiFxCProperty.Value = value;
        }

        #region private Fields
        private readonly EnumProperty<TrackFxMode> _modeProperty;
        private readonly EnumProperty<FxSlotWithNone> _singleEnabledSlotProperty;
        private readonly EnumProperty<FxSlot> _selectedSlotProperty;
        private readonly EnumProperty<TrackSingleFx> _selectedSingleFxAProperty;
        private readonly EnumProperty<TrackSingleFx> _selectedSingleFxBProperty;
        private readonly EnumProperty<TrackSingleFx> _selectedSingleFxCProperty;
        private readonly EnumProperty<TrackFxMulti> _multiEnabledSlotsProperty;
        private readonly EnumProperty<TrackMultiFxA> _selectedMultiFxAProperty;
        private readonly EnumProperty<TrackMultiFxB> _selectedMultiFxBProperty;
        private readonly EnumProperty<TrackMultiFxC> _selectedMultiFxCProperty;

        private XmlTrackFxSettings _xml;
        #endregion private Fields

        public ModelTrackFxSettings(XmlTrackFxSettings xmlTrackFx)
        {
            #region private Fields initialization
            _xml = xmlTrackFx;

            _modeProperty              = _xml.Mode;
            _singleEnabledSlotProperty = _xml.Switch;
            _selectedSlotProperty      = _xml.Selected;
            _selectedSingleFxAProperty = _xml.SelectedSingleFxA;
            _selectedSingleFxBProperty = _xml.SelectedSingleFxB;
            _selectedSingleFxCProperty = _xml.SelectedSingleFxC;
            _multiEnabledSlotsProperty = _xml.MultiSwitch;
            _selectedMultiFxAProperty  = _xml.SelectedMultiFxA;
            _selectedMultiFxBProperty  = _xml.SelectedMultiFxB;
            _selectedMultiFxCProperty  = _xml.SelectedMultiFxC;

            _modeProperty.PropertyChanged += (_, e) =>
            {
                _xml.Mode = e.Value;
                _xml.MultiMode = e.Value == 1 ? 0 : 1;
            };
            _singleEnabledSlotProperty.PropertyChanged += (_, e) => _xml.Switch = e.Value;
            _selectedSlotProperty.PropertyChanged      += (_, e) => _xml.Selected = e.Value;
            _selectedSingleFxAProperty.PropertyChanged += (_, e) => _xml.SelectedSingleFxA = e.Value;
            _selectedSingleFxBProperty.PropertyChanged += (_, e) => _xml.SelectedSingleFxB = e.Value;
            _selectedSingleFxCProperty.PropertyChanged += (_, e) => _xml.SelectedSingleFxC = e.Value;
            _multiEnabledSlotsProperty.PropertyChanged += (_, e) => _xml.MultiSwitch = e.Value;
            _selectedMultiFxAProperty.PropertyChanged  += (_, e) => _xml.SelectedMultiFxA = e.Value;
            _selectedMultiFxBProperty.PropertyChanged  += (_, e) => _xml.SelectedMultiFxB = e.Value;
            _selectedMultiFxCProperty.PropertyChanged  += (_, e) => _xml.SelectedMultiFxC = e.Value;
            #endregion private Fields initialization
        }
    }
}
