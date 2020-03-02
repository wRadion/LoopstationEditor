using Loopstation.Xml;
using Loopstation.Model.Memory;
using Loopstation.Model.System;

namespace Loopstation.Model
{
    public class ModelSystemFile
    {
        public ModelSystemSettings System;
        public ModelMemorySettings DefaultMemory;

        public ModelSystemFile() : this(new XmlSystemFile()) { }
        public ModelSystemFile(XmlSystemFile xmlSystem)
        {
            System        = new ModelSystemSettings(xmlSystem.System);
            DefaultMemory = new ModelMemorySettings(xmlSystem.System);
        }
    }
}
