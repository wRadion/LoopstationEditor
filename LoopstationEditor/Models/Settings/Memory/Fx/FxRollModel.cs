using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public enum FxRollMode { OFF = 0, _1_2 = 1, _1_4 = 2, _1_8 = 3, _1_16 = 4 }

    public class FxRollModel : SettingsModel
    {
        [XmlElement(FxProperty.RollTime, typeof(int))]
        [PropertyMixed(FxDelayTime.QUARTER_NOTE, 0, 1011, 0, 1000)]
        public ValueInt RollTime { get; set; }

        [XmlElement(FxProperty.RollMode, typeof(int))]
        [Property(FxRollMode._1_4, 0, 4)]
        public ValueEnum<FxRollMode> RollMode { get; set; }

        [XmlElement(FxProperty.RollFeedback, typeof(int))]
        [Property(20, 0, 100)]
        public ValueInt RollFeedback { get; set; }

        [XmlElement(FxProperty.RollLevel, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt RollLevel { get; set; }

        public FxRollModel() : base() { }
    }
}
