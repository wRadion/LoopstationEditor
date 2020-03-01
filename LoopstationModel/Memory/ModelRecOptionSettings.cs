using Loopstation.Xml.Memory;

namespace Loopstation.Model.Memory
{
    public enum RecOptionOverdubMode { OVERDUB, REPLACE }
    public enum RecOptionRecordAction { REC_THEN_OVERDUB, REC_THEN_PLAY }

    public class ModelRecOptionSettings
    {
        public RecOptionOverdubMode OverdubMode { get; set; } = RecOptionOverdubMode.OVERDUB;
        public RecOptionRecordAction RecordAction { get; set; } = RecOptionRecordAction.REC_THEN_OVERDUB;
        // TODO: Record Quantize ?

        public ModelRecOptionSettings() : this(null) { }
        public ModelRecOptionSettings(XmlRecOptionSettings xmlRecOption)
        {
            if (xmlRecOption == null) return;

            OverdubMode = (RecOptionOverdubMode)xmlRecOption.OverdubMode;
            RecordAction = (RecOptionRecordAction)xmlRecOption.RecordAction;
        }
    }
}
