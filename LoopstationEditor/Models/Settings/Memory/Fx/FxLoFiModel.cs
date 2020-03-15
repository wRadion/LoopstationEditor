using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxLoFiModel : SettingsModel
    {
        [XmlElement(FxProperty.LoFiDepth, typeof(int))]
        [Property(8, 0, 15)]
        public ValueInt LoFiDepth { get; set; }

        [XmlElement(FxProperty.LoFiSampleRate, typeof(int))]
        [Property(15, 0, 31)]
        public ValueInt LoFiSampleRate { get; set; }

        [XmlElement(FxProperty.LoFiBalance, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt LoFiBalance { get; set; }

        public FxLoFiModel() : base() { }
    }
}
