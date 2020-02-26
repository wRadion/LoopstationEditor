using System.Xml.Linq;

using LoopstationModels;

namespace LoopstationXml.Extensions
{
    public static class PropertyExtensions
    {
        public static void ReadXml(this Property property, XElement settingsXml)
        {
            property.Value = int.Parse(settingsXml.Element(property.Name).Value);
        }

        public static void WriteXml(this Property property, XElement settingsXml)
        {
            settingsXml.Add(new XElement(property.Name, property.Value.ToString()));
        }
    }
}
