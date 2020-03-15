using LoopstationEditor.Models.PropertyEngine;
using System.Xml.Serialization;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public enum FxSlicerPattern { P01 = 0, P02 = 1, P03 = 2, P04 = 3, P05 = 4, P06 = 5, P07 = 6, P08 = 7, P09 = 8, P10 = 9, P11 = 10, P12 = 11, P13 = 12, P14 = 13, P15 = 14, P16 = 15, P17 = 16, P18 = 17, P19 = 18, P20 = 19 }

    public class FxSlicerModel : SettingsModel
    {
        [XmlElement(FxProperty.SlicerPattern, typeof(int))]
        [Property(FxSlicerPattern.P01, 0, 19)]
        public ValueEnum<FxSlicerPattern> SlicerPattern { get; set; }

        [XmlElement(FxProperty.SlicerRate, typeof(int))]
        [Property(FxRate.EIGHTH_NOTE, 0, 114)]
        public ValueInt SlicerRate { get; set; }

        [XmlElement(FxProperty.SlicerDepth, typeof(int))]
        [Property(100, 0, 120)]
        public ValueInt SlicerDepth { get; set; }

        public FxSlicerModel() : base() { }
    }
}
