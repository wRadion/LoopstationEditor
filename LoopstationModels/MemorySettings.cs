using LoopstationModels.Memory;

namespace LoopstationModels
{
    public class MemorySettings
    {
        public int MemoryNumber { get; }

        public TrackSettings[] Tracks;
        public RythmSettings Rythm;
        public NameSettings Name;
        public MasterSettings Master;
        public RecOptionSettings RecOption;
        public PlayOptionSettings PlayOption;
        public AssignSettings[] Assigns;
        public InputFxOptionSettings InputFxOption;
        public TrackFxOptionSettings TrackFxOption;
        public BeatFxSettings[] BeatFxs;
        public FxSettings[] InputFxs;
        public FxSettings[] TrackFxs;

        public MemorySettings(int num)
        {
            MemoryNumber = num;

            Tracks = new TrackSettings[5]
            {
                new TrackSettings(1), new TrackSettings(2), new TrackSettings(3), new TrackSettings(4), new TrackSettings(5)
            };
            Rythm = new RythmSettings();
            Name = new NameSettings();
            Master = new MasterSettings();
            RecOption = new RecOptionSettings();
            PlayOption = new PlayOptionSettings();
            Assigns = new AssignSettings[16]
            {
                new AssignSettings(1), new AssignSettings(2), new AssignSettings(3), new AssignSettings(4),
                new AssignSettings(5), new AssignSettings(6), new AssignSettings(7), new AssignSettings(8),
                new AssignSettings(9), new AssignSettings(10), new AssignSettings(11), new AssignSettings(12),
                new AssignSettings(13), new AssignSettings(14), new AssignSettings(15), new AssignSettings(16),
            };
            InputFxOption = new InputFxOptionSettings();
            TrackFxOption = new TrackFxOptionSettings();
            BeatFxs = new BeatFxSettings[3]
            {
                new BeatFxSettings(FxPosition.A),
                new BeatFxSettings(FxPosition.B),
                new BeatFxSettings(FxPosition.C)
            };
            InputFxs = new FxSettings[3]
            {
                new FxSettings(FxType.INPUT, FxPosition.A),
                new FxSettings(FxType.INPUT, FxPosition.B),
                new FxSettings(FxType.INPUT, FxPosition.C)
            };
            TrackFxs = new FxSettings[3]
            {
                new FxSettings(FxType.TRACK, FxPosition.A),
                new FxSettings(FxType.TRACK, FxPosition.B),
                new FxSettings(FxType.TRACK, FxPosition.C)
            };
        }
    }
}
