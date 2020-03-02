using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public enum BeatShiftType { FUTURE, PAST }
    public enum BeatShiftShift { THRU, SIXTEENTH_NOTE, EIGHTH_NOTE, QUARTER_NOTE, HALF_NOTE, WHOLE_NOTE }

    public class BeatShiftFx
    {
        public BeatShiftType Type
        {
            get => _typeProperty.Value;
            set => _typeProperty.Value = value;
        }
        public BeatShiftShift Shift
        {
            get => _shiftProperty.Value;
            set => _shiftProperty.Value = value;
        }

        #region private Fields
        private readonly EnumProperty<BeatShiftType> _typeProperty;
        private readonly EnumProperty<BeatShiftShift> _shiftProperty;

        private readonly XmlBeatFxSettings _xml;
        #endregion private Fields

        public BeatShiftFx(XmlBeatFxSettings xmlBeatFx)
        {
            #region private Fields initialization
            _xml = xmlBeatFx;

            _typeProperty  = _xml.BeatShiftType;
            _shiftProperty = _xml.BeatShiftShift;

            _typeProperty.PropertyChanged  += (_, e) => _xml.BeatShiftType = e.Value;
            _shiftProperty.PropertyChanged += (_, e) => _xml.BeatShiftShift = e.Value;
            #endregion private Fields initialization
        }
    }
}
