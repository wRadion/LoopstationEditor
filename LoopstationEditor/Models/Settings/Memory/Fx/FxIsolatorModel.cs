using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public enum FxIsolatorBand { LOW = 0, MID = 1, HIGH = 2 }

    public class FxIsolatorModel : SettingsModel
    {
        [XmlElement(FxProperty.IsolatorBand, typeof(int))]
        [Property(FxIsolatorBand.LOW, 0, 2)]
        public ValueEnum<FxIsolatorBand> IsolatorBand { get; set; }

        [XmlElement(FxProperty.IsolatorRate, typeof(int))]
        [PropertyMixed(FxRate.ONE_MEASURE, 0, 114, 0, 100)]
        public ValueInt IsolatorRate { get; set; }

        [XmlElement(FxProperty.IsolatorDepth, typeof(int))]
        [Property(100, 0, 100)]
        public ValueInt IsolatorDepth { get; set; }

        [XmlElement(FxProperty.IsolatorStepRate, typeof(int))]
        [PropertyMixed(FxStepRate.OFF, 0, 115, 1, 101)]
        public ValueInt IsolatorStepRate { get; set; }

        [XmlElement(FxProperty.IsolatorLevel, typeof(int))]
        [Property(100, 0, 100)]
        public ValueInt IsolatorLevel { get; set; }


        public FxIsolatorModel() : base() { }
    }
}
