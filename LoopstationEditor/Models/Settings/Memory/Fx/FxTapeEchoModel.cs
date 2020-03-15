using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxTapeEchoModel : SettingsModel
    {
        [XmlElement(FxProperty.TapeEchoRate, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt TapeEchoRate { get; set; }

        [XmlElement(FxProperty.TapeEchoIntensity, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt TapeEchoIntensity { get; set; }

        [XmlElement(FxProperty.TapeEchoLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt TapeEchoLevel { get; set; }

        public FxTapeEchoModel() : base() { }
    }
}
