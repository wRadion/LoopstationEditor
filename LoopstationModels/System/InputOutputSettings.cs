using LoopstationModels.Base;

namespace LoopstationModels.System
{
    public class InputOutputSettings : BaseSettings
    {
        public InputOutputSettings() : base()
        {
            AddProperty("InNsThrs", def: 40);
            AddProperty("LineOutLvl", def: 50);
            AddProperty("InSrc", def: 1, max: 1);
            AddProperty("InLineOut", def: 1, max: 1);
            AddProperty("OutLvlSel", max: 1);
        }
    }
}
