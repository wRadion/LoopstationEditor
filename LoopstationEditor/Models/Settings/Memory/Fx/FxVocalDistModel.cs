using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxVocalDistModel : SettingsModel
    {
        [XmlElement(FxProperty.VocalDistDistortion, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VocalDistDistortion { get; set; }

        [XmlElement(FxProperty.VocalDistTone, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VocalDistTone { get; set; }

        [XmlElement(FxProperty.VocalDistLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VocalDistLevel { get; set; }

        public FxVocalDistModel() : base() { }
    }
}
