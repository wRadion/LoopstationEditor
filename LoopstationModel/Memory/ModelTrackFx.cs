using Loopstation.Xml.Memory;
using Loopstation.Model.Memory.Base;
using Loopstation.Model.Memory.Fx;

namespace Loopstation.Model.Memory
{
    public class ModelTrackFx : ModelFxSettingsBase
    {
        public  BeatRepeatFx BeatRepeat { get; }
        public   BeatShiftFx BeatShift { get; }
        public BeatScatterFx BeatScatter { get; }
        public  VinylFlickFx VinylFlick { get; }

        public ModelTrackFx(FxSlot slot, XmlFxSettings xmlFx, XmlBeatFxSettings xmlBeatFx) : base(FxType.TRACK, slot, xmlFx)
        {
            BeatRepeat  = new BeatRepeatFx(xmlBeatFx);
            BeatShift   = new BeatShiftFx(xmlBeatFx);
            BeatScatter = new BeatScatterFx(xmlBeatFx);
            VinylFlick  = new VinylFlickFx(xmlBeatFx);
        }
    }
}
