using LoopstationModels.Base;

namespace LoopstationModels.Memory
{
    public class MasterSettings : BaseSettings
    {
        public MasterSettings()
        {
            AddProperty("Lvl", def: 50);
            AddProperty("Tmp", def: 1200, min: 400, max: 2500);
            AddProperty("Cs", max: 40);
            AddProperty("Rv");
            AddProperty("PhOut", max: 1);
            AddProperty("PhOutTr", def: 31, max: 31);
        }
    }
}
