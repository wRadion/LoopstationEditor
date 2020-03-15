using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxChorusModel : SettingsModel
    {
        [XmlElement(FxProperty.ChorusRate, typeof(int))]
        [PropertyMixed(50, 0, 114, 0, 100)]
        public ValueInt ChorusRate { get; set; }

        [XmlElement(FxProperty.ChorusDepth, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt ChorusDepth { get; set; }

        [XmlElement(FxProperty.ChorusLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt ChorusLevel { get; set; }

        public FxChorusModel() : base() { }
    }
}
