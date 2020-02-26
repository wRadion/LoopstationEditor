using LoopstationModels.Base;

namespace LoopstationModels.Memory
{
    public class RythmSettings : BaseSettings
    {
        public RythmSettings() : base("RYTHM")
        {
            AddProperty("Sw", max: 1);
            AddProperty("Lvl", def: 50);
            AddProperty("Ptn", max: 57);
            AddProperty("Bt", def: 2, max: 16);
            AddProperty("LineOut", def: 1, max: 1);
            AddProperty("RecCnt", max: 1);
            AddProperty("PlyCnt", max: 1);
            AddProperty("Stp", def: 1, max: 2);
        }
    }
}
