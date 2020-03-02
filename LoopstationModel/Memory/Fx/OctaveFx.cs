using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory.Fx
{
    public enum OctaveMode { MINUS_1_OCT, MINUS_2_OCT, BOTH }

    public class OctaveFx
    {
        public OctaveMode Mode
        {
            get => _modeProperty.Value;
            set => _modeProperty.Value = value;
        }
        public int Level
        {
            get => _levelProperty.Value;
            set => _levelProperty.Value = value;
        }

        #region private Fields
        private readonly EnumProperty<OctaveMode> _modeProperty;
        private readonly IntProperty _levelProperty;

        private readonly XmlFxSettings _xml;
        #endregion private Fields

        public OctaveFx(XmlFxSettings xmlFx)
        {
            #region private Fields initialization
            _xml = xmlFx;

            _modeProperty  = _xml.OctaveMode;
            _levelProperty = _xml.OctaveLevel;

            _modeProperty.PropertyChanged  += (_, e) => _xml.OctaveMode = e.Value;
            _levelProperty.PropertyChanged += (_, e) => _xml.OctaveLevel = e.Value;
            #endregion private Fields initialization
        }
    }
}
