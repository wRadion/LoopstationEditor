using LoopstationModels.Base;

namespace LoopstationModels.Memory
{
    public class AssignSettings : BaseSettings
    {
        public int AssignNumber;

        public AssignSettings(int num) : base($"ASSIGN{ num }")
        {
            AssignNumber = num;

            int defSw = 0;
            int defSrc = 0;
            int defSrcMod = 0;
            int defTgt = 20;
            int defTgtMax = 100;

            switch (num)
            {
                case 1:
                    defSw = 1;
                    defTgt = 79;
                    break;
                case 2:
                    defSw = 1;
                    defSrc = 1;
                    defSrcMod = 1;
                    defTgt = 37;
                    defTgtMax = 0;
                    break;
                case 3:
                    defSw = 1;
                    defSrc = 2;
                    defSrcMod = 1;
                    defTgt = 38;
                    defTgtMax = 50;
                    break;
            }

            AddProperty("Sw", def: defSw, max: 1);
            AddProperty("Src", def: defSrc, max: 78);
            AddProperty("SrcMod", def: defSrcMod, max: 1);
            AddProperty("Tgt", def: defTgt, max: 142);
            AddProperty("TgtMin", max: 127);
            AddProperty("TgtMax", def: defTgtMax, max: 127);
        }
    }
}
