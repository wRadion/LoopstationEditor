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
        public PlayOptionSinglePlayChange SinglePlayChange { get; set; }
        public PlayOptionLoopQuantize LoopQuantize { get; set; }
        public PlayOptionLoopMode LoopMode { get; set; }
        public int LoopLength { get; set; }
        // TODO: Bitwise PlayOption>AllStart
        public PlayOptionAllStart AllStart { get; set; }
        // TODO: Bitwise PlayOption>AllStop
        public PlayOptionAllStop AllStop { get; set; }
        // TODO: Fade Time (1...64) (measures)
        public int FadeTime { get; set; }
        public Track TargetTrack { get; set; }

        public ModelPlayOptionSettings(XmlPlayOptionSettings xmlPlayOption)
        {
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
