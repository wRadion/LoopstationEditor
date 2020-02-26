using System.Xml.Linq;

using LoopstationModels.Base;

namespace LoopstationXml.Extensions
{
    public static class BaseSettingsExtensions
    {
        public static void ReadXml(this BaseSettings settings, XElement baseXml)
        {
            XElement settingsXml = baseXml.Element(settings.Name);

            settings.ForEachProperty((prop) => prop.ReadXml(settingsXml));
        }

        public static void WriteXml(this BaseSettings settings, XElement baseXml)
        {
            XElement settingsXml = new XElement(settings.Name);

            settings.ForEachProperty((prop) => prop.WriteXml(settingsXml));

            baseXml.Add(settingsXml);
        }
    }
}
