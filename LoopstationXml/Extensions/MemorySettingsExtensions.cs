using System.Xml.Linq;

using LoopstationModels;
using LoopstationModels.Memory;

namespace LoopstationXml.Extensions
{
    public static class MemorySettingsExtensions
    {
        public static void ReadXml(this MemorySettings memory, XElement memoryXml)
        {
            foreach (TrackSettings track in memory.Tracks)
                track.ReadXml(memoryXml);
            memory.Rythm.ReadXml(memoryXml);
            memory.Name.ReadXml(memoryXml);
            memory.Master.ReadXml(memoryXml);
            memory.RecOption.ReadXml(memoryXml);
            memory.PlayOption.ReadXml(memoryXml);
            foreach (AssignSettings assign in memory.Assigns)
                assign.ReadXml(memoryXml);
            memory.InputFxOption.ReadXml(memoryXml);
            memory.TrackFxOption.ReadXml(memoryXml);
            foreach (BeatFxSettings beatFx in memory.BeatFxs)
                beatFx.ReadXml(memoryXml);
            foreach (FxSettings fx in memory.InputFxs)
                fx.ReadXml(memoryXml);
            foreach (FxSettings fx in memory.TrackFxs)
                fx.ReadXml(memoryXml);
        }

        public static void WriteXml(this MemorySettings memory, XElement memoryXml)
        {
            foreach (TrackSettings track in memory.Tracks)
                track.WriteXml(memoryXml);
            memory.Rythm.WriteXml(memoryXml);
            memory.Name.WriteXml(memoryXml);
            memory.Master.WriteXml(memoryXml);
            memory.RecOption.WriteXml(memoryXml);
            memory.PlayOption.WriteXml(memoryXml);
            foreach (AssignSettings assign in memory.Assigns)
                assign.WriteXml(memoryXml);
            memory.InputFxOption.WriteXml(memoryXml);
            memory.TrackFxOption.WriteXml(memoryXml);
            foreach (BeatFxSettings beatFx in memory.BeatFxs)
                beatFx.WriteXml(memoryXml);
            foreach (FxSettings fx in memory.InputFxs)
                fx.WriteXml(memoryXml);
            foreach (FxSettings fx in memory.TrackFxs)
                fx.WriteXml(memoryXml);
        }
    }
}
