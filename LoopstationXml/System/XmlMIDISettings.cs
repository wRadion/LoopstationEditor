using System.Xml.Serialization;

using Loopstation.Common;

namespace Loopstation.Xml.System
{
    [XmlRoot("MIDI")]
    public class XmlMIDISettings : ICloneable<XmlMIDISettings>
    {
        private int _rxChannel;
        private int _omni;
        private int _txChannel;
        private int _sync;
        private int _syncSource;
        private int _pcOut;

        /// <summary>
        /// Integer from <c>0</c> to <c>15</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("RxCh")]
        public int RxChannel
        {
            get => _rxChannel;
            set => _rxChannel = Range.Guard(value, max: 15);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>1</c>.</para>
        /// </summary>
        [XmlElement("Omni")]
        public int Omni
        {
            get => _omni;
            set => _omni = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>16</c>.
        /// <para>Default value is <c>16</c>.</para>
        /// </summary>
        [XmlElement("TxCh")]
        public int TxChannel
        {
            get => _txChannel;
            set => _txChannel = Range.Guard(value, max: 16);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("Sync")]
        public int Sync
        {
            get => _sync;
            set => _sync = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>0</c>.</para>
        /// </summary>
        [XmlElement("InSel")]
        public int SyncSource
        {
            get => _syncSource;
            set => _syncSource = Range.Guard(value, max: 1);
        }

        /// <summary>
        /// Integer from <c>0</c> to <c>1</c>.
        /// <para>Default value is <c>1</c>.</para>
        /// </summary>
        [XmlElement("PcOut")]
        public int PcOut
        {
            get => _pcOut;
            set => _pcOut = Range.Guard(value, max: 1);
        }

        public XmlMIDISettings() : this(null) { }
        public XmlMIDISettings(XmlMIDISettings other)
        {
            RxChannel  = other?.RxChannel  ?? 0;
            Omni       = other?.Omni       ?? 1;
            TxChannel  = other?.TxChannel  ?? 16;
            Sync       = other?.Sync       ?? 0;
            SyncSource = other?.SyncSource ?? 0;
            PcOut      = other?.PcOut      ?? 1;
        }

        public XmlMIDISettings Clone() => new XmlMIDISettings(this);
    }
}
