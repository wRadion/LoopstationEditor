using System;

namespace Loopstation.Model.Memory.Fx
{
    public enum SlicerPattern { P01, P02, P03, P04, P05, P06, P07, P08, P09, P10, P11, P12, P13, P14, P15, P16, P17, P18, P19, P20 }

    public class SlicerFx : ICloneable
    {
        public SlicerPattern Pattern { get; set; } = SlicerPattern.P01;
        // TODO: Rate Default Value 110
        public Rate Rate { get; set; }
        public int Depth { get; set; } = 100;

        public SlicerFx() { }
        public SlicerFx(SlicerFx other)
        {
            Pattern = other.Pattern;
            Rate = other.Rate;
            Depth = other.Depth;
        }

        public object Clone() => new SlicerFx(this);
    }
}
