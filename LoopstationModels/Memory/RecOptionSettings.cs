using LoopstationModels.Base;

namespace LoopstationModels.Memory
{
    public class RecOptionSettings : BaseSettings
    {
        public RecOptionSettings() : base("REC_OPTION")
        {
            AddProperty("DubMod", max: 1);
            AddProperty("RecAct", max: 1);
            AddProperty("RecQtz", def: 1);
        }
    }
}
