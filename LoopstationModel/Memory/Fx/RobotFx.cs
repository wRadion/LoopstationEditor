using System;

namespace Loopstation.Model.Memory.Fx
{
    public enum RobotNote { C, Db, D, Eb, E, F, Gb, G, Ab, A, Bb, B }

    public class RobotFx : ICloneable
    {
        public RobotNote Note { get; set; } = RobotNote.C;
        // TODO: Robot Gender (0...20) -10
        public int Gender { get; set; } = 10;

        public RobotFx() { }
        public RobotFx(RobotFx other)
        {
            Note = other.Note;
            Gender = other.Gender;
        }

        public object Clone() => new RobotFx(this);
    }
}
