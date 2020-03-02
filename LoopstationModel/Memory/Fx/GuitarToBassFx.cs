using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public class GuitarToBassFx
    {
        public int Balance // TODO: Balance (0...100) (50:50)
        {
            get => _balanceProperty.Value;
            set => _balanceProperty.Value = value;
        }

        #region private Fields
        private readonly IntProperty _balanceProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public GuitarToBassFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _balanceProperty = _xml.GuitarToBassBalance;

            _balanceProperty.PropertyChanged += (_, e) => _xml.GuitarToBassBalance = e.Value;
            #endregion private Fields initialization
        }
    }
}
