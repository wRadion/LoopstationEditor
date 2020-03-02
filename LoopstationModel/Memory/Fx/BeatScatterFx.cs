using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public enum BeatScatterType { P1, P2, P3, P4 }
    public enum BeatScatterLength { THRU, HALF_NOTE, QUARTER_NOTE, EIGHTH_NOTE, SIXTEENTH_NOTE }

    public class BeatScatterFx
    {
        public BeatScatterType Type
        {
            get => _typeProperty.Value;
            set => _typeProperty.Value = value;
        }
        public BeatScatterLength Length
        {
            get => _lengthProperty.Value;
            set => _lengthProperty.Value = value;
        }

        #region private Fields
        private readonly EnumProperty<BeatScatterType> _typeProperty;
        private readonly EnumProperty<BeatScatterLength> _lengthProperty;

        private readonly XmlBeatFxSettings _xml;
        #endregion private Fields

        public BeatScatterFx(XmlBeatFxSettings xmlBeatFx)
        {
            #region private Fields initialization
            _xml = xmlBeatFx;

            _typeProperty   = _xml.BeatScatterType;
            _lengthProperty = _xml.BeatScatterLength;

            _typeProperty.PropertyChanged   += (_, e) => _xml.BeatScatterType = e.Value;
            _lengthProperty.PropertyChanged += (_, e) => _xml.BeatScatterLength = e.Value;
            #endregion private Fields initialization
        }
    }
}
