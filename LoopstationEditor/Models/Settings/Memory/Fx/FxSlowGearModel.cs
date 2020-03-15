using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxSlowGearModel : SettingsModel
    {
        [XmlElement(FxProperty.SlowGearSensitivity, typeof(int))]
        [Property(40, 0, 100)]
        public ValueInt SlowGearSensitivity { get; set; }

        [XmlElement(FxProperty.SlowGearRiseTime, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt SlowGearRiseTime { get; set; }

        [XmlElement(FxProperty.SlowGearLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt SlowGearLevel { get; set; }

        public FxSlowGearModel() : base() { }
    }
}
