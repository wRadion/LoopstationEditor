using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public enum FxOctaveMode { MINUS_1OCT = 0, MINUS_2OCT = 1, BOTH = 2}

    public class FxOctaveModel : SettingsModel
    {
        [XmlElement(FxProperty.OctaveMod, typeof(int))]
        [Property(FxOctaveMode.MINUS_1OCT, 0, 2)]
        public ValueEnum<FxOctaveMode> OctaveMod { get; set; }

        [XmlElement(FxProperty.OctaveLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt OctaveLevel { get; set; }

        public FxOctaveModel() : base() { }
    }
}
