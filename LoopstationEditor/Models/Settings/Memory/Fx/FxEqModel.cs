using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxEqModel : SettingsModel
    {
        [XmlElement(FxProperty.EqLow, typeof(int))]
        [Property(20, 0, 40)]
        public ValueInt EqLow { get; set; }

        [XmlElement(FxProperty.EqLowMid, typeof(int))]
        [Property(20, 0, 40)]
        public ValueInt EqLowMid { get; set; }

        [XmlElement(FxProperty.EqHighMid, typeof(int))]
        [Property(20, 0, 40)]
        public ValueInt EqHighMid { get; set; }

        [XmlElement(FxProperty.EqHigh, typeof(int))]
        [Property(20, 0, 40)]
        public ValueInt EqHigh { get; set; }

        [XmlElement(FxProperty.EqLevel, typeof(int))]
        [Property(20, 0, 40)]
        public ValueInt EqLevel { get; set; }

        public FxEqModel() : base() { }
    }
}
