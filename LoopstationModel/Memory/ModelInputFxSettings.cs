using Loopstation.Xml.Memory;
using Loopstation.Common.Property;
using Loopstation.Model.Memory.Base;

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
        public InputFxMode Mode
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
        public InputSingleFx SelectedSingleFxA
        {
            get => _selectedSingleFxAProperty.Value;
            set => _selectedSingleFxAProperty.Value = value;
        }
        public InputSingleFx SelectedSingleFxB
        {
            get => _selectedSingleFxBProperty.Value;
            set => _selectedSingleFxBProperty.Value = value;
        }
        public InputSingleFx SelectedSingleFxC
        {
            get => _selectedSingleFxCProperty.Value;
            set => _selectedSingleFxCProperty.Value = value;
        }
        public InputFxMulti MultiEnabledSlots // TODO: Bitwise InputFx>MultiSwitch
        {
            get => _multiEnabledSlotsProperty.Value;
            set => _multiEnabledSlotsProperty.Value = value;
        }
        public InputMultiFxA SelectedMultiFxA
        {
            get => _selectedMultiFxAProperty.Value;
            set => _selectedMultiFxAProperty.Value = value;
        }
        public InputMultiFxB SelectedMultiFxB
        {
            get => _selectedMultiFxBProperty.Value;
            set => _selectedMultiFxBProperty.Value = value;
        }
        public InputMultiFxC SelectedMultiFxC
        {
            get => _selectedMultiFxCProperty.Value;
            set => _selectedMultiFxCProperty.Value = value;
        }

        #region private Fields
        private readonly EnumProperty<InputFxMode> _modeProperty;
        private readonly EnumProperty<FxSlotWithNone> _singleEnabledSlotProperty;
        private readonly EnumProperty<FxSlot> _selectedSlotProperty;
        private readonly EnumProperty<InputSingleFx> _selectedSingleFxAProperty;
        private readonly EnumProperty<InputSingleFx> _selectedSingleFxBProperty;
        private readonly EnumProperty<InputSingleFx> _selectedSingleFxCProperty;
        private readonly EnumProperty<InputFxMulti> _multiEnabledSlotsProperty;
        private readonly EnumProperty<InputMultiFxA> _selectedMultiFxAProperty;
        private readonly EnumProperty<InputMultiFxB> _selectedMultiFxBProperty;
        private readonly EnumProperty<InputMultiFxC> _selectedMultiFxCProperty;

        private XmlInputFxSettings _xml;
        #endregion private Fields

        public ModelInputFxSettings(XmlInputFxSettings xmlInputFx)
        {
            #region private Fields initialization
            _xml = xmlInputFx;

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
