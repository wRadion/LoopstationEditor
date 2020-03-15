using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxGuitarToBassModel : SettingsModel
    {
        [XmlElement(FxProperty.GuitarToBassBalance, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt GuitarToBassBalance { get; set; }

        public FxGuitarToBassModel() : base() { }
    }
}
