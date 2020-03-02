using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public enum BeatRepeatType   { FORWARD, REWIND, MIX }
    public enum BeatRepeatLength { THRU, WHOLE_NOTE, HALF_NOTE, QUARTER_NOTE, EIGHTH_NOTE, SIXTEENTH_NOTE, THIRTYSECOND_NOTE }

    public class BeatRepeatFx
    {
        public BeatRepeatType Type
        {
            get => _typeProperty.Value;
            set => _typeProperty.Value = value;
        }
        public BeatRepeatLength Length
        {
            get => _lengthProperty.Value;
            set => _lengthProperty.Value = value;
        }

        #region private Fields
        private readonly EnumProperty<BeatRepeatType> _typeProperty;
        private readonly EnumProperty<BeatRepeatLength> _lengthProperty;

        private readonly XmlBeatFxSettings _xml;
        #endregion private Fields

        public BeatRepeatFx(XmlBeatFxSettings xmlBeatFx)
        {
            #region private Fields initialization
            _xml = xmlBeatFx;

            _typeProperty   = _xml.BeatRepeatType;
            _lengthProperty = _xml.BeatRepeatLength;

            _typeProperty.PropertyChanged   += (_, e) => _xml.BeatRepeatType = e.Value;
            _lengthProperty.PropertyChanged += (_, e) => _xml.BeatRepeatLength = e.Value;
            #endregion private Fields initialization
        }
    }
}
