using Loopstation.Xml.Base;
using Loopstation.Xml.Memory;
using Loopstation.Model.Memory;
using Loopstation.Model.Memory.Base;

namespace Loopstation.Model
{
    public class ModelMemorySettings
    {
        public int MemoryNumber { get; }

        public ModelTrackSettings[] Tracks;
        public ModelRhythmSettings Rhythm;
        public ModelNameSettings Name;
        public ModelMasterSettings Master;
        public ModelRecOptionSettings RecOption;
        public ModelPlayOptionSettings PlayOption;
        public ModelAssignSettings[] Assigns;
        public ModelInputFxSettings InputFx;
        public ModelTrackFxSettings TrackFx;
        public ModelInputFx[] InputFxs;
        public ModelTrackFx[] TrackFxs;

        public ModelMemorySettings() : this(0) { }
        public ModelMemorySettings(int num) : this(num, new XmlMemorySettings()) { }
        public ModelMemorySettings(XmlMemorySettingsBase xmlMemory) : this(0, xmlMemory) { }
        public ModelMemorySettings(int num, XmlMemorySettingsBase xmlMemory)
        {
            MemoryNumber = num;

            Tracks = new ModelTrackSettings[5]
            {
                new ModelTrackSettings(1, xmlMemory.Track1),
                new ModelTrackSettings(2, xmlMemory.Track2),
                new ModelTrackSettings(3, xmlMemory.Track3),
                new ModelTrackSettings(4, xmlMemory.Track4),
                new ModelTrackSettings(5, xmlMemory.Track5)
            };
            Rhythm     = new ModelRhythmSettings(xmlMemory.Rhythm);
            Name       = new ModelNameSettings(xmlMemory.Name);
            Master     = new ModelMasterSettings(xmlMemory.Master);
            RecOption  = new ModelRecOptionSettings(xmlMemory.RecOption);
            PlayOption = new ModelPlayOptionSettings(xmlMemory.PlayOption);
            Assigns    = new ModelAssignSettings[16]
            {
                new ModelAssignSettings(1, xmlMemory.Assign1), new ModelAssignSettings(2, xmlMemory.Assign2),
                new ModelAssignSettings(3, xmlMemory.Assign3), new ModelAssignSettings(4, xmlMemory.Assign4),
                new ModelAssignSettings(5, xmlMemory.Assign5), new ModelAssignSettings(6, xmlMemory.Assign6),
                new ModelAssignSettings(7, xmlMemory.Assign7), new ModelAssignSettings(8, xmlMemory.Assign8),
                new ModelAssignSettings(9, xmlMemory.Assign9), new ModelAssignSettings(10, xmlMemory.Assign10),
                new ModelAssignSettings(11, xmlMemory.Assign11), new ModelAssignSettings(12, xmlMemory.Assign12),
                new ModelAssignSettings(13, xmlMemory.Assign13), new ModelAssignSettings(14, xmlMemory.Assign14),
                new ModelAssignSettings(15, xmlMemory.Assign15), new ModelAssignSettings(16, xmlMemory.Assign16),
            };
            InputFx  = new ModelInputFxSettings(xmlMemory.InputFx);
            TrackFx  = new ModelTrackFxSettings(xmlMemory.TrackFx);
            InputFxs = new ModelInputFx[3]
            {
                new ModelInputFx(FxSlot.A, xmlMemory.InputFx1),
                new ModelInputFx(FxSlot.B, xmlMemory.InputFx2),
                new ModelInputFx(FxSlot.C, xmlMemory.InputFx3)
            };
            TrackFxs = new ModelTrackFx[3]
            {
                new ModelTrackFx(FxSlot.A, xmlMemory.TrackFx1, xmlMemory.BeatFx1),
                new ModelTrackFx(FxSlot.B, xmlMemory.TrackFx2, xmlMemory.BeatFx2),
                new ModelTrackFx(FxSlot.C, xmlMemory.TrackFx3, xmlMemory.BeatFx3)
            };
        }
    }
}
