using Loopstation.Xml;
using Loopstation.Model.Memory;

namespace Loopstation.Model
{
    public class ModelMemoryFile
    {
        public ModelMemorySettings[] Memories;

        public ModelMemoryFile() : this(new XmlMemoryFile()) { }
        public ModelMemoryFile(XmlMemoryFile xmlMemory)
        {
            Memories = new ModelMemorySettings[XmlMemoryFile.MEMORIES_COUNT];

            for (int i = 0; i < Memories.Length; ++i)
                Memories[i] = new ModelMemorySettings(i + 1, xmlMemory.Memories[i]);
        }
    }
}
