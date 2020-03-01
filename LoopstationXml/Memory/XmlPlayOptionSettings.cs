using System.Xml.Serialization;

using Loopstation.Xml.Interfaces;

namespace Loopstation.Xml.Memory
{
    [XmlRoot("PLAY_OPTION")]
    public class XmlPlayOptionSettings : ICloneable<XmlPlayOptionSettings>
    {
        [XmlElement("SinglePlyChg")]
        public int SinglePlayChange { get; set; } = 0;

        [XmlElement("LpQtz")]
        public int LoopQuantize { get; set; } = 0;

        [XmlElement("LpMod")]
        public int LoopMode { get; set; } = 0;

        [XmlElement("LpLen")]
        public int LoopLength { get; set; } = 0;

        [XmlElement("AllStrt")]
        public int AllStart { get; set; } = 31;

        [XmlElement("AllStp")]
        public int AllStop { get; set; } = 31;

        [XmlElement("FadeTim")]
        public int FadeTime { get; set; } = 2;

        [XmlElement("TgtTr")]
        public int TargetTrack { get; set; } = 0;

        public XmlPlayOptionSettings() { }
        public XmlPlayOptionSettings(XmlPlayOptionSettings other)
        {
            if (other == null) return;

            SinglePlayChange = other.SinglePlayChange;
            LoopQuantize = other.LoopQuantize;
            LoopMode = other.LoopMode;
            LoopLength = other.LoopLength;
            AllStart = other.AllStart;
            AllStop = other.AllStop;
            FadeTime = other.FadeTime;
            TargetTrack = other.TargetTrack;
        }

        public XmlPlayOptionSettings Clone() => new XmlPlayOptionSettings(this);
    }
}
