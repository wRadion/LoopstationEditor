using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public class FxVocoderModel : SettingsModel
    {
        [XmlElement(FxProperty.VocoderCarrier, typeof(int))]
        [Property(Track.TRACK1, 0, 4)]
        public ValueEnum<Track> VocoderCarrier { get; set; }

        [XmlElement(FxProperty.VocoderModSens, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VocoderModSens { get; set; }

        [XmlElement(FxProperty.VocoderAttack, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VocoderAttack { get; set; }

        [XmlElement(FxProperty.VocoderBalance, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt VocoderBalance { get; set; }

        public FxVocoderModel() : base() { }
    }
}
