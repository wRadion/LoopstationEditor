using System.Xml.Serialization;

using Loopstation.Xml.Base;
using Loopstation.Xml.Interfaces;

namespace Loopstation.Xml
{
    [XmlRoot("database")]
    public class XmlMemoryFile : XmlFileBase, ICloneable<XmlMemoryFile>
    {
        /// <summary>
        /// The default file name of a Loopstation RC-505 memory file.
        /// </summary>
        public const string FILE_NAME = "MEMORY.RC0";

        /// <summary>
        /// The default count of memory entries in a Loopstation RC-505 memory file.
        /// </summary>
        public const int MEMORIES_COUNT = 99;

        [XmlElement("mem")]
        public XmlMemorySettings[] Memories;

        /// <summary>
        /// Initializes an object that represents a Loopstation RC-505 memory file.
        /// </summary>
        public XmlMemoryFile() : this(null) { }
        /// <summary>
        /// Initializes an object that represents a Loopstation RC-505 memory file.
        /// </summary>
        /// <param name="other">An other memory file to copy the values from</param>
        public XmlMemoryFile(XmlMemoryFile other)
        {
            Memories = new XmlMemorySettings[MEMORIES_COUNT];

            for (int i = 0; i < Memories.Length; ++i)
                Memories[i] = new XmlMemorySettings(other?.Memories[i]);
        }

        public XmlMemoryFile Clone() => new XmlMemoryFile(this);
    }
}
