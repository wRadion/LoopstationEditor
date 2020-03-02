using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public class RingModulatorFx
    {
        public int Frequency
        {
            get => _frequencyProperty.Value;
            set => _frequencyProperty.Value = value;
        }
        public int Balance // TODO: Balance (0...100) (50:50)
        {
            get => _balanceProperty.Value;
            set => _balanceProperty.Value = value;
        }

        #region private Fields
        private readonly IntProperty _frequencyProperty;
        private readonly IntProperty _balanceProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public RingModulatorFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _frequencyProperty = _xml.RingModulatorFrequency;
            _balanceProperty   = _xml.RingModulatorBalance;

            _frequencyProperty.PropertyChanged += (_, e) => _xml.RingModulatorFrequency = e.Value;
            _balanceProperty.PropertyChanged   += (_, e) => _xml.RingModulatorBalance = e.Value;
            #endregion private Fields initialization
        }
    }
}
