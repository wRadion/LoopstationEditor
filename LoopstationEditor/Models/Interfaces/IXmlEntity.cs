using System.Xml.Linq;

namespace LoopstationEditor.Models.Interfaces
{
    public class XmlFlattenedEntity { }

    public interface IXmlEntity
    {
        void WriteXml(string file);
        void WriteXml(XElement parent);

        void ReadXml(string file);
        void ReadXml(XElement parent);
    }
}
