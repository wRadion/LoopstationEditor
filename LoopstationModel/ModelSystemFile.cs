using Loopstation.Xml;

namespace Loopstation.Model
{
    public class ModelSystemFile
    {
        public ModelSystemSettings System;
        public ModelMemorySettings DefaultMemory;

        public ModelSystemFile(XmlSystemFile xmlSystem)
        {
            System = new ModelSystemSettings(xmlSystem.System);
            DefaultMemory = new ModelMemorySettings(xmlSystem.System);
        }
    }
}
