using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxTransposeModel : SettingsModel
    {
        [XmlElement(FxProperty.TransposeSemitones, typeof(int))]
        [Property(12, 0, 24)]
        public ValueInt TransposeSemitones { get; set; }

        public FxTransposeModel() : base() { }
    }
}
