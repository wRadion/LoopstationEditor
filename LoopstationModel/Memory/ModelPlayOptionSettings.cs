using Loopstation.Xml.Memory;

namespace Loopstation.Model.Memory
{
    public enum PlayOptionSinglePlayChange { IMMEDIATE, LOOP_END }
    public enum PlayOptionLoopQuantize { REC_END, MEASURE, BEAT }
    public enum PlayOptionLoopMode { AUTO, LENGTH }
    public enum PlayOptionAllStart { }
    public enum PlayOptionAllStop { }

    public class ModelPlayOptionSettings
    {
        public PlayOptionSinglePlayChange SinglePlayChange { get; set; } = PlayOptionSinglePlayChange.IMMEDIATE;
        public PlayOptionLoopQuantize LoopQuantize { get; set; } = PlayOptionLoopQuantize.REC_END;
        public PlayOptionLoopMode LoopMode { get; set; } = PlayOptionLoopMode.AUTO;
        public int LoopLength { get; set; } = 0;
        // TODO: Bitwise PlayOption>AllStart
        // TODO: Bitwise Default Value 31 (ALL)
        public PlayOptionAllStart AllStart { get; set; }
        // TODO: Bitwise PlayOption>AllStop
        // TODO: Bitwise Default Value 31 (ALL)
        public PlayOptionAllStop AllStop { get; set; }
        // TODO: Fade Time (1...64) (measures)
        public int FadeTime { get; set; } = 2;
        public Track TargetTrack { get; set; } = Track.TRACK1;

        public ModelPlayOptionSettings() : this(null) { }
        public ModelPlayOptionSettings(XmlPlayOptionSettings xmlPlayOption)
        {
            if (xmlPlayOption == null) return;

            SinglePlayChange = (PlayOptionSinglePlayChange)xmlPlayOption.SinglePlayChange;
            LoopQuantize = (PlayOptionLoopQuantize)xmlPlayOption.LoopQuantize;
            LoopMode = (PlayOptionLoopMode)xmlPlayOption.LoopMode;
            LoopLength = xmlPlayOption.LoopLength;
            AllStart = (PlayOptionAllStart)xmlPlayOption.AllStart;
            AllStop = (PlayOptionAllStop)xmlPlayOption.AllStop;
            FadeTime = xmlPlayOption.FadeTime;
            TargetTrack = (Track)xmlPlayOption.TargetTrack;
        }
    }
}
