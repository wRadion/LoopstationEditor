using Loopstation.Xml.System;

using Loopstation.Model.System;

namespace Loopstation.Model
{
    public class ModelSystemSettings
    {
        public       ModelSetupSettings Setup;
        public ModelInputOutputSettings InputOutput;
        public         ModelUSBSettings USB;
        public        ModelMIDISettings MIDI;

        public ModelSystemSettings() : this(new XmlSystemSettings()) { }
        public ModelSystemSettings(XmlSystemSettings xmlSystem)
        {
            Setup       = new ModelSetupSettings(xmlSystem.Setup);
            InputOutput = new ModelInputOutputSettings(xmlSystem.InputOutput);
            USB         = new ModelUSBSettings(xmlSystem.USB);
            MIDI        = new ModelMIDISettings(xmlSystem.MIDI);
        }
    }
}
