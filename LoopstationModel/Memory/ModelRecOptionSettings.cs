using Loopstation.Xml.Memory;

namespace Loopstation.Model.Memory
{
    public enum RecOptionOverdubMode { OVERDUB, REPLACE }
    public enum RecOptionRecordAction { REC_THEN_OVERDUB, REC_THEN_PLAY }

    public class ModelRecOptionSettings
    {
        public RecOptionOverdubMode OverdubMode { get; set; }
        public RecOptionRecordAction RecordAction { get; set; }
        // TODO: Record Quantize ?

        public ModelRecOptionSettings(XmlRecOptionSettings xmlRecOption)
        {
            OverdubMode = (RecOptionOverdubMode)xmlRecOption.OverdubMode;
            RecordAction = (RecOptionRecordAction)xmlRecOption.RecordAction;
        }
    }
}
