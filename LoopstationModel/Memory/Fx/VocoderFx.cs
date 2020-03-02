using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public class VocoderFx
    {
        public Track Carrier
        {
            get => _carrierProperty.Value;
            set => _carrierProperty.Value = value;
        }
        public int ModSens
        {
            get => _modSensProperty.Value;
            set => _modSensProperty.Value = value;
        }
        public int Attack
        {
            get => _attackProperty.Value;
            set => _attackProperty.Value = value;
        }
        public int Balance // TODO: Balance (0...100) (50:50)
        {
            get => _balanceProperty.Value;
            set => _balanceProperty.Value = value;
        }

        #region private Fields
        private readonly EnumProperty<Track> _carrierProperty;
        private readonly IntProperty _modSensProperty;
        private readonly IntProperty _attackProperty;
        private readonly IntProperty _balanceProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public VocoderFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _carrierProperty = _xml.VocoderCarrier;
            _modSensProperty = _xml.VocoderModSens;
            _attackProperty  = _xml.VocoderAttack;
            _balanceProperty = _xml.VocoderBalance;

            _carrierProperty.PropertyChanged += (_, e) => _xml.VocoderCarrier = e.Value;
            _modSensProperty.PropertyChanged += (_, e) => _xml.VocoderModSens = e.Value;
            _attackProperty.PropertyChanged  += (_, e) => _xml.VocoderAttack = e.Value;
            _balanceProperty.PropertyChanged += (_, e) => _xml.VocoderBalance = e.Value;
            #endregion
        }
    }
}
