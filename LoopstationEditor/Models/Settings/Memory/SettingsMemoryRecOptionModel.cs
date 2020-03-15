using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory
{
    public enum RecOptionOverdubMode { OVERDUB = 0, REPLACE = 1 }
    public enum RecOptionRecordAction { REC_THEN_OVERDUB = 0, REC_THEN_PLAY = 1 }

    public static class RecOptionProperty
    {
        public const string OverdubMode = "DubMod";
        public const string RecordAction = "RecAct";
        public const string RecordQuantize = "RecQtz";
    }

    public class SettingsMemoryRecOptionModel : SettingsModel
    {
        [XmlElement(RecOptionProperty.OverdubMode, typeof(int))]
        [Property(RecOptionOverdubMode.OVERDUB, 0, 1)]
        public ValueEnum<RecOptionOverdubMode> OverdubMode { get; set; }

        [XmlElement(RecOptionProperty.RecordAction, typeof(int))]
        [Property(RecOptionRecordAction.REC_THEN_OVERDUB, 0, 1)]
        public ValueEnum<RecOptionRecordAction> RecordAction { get; set; }

        [XmlElement(RecOptionProperty.RecordQuantize, typeof(int))]
        [Property(1, 0, 1)]
        public ValueInt RecordQuantize { get; set; }

        public SettingsMemoryRecOptionModel() : base() { }
    }
}
