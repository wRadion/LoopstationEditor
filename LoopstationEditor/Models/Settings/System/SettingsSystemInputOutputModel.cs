using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.System
{
    public enum IOInputSource { MONO = 0, STEREO = 1 }
    public enum IOOutputLevelSelection { LINE_PLUS_PHONES = 0, PHONES = 1 }

    public class SettingsSystemInputOutputModel : SettingsModel
    {
        [XmlElement("InNsThrs", typeof(int))]
        [Property(40, 0, 100)]
        public ValueInt InputNSThreshold { get; set; }

        [XmlElement("LineOutLvl", typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt LineOutLevel { get; set; }

        [XmlElement("InSrc", typeof(int))]
        [Property(IOInputSource.STEREO, 0, 1)]
        public ValueEnum<IOInputSource> InputSource { get; set; }

        [XmlElement("InLineOut", typeof(int))]
        [Property(true, 0, 1)]
        public ValueBool InputLineOut { get; set; }

        [XmlElement("OutLvlSel", typeof(int))]
        [Property(IOOutputLevelSelection.LINE_PLUS_PHONES, 0, 1)]
        public ValueEnum<IOOutputLevelSelection> OutputLevelSelection { get; set; }

        public SettingsSystemInputOutputModel() : base() { }
    }
}
