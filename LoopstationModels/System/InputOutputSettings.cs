using LoopstationModels.Base;

namespace LoopstationModels.System
{
    public class InputOutputSettings : BaseSettings
    {
        public InputOutputSettings() : base()
        {
            AddProperty("InNsThrs", @default: 40);
            AddProperty("LineOutLvl", @default: 50);
            AddProperty("InSrc", @default: 1, max: 1);
            AddProperty("InLineOut", @default: 1, max: 1);
            AddProperty("OutLvlSel", max: 1);
        }
    }
}
