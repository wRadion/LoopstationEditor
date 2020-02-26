using LoopstationModels.Base;

namespace LoopstationModels.Memory
{
    public class PlayOptionSettings : BaseSettings
    {
        public PlayOptionSettings()
        {
            AddProperty("SinglePlyChg", max: 1);
            AddProperty("LpQtz", max: 2);
            AddProperty("LpMod", max: 1);
            AddProperty("LpLen", max: 1000);
            AddProperty("AllStrt", def: 31, max: 31);
            AddProperty("AllStp", def: 31, max: 31);
            AddProperty("FadeTim", def: 2, min: 1, max: 64);
            AddProperty("TgtTr", max: 4);
        }
    }
}
