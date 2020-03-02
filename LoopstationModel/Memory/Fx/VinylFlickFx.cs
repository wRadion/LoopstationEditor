using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public class VinylFlickFx
    {
        public int Flick
        {
            get => _flickProperty.Value;
            set => _flickProperty.Value = value;
        }

        #region private Fields
        private readonly IntProperty _flickProperty;

        private readonly XmlBeatFxSettings _xml;
        #endregion private Fields

        public VinylFlickFx(XmlBeatFxSettings xmlBeatFx)
        {
            #region private Fields initialization
            _xml = xmlBeatFx;

            _flickProperty = _xml.VinylFlick;

            _flickProperty.PropertyChanged += (_, e) => _xml.VinylFlick = e.Value;
            #endregion private Fields initialization
        }
    }
}
