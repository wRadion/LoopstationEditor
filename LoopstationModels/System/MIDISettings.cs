using LoopstationModels.Base;

namespace LoopstationModels.System
{
    public class MIDISettings : BaseSettings
    {
        public MIDISettings() : base("MIDI")
        {
            AddProperty("RxCh", max: 15);
            AddProperty("Omni", def: 1, max: 1);
            AddProperty("TxCh", def: 16, max: 16);
            AddProperty("Sync", max: 1);
            AddProperty("InSel", max: 1);
            AddProperty("PcOut", def: 1, max: 1);
        }
    }
}
