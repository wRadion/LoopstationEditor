using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory
{
    public enum RecOptionOverdubMode    { OVERDUB, REPLACE }
    public enum RecOptionRecordAction   { REC_THEN_OVERDUB, REC_THEN_PLAY }
    public enum RecOptionRecordQuantize { }

    public class ModelRecOptionSettings
    {
        public RecOptionOverdubMode OverdubMode
        {
            get => _overdubModeProperty.Value;
            set => _overdubModeProperty.Value = value;
        }
        public RecOptionRecordAction RecordAction
        {
            get => _recordActionProperty.Value;
            set => _recordActionProperty.Value = value;
        }
        public RecOptionRecordQuantize RecordQuantize
        {
            get => _recordQuantizeProperty.Value;
            set => _recordQuantizeProperty.Value = value;
        }

        #region private Fields
        private readonly EnumProperty<RecOptionOverdubMode> _overdubModeProperty;
        private readonly EnumProperty<RecOptionRecordAction> _recordActionProperty;
        private readonly EnumProperty<RecOptionRecordQuantize> _recordQuantizeProperty;

        private readonly XmlRecOptionSettings _xml;
        #endregion private Fields

        public ModelRecOptionSettings(XmlRecOptionSettings xmlRecOption)
        {
            #region private Fields initialization
            _xml = xmlRecOption;

            _overdubModeProperty    = _xml.OverdubMode;
            _recordActionProperty   = _xml.RecordAction;
            _recordQuantizeProperty = _xml.RecordQuantize;

            _overdubModeProperty.PropertyChanged    += (_, e) => _xml.OverdubMode = e.Value;
            _recordActionProperty.PropertyChanged   += (_, e) => _xml.RecordAction = e.Value;
            _recordQuantizeProperty.PropertyChanged += (_, e) => _xml.RecordQuantize = e.Value;
            #endregion private Fields initialization
        }
    }
}
