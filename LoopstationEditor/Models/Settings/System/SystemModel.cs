using System.Xml.Serialization;

namespace LoopstationEditor.Models.Settings.System
{
    [XmlRoot("sys")]
    public class SystemModel : SettingsContainerModel
    {
        [XmlElement("SETUP")]
        public SettingsSystemSetupModel Setup { get; set; }

        [XmlElement("INPUT_OUTPUT")]
        public SettingsSystemInputOutputModel InputOutput { get; set; }

        [XmlElement("USB")]
        public SettingsSystemUSBModel USB { get; set; }

        [XmlElement("MIDI")]
        public SettingsSystemMIDIModel MIDI { get; set; }

        public SystemModel() : base()
        {
            Setup = new SettingsSystemSetupModel();
            InputOutput = new SettingsSystemInputOutputModel();
            USB = new SettingsSystemUSBModel();
            MIDI = new SettingsSystemMIDIModel();
        }
    }
}
