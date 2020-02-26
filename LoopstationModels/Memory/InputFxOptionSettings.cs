using LoopstationModels.Base;

namespace LoopstationModels.Memory
{
    public class InputFxOptionSettings : BaseSettings
    {
        public InputFxOptionSettings() : base("INPUT_FX")
        {
            AddProperty("Mod", def: 1, max: 1);
            AddProperty("MltMod", max: 1);
            AddProperty("Sw", max: 2);
            AddProperty("Sel", max: 2);
            AddProperty("Typ1", max: 26);
            AddProperty("Typ2", def: 4, max: 26);
            AddProperty("Typ3", def: 17, max: 26);
            AddProperty("MltSw", max: 7);
            AddProperty("MltTyp1", max: 18);
            AddProperty("MltTyp2", def: 3, max: 14);
            AddProperty("MltTyp3", def: 8, max: 17);
        }
    }
}
