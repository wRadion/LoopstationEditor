using System.Xml.Serialization;

namespace LoopstationEditor.Models.Settings.System
{
    [XmlRoot("sys")]
    public class SettingsSystemModel
    {
        [XmlElement("SETUP")]
        public SettingsSystemSetupModel Setup { get; set; }

        [XmlElement("INPUT_OUTPUT")]
        public SettingsSystemInputOutputModel InputOutput { get; set; }

        [XmlElement("USB")]
        public SettingsSystemUSBModel USB { get; set; }

        [XmlElement("MIDI")]
        public SettingsSystemMIDIModel MIDI { get; set; }

        public SettingsSystemModel()
        {
            Setup = new SettingsSystemSetupModel();
            InputOutput = new SettingsSystemInputOutputModel();
            USB = new SettingsSystemUSBModel();
            MIDI = new SettingsSystemMIDIModel();
        }
    }
}
