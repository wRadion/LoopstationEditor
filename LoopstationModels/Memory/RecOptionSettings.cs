using LoopstationModels.Base;

namespace LoopstationModels.Memory
{
    public class RecOptionSettings : BaseSettings
    {
        public RecOptionSettings()
        {
            AddProperty("DubMod", max: 1);
            AddProperty("RecAct", max: 1);
            AddProperty("RecQtz", def: 1);
        }
    }
}
