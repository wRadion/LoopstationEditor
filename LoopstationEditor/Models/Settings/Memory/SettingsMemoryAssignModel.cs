using System.Xml.Serialization;

using LoopstationEditor.Models.PropertyEngine;

namespace LoopstationEditor.Models.Settings.Memory
{
    public enum AssignSource { EXP_PEDAL = 0, CTL1_PEDAL = 1, CTL2_PEDAL = 2, INPUT_FX_KNOB = 3, TRACK_FX_KNOB = 4, TR1_REC_DUB = 5, TR2_REC_DUB = 6, TR3_REC_DUB = 7, TR4_REC_DUB = 8, TR5_REC_DUB = 9, TR1_PLAY_STOP = 10, TR2_PLAY_STOP = 11, TR3_PLAY_STOP = 12, TR4_PLAY_STOP = 13, TR5_PLAY_STOP = 14, SYNC_START_STOP = 15, CC_1 = 16, CC_2 = 17, CC_3 = 18, CC_4 = 19, CC_5 = 20, CC_6 = 21, CC_7 = 22, CC_8 = 23, CC_9 = 24, CC_10 = 25, CC_11 = 26, CC_12 = 27, CC_13 = 28, CC_14 = 29, CC_15 = 30, CC_16 = 31, CC_17 = 32, CC_18 = 33, CC_19 = 34, CC_20 = 35, CC_21 = 36, CC_22 = 37, CC_23 = 38, CC_24 = 39, CC_25 = 40, CC_26 = 41, CC_27 = 42, CC_28 = 43, CC_29 = 44, CC_30 = 45, CC_31 = 46, CC_64 = 47, CC_65 = 48, CC_66 = 49, CC_67 = 50, CC_68 = 51, CC_69 = 52, CC_70 = 53, CC_71 = 54, CC_72 = 55, CC_73 = 56, CC_74 = 57, CC_75 = 58, CC_76 = 59, CC_77 = 60, CC_78 = 61, CC_79 = 62, CC_80 = 63, CC_81 = 64, CC_82 = 65, CC_83 = 66, CC_84 = 67, CC_85 = 68, CC_86 = 69, CC_87 = 70, CC_88 = 71, CC_89 = 72, CC_90 = 73, CC_91 = 74, CC_92 = 75, CC_93 = 76, CC_94 = 77, CC_95 = 78 }
    public enum AssignSourceMode { MOMENT = 0, TOGGLE = 1 }
    public enum AssignTarget { TR1_REC_PLAY = 0, TR2_REC_PLAY = 1, TR3_REC_PLAY = 2, TR4_REC_PLAY = 3, TR5_REC_PLAY = 4, TR1_PLAY_STOP = 5, TR2_PLAY_STOP = 6, TR3_PLAY_STOP = 7, TR4_PLAY_STOP = 8, TR5_PLAY_STOP = 9, TR1_CLEAR = 10, TR2_CLEAR = 11, TR3_CLEAR = 12, TR4_CLEAR = 13, TR5_CLEAR = 14, TR1_UNDO_REDO = 15, TR2_UNDO_REDO = 16, TR3_UNDO_REDO = 17, TR4_UNDO_REDO = 18, TR5_UNDO_REDO = 19, TR1_PLAY_LEVEL = 20, TR2_PLAY_LEVEL = 21, TR3_PLAY_LEVEL = 22, TR4_PLAY_LEVEL = 23, TR5_PLAY_LEVEL = 24, TR1_PAN = 25, TR2_PAN = 26, TR3_PAN = 27, TR4_PAN = 28, TR5_PAN = 29, TGT_TR_REC_PLAY = 30, TGT_TR_STOP = 31, TGT_TR_CLEAR = 32, TGT_TR_UNDO_REDO = 33, TGT_TR_PLAY_LEV = 34, ALL_START_STOP = 35, ALL_CLEAR = 36, UNDO_REDO = 37, RHYTHM_LEVEL = 38, RHYTHM_PATTERN = 39, MEMORY_LEVEL = 40, TEMPO_TAP = 41, MASTER_COMP = 42, MASTER_REVERB = 43, OVERDUB_MODE = 44, INPUT_FX_ON_OFF = 45, TRACK_FX_ON_OFF = 46, INPUT_FX_A_CONTROL = 47, INPUT_FX_B_CONTROL = 48, INPUT_FX_C_CONTROL = 49, TRACK_FX_A_CONTROL = 50, TRACK_FX_B_CONTROL = 51, TRACK_FX_C_CONTROL = 52, INPUT_FX_A_TYP_INC = 53, INPUT_FX_A_TYP_DEC = 54, INPUT_FX_B_TYP_INC = 55, INPUT_FX_B_TYP_DEC = 56, INPUT_FX_C_TYP_INC = 57, INPUT_FX_C_TYP_DEC = 58, TRACK_FX_A_TYP_INC = 59, TRACK_FX_A_TYP_DEC = 60, TRACK_FX_B_TYP_INC = 61, TRACK_FX_B_TYP_DEC = 62, TRACK_FX_C_TYP_INC = 63, TRACK_FX_C_TYP_DEC = 64, INPUT_FX_CONTROL = 65, TRACK_FX_CONTROL = 66, INPUT_FX_TYP_INC = 67, INPUT_FX_TYP_DEC = 68, TRACK_FX_TYP_INC = 69, TRACK_FX_TYP_DEC = 70, INPUT_FX_INC = 71, INPUT_FX_DEC = 72, TRACK_FX_INC = 73, TRACK_FX_DEC = 74, TARGET_TRACK_INC = 75, TARGET_TRACK_DEC = 76, MEMORY_INC = 77, MEMORY_DEC = 78, INPUT_LEVEL = 79, CC_1 = 80, CC_2 = 81, CC_3 = 82, CC_4 = 83, CC_5 = 84, CC_6 = 85, CC_7 = 86, CC_8 = 87, CC_9 = 88, CC_10 = 89, CC_11 = 90, CC_12 = 91, CC_13 = 92, CC_14 = 93, CC_15 = 94, CC_16 = 95, CC_17 = 96, CC_18 = 97, CC_19 = 98, CC_20 = 99, CC_21 = 100, CC_22 = 101, CC_23 = 102, CC_24 = 103, CC_25 = 104, CC_26 = 105, CC_27 = 106, CC_28 = 107, CC_29 = 108, CC_30 = 109, CC_31 = 110, CC_64 = 111, CC_65 = 112, CC_66 = 113, CC_67 = 114, CC_68 = 115, CC_69 = 116, CC_70 = 117, CC_71 = 118, CC_72 = 119, CC_73 = 120, CC_74 = 121, CC_75 = 122, CC_76 = 123, CC_77 = 124, CC_78 = 125, CC_79 = 126, CC_80 = 127, CC_81 = 128, CC_82 = 129, CC_83 = 130, CC_84 = 131, CC_85 = 132, CC_86 = 133, CC_87 = 134, CC_88 = 135, CC_89 = 136, CC_90 = 137, CC_91 = 138, CC_92 = 139, CC_93 = 140, CC_94 = 141, CC_95 = 142 }

    public class SettingsMemoryAssignModel : SettingsModel
    {
        [XmlElement("Sw", typeof(int))]
        [Property(false, 0, 1)]
        public ValueBool Enabled { get; set; }

        [XmlElement("Src", typeof(int))]
        [Property(AssignSource.EXP_PEDAL, 0, 78)]
        public ValueEnum<AssignSource> Source { get; set; }

        [XmlElement("SrcMod", typeof(int))]
        [Property(AssignSourceMode.MOMENT, 0, 1)]
        public ValueEnum<AssignSourceMode> SourceMode { get; set; }

        [XmlElement("Tgt", typeof(int))]
        [Property(AssignTarget.TR1_PLAY_LEVEL, 0, 142)]
        public ValueEnum<AssignTarget> Target { get; set; }

        [XmlElement("TgtMin", typeof(int))]
        [Property(0, 0, 100)]
        public ValueInt TargetMin { get; set; }

        [XmlElement("TgtMax", typeof(int))]
        [Property(100, 0, 100)]
        public ValueInt TargetMax { get; set; }

        public SettingsMemoryAssignModel() : base() { }
    }
}
