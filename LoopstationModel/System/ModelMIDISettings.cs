using Loopstation.Xml.System;

namespace Loopstation.Model.System
{
    public enum MIDISync { AUTO, INTERNAL }
    public enum MIDISyncSource { USB, MIDI }

    public class ModelMIDISettings
    {
        // TODO RxChannel (0...15) +1
        private int _rxCh;
        public int RxChannel { get; set; }

        public bool IsOmni { get; set; }

        // TODO TxChannel [MIX] (0...15, RX) +1
        private int _txCh;
        public int TxChannel { get; set; }

        public MIDISync Sync { get; set; }
        public MIDISyncSource SyncSource { get; set; }
        public bool IsPcOut { get; set; }

        public ModelMIDISettings(XmlMIDISettings xmlMIDI)
        {
            RxChannel = xmlMIDI.RxChannel;
            IsOmni = xmlMIDI.Omni == 1;
            TxChannel = xmlMIDI.TxChannel;
            Sync = (MIDISync)xmlMIDI.Sync;
            SyncSource = (MIDISyncSource)xmlMIDI.SyncSource;
            IsPcOut = xmlMIDI.PcOut == 1;
        }
    }
}
