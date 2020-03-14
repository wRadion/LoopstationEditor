using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings
{
    public enum IOInputSource { MONO = 0, STEREO = 1 }
    public enum IOOutputLevelSelection { LINE_PLUS_PHONES = 0, PHONES = 1 }

    public static class InputOutputProperty
    {
        public const string InputNSThreshold = "InNsThrs";
        public const string LineOutLevel = "LineOutLvl";
        public const string InputSource = "InSrc";
        public const string InputLineOut = "InLineOut";
        public const string OutputLevelSelection = "OutLvlSel";
    }

    public class SettingsSystemInputOutputModel : SettingsModel
    {
        [XmlElement(InputOutputProperty.InputNSThreshold, typeof(int))]
        [Property(40, 0, 100)]
        public ValueInt InputNSThreshold { get; set; }

        [XmlElement(InputOutputProperty.LineOutLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt LineOutLevel { get; set; }

        [XmlElement(InputOutputProperty.InputSource, typeof(int))]
        [Property(IOInputSource.STEREO, 0, 1)]
        public ValueEnum<IOInputSource> InputSource { get; set; }

        [XmlElement(InputOutputProperty.InputLineOut, typeof(int))]
        [Property(true, 0, 1)]
        public ValueBool InputLineOut { get; set; }

        [XmlElement(InputOutputProperty.OutputLevelSelection, typeof(int))]
        [Property(IOOutputLevelSelection.LINE_PLUS_PHONES, 0, 1)]
        public ValueEnum<IOOutputLevelSelection> OutputLevelSelection { get; set; }

        public SettingsSystemInputOutputModel() : base() { }
    }
}
