using LoopstationModels.Base;

namespace LoopstationModels.System
{
    public class USBSettings : BaseSettings
    {
        public USBSettings()
        {
            AddProperty("Mod", max: 1);
            AddProperty("AuRouting", max: 2);
            AddProperty("InLvl", @default: 50);
            AddProperty("OutLvl", @default: 50);
        }
    }
}
