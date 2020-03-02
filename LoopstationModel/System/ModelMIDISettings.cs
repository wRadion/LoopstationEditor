using Loopstation.Xml.System;
using Loopstation.Common.Property;

namespace Loopstation.Model.System
{
    public enum MIDISync       { AUTO, INTERNAL }
    public enum MIDISyncSource { USB, MIDI }
    public enum MIDITxChannel  { RX }

    public class ModelMIDISettings
    {
        public int RxChannel // TODO RxChannel (0...15) +1
        {
            get => _rxChannelProperty.Value;
            set => _rxChannelProperty.Value = value;
        }
        public bool Omni
        {
            get => _omniProperty.Value;
            set => _omniProperty.Value = value;
        }
        public object TxChannel // TODO TxChannel (0...15, RX) +1
        {
            get => _txChannelProperty.Value;
            set => _txChannelProperty.Value = value;
        }
        public MIDISync Sync
        {
            get => _syncProperty.Value;
            set => _syncProperty.Value = value;
        }
        public MIDISyncSource SyncSource
        {
            get => _syncSourceProperty.Value;
            set => _syncSourceProperty.Value = value;
        }
        public bool PcOut
        {
            get => _pcOutProperty.Value;
            set => _pcOutProperty.Value = value;
        }

        #region private Fields
        private readonly IntProperty _rxChannelProperty;
        private readonly BoolProperty _omniProperty;
        private readonly MixedProperty<MIDITxChannel> _txChannelProperty;
        private readonly EnumProperty<MIDISync> _syncProperty;
        private readonly EnumProperty<MIDISyncSource> _syncSourceProperty;
        private readonly BoolProperty _pcOutProperty;

        private readonly XmlMIDISettings _xml;
        #endregion private Fields

        public ModelMIDISettings(XmlMIDISettings xmlMIDI)
        {
            #region private Fields initialization
            _xml = xmlMIDI;

            _rxChannelProperty  = _xml.RxChannel;
            _omniProperty       = _xml.Omni;
            _txChannelProperty  = _xml.TxChannel;
            _syncProperty       = _xml.Sync;
            _syncSourceProperty = _xml.SyncSource;
            _pcOutProperty      = _xml.PcOut;

            _rxChannelProperty.PropertyChanged  += (_, e) => _xml.RxChannel = e.Value;
            _omniProperty.PropertyChanged       += (_, e) => _xml.Omni = e.Value;
            _txChannelProperty.PropertyChanged  += (_, e) => _xml.TxChannel = e.Value;
            _syncProperty.PropertyChanged       += (_, e) => _xml.Sync = e.Value;
            _syncSourceProperty.PropertyChanged += (_, e) => _xml.SyncSource = e.Value;
            _pcOutProperty.PropertyChanged      += (_, e) => _xml.PcOut = e.Value;
            #endregion private Fields initialization
        }
    }
}
