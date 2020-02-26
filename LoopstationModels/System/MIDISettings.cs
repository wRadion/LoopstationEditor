using LoopstationModels.Base;

namespace LoopstationModels.System
{
    public class MIDISettings : BaseSettings
    {
        public MIDISettings()
        {
            AddProperty("RxCh", max: 15);
            AddProperty("Omni", @default: 1, max: 1);
            AddProperty("TxCh", @default: 16, max: 16);
            AddProperty("Sync", max: 1);
            AddProperty("InSel", max: 1);
            AddProperty("PcOut", @default: 1, max: 1);
        }
    }
}
