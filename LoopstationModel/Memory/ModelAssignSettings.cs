using Loopstation.Xml.Memory;

namespace Loopstation.Model.Memory
{
    public enum AssignSource
    {
        EXP_PEDAL, CTL1_PEDAL, CTL2_PEDAL, INPUT_FX_KNOB, TRACK_FX_KNOB, 
        TR1_REC_DUB, TR2_REC_DUB, TR3_REC_DUB, TR4_REC_DUB, TR5_REC_DUB,
        TR1_PLAY_STOP, TR2_PLAY_STOP, TR3_PLAY_STOP, TR4_PLAY_STOP, TR5_PLAY_STOP,
        SYNC_START_STOP,
        CC_1, CC_2, CC_3, CC_4, CC_5, CC_6, CC_7, CC_8, CC_9, CC_10, CC_11, CC_12, CC_13, CC_14, CC_15, CC_16, CC_17, CC_18, CC_19, CC_20, CC_21, CC_22, CC_23, CC_24, CC_25, CC_26, CC_27, CC_28, CC_29, CC_30, CC_31, CC_64, CC_65, CC_66, CC_67, CC_68, CC_69, CC_70, CC_71, CC_72, CC_73, CC_74, CC_75, CC_76, CC_77, CC_78, CC_79, CC_80, CC_81, CC_82, CC_83, CC_84, CC_85, CC_86, CC_87, CC_88, CC_89, CC_90, CC_91, CC_92, CC_93, CC_94, CC_95
    }
    public enum AssignSourceMode { MOMENT, TOGGLE }
    public enum AssignTarget
    {
        TR1_REC_PLAY, TR2_REC_PLAY, TR3_REC_PLAY, TR4_REC_PLAY, TR5_REC_PLAY,
        TR1_PLAY_STOP, TR2_PLAY_STOP, TR3_PLAY_STOP, TR4_PLAY_STOP, TR5_PLAY_STOP,
        TR1_CLEAR, TR2_CLEAR, TR3_CLEAR, TR4_CLEAR, TR5_CLEAR,
        TR1_UNDO_REDO, TR2_UNDO_REDO, TR3_UNDO_REDO, TR4_UNDO_REDO, TR5_UNDO_REDO,
        TR1_PLAY_LEVEL, TR2_PLAY_LEVEL, TR3_PLAY_LEVEL, TR4_PLAY_LEVEL, TR5_PLAY_LEVEL,
        TR1_PAN, TR2_PAN, TR3_PAN, TR4_PAN, TR5_PAN,
        TGT_TR_REC_PLAY, TGT_TR_STOP, TGT_TR_CLEAR, TGT_TR_UNDO_REDO, TGT_TR_PLAY_LEV,
        ALL_START_STOP, ALL_CLEAR, UNDO_REDO, RHYTHM_LEVEL, RHYTHM_PATTERN,
        MEMORY_LEVEL, TAP_TEMPO, MASTER_COMP, MASTER_REVERB, OVERDUB_MODE,
        INPUT_FX_ON_OFF, TRACK_FX_ON_OFF,
        INPUT_FX_A_CONTROL, INPUT_FX_B_CONTROL, INPUT_FX_C_CONTROL,
        TRACK_FX_A_CONTROL, TRACK_FX_B_CONTROL, TRACK_FX_C_CONTROL,
        INPUT_FX_A_TYP_INC, INPUT_FX_A_TYP_DEC, INPUT_FX_B_TYP_INC, INPUT_FX_B_TYP_DEC, INPUT_FX_C_TYP_INC, INPUT_FX_C_TYP_DEC,
        TRACK_FX_A_TYP_INC, TRACK_FX_A_TYP_DEC, TRACK_FX_B_TYP_INC, TRACK_FX_B_TYP_DEC, TRACK_FX_C_TYP_INC, TRACK_FX_C_TYP_DEC,
        INPUT_FX_CONTROL, TRACK_FX_CONTROL, INPUT_FX_TYP_INC, INPUT_FX_TYP_DEC, TRACK_FX_TYP_INC, TRACK_FX_TYP_DEC,
        INPUT_FX_INC, INPUT_FX_DEC, TRACK_FX_INC, TRACK_FX_DEC, TARGET_TRACK_INC, TARGET_TRACK_DEC, MEMORY_INC, MEMORY_DEC, INPUT_LEVEL,
        CC_1, CC_2, CC_3, CC_4, CC_5, CC_6, CC_7, CC_8, CC_9, CC_10, CC_11, CC_12, CC_13, CC_14, CC_15, CC_16, CC_17, CC_18, CC_19, CC_20, CC_21, CC_22, CC_23, CC_24, CC_25, CC_26, CC_27, CC_28, CC_29, CC_30, CC_31, CC_64, CC_65, CC_66, CC_67, CC_68, CC_69, CC_70, CC_71, CC_72, CC_73, CC_74, CC_75, CC_76, CC_77, CC_78, CC_79, CC_80, CC_81, CC_82, CC_83, CC_84, CC_85, CC_86, CC_87, CC_88, CC_89, CC_90, CC_91, CC_92, CC_93, CC_94, CC_95
    }

    public class ModelAssignSettings
    {
        public int AssignNumber { get; }

        public bool Enabled { get; set; } = false;
        public AssignSource Source { get; set; } = AssignSource.EXP_PEDAL;
        public AssignSourceMode SourceMode { get; set; } = AssignSourceMode.MOMENT;
        public AssignTarget Target { get; set; } = AssignTarget.TR1_PLAY_LEVEL;
        public int TargetMin { get; set; } = 0;
        public int TargetMax { get; set; } = 100;

        public ModelAssignSettings(int num) : this(num, null) { }
        public ModelAssignSettings(int num, XmlAssignSettings xmlAssign)
        {
            AssignNumber = num;

            if (xmlAssign == null) return;

            Enabled = xmlAssign.Switch == 1;
            Source = (AssignSource)xmlAssign.Source;
            SourceMode = (AssignSourceMode)xmlAssign.SourceMode;
            Target = (AssignTarget)xmlAssign.Target;
            TargetMin = xmlAssign.TargetMin;
            TargetMax = xmlAssign.TargetMax;
        }
    }
}
