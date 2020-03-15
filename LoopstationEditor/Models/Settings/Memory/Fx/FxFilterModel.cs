using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public enum FxFilterType { LPF = 0, BPF = 1, HPF = 2 }

    public class FxFilterModel : SettingsModel
    {
        [XmlElement(FxProperty.FilterType, typeof(int))]
        [Property(FxFilterType.LPF, 0, 2)]
        public ValueEnum<FxFilterType> FilterType { get; set; }

        [XmlElement(FxProperty.FilterRate, typeof(int))]
        [PropertyMixed(50, 0, 114, 0, 100)]
        public ValueInt FilterRate { get; set; }

        [XmlElement(FxProperty.FilterDepth, typeof(int))]
        [Property(55, 0, 100)]
        public ValueInt FilterDepth { get; set; }

        [XmlElement(FxProperty.FilterResonance, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt FilterResonance { get; set; }

        [XmlElement(FxProperty.FilterCutoff, typeof(int))]
        [Property(50, 0, 100)]
        public ValueInt FilterCutoff { get; set; }

        [XmlElement(FxProperty.FilterStepRate, typeof(int))]
        [PropertyMixed(FxStepRate.OFF, 0, 115, 1, 101)]
        public ValueInt FilterStepRate { get; set; }

        public FxFilterModel() : base() { }
    }
}
