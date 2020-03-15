using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxReverbModel : SettingsModel
    {
        [XmlElement(FxProperty.ReverbTime, typeof(int))]
        [Property(27, 1, 100)]
        public ValueInt ReverbTime { get; set; }

        [XmlElement(FxProperty.ReverbLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt ReverbLevel { get; set; }

        [XmlElement(FxProperty.ReverbDryLevel, typeof(int))]
        [Property(100, 0, 100)]
        public ValueInt ReverbDryLevel { get; set; }

        public FxReverbModel() : base() { }
    }
}
