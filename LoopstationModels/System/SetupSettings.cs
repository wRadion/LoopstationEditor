using LoopstationModels.Base;

namespace LoopstationModels.System
{
    public class SetupSettings : BaseSettings
    {
        public SetupSettings() : base("SETUP")
        {
            AddProperty("MemNum", max: 98);
            AddProperty("LcdContrast", def: 7, max: 15);
            AddProperty("PhantomPwr", max: 1);
            AddProperty("DispMod", max: 6);
            AddProperty("IndMod", max: 3);
            AddProperty("AutoOff", def: 1, max: 1);
            AddProperty("AllClr", max: 1);
            AddProperty("QuickClr", max: 1);
            AddProperty("KnobMod", max: 1);
        }
    }
}
