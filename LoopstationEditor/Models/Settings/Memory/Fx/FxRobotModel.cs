using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory.Fx
{
    public enum FxRobotNote { C = 0, Db = 1, D = 2, Eb = 3, E = 4, F = 5, Gb = 6, G = 7, Ab = 8, A = 9, Bb = 10, B = 11 }

    public class FxRobotModel : SettingsModel
    {
        [XmlElement(FxProperty.RobotNote, typeof(int))]
        [Property(FxRobotNote.C, 0, 11)]
        public ValueEnum<FxRobotNote> RobotNote { get; set; }

        [XmlElement(FxProperty.RobotGender, typeof(int))]
        [Property(10, 0, 20)]
        public ValueInt RobotGender { get; set; }

        public FxRobotModel() : base() { }
    }
}
