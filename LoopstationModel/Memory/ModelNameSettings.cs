using System.Text;

using Loopstation.Xml.Memory;

namespace Loopstation.Model.Memory
{
    public class ModelNameSettings
    {
        private string _name = "INIT MEMORY";
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 12)
                    value += "            ";
                if (value.Length > 12)
                    value = value.Substring(0, 12);
                _name = value;
            }
        }

        public ModelNameSettings() : this(null) { }
        public ModelNameSettings(XmlNameSettings xmlName)
        {
            if (xmlName == null) return;

            _name = new StringBuilder((char)xmlName.Character01).Append((char)xmlName.Character02).
                Append((char)xmlName.Character03).Append((char)xmlName.Character04).
                Append((char)xmlName.Character05).Append((char)xmlName.Character06).
                Append((char)xmlName.Character07).Append((char)xmlName.Character08).
                Append((char)xmlName.Character09).Append((char)xmlName.Character10).
                Append((char)xmlName.Character11).Append((char)xmlName.Character12).ToString();
        }
    }
}
