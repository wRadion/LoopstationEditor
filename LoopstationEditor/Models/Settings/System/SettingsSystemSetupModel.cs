using LoopstationEditor.Models.PropertyEngine;
using System.Xml.Serialization;

namespace LoopstationEditor.Models.Settings.System
{
    public enum SetupDisplayMode { MEMORY_NUMBER = 0, LEVEL = 1, REVERSE = 2, ONESHOT = 3, MULTI = 4, REMAIN = 5, FX = 6 }
    public enum SetupIndicatorMode { STATUS = 0, POS = 1, STATUS_PLUS_POS = 2, LEVEL = 3 }
    public enum SetupKnobMode { IMMEDIATE = 0, HOOK = 1 }

    public static class SetupProperty
    {
        public const string SelectedMemory = "MemNum";
        public const string LcdContrast = "LcdContrast";
        public const string PhantomPower = "PhantomPwr";
        public const string DisplayMode = "DispMod";
        public const string IndicatorMode = "IndMod";
        public const string AutoOff = "AutoOff";
        public const string AllClear = "AllClr";
        public const string QuickClear = "QuickClr";
        public const string KnobMode = "KnobMod";
    }

    public class SettingsSystemSetupModel : SettingsModel
    {
        [XmlElement(SetupProperty.SelectedMemory, typeof(int))]
        [Property(0, 0, 98)]
        public ValueInt SelectedMemory { get; set; }

        [XmlElement(SetupProperty.LcdContrast, typeof(int))]
        [Property(7, 0, 15)]
        public ValueInt LcdContrast { get; set; }

        [XmlElement(SetupProperty.PhantomPower, typeof(int))]
        [Property(false, 0, 1)]
        public ValueBool PhantomPower { get; set; }

        [XmlElement(SetupProperty.DisplayMode, typeof(int))]
        [Property(SetupDisplayMode.MEMORY_NUMBER, 0, 6)]
        public ValueEnum<SetupDisplayMode> DisplayMode { get; set; }

        [XmlElement(SetupProperty.IndicatorMode, typeof(int))]
        [Property(SetupIndicatorMode.STATUS, 0, 3)]
        public ValueEnum<SetupIndicatorMode> IndicatorMode { get; set; }

        [XmlElement(SetupProperty.AutoOff, typeof(int))]
        [Property(true, 0, 1)]
        public ValueBool AutoOff { get; set; }

        [XmlElement(SetupProperty.AllClear, typeof(int))]
        [Property(false, 0, 1)]
        public ValueBool AllClear { get; set; }

        [XmlElement(SetupProperty.QuickClear, typeof(int))]
        [Property(false, 0, 1)]
        public ValueBool QuickClear { get; set; }

        [XmlElement(SetupProperty.KnobMode, typeof(int))]
        [Property(SetupKnobMode.IMMEDIATE, 0, 1)]
        public ValueEnum<SetupKnobMode> KnobMode { get; set; }

        public SettingsSystemSetupModel() : base() { }
    }
}
