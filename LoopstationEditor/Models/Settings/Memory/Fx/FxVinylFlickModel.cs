using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxVinylFlickModel : SettingsModel
    {
        [XmlElement(FxProperty.VinylFlick, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VinylFlick { get; set; }

        public FxVinylFlickModel() : base() { }
    }
}
