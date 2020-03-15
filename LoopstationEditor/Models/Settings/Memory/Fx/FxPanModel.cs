using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public enum FxPanType { AUTO1 = 0, AUTO2 = 1, MANUAL = 2 }

    public class FxPanModel : SettingsModel
    {
        [XmlElement(FxProperty.PanType, typeof(int))]
        [Property(FxPanType.AUTO1, 0, 2)]
        public ValueEnum<FxPanType> PanType { get; set; }

        [XmlElement(FxProperty.PanRate, typeof(int))]
        [PropertyMixed(50, 0, 114, 0, 100)]
        public ValueInt PanRate { get; set; }

        [XmlElement(FxProperty.PanDepth, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt PanDepth { get; set; }

        [XmlElement(FxProperty.PanStepRate, typeof(int))]
        [Property(FxStepRate.OFF, 0, 115)]
        public ValueInt PanStepRate { get; set; }

        [XmlElement(FxProperty.PanPosition, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt PanPosition { get; set; }


        public FxPanModel() : base() { }
    }
}
