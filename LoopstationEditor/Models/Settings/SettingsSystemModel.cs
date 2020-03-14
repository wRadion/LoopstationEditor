using System.Xml.Serialization;

namespace LoopstationEditor.Models.Settings
{
    [XmlRoot("sys")]
    public class SettingsSystemModel
    {
        [XmlElement("INPUT_OUTPUT")]
        public SettingsSystemInputOutputModel InputOutput { get; set; }

        public SettingsSystemModel()
        {
            InputOutput = new SettingsSystemInputOutputModel();
        }
    }
}
