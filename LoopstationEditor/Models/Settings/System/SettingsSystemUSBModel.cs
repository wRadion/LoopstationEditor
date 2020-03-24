using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.System
{
    public enum USBMode { STORAGE = 0, AUDIO_MIDI = 1 }
    public enum USBAudioRouting { LOOP_IN = 0, SUB_MIX = 1, LINEOUT = 2 }

    public class SettingsSystemUSBModel : SettingsModel
    {
        [XmlElement("Mod", typeof(int))]
        [Property(USBMode.STORAGE, 0, 1)]
        public ValueEnum<USBMode> Mode { get; set; }

        [XmlElement("AuRouting", typeof(int))]
        [Property(USBAudioRouting.LOOP_IN, 0, 2)]
        public ValueEnum<USBAudioRouting> AudioRouting { get; set; }

        [XmlElement("InLvl", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt InputLevel { get; set; }

        [XmlElement("OutLvL", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt OutputLevel { get; set; }

        public SettingsSystemUSBModel() : base() { }
    }
}
