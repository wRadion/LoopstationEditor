using LoopstationModels.Base;

namespace LoopstationModels.Memory
{
    public class BeatFxSettings : BaseSettings
    {
        public FxPosition FxPosition;

        public BeatFxSettings(FxPosition pos)
        {
            FxPosition = pos;

            AddProperty("RepTyp", max: 2);
            AddProperty("RepLen", def: 5, max: 6);
            AddProperty("ShftTyp", max: 1);
            AddProperty("ShftShft", def: 3, max: 5);
            AddProperty("ScatTyp", max: 3);
            AddProperty("ScatLen", def: 3, max: 4);
            AddProperty("Flick", def: 50);
        }
    }
}
