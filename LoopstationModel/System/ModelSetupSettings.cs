using Loopstation.Xml.System;
using Loopstation.Common.Property;

namespace Loopstation.Model.System
{
    public enum SetupDisplayMode   { MEMORY_NUMBER, LEVEL, REVERSE, ONESHOT, MULTI, REMAIN, FX }
    public enum SetupIndicatorMode { STATUS, POS, STATUS_PLUS_POS, LEVEL }
    public enum SetupKnobMode      { IMMEDIATE, HOOK }

    public class ModelSetupSettings
    {
        public int SelectedMemory // TODO MemoryNumber (0...98) +1
        {
            get => _selectedMemoryProperty.Value;
            set => _selectedMemoryProperty.Value = value;
        }
        public int LCDContrast
        {
            get => _lcdContrastProperty.Value;
            set => _lcdContrastProperty.Value = value;
        }
        public bool PhantomPower
        {
            get => _phantomPowerProperty.Value;
            set => _phantomPowerProperty.Value = value;
        }
        public SetupDisplayMode DisplayMode
        {
            get => _displayModeProperty.Value;
            set => _displayModeProperty.Value = value;
        }
        public SetupIndicatorMode IndicatorMode
        {
            get => _indicatorModeProperty.Value;
            set => _indicatorModeProperty.Value = value;
        }
        public bool AutoOff
        {
            get => _autoOffProperty.Value;
            set => _autoOffProperty.Value = value;
        }
        public bool AllClear
        {
            get => _allClearProperty.Value;
            set => _allClearProperty.Value = value;
        }
        public bool QuickClear
        {
            get => _quickClearProperty.Value;
            set => _quickClearProperty.Value = value;
        }
        public SetupKnobMode KnobMode
        {
            get => _knobModeProperty.Value;
            set => _knobModeProperty.Value = value;
        }

        #region private Fields
        private readonly IntProperty _selectedMemoryProperty;
        private readonly IntProperty _lcdContrastProperty;
        private readonly BoolProperty _phantomPowerProperty;
        private readonly EnumProperty<SetupDisplayMode> _displayModeProperty;
        private readonly EnumProperty<SetupIndicatorMode> _indicatorModeProperty;
        private readonly BoolProperty _autoOffProperty;
        private readonly BoolProperty _allClearProperty;
        private readonly BoolProperty _quickClearProperty;
        private readonly EnumProperty<SetupKnobMode> _knobModeProperty;

        private readonly XmlSetupSettings _xml;
        #endregion private Fields

        public ModelSetupSettings(XmlSetupSettings xmlSetup)
        {
            #region private Fields initialization
            _xml = xmlSetup;

            _selectedMemoryProperty = _xml.MemoryNumber;
            _lcdContrastProperty    = _xml.LCDContrast;
            _phantomPowerProperty   = _xml.PhantomPower;
            _displayModeProperty    = _xml.DisplayMode;
            _indicatorModeProperty  = _xml.IndicatorMode;
            _autoOffProperty        = _xml.AutoOff;
            _allClearProperty       = _xml.AllClear;
            _quickClearProperty     = _xml.QuickClear;
            _knobModeProperty       = _xml.KnobMode;

            _selectedMemoryProperty.PropertyChanged += (_, e) => _xml.MemoryNumber = e.Value;
            _lcdContrastProperty.PropertyChanged    += (_, e) => _xml.LCDContrast = e.Value;
            _phantomPowerProperty.PropertyChanged   += (_, e) => _xml.PhantomPower = e.Value;
            _displayModeProperty.PropertyChanged    += (_, e) => _xml.DisplayMode = e.Value;
            _indicatorModeProperty.PropertyChanged  += (_, e) => _xml.IndicatorMode = e.Value;
            _autoOffProperty.PropertyChanged        += (_, e) => _xml.AutoOff = e.Value;
            _allClearProperty.PropertyChanged       += (_, e) => _xml.AllClear = e.Value;
            _quickClearProperty.PropertyChanged     += (_, e) => _xml.QuickClear = e.Value;
            _knobModeProperty.PropertyChanged       += (_, e) => _xml.KnobMode = e.Value;
            #endregion private Fields initialization
        }
    }
}
