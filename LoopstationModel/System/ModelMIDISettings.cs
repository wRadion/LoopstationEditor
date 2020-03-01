using Loopstation.Xml.System;

namespace Loopstation.Model.System
{
    public enum MIDIOmni { OFF, ON }
    public enum MIDISync { AUTO, INTERNAL }
    public enum MIDISyncSource { USB, MIDI }
    public enum MIDIPCOut { OFF, ON }

    public class ModelMIDISettings
    {
        // TODO RxChannel (0...15) +1
        private int _rxCh;
        public int RxChannel { get; set; }

        public MIDIOmni Omni { get; set; }

        // TODO TxChannel [MIX] (0...15, RX) +1
        private int _txCh;
        public int TxChannel { get; set; }

        public MIDISync Sync { get; set; }
        public MIDISyncSource SyncSource { get; set; }
        public MIDIPCOut PcOut { get; set; }

        public ModelMIDISettings(XmlMIDISettings xmlMIDI)
        {
            RxChannel = xmlMIDI.RxChannel;
            Omni = (MIDIOmni)xmlMIDI.Omni;
            TxChannel = xmlMIDI.TxChannel;
            Sync = (MIDISync)xmlMIDI.Sync;
            SyncSource = (MIDISyncSource)xmlMIDI.SyncSource;
            PcOut = (MIDIPCOut)xmlMIDI.PcOut;
        }
    }
}
