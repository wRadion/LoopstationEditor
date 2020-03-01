using System;

namespace Loopstation.Model.Memory.Fx
{
    public enum PanType { AUTO1, AUTO2, MANUAL }

    public class PanFx : ICloneable
    {
        public PanType Type { get; set; } = PanType.AUTO1;
        // TODO: Rate Default Value 50
        public Rate Rate { get; set; }
        public int Depth { get; set; } = 50;
        // TODO: StepRate Default Value 0
        public StepRate StepRate { get; set; }
        // TODO: Pan Position (0...100) -50
        public int Position { get; set; } = 50;

        public PanFx() { }
        public PanFx(PanFx other)
        {
            Type = other.Type;
            Rate = other.Rate;
            Depth = other.Depth;
            StepRate = other.StepRate;
            Position = other.Position;
        }

        public object Clone() => new PanFx(this);
    }
}
