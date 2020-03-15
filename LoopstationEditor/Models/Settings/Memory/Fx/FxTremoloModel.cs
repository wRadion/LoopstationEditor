using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxTremoloModel : SettingsModel
    {
        [XmlElement(FxProperty.TremoloRate, typeof(int))]
        [PropertyMixed(85, 0, 114, 0, 100)]
        public ValueInt TremoloRate { get; set; }

        [XmlElement(FxProperty.TremoloDepth, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt TremoloDepth { get; set; }

        [XmlElement(FxProperty.TremoloLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt TremoloLevel { get; set; }

        public FxTremoloModel() : base() { }
    }
}
