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
        public int MemoryNumber { get; set; }

        public int LCDContrast { get; set; }
        public bool HasPhantomPower { get; set; }
        public SetupDisplayMode DisplayMode { get; set; }
        public SetupIndicatorMode IndicatorMode { get; set; }
        public bool IsAutoOff { get; set; }
        public bool HasAllClear { get; set; }
        public bool HasQuickClear { get; set; }
        public SetupKnobMode KnobMode { get; set; }

        public ModelSetupSettings(XmlSetupSettings xmlSetup)
        {
            MemoryNumber = xmlSetup.MemoryNumber;
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
