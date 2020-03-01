using System;
using System.Xml.Serialization;

namespace Loopstation.Xml.Base
{
    [XmlRoot("database")]
    public abstract class XmlFileBase : ICloneable
    {
        [XmlAttribute("name")]
        public string Name { get; set; } = "RC-505";

        [XmlAttribute("revision")]
        public int Revision { get; set; } = 2;

        public abstract object Clone();
    }
}
