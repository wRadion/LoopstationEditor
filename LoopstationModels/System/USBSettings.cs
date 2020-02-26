using LoopstationModels.Base;

namespace LoopstationModels.System
{
    public class USBSettings : BaseSettings
    {
        public USBSettings() : base("USB")
        {
            AddProperty("Mod", max: 1);
            AddProperty("AuRouting", max: 2);
            AddProperty("InLvl", def: 50);
            AddProperty("OutLvl", def: 50);
        }
    }
}
