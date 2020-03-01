using System.Xml.Serialization;

using Loopstation.Xml.Base;
using Loopstation.Xml.Interfaces;
using Loopstation.Xml.System;

namespace Loopstation.Xml
{
    [XmlRoot("sys")]
    public class XmlSystemSettings : XmlMemorySettingsBase, ICloneable<XmlSystemSettings>
    {
        [XmlElement("SETUP")]
        public XmlSetupSettings Setup;

        [XmlElement("INPUT_OUTPUT")]
        public XmlInputOutputSettings InputOutput;

        [XmlElement("USB")]
        public XmlUSBSettings USB;

        [XmlElement("MIDI")]
        public XmlMIDISettings MIDI;

        public XmlSystemSettings() : this(null) { }
        public XmlSystemSettings(XmlSystemSettings other) : base(other)
        {
            Setup = new XmlSetupSettings(other?.Setup);
            InputOutput = new XmlInputOutputSettings(other?.InputOutput);
            USB = new XmlUSBSettings(other?.USB);
            MIDI = new XmlMIDISettings(other?.MIDI);
        }

        public XmlSystemSettings Clone() => new XmlSystemSettings(this);
    }
}
