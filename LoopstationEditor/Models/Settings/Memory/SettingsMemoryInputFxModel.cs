using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory
{
    public enum SingleInputFx { FILTER = 0, PHASER = 1, FLANGER = 2, SYNTH = 3, LO_FI = 4, RING_MODULATOR = 5, GUITAR_TO_BASS = 6, SLOW_GEAR = 7, TRANSPOSE = 8, PITCH_BEND = 9, ROBOT = 10, VOCAL_DIST = 11, VOCODER = 12, DYNAMICS = 13, EQ = 14, ISOLATOR = 15, OCTAVE = 16, PAN = 17, TREMOLO = 18, SLICER = 19, DELAY = 20, PANNING_DELAY = 21, TAPE_ECHO = 22, GRANULAR_DELAY = 23, ROLL = 24, CHORUS = 25, REVERB = 26 }
    public enum MultiInputFxA { FILTER = 0, PHASER = 1, SYNTH = 2, LO_FI = 3, RING_MODULATOR = 4, GUITAR_TO_BASS = 5, SLOW_GEAR = 6, TRANSPOSE = 7, PITCH_BEND = 8, ROBOT = 9, VOCAL_DIST = 10, VOCODER = 11, DYNAMICS = 12, EQ = 13, ISOLATOR = 14, OCTAVE = 15, PAN = 16, TREMOLO = 17, SLICER = 18 }
    public enum MultiInputFxB { FILTER = 0, PHASER = 1, FLANGER = 2, LO_FI = 3, RING_MODULATOR = 4, VOCAL_DIST = 5, EQ = 6, ISOLATOR = 7, PAN = 8, TREMOLO = 9, SLICER = 10, DELAY = 11, PANNING_DELAY = 12, ROLL = 13, CHORUS = 14 }
    public enum MultiInputFxC { FILTER = 0, PHASER = 1, FLANGER = 2, LO_FI = 3, RING_MODULATOR = 4, VOCAL_DIST = 5, EQ = 6, ISOLATOR = 7, PAN = 8, TREMOLO = 9, SLICER = 10, DELAY = 11, PANNING_DELAY = 12, TAPE_ECHO = 13, GRANUAR_DELAY = 14, ROLL = 15, CHORUS = 16, REVERB = 17 }

    public class SettingsMemoryInputFxModel : SettingsModel
    {
        [XmlElement("Mod", typeof(int))]
        [Property(FxMode.SINGLE, 0, 1)]
        public ValueEnum<FxMode> Mode { get; set; }

        [XmlElement("MltMod", typeof(int))]
        public ValueBool MultiMode
        {
            get => Mode == FxMode.MULTI;
            set => Mode = value ? FxMode.MULTI : FxMode.SINGLE;
        }

        [XmlElement("Sw", typeof(int))]
        [Property(FxSlotOrNone.NONE, 0, 3)]
        public ValueEnum<FxSlotOrNone> SingleEnabledFxSlot { get; set; }

        [XmlElement("Sel", typeof(int))]
        [Property(FxSlot.A, 0, 2)]
        public ValueEnum<FxSlot> SelectedFxSlot { get; set; }

        [XmlElement("Typ1", typeof(int))]
        [Property(SingleInputFx.FILTER, 0, 26)]
        public ValueEnum<SingleInputFx> SelectedSingleFxA { get; set; }

        [XmlElement("Typ2", typeof(int))]
        [Property(SingleInputFx.LO_FI, 0, 26)]
        public ValueEnum<SingleInputFx> SelectedSingleFxB { get; set; }

        [XmlElement("Typ3", typeof(int))]
        [Property(SingleInputFx.PAN, 0, 26)]
        public ValueEnum<SingleInputFx> SelectedSingleFxC { get; set; }

        [XmlElement("MltSw", typeof(int))]
        [Property(FxSlotBitwise.NONE, 0, 7)]
        public ValueEnum<FxSlotBitwise> MultiEnabledFxSlot { get; set; }

        [XmlElement("MltTyp1", typeof(int))]
        [Property(MultiInputFxA.FILTER, 0, 18)]
        public ValueEnum<MultiInputFxA> SelectedMultiFxA { get; set; }

        [XmlElement("MltTyp2", typeof(int))]
        [Property(MultiInputFxB.LO_FI, 0, 14)]
        public ValueEnum<MultiInputFxB> SelectedMultiFxB { get; set; }

        [XmlElement("MltTyp3", typeof(int))]
        [Property(MultiInputFxC.PAN, 0, 17)]
        public ValueEnum<MultiInputFxC> SelectedMultiFxC { get; set; }

        public SettingsMemoryInputFxModel() : base() { }
    }
}
