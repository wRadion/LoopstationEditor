using Loopstation.Xml.Memory;
using Loopstation.Common.Property;

namespace Loopstation.Model.Memory
{
    public enum PlayOptionSinglePlayChange { IMMEDIATE, LOOP_END }
    public enum PlayOptionLoopQuantize     { REC_END, MEASURE, BEAT }
    public enum PlayOptionLoopMode         { AUTO, LENGTH }
    public enum PlayOptionAllStart         { }
    public enum PlayOptionAllStop          { }

    public class ModelPlayOptionSettings
    {
        public PlayOptionSinglePlayChange SinglePlayChange
        {
            get => _singlePlayChangeProperty.Value;
            set => _singlePlayChangeProperty.Value = value;
        }
        public PlayOptionLoopQuantize LoopQuantize
        {
            get => _loopQuantizeProperty.Value;
            set => _loopQuantizeProperty.Value = value;
        }
        public PlayOptionLoopMode LoopMode
        {
            get => _loopModeProperty.Value;
            set => _loopModeProperty.Value = value;
        }
        public int LoopLength
        {
            get => _loopLengthProperty.Value;
            set => _loopLengthProperty.Value = value;
        }
        public PlayOptionAllStart AllStart // TODO: Bitwise PlayOption>AllStart
        {
            get => _allStartProperty.Value;
            set => _allStartProperty.Value = value;
        }
        public PlayOptionAllStop AllStop // TODO: Bitwise PlayOption>AllStop
        {
            get => _allStopProperty.Value;
            set => _allStopProperty.Value = value;
        }
        public int FadeTime
        {
            get => _fadeTimeProperty.Value;
            set => _fadeTimeProperty.Value = value;
        }
        public Track TargetTrack
        {
            get => _targetTrackProperty.Value;
            set => _targetTrackProperty.Value = value;
        }

        #region private Fields
        private readonly EnumProperty<PlayOptionSinglePlayChange> _singlePlayChangeProperty;
        private readonly EnumProperty<PlayOptionLoopQuantize> _loopQuantizeProperty;
        private readonly EnumProperty<PlayOptionLoopMode> _loopModeProperty;
        private readonly IntProperty _loopLengthProperty;
        private readonly EnumProperty<PlayOptionAllStart> _allStartProperty;
        private readonly EnumProperty<PlayOptionAllStop> _allStopProperty;
        private readonly IntProperty _fadeTimeProperty;
        private readonly EnumProperty<Track> _targetTrackProperty;

        private readonly XmlPlayOptionSettings _xml;
        #endregion private Fields

        public ModelPlayOptionSettings(XmlPlayOptionSettings xmlPlayOption)
        {
            #region private Fields initialization
            _xml = xmlPlayOption;

            _singlePlayChangeProperty = _xml.SinglePlayChange;
            _loopQuantizeProperty     = _xml.LoopQuantize;
            _loopModeProperty         = _xml.LoopMode;
            _loopLengthProperty       = _xml.LoopLength;
            _allStartProperty         = _xml.AllStart;
            _allStopProperty          = _xml.AllStop;
            _fadeTimeProperty         = _xml.FadeTime;
            _targetTrackProperty      = _xml.TargetTrack;

            _singlePlayChangeProperty.PropertyChanged += (_, e) => _xml.SinglePlayChange = e.Value;
            _loopQuantizeProperty.PropertyChanged     += (_, e) => _xml.LoopQuantize = e.Value;
            _loopModeProperty.PropertyChanged         += (_, e) => _xml.LoopMode = e.Value;
            _loopLengthProperty.PropertyChanged       += (_, e) => _xml.LoopLength = e.Value;
            _allStartProperty.PropertyChanged         += (_, e) => _xml.AllStart = e.Value;
            _allStopProperty.PropertyChanged          += (_, e) => _xml.AllStop = e.Value;
            _fadeTimeProperty.PropertyChanged         += (_, e) => _xml.FadeTime = e.Value;
            _targetTrackProperty.PropertyChanged      += (_, e) => _xml.TargetTrack = e.Value;
            #endregion private Fields initialization
        }
    }
}
