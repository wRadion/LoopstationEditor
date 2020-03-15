using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxRingModulatorModel : SettingsModel
    {
        [XmlElement(FxProperty.RingModulatorFrequency, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt RingModulatorFrequency { get; set; }

        [XmlElement(FxProperty.RingModulatorBalance, typeof(int))]
        [Property(100, 0, 100)]
        public ValueInt RingModulatorBalance { get; set; }

        public FxRingModulatorModel() : base() { }
    }
}
