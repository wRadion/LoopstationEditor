using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public enum FxDynamicsType { NATURAL_COMP = 0, MIXER_COMP = 1, LIVE_COMP = 2, NATURAL_LIM = 3, HARD_LIM = 4, JINGL_COMP = 5, HARD_COMP = 6, SOFT_COMP = 7, CLEAN_COMP = 8, DANCE_COMP = 9, ORCH_COMP = 10, VOCAL_COMP = 11, ACOUSTIC = 12, ROCK_BAND = 13, ORCHESTRA = 14, LOW_BOOST = 15, BRIGHTEN = 16, DJs_VOICE = 17, PHONE_VOX = 18 }

    public class FxDynamicsModel : SettingsModel
    {
        [XmlElement(FxProperty.DynamicsType, typeof(int))]
        [Property(FxDynamicsType.NATURAL_COMP, 0, 18)]
        public ValueEnum<FxDynamicsType> DynamicsType { get; set; }

        [XmlElement(FxProperty.DynamicsDynamics, typeof(int))]
        [Property(20, 0, 40)]
        public ValueInt DynamicsDynamics { get; set; }

        public FxDynamicsModel() : base() { }
    }
}
