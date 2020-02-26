using LoopstationModels.Base;

namespace LoopstationModels.Memory
{
    public class TrackSettings : BaseSettings
    {
        public int TrackNumber;

        public TrackSettings(int num)
        {
            TrackNumber = num;

            AddProperty("Rev", max: 1);
            AddProperty("PlyLvl", def: 50);
            AddProperty("Pan", def: 50);
            AddProperty("One", max: 1);
            AddProperty("TrkFx", def: 1, max: 1);
            AddProperty("PlyMod", max: 1);
            AddProperty("StrtMod", max: 1);
            AddProperty("StpMod", max: 2);
            AddProperty("MeasMod", max: 2);
            AddProperty("MeasLen", max: 1000);
            AddProperty("MeasBtLp", max: 5);
            AddProperty("LpSync", def: 1, max: 1);
            AddProperty("TmpSync", def: 1, max: 1);
            AddProperty("RecTmp", def: 1200, min: 400, max: 2500);
            AddProperty("WavStat", max: 1);
            AddProperty("WavLen", max: 1_000_000_000);
        }
    }
}
