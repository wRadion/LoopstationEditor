using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.System
{
    public enum USBMode { STORAGE = 0, AUDIO_MIDI = 1 }
    public enum USBAudioRouting { LOOP_IN = 0, SUBMIX = 1, LINEOUT = 2 }

    public static class USBProperty
    {
        public const string Mode = "Mod";
        public const string AudioRouting = "AuRouting";
        public const string InputLevel = "InLvl";
        public const string OutputLevel = "OutLvL";
    }

    public class SettingsSystemUSBModel : SettingsModel
    {
        [XmlElement(USBProperty.Mode, typeof(int))]
        [Property(USBMode.STORAGE, 0, 1)]
        public ValueEnum<USBMode> Mode { get; set; }

        [XmlElement(USBProperty.AudioRouting, typeof(int))]
        [Property(USBAudioRouting.LOOP_IN, 0, 2)]
        public ValueEnum<USBAudioRouting> AudioRouting { get; set; }

        [XmlElement(USBProperty.InputLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt InputLevel { get; set; }

        [XmlElement(USBProperty.OutputLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt OutputLevel { get; set; }

        public SettingsSystemUSBModel() : base() { }
    }
}
