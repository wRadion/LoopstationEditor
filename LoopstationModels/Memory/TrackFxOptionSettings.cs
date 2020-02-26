using LoopstationModels.Base;

namespace LoopstationModels.Memory
{
    public class TrackFxOptionSettings : BaseSettings
    {
        public TrackFxOptionSettings() : base("TRACK_FX")
        {
            AddProperty("Mod", def: 1, max: 1);
            AddProperty("MltMod", max: 1);
            AddProperty("Sw", max: 2);
            AddProperty("Sel", max: 2);
            AddProperty("Typ1", def: 2, max: 30);
            AddProperty("Typ2", def: 20, max: 30);
            AddProperty("Typ3", def: 27, max: 30);
            AddProperty("MltSw", max: 7);
            AddProperty("MltTyp1", def: 19, max: 22);
            AddProperty("MltTyp2", def: 2, max: 14);
            AddProperty("MltTyp3", def: 11, max: 17);
        }
    }
}
