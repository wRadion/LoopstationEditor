using System.Xml.Serialization;

namespace LoopstationEditor.Models.Settings.Memory
{
    [XmlRoot("mem")]
    public class MemoryModel : SettingsContainerModel
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        #region Tracks
        [XmlElement("TRACK1")]
        public SettingsMemoryTrackModel Track1 { get; set; }
        [XmlElement("TRACK2")]
        public SettingsMemoryTrackModel Track2 { get; set; }
        [XmlElement("TRACK3")]
        public SettingsMemoryTrackModel Track3 { get; set; }
        [XmlElement("TRACK4")]
        public SettingsMemoryTrackModel Track4 { get; set; }
        [XmlElement("TRACK5")]
        public SettingsMemoryTrackModel Track5 { get; set; }
        #endregion Tracks

        [XmlElement("RHYTHM")]
        public SettingsMemoryRhythmModel Rhythm { get; set; }

        [XmlElement("NAME")]
        public SettingsMemoryNameModel Name { get; set; }

        [XmlElement("MASTER")]
        public SettingsMemoryMasterModel Master { get; set; }

        [XmlElement("REC_OPTION")]
        public SettingsMemoryRecOptionModel RecOption { get; set; }

        [XmlElement("PLAY_OPTION")]
        public SettingsMemoryPlayOptionModel PlayOption { get; set; }

        #region Assigns
        [XmlElement("ASSIGN1")]
        public SettingsMemoryAssignModel Assign1 { get; set; }
        [XmlElement("ASSIGN2")]
        public SettingsMemoryAssignModel Assign2 { get; set; }
        [XmlElement("ASSIGN3")]
        public SettingsMemoryAssignModel Assign3 { get; set; }
        [XmlElement("ASSIGN4")]
        public SettingsMemoryAssignModel Assign4 { get; set; }
        [XmlElement("ASSIGN5")]
        public SettingsMemoryAssignModel Assign5 { get; set; }
        [XmlElement("ASSIGN6")]
        public SettingsMemoryAssignModel Assign6 { get; set; }
        [XmlElement("ASSIGN7")]
        public SettingsMemoryAssignModel Assign7 { get; set; }
        [XmlElement("ASSIGN8")]
        public SettingsMemoryAssignModel Assign8 { get; set; }
        [XmlElement("ASSIGN9")]
        public SettingsMemoryAssignModel Assign9 { get; set; }
        [XmlElement("ASSIGN10")]
        public SettingsMemoryAssignModel Assign10 { get; set; }
        [XmlElement("ASSIGN11")]
        public SettingsMemoryAssignModel Assign11 { get; set; }
        [XmlElement("ASSIGN12")]
        public SettingsMemoryAssignModel Assign12 { get; set; }
        [XmlElement("ASSIGN13")]
        public SettingsMemoryAssignModel Assign13 { get; set; }
        [XmlElement("ASSIGN14")]
        public SettingsMemoryAssignModel Assign14 { get; set; }
        [XmlElement("ASSIGN15")]
        public SettingsMemoryAssignModel Assign15 { get; set; }
        [XmlElement("ASSIGN16")]
        public SettingsMemoryAssignModel Assign16 { get; set; }
        #endregion Assigns

        [XmlElement("INPUT_FX")]
        public SettingsMemoryInputFxModel InputFx { get; set; }

        [XmlElement("TRACK_FX")]
        public SettingsMemoryTrackFxModel TrackFx { get; set; }

        [XmlElement("INPUT_FX1")]
        public SettingsMemoryFxInputModel InputFxA { get; set; }
        [XmlElement("INPUT_FX2")]
        public SettingsMemoryFxInputModel InputFxB { get; set; }
        [XmlElement("INPUT_FX3")]
        public SettingsMemoryFxInputModel InputFxC { get; set; }

        [XmlElement("TRACK_FX1")]
        public SettingsMemoryFxTrackModel TrackFxA { get; set; }
        [XmlElement("TRACK_FX2")]
        public SettingsMemoryFxTrackModel TrackFxB { get; set; }
        [XmlElement("TRACK_FX3")]
        public SettingsMemoryFxTrackModel TrackFxC { get; set; }

        public MemoryModel() : base()
        {
            Track1 = new SettingsMemoryTrackModel();
            Track2 = new SettingsMemoryTrackModel();
            Track3 = new SettingsMemoryTrackModel();
            Track4 = new SettingsMemoryTrackModel();
            Track5 = new SettingsMemoryTrackModel();

            Rhythm = new SettingsMemoryRhythmModel();
            Name = new SettingsMemoryNameModel();
            Master = new SettingsMemoryMasterModel();
            RecOption = new SettingsMemoryRecOptionModel();
            PlayOption = new SettingsMemoryPlayOptionModel();

            Assign1 = new SettingsMemoryAssignModel(1);
            Assign2 = new SettingsMemoryAssignModel(2);
            Assign3 = new SettingsMemoryAssignModel(3);
            Assign4 = new SettingsMemoryAssignModel(4);
            Assign5 = new SettingsMemoryAssignModel(5);
            Assign6 = new SettingsMemoryAssignModel(6);
            Assign7 = new SettingsMemoryAssignModel(7);
            Assign8 = new SettingsMemoryAssignModel(8);
            Assign9 = new SettingsMemoryAssignModel(9);
            Assign10 = new SettingsMemoryAssignModel(10);
            Assign11 = new SettingsMemoryAssignModel(11);
            Assign12 = new SettingsMemoryAssignModel(12);
            Assign13 = new SettingsMemoryAssignModel(13);
            Assign14 = new SettingsMemoryAssignModel(14);
            Assign15 = new SettingsMemoryAssignModel(15);
            Assign16 = new SettingsMemoryAssignModel(16);

            InputFx = new SettingsMemoryInputFxModel();
            TrackFx = new SettingsMemoryTrackFxModel();

            InputFxA = new SettingsMemoryFxInputModel(FxSlot.A);
            InputFxB = new SettingsMemoryFxInputModel(FxSlot.B);
            InputFxC = new SettingsMemoryFxInputModel(FxSlot.C);

            TrackFxA = new SettingsMemoryFxTrackModel(FxSlot.A);
            TrackFxB = new SettingsMemoryFxTrackModel(FxSlot.B);
            TrackFxC = new SettingsMemoryFxTrackModel(FxSlot.C);
        }
    }
}
