using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public class SynthFx
    {
        public int Frequency
        {
            get => _frequencyProperty.Value;
            set => _frequencyProperty.Value = value;
        }
        public int Resonance
        {
            get => _resonanceProperty.Value;
            set => _resonanceProperty.Value = value;
        }
        public int Decay
        {
            get => _decayProperty.Value;
            set => _decayProperty.Value = value;
        }
        public int Balance // TODO: Balance (0...100) (50:50)
        {
            get => _balanceProperty.Value;
            set => _balanceProperty.Value = value;
        }

        #region private Fields
        private readonly IntProperty _frequencyProperty;
        private readonly IntProperty _resonanceProperty;
        private readonly IntProperty _decayProperty;
        private readonly IntProperty _balanceProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public SynthFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _frequencyProperty = _xml.SynthFrequency;
            _resonanceProperty = _xml.SynthResonance;
            _decayProperty     = _xml.SynthDecay;
            _balanceProperty   = _xml.SynthBalance;

            _frequencyProperty.PropertyChanged += (_, e) => _xml.SynthFrequency = e.Value;
            _resonanceProperty.PropertyChanged += (_, e) => _xml.SynthResonance = e.Value;
            _decayProperty.PropertyChanged     += (_, e) => _xml.SynthDecay = e.Value;
            _balanceProperty.PropertyChanged   += (_, e) => _xml.SynthBalance = e.Value;
            #endregion private Fields initialization
        }
    }
}
