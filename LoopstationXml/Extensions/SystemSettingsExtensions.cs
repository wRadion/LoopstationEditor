using System.Xml.Linq;

using LoopstationModels;

namespace LoopstationXml.Extensions
{
    public static class SystemSettingsExtensions
    {
        public static void ReadXml(this SystemSettings system, XElement systemXml)
        {
            system.Setup.ReadXml(systemXml);
            system.InputOutput.ReadXml(systemXml);
            system.USB.ReadXml(systemXml);
            system.MIDI.ReadXml(systemXml);

            system.DefaultMemory.ReadXml(systemXml);
        }

        public static void WriteXml(this SystemSettings system, XElement systemXml)
        {
            system.Setup.WriteXml(systemXml);
            system.InputOutput.WriteXml(systemXml);
            system.USB.WriteXml(systemXml);
            system.MIDI.WriteXml(systemXml);

            system.DefaultMemory.WriteXml(systemXml);
        }
    }
}
