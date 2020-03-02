using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public class TransposeFx
    {
        public int Semitones // TODO: Transpose Semitones (0...24) (-12)
        {
            get => _semitonesProperty.Value;
            set => _semitonesProperty.Value = value;
        }

        #region private Fields
        private readonly IntProperty _semitonesProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public TransposeFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _semitonesProperty = _xml.Transpose;

            _semitonesProperty.PropertyChanged += (_, e) => _xml.Transpose = e.Value;
            #endregion private Fields initialization
        }
    }
}
