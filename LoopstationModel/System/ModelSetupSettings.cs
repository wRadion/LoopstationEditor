using Loopstation.Xml.System;

namespace Loopstation.Model.System
{
    public enum PhantomPower { OFF, ON }
    public enum DisplayMode { MEMORY_NUMBER, LEVEL, REVERSE, ONESHOT, MULTI, REMAIN, FX }
    public enum IndicatorMode { STATUS, POS, STATUS_PLUS_POS, LEVEL }
    public enum AutoOff { OFF, ON }
    public enum AllClear { DISABLED, ENABLED }
    public enum QuickClear { DISABLED, ENABLED }
    public enum KnobMode { IMMEDIATE, HOOK }

    public class ModelSetupSettings
    {
        // TODO MemoryNumber (0...98) +1
        private int _memNum;
        public int MemoryNumber { get; set; }

        public int LCDContrast { get; set; }
        public PhantomPower PhantomPower { get; set; }
        public DisplayMode DisplayMode { get; set; }
        public IndicatorMode IndicatorMode { get; set; }
        public AutoOff AutoOff { get; set; }
        public AllClear AllClear { get; set; }
        public QuickClear QuickClear { get; set; }
        public KnobMode KnobMode { get; set; }

        public ModelSetupSettings(XmlSetupSettings xmlSetup)
        {
            MemoryNumber = xmlSetup.MemoryNumber;
            LCDContrast = xmlSetup.LCDContrast;
            PhantomPower = (PhantomPower)xmlSetup.PhantomPower;
            DisplayMode = (DisplayMode)xmlSetup.DisplayMode;
            IndicatorMode = (IndicatorMode)xmlSetup.IndicatorMode;
            AutoOff = (AutoOff)xmlSetup.AutoOff;
            AllClear = (AllClear)xmlSetup.AllClear;
            QuickClear = (QuickClear)xmlSetup.QuickClear;
            KnobMode = (KnobMode)xmlSetup.KnobMode;
        }
    }
}
