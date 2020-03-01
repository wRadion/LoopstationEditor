﻿using Loopstation.Xml.System;

namespace Loopstation.Model.System
{
    public enum MIDISync { AUTO, INTERNAL }
    public enum MIDISyncSource { USB, MIDI }

    public class ModelMIDISettings
    {
        // TODO RxChannel (0...15) +1
        private int _rxCh;
        public int RxChannel { get; set; } = 0;

        public bool IsOmni { get; set; } = true;

        // TODO TxChannel [MIX] (0...15, RX) +1
        private int _txCh;
        public int TxChannel { get; set; } = 16;

        public MIDISync Sync { get; set; } = MIDISync.AUTO;
        public MIDISyncSource SyncSource { get; set; } = MIDISyncSource.USB;
        public bool IsPcOut { get; set; } = true;

        public ModelMIDISettings() : this(null) { }
        public ModelMIDISettings(XmlMIDISettings xmlMIDI)
        {
            if (xmlMIDI == null) return;

            RxChannel = xmlMIDI.RxChannel;
            IsOmni = xmlMIDI.Omni == 1;
            TxChannel = xmlMIDI.TxChannel;
            Sync = (MIDISync)xmlMIDI.Sync;
            SyncSource = (MIDISyncSource)xmlMIDI.SyncSource;
            IsPcOut = xmlMIDI.PcOut == 1;
        }
    }
}
