using System.Text;

using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory
{
    public class ModelNameSettings
    {
        public string Name
        {
            get
            {
                return new StringBuilder(_c01Property.Value).Append(_c02Property.Value).
                    Append(_c03Property.Value).Append(_c04Property.Value).
                    Append(_c05Property.Value).Append(_c06Property.Value).
                    Append(_c07Property.Value).Append(_c08Property.Value).
                    Append(_c09Property.Value).Append(_c10Property.Value).
                    Append(_c11Property.Value).Append(_c12Property.Value).ToString();
            }

            set
            {
                StringBuilder str = new StringBuilder(value, 12);

                if (value.Length < 12)
                    str.Append(' ', 12 - value.Length);

                _c01Property.Value = str[0]; _c02Property.Value = str[1];
                _c03Property.Value = str[2]; _c04Property.Value = str[3];
                _c05Property.Value = str[4]; _c06Property.Value = str[5];
                _c07Property.Value = str[6]; _c08Property.Value = str[7];
                _c09Property.Value = str[8]; _c10Property.Value = str[9];
                _c11Property.Value = str[10]; _c12Property.Value = str[11];
            }
        }

        #region private Fields
        private readonly CharProperty _c01Property;
        private readonly CharProperty _c02Property;
        private readonly CharProperty _c03Property;
        private readonly CharProperty _c04Property;
        private readonly CharProperty _c05Property;
        private readonly CharProperty _c06Property;
        private readonly CharProperty _c07Property;
        private readonly CharProperty _c08Property;
        private readonly CharProperty _c09Property;
        private readonly CharProperty _c10Property;
        private readonly CharProperty _c11Property;
        private readonly CharProperty _c12Property;

        private readonly XmlNameSettings _xml;
        #endregion private Fields

        public ModelNameSettings(XmlNameSettings xmlName)
        {
            #region private Fields initialization
            _xml = xmlName;

            _c01Property = _xml.Character01;
            _c02Property = _xml.Character02;
            _c03Property = _xml.Character03;
            _c04Property = _xml.Character04;
            _c05Property = _xml.Character05;
            _c06Property = _xml.Character06;
            _c07Property = _xml.Character07;
            _c08Property = _xml.Character08;
            _c09Property = _xml.Character09;
            _c10Property = _xml.Character10;
            _c11Property = _xml.Character11;
            _c12Property = _xml.Character12;

            _c01Property.PropertyChanged += (_, e) => _xml.Character01 = e.Value;
            _c02Property.PropertyChanged += (_, e) => _xml.Character02 = e.Value;
            _c03Property.PropertyChanged += (_, e) => _xml.Character03 = e.Value;
            _c04Property.PropertyChanged += (_, e) => _xml.Character04 = e.Value;
            _c05Property.PropertyChanged += (_, e) => _xml.Character05 = e.Value;
            _c06Property.PropertyChanged += (_, e) => _xml.Character06 = e.Value;
            _c07Property.PropertyChanged += (_, e) => _xml.Character07 = e.Value;
            _c08Property.PropertyChanged += (_, e) => _xml.Character08 = e.Value;
            _c09Property.PropertyChanged += (_, e) => _xml.Character09 = e.Value;
            _c10Property.PropertyChanged += (_, e) => _xml.Character10 = e.Value;
            _c11Property.PropertyChanged += (_, e) => _xml.Character11 = e.Value;
            _c12Property.PropertyChanged += (_, e) => _xml.Character12 = e.Value;
            #endregion private Fields initialization
        }
    }
}
