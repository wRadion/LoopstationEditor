using System;
using System.Text;
using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory
{
    public class SettingsMemoryNameModel : SettingsModel
    {
        public const int Length = 12;

        public event EventHandler NameChanged;

        [XmlElement("C01", typeof(int))]
        [Property('I', 32, 126)]
        public ValueChar Character01 { get; set; }

        [XmlElement("C02", typeof(int))]
        [Property('N', 32, 126)]
        public ValueChar Character02 { get; set; }

        [XmlElement("C03", typeof(int))]
        [Property('I', 32, 126)]
        public ValueChar Character03 { get; set; }

        [XmlElement("C04", typeof(int))]
        [Property('T', 32, 126)]
        public ValueChar Character04 { get; set; }

        [XmlElement("C05", typeof(int))]
        [Property(' ', 32, 126)]
        public ValueChar Character05 { get; set; }

        [XmlElement("C06", typeof(int))]
        [Property('M', 32, 126)]
        public ValueChar Character06 { get; set; }

        [XmlElement("C07", typeof(int))]
        [Property('E', 32, 126)]
        public ValueChar Character07 { get; set; }

        [XmlElement("C08", typeof(int))]
        [Property('M', 32, 126)]
        public ValueChar Character08 { get; set; }

        [XmlElement("C09", typeof(int))]
        [Property('O', 32, 126)]
        public ValueChar Character09 { get; set; }

        [XmlElement("C10", typeof(int))]
        [Property('R', 32, 126)]
        public ValueChar Character10 { get; set; }

        [XmlElement("C11", typeof(int))]
        [Property('Y', 32, 126)]
        public ValueChar Character11 { get; set; }

        [XmlElement("C12", typeof(int))]
        [Property(' ', 32, 126)]
        public ValueChar Character12 { get; set; }

        public SettingsMemoryNameModel() : base() { }

        public void OnNameChanged() => NameChanged?.Invoke(this, EventArgs.Empty);

        public override string ToString()
        {
            return new StringBuilder(12).Append((char)Character01).Append((char)Character02).Append((char)Character03).Append((char)Character04).
                Append((char)Character05).Append((char)Character06).Append((char)Character07).Append((char)Character08).Append((char)Character09).
                Append((char)Character10).Append((char)Character11).Append((char)Character12).ToString();
        }
    }
}
