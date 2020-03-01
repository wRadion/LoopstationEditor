using Loopstation.Xml.System;

namespace Loopstation.Model.System
{
    public enum SetupDisplayMode { MEMORY_NUMBER, LEVEL, REVERSE, ONESHOT, MULTI, REMAIN, FX }
    public enum SetupIndicatorMode { STATUS, POS, STATUS_PLUS_POS, LEVEL }
    public enum SetupKnobMode { IMMEDIATE, HOOK }

    public class ModelSetupSettings
    {
        // TODO MemoryNumber (0...98) +1
        private int _memNum;
        public int SelectedMemory { get; set; } = 0;

        public int LCDContrast { get; set; } = 7;
        public bool HasPhantomPower { get; set; } = false;
        public SetupDisplayMode DisplayMode { get; set; } = SetupDisplayMode.MEMORY_NUMBER;
        public SetupIndicatorMode IndicatorMode { get; set; } = SetupIndicatorMode.STATUS;
        public bool IsAutoOff { get; set; } = true;
        public bool HasAllClear { get; set; } = false;
        public bool HasQuickClear { get; set; } = false;
        public SetupKnobMode KnobMode { get; set; } = SetupKnobMode.IMMEDIATE;

        public ModelSetupSettings() : this(null) { }
        public ModelSetupSettings(XmlSetupSettings xmlSetup)
        {
            if (xmlSetup == null) return;

            SelectedMemory = xmlSetup.MemoryNumber;
            LCDContrast = xmlSetup.LCDContrast;
            HasPhantomPower = xmlSetup.PhantomPower == 1;
            DisplayMode = (SetupDisplayMode)xmlSetup.DisplayMode;
            IndicatorMode = (SetupIndicatorMode)xmlSetup.IndicatorMode;
            IsAutoOff = xmlSetup.AutoOff == 1;
            HasAllClear = xmlSetup.AllClear == 1;
            HasQuickClear = xmlSetup.QuickClear == 1;
            KnobMode = (SetupKnobMode)xmlSetup.KnobMode;
        }
    }
}
